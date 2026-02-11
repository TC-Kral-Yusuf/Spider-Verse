using System.Diagnostics;

namespace Spider_Patcher
{
    public partial class Main : Form
    {
        // Copying directories, files and subdirectories. Using Task, the main thread / UI doesn't freeze while installing Mods.
        private static async Task CopyFiles(string sourceDir, string targetDir)
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

        // Avoid the Patcher from starting if the Spider-Verse tool is active or if there is already a Patcher instance. 
        private static void CheckInstance()
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

        private static bool CheckPatchFiles()
        {
            if (!Directory.Exists(patchPath) || !Directory.EnumerateFileSystemEntries(patchPath).Any())
            {
                MessageBox.Show("No patch files found.\n\nClick OK to exit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
