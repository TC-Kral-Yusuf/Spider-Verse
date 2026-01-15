namespace Spider_Verse
{
    public partial class Main : Form
    {
        // If the selected Mod Category exists AND not empty, then load all Objectives into the left Listbox.
        private void LoadObj()
        {
            try
            {
                RefreshUI();
                string fullPath = Path.Combine(dataPath, selectedType.ToString());

                if (!CheckDirFiles(fullPath))
                {
                    MessageBox.Show($"{errorSelectedType} {selectedType}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var d in Directory.GetDirectories(fullPath))
                {
                    string trimmedPath = new DirectoryInfo(d).Name;
                    lst_Obj.Items.Add(trimmedPath);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // If the selected Objective exists AND is not empty, then load all respective Mods into the right Listbox.
        private void LoadMods()
        {
            try
            {
                modList.Clear();
                lst_Mods.Items.Clear();
                string fullPath = Path.Combine(dataPath, selectedType.ToString(), selectedObj);

                if (!CheckDirFiles(fullPath))
                {
                    MessageBox.Show($"{errorSelectedObj}\n\nObjective: {selectedObj}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var d in Directory.GetDirectories(fullPath))
                {
                    string trimmedPath = Path.GetFileName(d);
                    modList.Add(trimmedPath);
                }

                if (modList.Count > 0)
                {
                    foreach (var i in modList)
                    {
                        lst_Mods.Items.Add(i);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validate the Type + Objective + Mod selection to catch errors before copying directories and files from the source to the destination.
        private bool ValidateModSelection()
        {
            if (selectedType == ModCategory.None || string.IsNullOrWhiteSpace(selectedObj) || string.IsNullOrWhiteSpace(selectedMod))
            {
                MessageBox.Show(errorNoSelection, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string src = Path.Combine(dataPath, selectedType.ToString(), selectedObj, selectedMod);
            
            if (!Directory.Exists(src))
            {
                MessageBox.Show(errorSourceNotFound, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        // Enable the selected mod by copying all directories and files from the source to the destination (Flycast Texture Path).
        private async Task EnableMod()
        {
            try
            {
                string src = Path.Combine(dataPath, selectedType.ToString(), selectedObj, selectedMod);
                string dst = Path.Combine(emuPath, "data", "textures", "T13008N");

                if (!ValidateModSelection())
                {
                    return;
                }

                await CopyFiles(src, dst);

                if (cb_HUD.Checked) await CopyDefaultHUD();
                if (messageBoxToolStripMenuItem.Checked) MessageBox.Show(successEnableMod, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Disable the seleced mod by checking all directories and files from the selected mod in the Flycast textures directory. 
        private async Task DisableMod()
        {
            try
            {
                string src = Path.Combine(dataPath, selectedType.ToString(), selectedObj, selectedMod);
                string dst = Path.Combine(emuPath, "data", "textures", "T13008N");
                bool isFound = false;

                if (!ValidateModSelection())
                {
                    return;
                }

                foreach (var d in Directory.GetDirectories(src))
                {
                    var dir = Path.Combine(dst, Path.GetFileName(d));
                    if (Directory.Exists(dir))
                    {
                        Directory.Delete(dir, true);
                        isFound = true;
                    }
                }

                foreach (var f in Directory.GetFiles(src))
                {
                    var file = Path.Combine(dst, Path.GetFileName(f));
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                        isFound = true;
                    }
                }

                if (!isFound)
                {
                    MessageBox.Show(errorModsEmpty, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (messageBoxToolStripMenuItem.Checked) MessageBox.Show(successDisableMod, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deleting and recreating the Flycast texture directory.
        private async Task DisableAllMods()
        {
            try
            {
                string dst = Path.Combine(emuPath, "data", "textures", "T13008N");

                if (!Directory.Exists(dst) || !Directory.EnumerateFileSystemEntries(dst).Any())
                {
                    MessageBox.Show(errorDisableAll, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dr = MessageBox.Show("Do you really want to disable all Mods? This cannot be undone.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                Directory.Delete(dst, true);
                Directory.CreateDirectory(dst);

                MessageBox.Show(successDisableAll, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This function is only used by the search bar textbox to filter mod names for an easier selection.
        private void FilterMods(string filter)
        {
            lst_Mods.Items.Clear();
            var filtered = modList.Where(m => m.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToArray();
            lst_Mods.Items.AddRange(filtered);
        }
    }
}