using System.Diagnostics;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Refreshes UI controls: enables/disables buttons, search box, and HUD checkbox based on selected Objective/Mod, available data folders, as well as emulator directory status.
        private void RefreshUI()
        {
            if (isDataFound)
            {
                bool hasCostumes = CheckDirFiles(costumesPath);
                bool hasCharacters = CheckDirFiles(characterPath);
                bool hasGfx = CheckDirFiles(gfxPath);

                bool isObjValid = lst_Obj.Items.Count > 0 && lst_Obj.SelectedIndex > -1;
                bool isModValid = lst_Mods.Items.Count > 0 && lst_Mods.SelectedIndex > -1;

                btn_Flycast.Enabled = isEmuFound;
                btn_Costumes.Enabled = isEmuFound && hasCostumes;
                btn_Chars.Enabled = isEmuFound && hasCharacters;
                btn_Gfx.Enabled = isEmuFound && hasGfx;

                btn_Enable.Enabled = isEmuFound && isObjValid && isModValid;
                btn_Disable.Enabled = isEmuFound && isObjValid && isModValid;
                btn_Reset.Enabled = isEmuFound;
                tb_Search.Enabled = isEmuFound && lst_Obj.Items.Count > 0;

                cb_HUD.Enabled = isEmuFound && isObjValid && isModValid && selectedType == ModCategory.Costumes && !selectedObj.Contains("Peter Parker", StringComparison.OrdinalIgnoreCase);

                if (!cb_HUD.Enabled) cb_HUD.Checked = false;
            }
        }

        // Opens the default web browser to download Flycast. Any errors during this process are caught and displayed.
        private void DownloadFlycast()
        {
            try
            {
                OpenInBrowser(urlFlycast);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Browse and set the Flycast directory using FolderBrowserDialog. It is only checking for the flycast.exe and nothing else.
        private void SetFlycastPath()
        {
            try
            {
                using FolderBrowserDialog fbd = new()
                {
                    Description = "Navigate to the directory, where Flycast is installed / located."
                };

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    emuPath = fbd.SelectedPath;
                    tb_Path.Text = emuPath;
                    CheckEmuPath();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Starts the Flycast emulator from the respective directory, which has been setted by the User.
        private void StartFlycast()
        {
            try
            {
                var emuFullPath = Path.Combine(emuPath, "flycast.exe");
                Process[] proc = Process.GetProcessesByName("flycast");

                if (proc.Length > 0)
                {
                    MessageBox.Show(errorEmuInstance, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = emuFullPath,
                    UseShellExecute = true
                });
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}