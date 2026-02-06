using System;
using System.Collections.Generic;
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
                    File.Copy(file, targetFile, true);
                }

                foreach (var dir in Directory.GetDirectories(sourceDir))
                {
                    string targetSubDir = Path.Combine(targetDir, Path.GetFileName(dir));
                    await CopyFiles(dir, targetSubDir);
                }
            });
        }

        private async Task PatchFunc()
        {
            isBusy = true;
            lstOutput.Items.Clear();
            var costPath = Path.Combine(dataPath, "Costumes");
            var charPath = Path.Combine(dataPath, "Characters");
            var gfxPath = Path.Combine(dataPath, "Graphics");
            var exePath = Path.Combine(baseDir, "Spider-Verse.exe");

            // Patching the Spider-Verse executable.
            lstOutput.Items.Add("Patching Spider-Verse.exe...");
            File.Copy(Path.Combine(patchPath, "Spider-Verse.exe"), exePath, true);

            // Patching Costume mods.
            lstOutput.Items.Add("Patching Costumes...");
            await CopyFiles(Path.Combine(patchPath, "data", "Costumes"), costPath);

            // Patching Character mods.
            lstOutput.Items.Add("Patching Characters...");
            if (Directory.Exists(charPath))
            {
                Directory.Delete(charPath, true);
            }
            await CopyFiles(Path.Combine(patchPath, "data", "Characters"), charPath);

            // Patching Graphic mods.
            lstOutput.Items.Add("Patching Graphics...");
            if (Directory.Exists(gfxPath))
            {
                Directory.Delete(gfxPath, true);
            }
            await CopyFiles(Path.Combine(patchPath, "data", "Graphics"), gfxPath);

            // Finish the patch process and copy the next Spider-Verse executable file.
            isBusy = false;
            lstOutput.Items.Add("Removing Patch Folder...");
            Directory.Delete(patchPath, true);
            lstOutput.Items.Add("✅ PATCH COMPLETE!");
            MessageBox.Show("Files have been successfully patched!\n\nClick OK to finish.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
