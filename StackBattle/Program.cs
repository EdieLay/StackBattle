namespace StackBattle
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            TurnCommand tc = new(new Army(), new Army(), new StackStructure());
            ProxyCommand pc = new(tc);
            pc.Log();
        }
    }
}