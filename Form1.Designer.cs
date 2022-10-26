namespace PlateChef
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkNoLosing = new System.Windows.Forms.CheckBox();
            this.checkNoPatience = new System.Windows.Forms.CheckBox();
            this.checkInstanceProcesses = new System.Windows.Forms.CheckBox();
            this.checkNoBadProcess = new System.Windows.Forms.CheckBox();
            this.checkNoProcesses = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.buttonConnectRoom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.checkBoxEnablePolls = new System.Windows.Forms.CheckBox();
            this.listBoxVisitingNames = new System.Windows.Forms.ListBox();
            this.labelVisiting = new System.Windows.Forms.Label();
            this.labelVisited = new System.Windows.Forms.Label();
            this.listBoxFinishedNames = new System.Windows.Forms.ListBox();
            this.labelQueue = new System.Windows.Forms.Label();
            this.checkBoxEnableOrder = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableVisit = new System.Windows.Forms.CheckBox();
            this.labelVisitStatus = new System.Windows.Forms.Label();
            this.listBoxQueueNames = new System.Windows.Forms.ListBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Blueprint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(399, 25);
            this.comboBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Load Game Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(25, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(399, 25);
            this.comboBox2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(430, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Create Card";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Set Money";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(131, 269);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Set Day";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 269);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 11;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "End Day";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(131, 324);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Remove Customer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(360, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "Add Customer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(255, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 16;
            // 
            // checkNoLosing
            // 
            this.checkNoLosing.AutoSize = true;
            this.checkNoLosing.Location = new System.Drawing.Point(25, 388);
            this.checkNoLosing.Name = "checkNoLosing";
            this.checkNoLosing.Size = new System.Drawing.Size(87, 21);
            this.checkNoLosing.TabIndex = 17;
            this.checkNoLosing.Text = "No Losing";
            this.checkNoLosing.UseVisualStyleBackColor = true;
            this.checkNoLosing.CheckedChanged += new System.EventHandler(this.checkNoLosing_CheckedChanged);
            // 
            // checkNoPatience
            // 
            this.checkNoPatience.AutoSize = true;
            this.checkNoPatience.Location = new System.Drawing.Point(118, 388);
            this.checkNoPatience.Name = "checkNoPatience";
            this.checkNoPatience.Size = new System.Drawing.Size(97, 21);
            this.checkNoPatience.TabIndex = 18;
            this.checkNoPatience.Text = "No Patience";
            this.checkNoPatience.UseVisualStyleBackColor = true;
            this.checkNoPatience.CheckedChanged += new System.EventHandler(this.checkNoPatience_CheckedChanged);
            // 
            // checkInstanceProcesses
            // 
            this.checkInstanceProcesses.AutoSize = true;
            this.checkInstanceProcesses.Location = new System.Drawing.Point(221, 388);
            this.checkInstanceProcesses.Name = "checkInstanceProcesses";
            this.checkInstanceProcesses.Size = new System.Drawing.Size(128, 21);
            this.checkInstanceProcesses.TabIndex = 19;
            this.checkInstanceProcesses.Text = "Instant Processes";
            this.checkInstanceProcesses.UseVisualStyleBackColor = true;
            this.checkInstanceProcesses.CheckedChanged += new System.EventHandler(this.checkInstanceProcesses_CheckedChanged);
            // 
            // checkNoBadProcess
            // 
            this.checkNoBadProcess.AutoSize = true;
            this.checkNoBadProcess.Location = new System.Drawing.Point(25, 415);
            this.checkNoBadProcess.Name = "checkNoBadProcess";
            this.checkNoBadProcess.Size = new System.Drawing.Size(134, 21);
            this.checkNoBadProcess.TabIndex = 20;
            this.checkNoBadProcess.Text = "No Bad Processes";
            this.checkNoBadProcess.UseVisualStyleBackColor = true;
            this.checkNoBadProcess.CheckedChanged += new System.EventHandler(this.checkNoBadProcess_CheckedChanged);
            // 
            // checkNoProcesses
            // 
            this.checkNoProcesses.AutoSize = true;
            this.checkNoProcesses.Location = new System.Drawing.Point(165, 415);
            this.checkNoProcesses.Name = "checkNoProcesses";
            this.checkNoProcesses.Size = new System.Drawing.Size(107, 21);
            this.checkNoProcesses.TabIndex = 21;
            this.checkNoProcesses.Text = "No Processes";
            this.checkNoProcesses.UseVisualStyleBackColor = true;
            this.checkNoProcesses.CheckedChanged += new System.EventHandler(this.checkNoProcesses_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Syncing Status?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(361, 269);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 23);
            this.button10.TabIndex = 25;
            this.button10.Text = "Set Level";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(255, 269);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 24;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(25, 452);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(505, 23);
            this.textBoxCommand.TabIndex = 26;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(536, 452);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(119, 23);
            this.buttonSendCommand.TabIndex = 27;
            this.buttonSendCommand.Text = "Send Command";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // buttonConnectRoom
            // 
            this.buttonConnectRoom.Location = new System.Drawing.Point(251, 6);
            this.buttonConnectRoom.Name = "buttonConnectRoom";
            this.buttonConnectRoom.Size = new System.Drawing.Size(113, 23);
            this.buttonConnectRoom.TabIndex = 28;
            this.buttonConnectRoom.Text = "Connect Room";
            this.buttonConnectRoom.UseVisualStyleBackColor = true;
            this.buttonConnectRoom.Click += new System.EventHandler(this.buttonConnectRoom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 526);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonSendCommand);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxCommand);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.checkNoProcesses);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.checkNoBadProcess);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.checkInstanceProcesses);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.checkNoPatience);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.checkNoLosing);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cheat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExport);
            this.tabPage2.Controls.Add(this.buttonShuffle);
            this.tabPage2.Controls.Add(this.buttonImport);
            this.tabPage2.Controls.Add(this.checkBoxEnablePolls);
            this.tabPage2.Controls.Add(this.listBoxVisitingNames);
            this.tabPage2.Controls.Add(this.labelVisiting);
            this.tabPage2.Controls.Add(this.labelVisited);
            this.tabPage2.Controls.Add(this.listBoxFinishedNames);
            this.tabPage2.Controls.Add(this.labelQueue);
            this.tabPage2.Controls.Add(this.checkBoxEnableOrder);
            this.tabPage2.Controls.Add(this.checkBoxEnableVisit);
            this.tabPage2.Controls.Add(this.labelVisitStatus);
            this.tabPage2.Controls.Add(this.listBoxQueueNames);
            this.tabPage2.Controls.Add(this.textBoxComment);
            this.tabPage2.Controls.Add(this.textBoxRoomID);
            this.tabPage2.Controls.Add(this.buttonConnectRoom);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chef";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(452, 32);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 44;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Location = new System.Drawing.Point(533, 32);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(75, 23);
            this.buttonShuffle.TabIndex = 43;
            this.buttonShuffle.Text = "Shuffle";
            this.buttonShuffle.UseVisualStyleBackColor = true;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(371, 32);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 41;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // checkBoxEnablePolls
            // 
            this.checkBoxEnablePolls.AutoSize = true;
            this.checkBoxEnablePolls.Location = new System.Drawing.Point(584, 6);
            this.checkBoxEnablePolls.Name = "checkBoxEnablePolls";
            this.checkBoxEnablePolls.Size = new System.Drawing.Size(97, 21);
            this.checkBoxEnablePolls.TabIndex = 40;
            this.checkBoxEnablePolls.Text = "Enable Polls";
            this.checkBoxEnablePolls.UseVisualStyleBackColor = true;
            this.checkBoxEnablePolls.CheckedChanged += new System.EventHandler(this.checkBoxEnablePolls_CheckedChanged);
            // 
            // listBoxVisitingNames
            // 
            this.listBoxVisitingNames.FormattingEnabled = true;
            this.listBoxVisitingNames.ItemHeight = 17;
            this.listBoxVisitingNames.Location = new System.Drawing.Point(526, 76);
            this.listBoxVisitingNames.Name = "listBoxVisitingNames";
            this.listBoxVisitingNames.Size = new System.Drawing.Size(150, 412);
            this.listBoxVisitingNames.TabIndex = 39;
            // 
            // labelVisiting
            // 
            this.labelVisiting.AutoSize = true;
            this.labelVisiting.Location = new System.Drawing.Point(526, 56);
            this.labelVisiting.Name = "labelVisiting";
            this.labelVisiting.Size = new System.Drawing.Size(50, 17);
            this.labelVisiting.TabIndex = 38;
            this.labelVisiting.Text = "Visiting";
            // 
            // labelVisited
            // 
            this.labelVisited.AutoSize = true;
            this.labelVisited.Location = new System.Drawing.Point(681, 56);
            this.labelVisited.Name = "labelVisited";
            this.labelVisited.Size = new System.Drawing.Size(55, 17);
            this.labelVisited.TabIndex = 37;
            this.labelVisited.Text = "Finished";
            // 
            // listBoxFinishedNames
            // 
            this.listBoxFinishedNames.FormattingEnabled = true;
            this.listBoxFinishedNames.ItemHeight = 17;
            this.listBoxFinishedNames.Location = new System.Drawing.Point(682, 76);
            this.listBoxFinishedNames.Name = "listBoxFinishedNames";
            this.listBoxFinishedNames.Size = new System.Drawing.Size(150, 412);
            this.listBoxFinishedNames.TabIndex = 36;
            // 
            // labelQueue
            // 
            this.labelQueue.AutoSize = true;
            this.labelQueue.Location = new System.Drawing.Point(369, 56);
            this.labelQueue.Name = "labelQueue";
            this.labelQueue.Size = new System.Drawing.Size(46, 17);
            this.labelQueue.TabIndex = 35;
            this.labelQueue.Text = "Queue";
            // 
            // checkBoxEnableOrder
            // 
            this.checkBoxEnableOrder.AutoSize = true;
            this.checkBoxEnableOrder.Location = new System.Drawing.Point(473, 6);
            this.checkBoxEnableOrder.Name = "checkBoxEnableOrder";
            this.checkBoxEnableOrder.Size = new System.Drawing.Size(105, 21);
            this.checkBoxEnableOrder.TabIndex = 34;
            this.checkBoxEnableOrder.Text = "Enable Order";
            this.checkBoxEnableOrder.UseVisualStyleBackColor = true;
            this.checkBoxEnableOrder.CheckedChanged += new System.EventHandler(this.checkBoxEnableOrder_CheckedChanged);
            // 
            // checkBoxEnableVisit
            // 
            this.checkBoxEnableVisit.AutoSize = true;
            this.checkBoxEnableVisit.Location = new System.Drawing.Point(371, 6);
            this.checkBoxEnableVisit.Name = "checkBoxEnableVisit";
            this.checkBoxEnableVisit.Size = new System.Drawing.Size(94, 21);
            this.checkBoxEnableVisit.TabIndex = 33;
            this.checkBoxEnableVisit.Text = "Enable Visit";
            this.checkBoxEnableVisit.UseVisualStyleBackColor = true;
            this.checkBoxEnableVisit.CheckedChanged += new System.EventHandler(this.checkBoxEnableVisit_CheckedChanged);
            // 
            // labelVisitStatus
            // 
            this.labelVisitStatus.AutoSize = true;
            this.labelVisitStatus.Location = new System.Drawing.Point(614, 35);
            this.labelVisitStatus.Name = "labelVisitStatus";
            this.labelVisitStatus.Size = new System.Drawing.Size(95, 17);
            this.labelVisitStatus.TabIndex = 32;
            this.labelVisitStatus.Text = "labelVisitStatus";
            // 
            // listBoxQueueNames
            // 
            this.listBoxQueueNames.FormattingEnabled = true;
            this.listBoxQueueNames.ItemHeight = 17;
            this.listBoxQueueNames.Location = new System.Drawing.Point(370, 76);
            this.listBoxQueueNames.Name = "listBoxQueueNames";
            this.listBoxQueueNames.Size = new System.Drawing.Size(150, 412);
            this.listBoxQueueNames.TabIndex = 31;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(6, 35);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.ReadOnly = true;
            this.textBoxComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxComment.Size = new System.Drawing.Size(358, 455);
            this.textBoxComment.TabIndex = 30;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.Location = new System.Drawing.Point(6, 6);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.Size = new System.Drawing.Size(239, 23);
            this.textBoxRoomID.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 555);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PlateChef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label3;
        private ComboBox comboBox2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox3;
        private CheckBox checkNoLosing;
        private CheckBox checkNoPatience;
        private CheckBox checkInstanceProcesses;
        private CheckBox checkNoBadProcess;
        private CheckBox checkNoProcesses;
        private CheckBox checkBox1;
        private Button button10;
        private TextBox textBox4;
        private TextBox textBoxCommand;
        private Button buttonSendCommand;
        private Button buttonConnectRoom;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxRoomID;
        private TextBox textBoxComment;
        private Label labelVisitStatus;
        private ListBox listBoxQueueNames;
        private CheckBox checkBoxEnableOrder;
        private CheckBox checkBoxEnableVisit;
        private Label labelVisited;
        private ListBox listBoxFinishedNames;
        private Label labelQueue;
        private ListBox listBoxVisitingNames;
        private Label labelVisiting;
        private CheckBox checkBoxEnablePolls;
        private Button buttonExport;
        private Button buttonShuffle;
        private Button buttonImport;
    }
}