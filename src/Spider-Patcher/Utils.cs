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
    }
}
