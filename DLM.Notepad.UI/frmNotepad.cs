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
    }
}
