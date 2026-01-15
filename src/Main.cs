using System.Diagnostics;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Constructor for the MainForm. Initializes all controls, event handlers, and designer settings.
        public Main()
        {
            InitializeComponent();
        }

        // Includes all necessary actions when the MainForm has been loaded, such as the Single-Instance Check, as well as checking the data directory.
        private void Main_Load(object sender, EventArgs e)
        {
            fswDir.Path = baseDir;
            currentVersion = new(Application.ProductVersion);
            CheckDataPath();
            CheckToolInstance();
            ConfigLoad();
        }

        // Triggered when the MainForm is first displayed.
        private async void Main_Shown(object sender, EventArgs e)
        {
            RefreshUI();
            await GetUpdatesOnStartup();
            isStarted = true;
        }

        // Triggered when the MainForm is about to close. Can be used to cancel closing or prompt the user to save changes.
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = isRestartRequired ? "Do you want to restart?" : "Do you really want to exit?";
            DialogResult dr = MessageBox.Show(message, "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
                isRestartRequired = false;
                return;
            }
        }

        // Triggered after the MainForm has closed. In this case, it is used to restart the application if the Restart flag is set to true.
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isRestartRequired)
            {
                Application.Restart();
            }
        }

        // Opens the default web browser to download Flycast. Any errors during this process are caught and displayed.
        private void btn_Download_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            DownloadFlycast();
        }

        // Selecting the directory, where Flycast is located/installed.
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            SetFlycastPath();
            RefreshUI();
        }

        // Does nothing special, starts the Flycast emulator from the respective directory.
        private void btn_Flycast_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            StartFlycast();
        }

        // Loading all Costumes (Objectives) into the first Listbox (left side).
        private void btn_Costumes_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            ClearValues();
            selectedType = ModCategory.Costumes;
            LoadObj();
        }

        // Loading all Characters (Objectives) into the first Listbox (left side).
        private void btn_Chars_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            ClearValues();
            selectedType = ModCategory.Characters;
            LoadObj();
        }

        // Loading all Graphic/Texture Mods (Objectives) into the first Listbox (left side).
        private void btn_Gfx_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            ClearValues();
            selectedType = ModCategory.Graphics;
            LoadObj();
        }

        // Enable the selected Mod from the right Listbox by copying all files to the "textures" folder within the Flycast directory.
        private async void btn_Enable_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            await EnableMod();
        }

        // Disable the all Mods for the current Objective by deleting all files from the "textures" folder within the Flycast directory.
        private async void btn_Disable_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            await DisableMod();
        }

        // Disable all Mods for the current / selected Mod Category.
        private async void btn_Reset_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            await DisableAllMods();
        }

        // Opens the default web browser and forwarding to the respective URL - in this case its my YouTube channel.
        private void btn_YouTube_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            Process.Start(new ProcessStartInfo
            {
                FileName = urlYouTube,
                UseShellExecute = true
            });
        }

        // Opens the default web browser and forwarding to the respective URL - in this case its my GitHub profile.
        private void btn_GitHub_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            Process.Start(new ProcessStartInfo
            {
                FileName = urlGitHub,
                UseShellExecute = true
            });
        }

        // Check for newer updates, requires an internet connection.
        private async void btn_CheckUpdate_Click(object sender, EventArgs e)
        {
            PlaySFX(Properties.Resources.Pop);
            await GetUpdates();
        }

        // Triggered whenever the selected item in the Objective Listbox changes. Typically used to update the selected Objective and refresh related UI elements.
        private void lst_Obj_SelectedIndexChanged(object sender, EventArgs e)
        {
            string obj = lst_Obj.SelectedItem?.ToString() ?? string.Empty;
            if (selectedType == ModCategory.None || string.IsNullOrWhiteSpace(obj) || obj == selectedLastObj) return;
            cb_HUD.Checked = false;
            tb_Search.Text = string.Empty;
            selectedObj = obj;
            selectedLastObj = obj;
            LoadMods();
            RefreshUI();
        }

        // Triggered whenever the selected item in the Mod Listbox changes. Typically used to update the selected Mod and refresh related UI elements.
        private void lst_Mods_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mod = lst_Mods.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(mod)) return;
            selectedMod = mod;
            RefreshUI();
        }

        // Triggered whenever the user types in the search TextBox. Filters and updates the Mod Listbox based on the search term.
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            FilterMods(tb_Search.Text);
            RefreshUI();
        }

        // Handles all file system changes in the current directory.
        private void fswDir_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Deleted || e.ChangeType == WatcherChangeTypes.Renamed)
            {
                fswDirTimer.Stop();
                fswDirTimer.Start();
            }
        }

        // Handles all file system changes in the Flycast directory.
        private void fswEmu_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Deleted || e.ChangeType == WatcherChangeTypes.Renamed)
            {
                fswEmuTimer.Stop();
                fswEmuTimer.Start();
            }
        }

        // Combining FileSystemWatcher for the current directory with Timer to avoid flickering and UI issues.
        private void fswDirTimer_Tick(object sender, EventArgs e)
        {
            fswDirTimer.Stop();
            ClearValues();
            CheckDataPath();
            RefreshUI();
        }

        // Combining FileSystemWatcher for flycast.exe with Timer to avoid flickering and UI issues.
        private void fswEmuTimer_Tick(object sender, EventArgs e)
        {
            fswEmuTimer.Stop();
            ClearValues();
            CheckEmuPath();
            RefreshUI();
        }
    }
}