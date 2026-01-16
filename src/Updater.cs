using System.Diagnostics;
using System.Text.Json;

namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Getting updates by reading the latest release using the tag name with the GitHub API.
        private async Task GetUpdates()
        {
            try
            {
                using var http = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                http.DefaultRequestHeaders.UserAgent.ParseAdd("Spider-Verse-Mod-Menu");
                string json = await http.GetStringAsync(urlAPI);
                using var doc = JsonDocument.Parse(json);
                string tag = doc.RootElement.GetProperty("tag_name").GetString() ?? "";
                string version = new(tag.Where(c => char.IsDigit(c) || c == '.').ToArray());
                latestVersion = new Version(version);

                if (currentVersion == null || latestVersion == null)
                {
                    MessageBox.Show(errorVersion, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await ShowUpdateMsg();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Output a MessageBox, if a new update for this tool is available.
        private async Task ShowUpdateMsg()
        {
            try
            {
                string message = $"A new update is available: {latestVersion}\n\nCurrent Version: {currentVersion}\nLatest Version: {latestVersion}\n\nDo you want to download this Update?";
                string repo = $"{urlGitHub}/Spider-Verse/releases/latest";
                if (latestVersion > currentVersion)
                {
                    DialogResult dr = MessageBox.Show(message, "Update found!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr != DialogResult.Yes) return;

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = repo,
                        UseShellExecute = true
                    });
                }

                else
                {
                    if (isStarted) MessageBox.Show("You are up-to-date!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This function is only used, if the "Auto Update Check" option is enabled in the Settings.
        private async Task GetUpdatesOnStartup()
        {
            if (autoUpdateCheckToolStripMenuItem.Checked) await GetUpdates();
        }
    }
}