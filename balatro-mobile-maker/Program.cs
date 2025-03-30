namespace balatro_mobile_maker;


/// <summary>
/// Main entry point for the program.
/// </summary>
internal static class Program
{
    public static bool _verboseMode;

    //TODO: Better command line args handling
    public static bool ArgsEnableAccessibleSave = true;

    /// <summary>
    /// Main entry point of the program
    /// </summary>
    /// <param name="args">Command line arguments</param>
    public static void Main(string[] args)
    {
        View mainView = new View();
        mainView.Begin();
    }
}
