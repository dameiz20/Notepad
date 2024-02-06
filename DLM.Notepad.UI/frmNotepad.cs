namespace DLM.Notepad.UI
{
    public partial class frmNotepad : Form
    {
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
                lblStatus.ForeColor = Color.Blue;

                //Designate the file path and escape the slashes
                string strFileName = "c:\\Users\\public\\data.txt";

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
    }
}
