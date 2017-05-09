namespace Sericulus2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabContainer = new System.Windows.Forms.TabControl();
            this.SetupTab = new System.Windows.Forms.TabPage();
            this.Tests = new System.Windows.Forms.GroupBox();
            this.DoRDNS = new System.Windows.Forms.CheckBox();
            this.DoFDNS = new System.Windows.Forms.CheckBox();
            this.DoLoggedIn = new System.Windows.Forms.CheckBox();
            this.DoPing = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StopTest = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.StartTest = new System.Windows.Forms.Button();
            this.SortDesc = new System.Windows.Forms.Button();
            this.SortAsc = new System.Windows.Forms.Button();
            this.DeBlank = new System.Windows.Forms.Button();
            this.Deduplicate = new System.Windows.Forms.Button();
            this.computers = new System.Windows.Forms.TextBox();
            this.ResultsTab = new System.Windows.Forms.TabPage();
            this.Results = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.TabContainer.SuspendLayout();
            this.SetupTab.SuspendLayout();
            this.Tests.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ResultsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabContainer
            // 
            this.TabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabContainer.Controls.Add(this.SetupTab);
            this.TabContainer.Controls.Add(this.ResultsTab);
            this.TabContainer.Location = new System.Drawing.Point(0, 4);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.SelectedIndex = 0;
            this.TabContainer.Size = new System.Drawing.Size(404, 322);
            this.TabContainer.TabIndex = 0;
            // 
            // SetupTab
            // 
            this.SetupTab.Controls.Add(this.Tests);
            this.SetupTab.Controls.Add(this.groupBox1);
            this.SetupTab.Location = new System.Drawing.Point(4, 22);
            this.SetupTab.Name = "SetupTab";
            this.SetupTab.Padding = new System.Windows.Forms.Padding(3);
            this.SetupTab.Size = new System.Drawing.Size(396, 296);
            this.SetupTab.TabIndex = 0;
            this.SetupTab.Text = "Setup";
            this.SetupTab.UseVisualStyleBackColor = true;
            // 
            // Tests
            // 
            this.Tests.Controls.Add(this.DoRDNS);
            this.Tests.Controls.Add(this.DoFDNS);
            this.Tests.Controls.Add(this.DoLoggedIn);
            this.Tests.Controls.Add(this.DoPing);
            this.Tests.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tests.Location = new System.Drawing.Point(262, 3);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(125, 290);
            this.Tests.TabIndex = 2;
            this.Tests.TabStop = false;
            this.Tests.Text = "Tests";
            // 
            // DoRDNS
            // 
            this.DoRDNS.AutoSize = true;
            this.DoRDNS.Location = new System.Drawing.Point(7, 89);
            this.DoRDNS.Name = "DoRDNS";
            this.DoRDNS.Size = new System.Drawing.Size(92, 17);
            this.DoRDNS.TabIndex = 3;
            this.DoRDNS.Text = "Reverse DNS";
            this.DoRDNS.UseVisualStyleBackColor = true;
            this.DoRDNS.CheckedChanged += new System.EventHandler(this.DoRDNS_CheckedChanged);
            // 
            // DoFDNS
            // 
            this.DoFDNS.AutoSize = true;
            this.DoFDNS.Location = new System.Drawing.Point(7, 66);
            this.DoFDNS.Name = "DoFDNS";
            this.DoFDNS.Size = new System.Drawing.Size(90, 17);
            this.DoFDNS.TabIndex = 2;
            this.DoFDNS.Text = "Forward DNS";
            this.DoFDNS.UseVisualStyleBackColor = true;
            this.DoFDNS.CheckedChanged += new System.EventHandler(this.DoFDNS_CheckedChanged);
            // 
            // DoLoggedIn
            // 
            this.DoLoggedIn.AutoSize = true;
            this.DoLoggedIn.Location = new System.Drawing.Point(7, 43);
            this.DoLoggedIn.Name = "DoLoggedIn";
            this.DoLoggedIn.Size = new System.Drawing.Size(107, 17);
            this.DoLoggedIn.TabIndex = 1;
            this.DoLoggedIn.Text = "Who\'s Logged In";
            this.DoLoggedIn.UseVisualStyleBackColor = true;
            this.DoLoggedIn.CheckedChanged += new System.EventHandler(this.DoLoggedIn_CheckedChanged);
            // 
            // DoPing
            // 
            this.DoPing.AutoSize = true;
            this.DoPing.Location = new System.Drawing.Point(7, 20);
            this.DoPing.Name = "DoPing";
            this.DoPing.Size = new System.Drawing.Size(47, 17);
            this.DoPing.TabIndex = 0;
            this.DoPing.Text = "Ping";
            this.DoPing.UseVisualStyleBackColor = true;
            this.DoPing.CheckedChanged += new System.EventHandler(this.DoPing_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.computers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 290);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computers";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StopTest);
            this.panel1.Controls.Add(this.Quit);
            this.panel1.Controls.Add(this.StartTest);
            this.panel1.Controls.Add(this.SortDesc);
            this.panel1.Controls.Add(this.SortAsc);
            this.panel1.Controls.Add(this.DeBlank);
            this.panel1.Controls.Add(this.Deduplicate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 271);
            this.panel1.TabIndex = 2;
            // 
            // StopTest
            // 
            this.StopTest.Enabled = false;
            this.StopTest.Location = new System.Drawing.Point(4, 216);
            this.StopTest.Name = "StopTest";
            this.StopTest.Size = new System.Drawing.Size(129, 23);
            this.StopTest.TabIndex = 6;
            this.StopTest.Text = "STOP";
            this.StopTest.UseVisualStyleBackColor = true;
            // 
            // Quit
            // 
            this.Quit.Enabled = false;
            this.Quit.Location = new System.Drawing.Point(4, 245);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(129, 23);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "QUIT";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(3, 189);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(130, 23);
            this.StartTest.TabIndex = 4;
            this.StartTest.Text = "START";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // SortDesc
            // 
            this.SortDesc.Location = new System.Drawing.Point(4, 93);
            this.SortDesc.Name = "SortDesc";
            this.SortDesc.Size = new System.Drawing.Size(130, 23);
            this.SortDesc.TabIndex = 3;
            this.SortDesc.Text = "Sort Descending";
            this.SortDesc.UseVisualStyleBackColor = true;
            this.SortDesc.Click += new System.EventHandler(this.SortDesc_Click);
            // 
            // SortAsc
            // 
            this.SortAsc.Location = new System.Drawing.Point(4, 63);
            this.SortAsc.Name = "SortAsc";
            this.SortAsc.Size = new System.Drawing.Size(130, 23);
            this.SortAsc.TabIndex = 2;
            this.SortAsc.Text = "Sort Ascending";
            this.SortAsc.UseVisualStyleBackColor = true;
            this.SortAsc.Click += new System.EventHandler(this.SortAsc_Click);
            // 
            // DeBlank
            // 
            this.DeBlank.Location = new System.Drawing.Point(4, 34);
            this.DeBlank.Name = "DeBlank";
            this.DeBlank.Size = new System.Drawing.Size(130, 23);
            this.DeBlank.TabIndex = 1;
            this.DeBlank.Text = "Remove Blank Lines";
            this.DeBlank.UseVisualStyleBackColor = true;
            this.DeBlank.Click += new System.EventHandler(this.DeBlank_Click);
            // 
            // Deduplicate
            // 
            this.Deduplicate.Location = new System.Drawing.Point(4, 4);
            this.Deduplicate.Name = "Deduplicate";
            this.Deduplicate.Size = new System.Drawing.Size(130, 23);
            this.Deduplicate.TabIndex = 0;
            this.Deduplicate.Text = "Deduplicate";
            this.Deduplicate.UseVisualStyleBackColor = true;
            this.Deduplicate.Click += new System.EventHandler(this.DeDuplicate_Click);
            // 
            // computers
            // 
            this.computers.Dock = System.Windows.Forms.DockStyle.Right;
            this.computers.Location = new System.Drawing.Point(144, 16);
            this.computers.Multiline = true;
            this.computers.Name = "computers";
            this.computers.Size = new System.Drawing.Size(112, 271);
            this.computers.TabIndex = 0;
            // 
            // ResultsTab
            // 
            this.ResultsTab.Controls.Add(this.Results);
            this.ResultsTab.Location = new System.Drawing.Point(4, 22);
            this.ResultsTab.Name = "ResultsTab";
            this.ResultsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ResultsTab.Size = new System.Drawing.Size(396, 296);
            this.ResultsTab.TabIndex = 1;
            this.ResultsTab.Text = "Results";
            this.ResultsTab.UseVisualStyleBackColor = true;
            // 
            // Results
            // 
            this.Results.AllowUserToAddRows = false;
            this.Results.AllowUserToOrderColumns = true;
            this.Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Results.Location = new System.Drawing.Point(3, 3);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(390, 290);
            this.Results.TabIndex = 0;
            this.Results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Results_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(404, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status :";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 1;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 352);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TabContainer);
            this.MinimumSize = new System.Drawing.Size(420, 390);
            this.Name = "Form1";
            this.Text = "Sericulus 2.1";
            this.TabContainer.ResumeLayout(false);
            this.SetupTab.ResumeLayout(false);
            this.Tests.ResumeLayout(false);
            this.Tests.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResultsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage SetupTab;
        private System.Windows.Forms.TabPage ResultsTab;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox computers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SortDesc;
        private System.Windows.Forms.Button SortAsc;
        private System.Windows.Forms.Button DeBlank;
        private System.Windows.Forms.Button Deduplicate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.GroupBox Tests;
        private System.Windows.Forms.CheckBox DoFDNS;
        private System.Windows.Forms.CheckBox DoLoggedIn;
        private System.Windows.Forms.CheckBox DoPing;
        private System.Windows.Forms.Button StartTest;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button StopTest;
        public System.Windows.Forms.TabControl TabContainer;
        private System.Windows.Forms.CheckBox DoRDNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}

