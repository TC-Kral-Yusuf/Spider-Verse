using System.Text.Json;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Represents the configuration settings that will be saved in a JSON file.
        public class Config
        {
            public string FlycastPath { get; set; } = string.Empty;
            public bool Notifications { get; set; } = true;
            public bool AutoUpdateCheckOnStartup { get; set; } = true;
        }

        // Instance of the Config class. Everything here are the current settings being saved in the memory.
        private Config conf = new();

        // Saves the config file by creating a JSON file and inserting the respective values.
        private void ConfigSave()
        {
            try
            {
                conf.FlycastPath = emuPath;
                conf.Notifications = messageBoxToolStripMenuItem.Checked;
                conf.AutoUpdateCheckOnStartup = autoUpdateCheckToolStripMenuItem.Checked;
                string json = JsonSerializer.Serialize(conf, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(configFile, json);

                if (messageBoxToolStripMenuItem.Checked)
                {
                    MessageBox.Show(successConfigSave, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Loading the config file from the current directory. If the config file is damaged or if it has invalid values, the tool will immediateyl clear all values and disable all respective Mod buttons.
        private void ConfigLoad()
        {
            try
            {
                if (!File.Exists(configFile))
                {
                    if (isStarted) MessageBox.Show(errorConfigLoad, "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string json = File.ReadAllText(configFile);
                    conf = JsonSerializer.Deserialize<Config>(json) ?? new Config();

                    emuPath = string.IsNullOrWhiteSpace(conf.FlycastPath) ? string.Empty : conf.FlycastPath;
                    messageBoxToolStripMenuItem.Checked = conf.Notifications;
                    autoUpdateCheckToolStripMenuItem.Checked = conf.AutoUpdateCheckOnStartup;
                    tb_Path.Text = emuPath;

                    if (messageBoxToolStripMenuItem.Checked && isStarted)
                    {
                        MessageBox.Show(successConfigLoad, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    CheckEmuPath();
                }
            }

            catch (Exception ex)
            {
                emuPath = string.Empty;
                ClearValues();
                RefreshUI();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Deleting the config file from the current directory.
        private void ConfigDelete()
        {
            try
            {
                if (!File.Exists(configFile))
                {
                    MessageBox.Show(errorConfigDelete, "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                File.Delete(configFile);
                
                if (messageBoxToolStripMenuItem.Checked)
                {
                    MessageBox.Show(successConfigDelete, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}