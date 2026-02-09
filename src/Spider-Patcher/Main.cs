namespace Spider_Patcher
{
    public partial class Main : Form
    {
        // Main initialization.
        public Main()
        {
            InitializeComponent();
        }

        // Show MessageBox when the MainForm is loaded and displayed.
        private async void Main_Shown(object sender, EventArgs e)
        {
            if (!Directory.Exists(patchPath) || !Directory.EnumerateFileSystemEntries(patchPath).Any())
            {
                MessageBox.Show("No patch files found.\n\nClick OK to exit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            var msg = MessageBox.Show("Do you want to patch all files?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult dr = msg;
            if (dr != DialogResult.Yes)
            {
                Application.Exit();
                return;
            }
            await RunPatch();
        }

        // Avoid and close multiple instances on load.
        private void Main_Load(object sender, EventArgs e)
        {
            CheckInstance();
        }

        // Avoid closing the tool while the patch is running.
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBusy)
            {
                MessageBox.Show("Patch is still running, please wait.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
        }
    }
}
