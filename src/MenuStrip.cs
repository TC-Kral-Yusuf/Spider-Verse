using System.Diagnostics;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Show Cheat Codes.
        private void cheatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.Cheats.ToString(), "Cheat Codes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Show Credits.
        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.CreditsText.ToString(), "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Show information about this tool.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Version {currentVersion}\n{Properties.Resources.AboutText.ToString()}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Restart this tool.
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRestartRequired = true;
            this.Close();
        }

        // Exit, lol. What else did you expect, homeboy?
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Saving the config file in the current directory by calling the respective function.
        private void saveConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigSave();
        }

        // Loading the config file in the current directory by calling the respective function.
        private void loadConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigLoad();
        }

        // Deleting the config file in the current directory by calling the respective function.
        private void deleteConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigDelete();
        }
    }
}