using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sericulus2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeDuplicate_Click(object sender, EventArgs e)
        {
            computers.Lines = computers.Lines.Distinct().ToArray();

        }

        private void DeBlank_Click(object sender, EventArgs e)
        {
            computers.Lines = computers.Lines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        }

        private void SortAsc_Click(object sender, EventArgs e)
        {
            computers.Lines = computers.Lines.OrderBy(x=>x).ToArray();
        }

        private void SortDesc_Click(object sender, EventArgs e)
        {
            computers.Lines = computers.Lines.OrderByDescending(x => x).ToArray();
        }

        private void DoPing_CheckedChanged(object sender, EventArgs e)
        {
            if (DoPing.Checked) {
                Results.Columns.Add("TestPing", "Ping");
            }
            else
            {
                Results.Columns.Remove("TestPing");
            }
        }

        private void DoLoggedIn_CheckedChanged(object sender, EventArgs e)
        {
            if (DoLoggedIn.Checked)
            {
                Results.Columns.Add("TestLoggedIn", "Who is Logged in");
            }
            else
            {
                Results.Columns.Remove("TestLoggedIn");
            }
        }

        private void DoFDNS_CheckedChanged(object sender, EventArgs e)
        {
            if (DoFDNS.Checked)
            {
                Results.Columns.Add("TestFDNS", "Forward DNS");
            }
            else
            {
                Results.Columns.Remove("TestFDNS");
            }
        }

        private void DoRDNS_CheckedChanged(object sender, EventArgs e)
        {
            if (DoRDNS.Checked)
            {
                Results.Columns.Add("TestRDNS", "Reverse DNS");
            }
            else
            {
                Results.Columns.Remove("TestRDNS");
            }
        }

        private void StartTest_Click(object sender, EventArgs e)
        {
            // Make sure there is at least one machine listed to be tested.
            String concat = "";
            foreach (String item in computers.Lines)
            {
                concat += item.ToString().Trim();
            }
            if (concat=="")
            {
                MessageBox.Show("No machines listed.");
            }
            else
            {
                // Make sure there is at least on test chosen.
                if (Results.Columns.Count < 2)
                {
                    MessageBox.Show("No Tests chosen.");
                }
                else
                {
                    // Switch GUI to Results Tab
                    TabContainer.SelectTab(ResultsTab);
                    Application.DoEvents();

                    // Populate Results Tab with computer list
                    AddComputersToResultsGrid();
                    Application.DoEvents();

                    // Create a TestMaster and start it off.
                    TestMaster tm = new TestMaster(Results,toolStripProgressBar1);
                    tm.StartTest();
                    // The results appear in the Results grid
                }
            }
        }

        private void AddComputersToResultsGrid()
        {
            // Get rid of the old Results
            Results.Rows.Clear();

            // Remove leading blank lines
            var computersList = computers.Lines.ToList();
            while (computersList.ElementAt(0) == "")
            {
                computersList.RemoveAt(0);
            }

            // Remove training blank lines
            computersList.Reverse();
            while (computersList.ElementAt(0) == "")
            {
                computersList.RemoveAt(0);
            }
            computersList.Reverse();
            computers.Lines = computersList.ToArray();

            // Add the computers to the list to be tested
            foreach (String computer in computers.Lines)
            {
                Results.Rows.Add(computer);
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

    internal class TestMaster
    {
        private volatile DataGridView results;
        private ToolStripProgressBar toolStripProgressBar1;

        public TestMaster(DataGridView results, 
            ToolStripProgressBar toolStripProgressBar1)
        {
            this.results = results;
            this.toolStripProgressBar1 = toolStripProgressBar1;
            this.toolStripProgressBar1.Minimum = 0;
        }

        internal void StartTest()
        {
            int numberOfComputers = results.RowCount;
            int numberOfTestsPerComputer = results.ColumnCount-1;
            int totalNumberOfTests = numberOfComputers * numberOfTestsPerComputer;
            toolStripProgressBar1.Maximum = totalNumberOfTests;
            toolStripProgressBar1.Value = 0;
            foreach (DataGridViewRow computer in results.Rows)
            {
                // Get the NAME of this computer
                String computerName = 
                    computer.Cells[results.Columns["Name"].Index].Value.ToString().Trim();
                
                // For Each column in this row (where row= computer)...
                // ...do the appropriate test (each column represents one type of test).
                foreach ( DataGridViewColumn col in results.Columns)
                {
                    // CELL is where the results for this test
                    // for this computer need to be put.
                    DataGridViewCell cell = computer.Cells[col.Index];
                    if (cell.Value == null)
                    {
                        cell.Value = "WAITING";
                    }

                    // Perform this TEST (col.Name) for this COMPUTER (computerName).
                    // And put the results in cell.
                    // Worker workerObject = new Worker();
                    TestWorker testWorker = new TestWorker(computerName, col.Name, cell);
                    Thread testThread = new Thread(testWorker.DoWork);
                    testThread.Start();
                    Thread.Sleep(1);
                    Application.DoEvents();
                    // Increment the progress bar that indicates a test has started
                    toolStripProgressBar1.Increment(1);
                } 
            }
        }
    }

    internal class TestWorker
    {
        private string name;
        private DataGridViewCell cell;
        private string computerName;
        private readonly object notYetImplementedMessage = "NOT YET IMPLEMENTED";
        
        public TestWorker(
            string computerName, 
            string name, 
            DataGridViewCell cell)
        {
            this.computerName = computerName;
            this.name = name;
            this.cell = cell;
        }

        internal void DoWork()
        {
            // The CASE being tested is the NAME of the COLUMN.

            switch (name)
            {
                case "name":
                    break;

                case "TestPing":
                    cell.Value = TestPing(computerName); 
                    break;

                case "TestLoggedIn":
                    cell.Value = TestLoggedIn(computerName);
                    break;

                case "TestRDNS":
                    cell.Value = TestReverseDNS(computerName);
                    break;

                case "TestFDNS":
                    cell.Value = TestForwardDNS(computerName);
                    break;

                default:
                    MessageBox.Show
                        ("TEST called '"+ name + "' NOT FOUND for computer called : " + computerName);
                    break;
            }
        }

        private object TestLoggedIn(string ComputerName)
        {
            // return notYetImplementedMessage;
            // Might be useful :-
            // http://stackoverflow.com/questions/14212155/how-to-get-logged-on-users-with-their-status-on-remote-machine

            // Possibly useful :-
            // wmic /node:"servername or ip address" computersystem get username

            String LoggedOnUsers = null;

            try
            {
                System.Management.ManagementScope Scope;

                if (!ComputerName.Equals("localhost", StringComparison.OrdinalIgnoreCase))
                {
                    ConnectionOptions Conn = new ConnectionOptions();
                    Conn.Username = "shaun.dunmall.adm";
                    Conn.Password = "Oncology2020";
                    Conn.Authority = "ntlmdomain:ADMTW-TR";
                    Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), Conn);
                }
                else
                    Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), null);

                Scope.Connect();
                ObjectQuery Query = new ObjectQuery("SELECT LogonId  FROM Win32_LogonSession Where LogonType=2");
                ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);

                foreach (ManagementObject WmiObject in Searcher.Get())
                {
                    ObjectQuery LQuery = new ObjectQuery("Associators of {Win32_LogonSession.LogonId=" + WmiObject["LogonId"] + "} Where AssocClass=Win32_LoggedOnUser Role=Dependent");
                    ManagementObjectSearcher LSearcher = new ManagementObjectSearcher(Scope, LQuery);
                    foreach (ManagementObject LWmiObject in LSearcher.Get())
                    {
                        LoggedOnUsers += LWmiObject["Name"]+",";
                    }
                }
            }
            catch (Exception e)
            {
                //
            }
            if (LoggedOnUsers == "" || LoggedOnUsers == null)
            {
                return "N/A";
            }
            else
            {
                return LoggedOnUsers.Substring(0, LoggedOnUsers.Length - 1);
            }
        }

        private object TestForwardDNS(string computerName)
        {
            if (DNSlookupIsOK(computerName))
            {
                return DNSlookup(computerName);
            }
            else
            {
                return "ERROR";
            }
        }

        private object TestReverseDNS(string computerName)
        {
            return notYetImplementedMessage;
        }

        private string TestPing(string thing)
        {
            if (ISaValidIPAddress(thing))
            {
                // PING the IP address.
                if (PingByIP(thing))
                {
                    return "True";
                }
                else
                {
                    return "False";
                }
            }
            else
            {
                if (DNSlookupIsOK(thing))
                {
                    // PING the IP address from looking up the DNS name.
                    if(PingByNAME(thing))
                    {
                        return "True";
                    }
                    else
                    {
                        return "False";
                    }
                }
                else
                {
                    // Is not an IP address,
                    // and did not DNS lookup.
                    // Error!
                    return "DNS ERROR";
                }
            }
        }

        private bool PingByNAME(string thing)
        {
            if (DNSlookupIsOK(thing))
            {
                return PingByIP(DNSlookup(thing));
            }
            else
            {
                return false;
            }
        }

        private String DNSlookup(string thing)
        {
            return Dns.GetHostByName(thing).AddressList[0].ToString();
        }

        private bool DNSlookupIsOK(string thing)
        {
            // Make sure this isn't just a regular number like "1111" or "1."
            // which are actually  valid IP addresses, in decimal
            // which DNS would try, and fail, to lookup.
            bool result = float.TryParse(thing, out float number);
            if (result)
            {
                // It was a number so reject it.
                return false;
            }

            // OK, it's not a number, so see it if looks up.
            try
            {
                String s =  Dns.GetHostByName(thing).AddressList[0].ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool PingByIP(string thing)
        {
            if (!ISaValidIPAddress(thing))
            {
                return false;
            }
            Ping ping = new Ping();
            PingReply reply = ping.Send(thing);
            if (reply.Status == IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ISaValidIPAddress(string thing)
        {
            String[] octets = thing.Split('.');
            if (octets.Length != 4) return false;

            // if 0.0.0.0 then return false
            if (Int32.Parse(octets[0]) == 0 &&
                Int32.Parse(octets[1]) == 0 &&
                Int32.Parse(octets[2]) == 0 &&
                Int32.Parse(octets[3]) == 0 )
            {
                return false;
            }

            // if 255.255.255.255 then return false
            if (Int32.Parse(octets[0]) == 255 &&
                Int32.Parse(octets[1]) == 255 &&
                Int32.Parse(octets[2]) == 255 &&
                Int32.Parse(octets[3]) == 255)
            {
                return false;
            }

            // Make sure all the octets are between 0 and 255 inclusive
            foreach (String octet in octets)
            {
                if (!Int32.TryParse(octet, out int q) || q < 0 || q > 255) { return false; }
            }
            return true;
        }
    }    
}
