using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Spider_Patcher
{
    public partial class Main : Form
    {
        // Copying directories, files and subdirectories. Using Task, the main thread / UI doesn't freeze while installing Mods.
        private async Task CopyFiles(string sourceDir, string targetDir)
        {
            await Task.Run(async () =>
            {
                Directory.CreateDirectory(targetDir);

                foreach (var file in Directory.GetFiles(sourceDir))
                {
                    string targetFile = Path.Combine(targetDir, Path.GetFileName(file));
                    File.Move(file, targetFile, true);
                }

                foreach (var dir in Directory.GetDirectories(sourceDir))
                {
                    string targetSubDir = Path.Combine(targetDir, Path.GetFileName(dir));
                    await CopyFiles(dir, targetSubDir);
                }
            });
        }

        // Avoid the Patcher from starting if the Spider-Verse tool is active or if there is already a Patcher instance using Mutex. 
        private void CheckInstance()
        {
            Process[] proc = Process.GetProcessesByName("Spider-Verse");
            if (proc.Length > 0)
            {
                MessageBox.Show("Please exit Spider-Verse.exe before you run the Patcher! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }

            Mutex singleInstanceMutex = new(true, "Spider-Patcher");
            if (!singleInstanceMutex.WaitOne(0, false))
            {
                Environment.Exit(1);
            }
        }

        // This function patches all files by copying/removing the respective mod files.
        private async Task RunPatch()
        {
            try
            {
                isBusy = true;
                lstOutput.Items.Clear();
                var costPath = Path.Combine(dataPath, "Costumes");
                var charPath = Path.Combine(dataPath, "Characters");
                var gfxPath = Path.Combine(dataPath, "Graphics");
                var exePath = Path.Combine(baseDir, "Spider-Verse.exe");

                // Patching the Spider-Verse executable.
                lstOutput.Items.Add("PATCH RUNNING - PLEASE WAIT!");
                lstOutput.Items.Add("PATCHING: Spider-Verse.exe");
                File.Copy(Path.Combine(patchPath, "Spider-Verse.exe"), exePath, true);

                // Patching Costume mods.
                lstOutput.Items.Add("PATCHING: Costumes");
                await CopyFiles(Path.Combine(patchPath, "data", "Costumes"), costPath);

                // Patching Character mods.
                lstOutput.Items.Add("PATCHING: Characters");
                if (Directory.Exists(charPath))
                {
                    Directory.Delete(charPath, true);
                }
                await CopyFiles(Path.Combine(patchPath, "data", "Characters"), charPath);

                // Patching Graphic mods.
                lstOutput.Items.Add("PATCHING: Graphics");
                if (Directory.Exists(gfxPath))
                {
                    Directory.Delete(gfxPath, true);
                }
                await CopyFiles(Path.Combine(patchPath, "data", "Graphics"), gfxPath);

                // Finish the patch process and copy the next Spider-Verse executable file.
                lstOutput.Items.Add("DELETING: Patch Folder");
                Directory.Delete(patchPath, true);
                lstOutput.Items.Add("SUCCESS: PATCH COMPLETE!");
                MessageBox.Show("Patched successfully!\n\nClick OK to finish.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An Error has occured:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                isBusy = false;
                Application.Exit();
            }
        }
    }
}
