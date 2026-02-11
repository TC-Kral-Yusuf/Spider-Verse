namespace Spider_Patcher
{
    public partial class Main : Form
    {

        // Patch the Spider-Verse executable, which copies the updated one to the current directory.
        private async Task PatchExe()
        {
            string src = Path.Combine(patchPath, "Spider-Verse.exe");
            string dst = Path.Combine(baseDir, "Spider-Verse.exe");
            if (!File.Exists(src))
            {
                isBusy = false;
                MessageBox.Show("Error: Spider-Verse.exe was not found in Patch folder.\n\nClick OK to exit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }
            lstOutput.Items.Add("PATCHING: Spider-Verse.exe");
            File.Move(src, dst, true);
        }

        // This function copies all respective mod files to the data folder using the string parameter.
        private async Task PatchFiles(string category)
        {
            string src = Path.Combine(patchPath, "data", category);
            string dst = Path.Combine(dataPath, category);
            lstOutput.Items.Add($"PATCHING: {category}");
            if (Directory.Exists(dst) && category != "Costumes")
            {
                Directory.Delete(dst, true);
            }
            await CopyFiles(src, dst);
        }

        // This function patches all files by copying/removing the respective mod files.
        private async Task RunPatch()
        {
            try
            {
                if (!CheckPatchFiles())
                {
                    Environment.Exit(1);
                    return;
                }

                isBusy = true;
                lstOutput.Items.Clear();
                lstOutput.Items.Add("PATCH RUNNING - PLEASE WAIT!");
                await PatchExe();
                await PatchFiles("Costumes");
                await PatchFiles("Characters");
                await PatchFiles("Graphics");
                lstOutput.Items.Add("PATCHED!");
                Directory.Delete(patchPath, true);
                MessageBox.Show("Patched successfully!\n\nClick OK to finish.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An Error has occured:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isBusy = false;
                Environment.Exit(1);
            }

            finally
            {
                isBusy = false;
                Environment.Exit(1);
            }
        }
    }
}
