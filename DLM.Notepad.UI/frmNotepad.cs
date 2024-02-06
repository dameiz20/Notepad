namespace DLM.Notepad.UI
{
    public partial class frmNotepad : Form
    {
        string filename = @"c:\users\public\data.txt";
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

                lblStatus.Text =$"File written ({ filename})";
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
