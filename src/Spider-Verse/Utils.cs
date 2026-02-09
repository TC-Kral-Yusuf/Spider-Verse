using System.Diagnostics;
using System.Media;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Return true, if directory exists AND not empty. Recommended for boolean variables.
        private static bool CheckDirFiles(string path)
        {
            return Directory.Exists(path) && Directory.EnumerateFileSystemEntries(path).Any();
        }

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

        // Open the URL in the default browser.
        private void OpenInBrowser(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        // Clear selected Objective including all variables and listboxes.
        private void ClearValues()
        {
            selectedType = ModCategory.None;
            selectedLastType = ModCategory.None;
            selectedObj = string.Empty;
            selectedLastObj = string.Empty;
            tb_Search.Text = string.Empty;
            cb_HUD.Enabled = false;
            lst_Obj.Items.Clear();
            ClearModValues();
        }

        // Clear selected Mod including variables and listboxes.
        private void ClearModValues()
        {
            selectedMod = string.Empty;
            modList.Clear();
            lst_Mods.Items.Clear();
        }

        // Playing a custom sound effect, whenever the user is clicking on a button. Works only if Sound Effects are enabled in the Settings
        private void PlaySFX(Stream sfx)
        {
            try
            {
                if (!soundEffectsToolStripMenuItem.Checked || sfx == null)
                {
                    return;
                }

                using var player = new SoundPlayer(sfx);
                player.Play();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Copy default HUD for Spidey, regardless which costume mod is in usage.
        private async Task CopyDefaultHUD()
        {
            try
            {
                if (!cb_HUD.Checked) return;

                string src = string.Empty;
                string dst = string.Empty;
                string dstBase = Path.Combine(emuPath, "data", "textures", "T13008N");
                string fileName = string.Empty;
                string dirName = string.Empty;
                string modelName = string.Empty;

                switch (selectedObj)
                {
                    case "01 - Spider-Man":
                    case "05 - Spidey Unlimited":
                    case "08 - Ben Reilly":
                        fileName = "14cede72.png";
                        dirName = Path.Combine("Comic-Accurate (Todd McFarlane)", "spidey");
                        src = Path.Combine(costumesPath, "01 - Spider-Man", dirName, fileName);
                        break;

                    case "02 - Spider-Man 2099":
                        fileName = "7f5866ae.png";
                        dirName = Path.Combine("Remastered", "sp2099");
                        src = Path.Combine(costumesPath, selectedObj, dirName, fileName);
                        break;

                    case "03 - Symbiote Spider-Man":
                        fileName = "55d17f89.png";
                        dirName = Path.Combine("Remastered v1", "spSymbi");
                        src = Path.Combine(costumesPath, selectedObj, dirName, fileName);
                        break;

                    case "04 - Captain Universe":
                        fileName = "b1e61f09.png";
                        dirName = Path.Combine("Remastered v1", "spUniv");
                        src = Path.Combine(costumesPath, selectedObj, dirName, fileName);
                        break;

                    case "06 - Amazing Bag-Man":
                        fileName = "a0922035.png";
                        dirName = Path.Combine("Remastered v1", "spBagMan");
                        src = Path.Combine(costumesPath, selectedObj, dirName, fileName);
                        break;

                    case "07 - Scarlet Spider":
                        fileName = "8f0f4c60.png";
                        dirName = Path.Combine("Remastered", "spScar");
                        src = Path.Combine(costumesPath, selectedObj, dirName, fileName);
                        break;

                    case "10 - Spider-Armor":
                        fileName = "c45522f5.png";
                        dirName = Path.Combine("Remastered v1", "spArmor");
                        src = Path.Combine(costumesPath, selectedObj, dirName, fileName);
                        break;

                    default:
                        MessageBox.Show($"No HUD mapping for: {selectedObj}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                
                if (!File.Exists(src))
                {
                    MessageBox.Show(errorDefaultHUD, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                modelName = Path.GetFileName(dirName);
                dst = Path.Combine(dstBase, modelName, fileName);
                File.Copy(src, dst, true);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}