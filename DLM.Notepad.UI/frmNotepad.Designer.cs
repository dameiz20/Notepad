namespace DLM.Notepad.UI
{
    partial class frmNotepad
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            nmuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuFileExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            btnTimerToggle = new Button();
            btnWrite = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            lblInfo = new Label();
            txtInfo = new TextBox();
            lbxinfo = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblStatus = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nmuFileNew, mnuFileOpen, toolStripMenuItem1, mnuFileExit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // nmuFileNew
            // 
            nmuFileNew.Name = "nmuFileNew";
            nmuFileNew.Size = new Size(169, 26);
            nmuFileNew.Text = "&New";
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(169, 26);
            mnuFileOpen.Text = "&Open";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(166, 6);
            // 
            // mnuFileExit
            // 
            mnuFileExit.Name = "mnuFileExit";
            mnuFileExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuFileExit.Size = new Size(169, 26);
            mnuFileExit.Text = "E&xit";
            mnuFileExit.Click += mnuFileExit_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(128, 26);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // btnTimerToggle
            // 
            btnTimerToggle.Location = new Point(12, 50);
            btnTimerToggle.Name = "btnTimerToggle";
            btnTimerToggle.Size = new Size(131, 29);
            btnTimerToggle.TabIndex = 1;
            btnTimerToggle.Text = "ON";
            btnTimerToggle.UseVisualStyleBackColor = true;
            btnTimerToggle.Click += btnTimerToggle_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(12, 85);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(131, 29);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 120);
            button3.Name = "button3";
            button3.Size = new Size(131, 29);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 155);
            button4.Name = "button4";
            button4.Size = new Size(131, 29);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 190);
            button5.Name = "button5";
            button5.Size = new Size(131, 29);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 225);
            button6.Name = "button6";
            button6.Size = new Size(131, 29);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 260);
            button7.Name = "button7";
            button7.Size = new Size(131, 29);
            button7.TabIndex = 7;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 505);
            button8.Name = "button8";
            button8.Size = new Size(131, 29);
            button8.TabIndex = 14;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(12, 470);
            button9.Name = "button9";
            button9.Size = new Size(131, 29);
            button9.TabIndex = 13;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(12, 435);
            button10.Name = "button10";
            button10.Size = new Size(131, 29);
            button10.TabIndex = 12;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(12, 400);
            button11.Name = "button11";
            button11.Size = new Size(131, 29);
            button11.TabIndex = 11;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(12, 365);
            button12.Name = "button12";
            button12.Size = new Size(131, 29);
            button12.TabIndex = 10;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(12, 330);
            button13.Name = "button13";
            button13.Size = new Size(131, 29);
            button13.TabIndex = 9;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(12, 295);
            button14.Name = "button14";
            button14.Size = new Size(131, 29);
            button14.TabIndex = 8;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            lblInfo.BorderStyle = BorderStyle.FixedSingle;
            lblInfo.Location = new Point(149, 35);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(415, 208);
            lblInfo.TabIndex = 15;
            lblInfo.Text = "label1";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(149, 246);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(415, 253);
            txtInfo.TabIndex = 16;
            // 
            // lbxinfo
            // 
            lbxinfo.FormattingEnabled = true;
            lbxinfo.ItemHeight = 20;
            lbxinfo.Location = new Point(570, 35);
            lbxinfo.Name = "lbxinfo";
            lbxinfo.Size = new Size(394, 464);
            lbxinfo.TabIndex = 17;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblStatus
            // 
            lblStatus.ImageScalingSize = new Size(20, 20);
            lblStatus.Location = new Point(0, 525);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(994, 24);
            lblStatus.TabIndex = 18;
            // 
            // frmNotepad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 549);
            Controls.Add(lblStatus);
            Controls.Add(lbxinfo);
            Controls.Add(txtInfo);
            Controls.Add(lblInfo);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnWrite);
            Controls.Add(btnTimerToggle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmNotepad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem nmuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private Button btnTimerToggle;
        private Button btnWrite;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Label lblInfo;
        private TextBox txtInfo;
        private ListBox lbxinfo;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip lblStatus;
    }
}
