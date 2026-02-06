namespace Spider_Patcher
{
    public partial class Main : Form
    {
        // Boolean variable to avoid exiting the tool while patching the files.
        private bool isBusy = false;

        // Base directory of the Patcher.
        private static readonly string baseDir = AppContext.BaseDirectory;

        // Path of the "data" folder inside the base directory.
        private static readonly string dataPath = Path.Combine(baseDir, "data");

        // Path of the "Patch" folder inside the base directory.
        private static readonly string patchPath = Path.Combine(baseDir, "Patch");
    }
}
