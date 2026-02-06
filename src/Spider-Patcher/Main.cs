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

            var msg = MessageBox.Show("Do you want patch all files?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult dr = msg;
            if (dr != DialogResult.Yes)
            {
                Application.Exit();
                return;
            }
            await RunPatch();
        }

        // Function for copying all patch files into the data directory.
        private async Task RunPatch()
        {
            isBusy = true;
            lstOutput.Items.Clear();
            var pathCost = Path.Combine(dataPath, "Costumes");
            var pathChar = Path.Combine(dataPath, "Characters");
            var pathGFX = Path.Combine(dataPath, "Graphics");

            // Patching Costume mods.
            lstOutput.Items.Add("Patching Costumes...");
            await CopyFiles(Path.Combine(patchPath, "data", "Costumes"), pathCost);
            lstOutput.Items.Add("✅ PATCHED!");

            // Patching Character mods.
            lstOutput.Items.Add("Patching Characters...");
            if (Directory.Exists(pathChar))
            {
                Directory.Delete(pathChar, true);
            }
            await CopyFiles(Path.Combine(patchPath, "data", "Characters"), pathChar);
            lstOutput.Items.Add("✅ PATCHED!");

            // Patching Graphic mods.
            lstOutput.Items.Add("Patching Graphics...");
            if (Directory.Exists(pathGFX))
            {
                Directory.Delete(pathGFX, true);
            }
            await CopyFiles(Path.Combine(patchPath, "data", "Graphics"), pathGFX);
            lstOutput.Items.Add("✅ PATCHED!");

            isBusy = false;
            Directory.Delete(patchPath, true);
            MessageBox.Show("Files have been successfully patched!\n\nClick OK to finish.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

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
