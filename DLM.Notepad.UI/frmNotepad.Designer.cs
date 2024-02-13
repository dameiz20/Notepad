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
            btnRead = new Button();
            btnDelete = new Button();
            btnWriteAppend = new Button();
            btnCopy = new Button();
            btnReadByLine = new Button();
            btnSetFont = new Button();
            btnSelectDirectory = new Button();
            btnChangeButtonColor = new Button();
            btnSelectColor = new Button();
            btnSelectOpenFile = new Button();
            btnSaveFile = new Button();
            btnPickAFile = new Button();
            lblInfo = new Label();
            txtInfo = new TextBox();
            lbxinfo = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            trackBar1 = new TrackBar();
            btnChangeStlye = new Button();
            btnPrintPreview = new Button();
            menuStrip1.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            // btnRead
            // 
            btnRead.Location = new Point(12, 120);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(131, 29);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnWriteAppend
            // 
            btnWriteAppend.Location = new Point(12, 190);
            btnWriteAppend.Name = "btnWriteAppend";
            btnWriteAppend.Size = new Size(131, 29);
            btnWriteAppend.TabIndex = 5;
            btnWriteAppend.Text = "Write Append";
            btnWriteAppend.UseVisualStyleBackColor = true;
            btnWriteAppend.Click += btnWriteAppend_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(12, 225);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(131, 29);
            btnCopy.TabIndex = 6;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnReadByLine
            // 
            btnReadByLine.Location = new Point(12, 260);
            btnReadByLine.Name = "btnReadByLine";
            btnReadByLine.Size = new Size(131, 29);
            btnReadByLine.TabIndex = 7;
            btnReadByLine.Text = "Read By Line";
            btnReadByLine.UseVisualStyleBackColor = true;
            btnReadByLine.Click += btnReadByLine_Click;
            // 
            // btnSetFont
            // 
            btnSetFont.Location = new Point(12, 505);
            btnSetFont.Name = "btnSetFont";
            btnSetFont.Size = new Size(131, 29);
            btnSetFont.TabIndex = 14;
            btnSetFont.Text = "Set Font";
            btnSetFont.UseVisualStyleBackColor = true;
            btnSetFont.Click += btnSetFont_Click;
            // 
            // btnSelectDirectory
            // 
            btnSelectDirectory.Location = new Point(12, 470);
            btnSelectDirectory.Name = "btnSelectDirectory";
            btnSelectDirectory.Size = new Size(131, 29);
            btnSelectDirectory.TabIndex = 13;
            btnSelectDirectory.Text = "Select Directory";
            btnSelectDirectory.UseVisualStyleBackColor = true;
            // 
            // btnChangeButtonColor
            // 
            btnChangeButtonColor.Location = new Point(12, 435);
            btnChangeButtonColor.Name = "btnChangeButtonColor";
            btnChangeButtonColor.Size = new Size(131, 29);
            btnChangeButtonColor.TabIndex = 12;
            btnChangeButtonColor.Text = "Button Color";
            btnChangeButtonColor.UseVisualStyleBackColor = true;
            btnChangeButtonColor.Click += btnChangeButtonColor_Click;
            // 
            // btnSelectColor
            // 
            btnSelectColor.Location = new Point(12, 400);
            btnSelectColor.Name = "btnSelectColor";
            btnSelectColor.Size = new Size(131, 29);
            btnSelectColor.TabIndex = 11;
            btnSelectColor.Text = "Select Color";
            btnSelectColor.UseVisualStyleBackColor = true;
            btnSelectColor.Click += btnSelectColor_Click;
            // 
            // btnSelectOpenFile
            // 
            btnSelectOpenFile.Location = new Point(12, 365);
            btnSelectOpenFile.Name = "btnSelectOpenFile";
            btnSelectOpenFile.Size = new Size(131, 29);
            btnSelectOpenFile.TabIndex = 10;
            btnSelectOpenFile.Text = "Select Open File";
            btnSelectOpenFile.UseVisualStyleBackColor = true;
            btnSelectOpenFile.Click += btnSelectOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(12, 330);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(131, 29);
            btnSaveFile.TabIndex = 9;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnPickAFile
            // 
            btnPickAFile.Location = new Point(12, 295);
            btnPickAFile.Name = "btnPickAFile";
            btnPickAFile.Size = new Size(131, 29);
            btnPickAFile.TabIndex = 8;
            btnPickAFile.Text = "Pick A File";
            btnPickAFile.UseVisualStyleBackColor = true;
            btnPickAFile.Click += btnPickAFile_Click;
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
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 615);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(994, 22);
            statusStrip.TabIndex = 18;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 16);
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 16);
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(149, 523);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(415, 56);
            trackBar1.TabIndex = 19;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btnChangeStlye
            // 
            btnChangeStlye.Location = new Point(12, 540);
            btnChangeStlye.Name = "btnChangeStlye";
            btnChangeStlye.Size = new Size(131, 29);
            btnChangeStlye.TabIndex = 20;
            btnChangeStlye.Text = "Change Style";
            btnChangeStlye.UseVisualStyleBackColor = true;
            btnChangeStlye.Click += btnChangeStlye_Click;
            // 
            // btnPrintPreview
            // 
            btnPrintPreview.Location = new Point(12, 575);
            btnPrintPreview.Name = "btnPrintPreview";
            btnPrintPreview.Size = new Size(131, 29);
            btnPrintPreview.TabIndex = 21;
            btnPrintPreview.Text = "Print Preview";
            btnPrintPreview.UseVisualStyleBackColor = true;
            btnPrintPreview.Click += btnPrintPreview_Click;
            // 
            // frmNotepad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 637);
            Controls.Add(btnPrintPreview);
            Controls.Add(btnChangeStlye);
            Controls.Add(trackBar1);
            Controls.Add(statusStrip);
            Controls.Add(lbxinfo);
            Controls.Add(txtInfo);
            Controls.Add(lblInfo);
            Controls.Add(btnSetFont);
            Controls.Add(btnSelectDirectory);
            Controls.Add(btnChangeButtonColor);
            Controls.Add(btnSelectColor);
            Controls.Add(btnSelectOpenFile);
            Controls.Add(btnSaveFile);
            Controls.Add(btnPickAFile);
            Controls.Add(btnReadByLine);
            Controls.Add(btnCopy);
            Controls.Add(btnWriteAppend);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(btnTimerToggle);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmNotepad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private Button btnRead;
        private Button btnDelete;
        private Button btnWriteAppend;
        private Button btnCopy;
        private Button btnReadByLine;
        private Button btnSetFont;
        private Button btnSelectDirectory;
        private Button btnChangeButtonColor;
        private Button btnSelectColor;
        private Button btnSelectOpenFile;
        private Button btnSaveFile;
        private Button btnPickAFile;
        private Label lblInfo;
        private TextBox txtInfo;
        private ListBox lbxinfo;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TrackBar trackBar1;
        private Button btnChangeStlye;
        private Button btnPrintPreview;
    }
}
