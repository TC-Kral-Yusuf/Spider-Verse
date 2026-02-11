namespace Spider_Patcher
{
    public partial class Main : Form
    {
        // Main initialization.
        public Main()
        {
            InitializeComponent();
        }

        // Boolean variable to avoid exiting the tool while patching the files.
        private bool isBusy = false;

        // Base directory of the Patcher.
        private static readonly string baseDir = AppContext.BaseDirectory;

        // Path of the "data" folder inside the base directory.
        private static readonly string dataPath = Path.Combine(baseDir, "data");

        // Path of the "Patch" folder inside the base directory.
        private static readonly string patchPath = Path.Combine(baseDir, "Patch");

        // Show MessageBox when the MainForm is loaded and displayed.
        private async void Main_Shown(object sender, EventArgs e)
        {
            if (!CheckPatchFiles())
            {
                Environment.Exit(1);
                return;
            }

            var msg = MessageBox.Show("Do you want to patch all files?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult dr = msg;
            if (dr != DialogResult.Yes)
            {
                Environment.Exit(1);
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
