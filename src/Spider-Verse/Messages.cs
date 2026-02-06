namespace Spider_Verse
{
    public partial class Main : Form
    {

        // Error messages are defined as const strings, since they are immutable and resolved at compile time.
        private const string errorToolInstance = "Error: This tool is already running.";
        private const string errorEmuInstance = "Error: Flycast is already running.";
        private const string errorVersion = "Error: Either the current or latest version is null OR the tool couldn't obtain the update information from the GitHub API.";
        private const string errorEmuPath = "Error: The current Flycast directory is invalid.\n\nPlease select the correct directory, where Flycast is located and installed.";
        private const string errorDataPath = "Error: The data folder was not found or its empty.\n\nPlease check for the data folder or reinstall Project: Spider-Verse.";
        private const string errorSelectedType = "Error: The selected Mod Category was not found or its empty: ";
        private const string errorSelectedObj = "Error: The selected Objective doesn't contain any mods OR it doesn't exist anymore.";
        private const string errorNoSelection = "Error: Please select an Objective and a Mod.";
        private const string errorDisableMod = "Error: There are no Mods installed for this Objective:";
        private const string errorDisableAll = "Error: There are no Mods installed.";
        private const string errorModsEmpty = "Error: There are no Mods for this Objective.";
        private const string errorSourceNotFound = "Error: The source path was not found, either it was moved, renamed or even deleted.";
        private const string errorConfigLoad = "Error: There is no config file to load.";
        private const string errorConfigDelete = "Error: There is no config file to delete.";
        private const string errorDefaultHUD = "Error: Default HUD cannot be installed. Either the source path doesn't exist or it has been renamed.";

        // Success messages are defined as const strings, since they are immutable and resolved at compile time.
        private const string successEmuPath = "Success: Flycast has been found.";
        private const string successEnableMod = "Success: Mods have been installed.";
        private const string successDisableMod = "Success: Mods have been uninstalled.";
        private const string successDisableAll = "Success: All Mods have been uninstalled.";
        private const string successConfigSave = "Success: Config saved.";
        private const string successConfigLoad = "Success: Config loaded.";
        private const string successConfigDelete = "Success: Config deleted.";
    }
}