namespace DLM.Notepad.UI
{
    public partial class frmNotepad : Form
    {
        string filename = @"c:\users\public\data.txt";
        string folder = string.Empty;
        List<string> lines;
        public frmNotepad()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTimerToggle_Click(object sender, EventArgs e)
        {
            /*
                //Toggle the button - Long Way
                if (btnTimerToggle.Text == "ON")
                {
                    // Enable timer and change text to off
                    btnTimerToggle.Text = "OFF";
                    timer1.Enabled = true;
                }
                else
                {
                    //Disable Timer and Change text to ON
                    btnTimerToggle.Text = "ON";
                    timer1.Enabled = false;
                }
             */

            // Ternary operator

            btnTimerToggle.Text = btnTimerToggle.Text == "ON" ? "OFF" : "ON";
            // does oposite of each other
            timer1.Enabled = !timer1.Enabled;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //This code will execute every second when timer is enabled

            lbxinfo.Items.Add(DateTime.Now.ToString());
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                statusStrip.ForeColor = Color.Blue;

                //Designate the file path and escape the slashes
                string strFileName = "c:\\Users\\Public\\data.txt";

                StreamWriter streamWriter;

                //Use the StreamWriter to create a file.
                streamWriter = File.CreateText(strFileName);

                //put the data in the file
                string strContents = txtInfo.Text;
                streamWriter.WriteLine(strContents);

                //Clean Up
                streamWriter.Close();

                lblStatus.Text = "File written (" + strFileName + ")";
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                statusStrip.ForeColor = Color.Blue;

                string strFileName = @"c:\Users\Public\data.txt";

                StreamReader streamReader;
                lblInfo.Text = string.Empty;

                if (File.Exists(filename))
                {
                    streamReader = File.OpenText(filename);
                    string contents = streamReader.ReadToEnd();

                    streamReader.Close();
                    streamReader = null;

                    lblInfo.Text = contents;
                    lblStatus.Text = "Succefully read " + filename;
                }
                else
                {
                    throw new Exception(filename + " does not exist");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                if (!string.IsNullOrEmpty(filename) && File.Exists(filename))
                {
                    File.Delete(filename);
                    lblStatus.Text = $"{filename} was deleted";
                }
                else
                {
                    throw new FileNotFoundException($"{filename} not set or does not exist");
                }
            }
            catch (FileNotFoundException ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Purple;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Opacity = trackBar1.Value / 100.0;

            //int number1 = trackBar1.Value / 100;
            //int number2 = trackBar1.Value % 100;
            //Text = $"{number1} r {number2}";

        }

        private void btnWriteAppend_Click(object sender, EventArgs e)
        {
            try
            {
                statusStrip.ForeColor = Color.Blue;

                StreamWriter streamWriter;

                //Use the StreamWriter to create a file.
                streamWriter = File.AppendText(filename);

                //put the data in the file
                string strContents = txtInfo.Text;
                streamWriter.WriteLine(strContents);

                //Clean Up
                streamWriter.Close();

                lblStatus.Text = $"File written ({filename})";
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                string targetfile = Path.GetDirectoryName(filename) + "\\data_copy.txt";

                if (!string.IsNullOrEmpty(filename) && File.Exists(filename))
                {
                    File.Copy(filename, targetfile);
                    lblStatus.Text = $"{filename} was copied.";
                }
                else
                {
                    throw new FileNotFoundException($"{filename} not set or does not exist");
                }
            }
            catch (FileNotFoundException ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Purple;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnReadByLine_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;

                StreamReader streamReader;
                lblInfo.Text = string.Empty;

                if (File.Exists(filename))
                {
                    streamReader = File.OpenText(filename);
                    lbxinfo.Items.Clear();


                    lines = new List<string>();
                    //Loop while i am not at the end of file.
                    while (!streamReader.EndOfStream)
                    {
                        lines.Add(streamReader.ReadLine());

                    }

                    //Bind the lines to the list box
                    lbxinfo.DataSource = lines;

                    streamReader.Close();
                    streamReader = null;

                    lblStatus.Text = $"Succefully read {lines.Count} records.";
                }
                else
                {
                    throw new Exception(filename + " does not exist");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnPickAFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                OpenFileDialog openFileDialog;
                openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Pick a file";
                openFileDialog.InitialDirectory = @"C:\users\public";

                //Show dialog to user
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblStatus.Text = openFileDialog.FileName;
                    filename = openFileDialog.FileName;
                }
                else
                {
                    throw new Exception("No file selected. No soup for you");
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                StreamWriter StreamWriter;

                saveFileDialog.Title = "Please Pick a File";
                saveFileDialog.InitialDirectory = @"C:\Users\Public";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog.FileName;
                    StreamWriter = File.CreateText(saveFileDialog.FileName);
                    StreamWriter.WriteLine(txtInfo.Text);
                    StreamWriter.Close();
                    StreamWriter = null;
                    lblStatus.Text = $"{filename} has been written...";
                }
                else
                {
                    throw new Exception("No file selected");
                }

            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelectOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                OpenFileDialog openFileDialog;

                openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Pick a file";
                openFileDialog.InitialDirectory = @"c:\Users\public";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                // Show the dialog to the user
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog.FileName;
                    StreamReader streamReader = File.OpenText(filename);
                    lblInfo.Text = streamReader.ReadToEnd();
                    lblStatus.Text = openFileDialog.FileName;
                    streamReader.Close();
                    streamReader = null;
                }
                else
                {
                    throw new Exception("No file selected.  No soup for you!");
                }


            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                    this.BackColor = colorDialog.Color;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnChangeButtonColor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Loops through all the controls on the form.
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        // Ask if the particular control is a button
                        if (this.Controls[i].GetType() == typeof(Button))
                        {
                            this.Controls[i].BackColor = colorDialog.Color;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog.SelectedPath;
                lblStatus.Text = $"Selected Folder: {folder}";

            }
        }
    }
}
