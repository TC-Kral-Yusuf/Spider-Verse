namespace Spider_Verse
{
    public partial class Main : Form
    {
        // Version variables for the current version. To set the latest version, the respective GitHub API is used to read the latest release using the tag name.
        private Version? currentVersion;
        private Version? latestVersion;

        // Initializing some really important URLs as strings - pretty obvious, right?
        private static readonly string urlFlycast = "https://flyinghead.github.io/flycast-builds/";
        private static readonly string urlAPI = "https://api.github.com/repos/TC-Kral-Yusuf/Spider-Verse/releases/latest";
        private static readonly string urlGitHub = "https://github.com/TC-Kral-Yusuf";
        private static readonly string urlYouTube = "https://www.youtube.com/@T.C-Kral-Yusuf";

        // Base directory of the application (where the tool is running).
        private static readonly string baseDir = AppContext.BaseDirectory;

        // Path of the "data" folder inside the base directory.
        private static readonly string dataPath = Path.Combine(baseDir, "data");

        // Path of the configuration file "config.ini" inside the base directory.
        private static readonly string configFile = Path.Combine(baseDir, "config.json");

        // Initialize bool variable to check, whether the tool has been started or not - useful when calling functions with Messageboxes.
        private bool isStarted = false;

        // Path of the Flycast directory.
        private string emuPath = string.Empty;

        // Initialize bool variable to check, whether the data folder exists AND not empty.
        private bool isDataFound = false;

        // Initialize bool variable to check, whether flycast.exe was found or not.
        private bool isEmuFound = false;

        // Initialize bool variable to set the Restart flag.
        private bool isRestartRequired = false;

        // Initialize bool variable to set the Busy flag (e.g while installing or uninstalling mods).
        private bool isBusy = false;

        // Initialize Mod Category, Objective and Mod - mostly used for checks and path combining. Using ModCategory instead of the string datatype, since its more prone to errors.
        enum ModCategory
        {
            None,
            Costumes,
            Characters,
            Graphics
        }
        private ModCategory selectedType = ModCategory.None;
        private ModCategory selectedLastType = ModCategory.None;
        private string selectedObj = string.Empty;
        private string selectedLastObj = string.Empty;
        private string selectedMod = string.Empty;

        // Initialize static and read-only variables for the path regarding Costumes, Characters and Graphics mods.
        private static readonly string costumesPath = Path.Combine(dataPath, ModCategory.Costumes.ToString());
        private static readonly string characterPath = Path.Combine(dataPath, ModCategory.Characters.ToString());
        private static readonly string gfxPath = Path.Combine(dataPath, ModCategory.Graphics.ToString());

        private List<string> modList = new();
    }
}