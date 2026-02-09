using System.Diagnostics;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Avoid the tool from starting if the Patcher is active or if there is already a Spider-Verse.exe instance using Mutex.
        private void CheckToolInstance()
        {
            Process[] proc = Process.GetProcessesByName("Spider-Patcher");
            if (proc.Length > 0)
            {
                MessageBox.Show(errorPatchRunning, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }

            Mutex singleInstanceMutex = new(true, "Spider-Verse");
            if (!singleInstanceMutex.WaitOne(0, false))
            {
                MessageBox.Show(errorToolInstance, "Instance Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }
        }

        // Check for the data folder. If it doesn't exist OR if its empty, the tool will exit immediately (and merciless, lol).
        private void CheckDataPath()
        {
            try
            {
                isDataFound = CheckDirFiles(dataPath);
                if (!isDataFound)
                {
                    MessageBox.Show(errorDataPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        // Check for the flycast.exe. If it doesn't exist, then show an error message.
        private void CheckEmuPath()
        {
            string fullPath = Path.Combine(emuPath, "flycast.exe");
            isEmuFound = File.Exists(fullPath);
            fswEmu.Path = emuPath;
            fswEmu.EnableRaisingEvents = true;

            if (!isEmuFound)
            {
                ClearValues();
                MessageBox.Show(errorEmuPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isStarted) MessageBox.Show(successEmuPath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}