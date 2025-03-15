namespace AutoService
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
            try
            {
                Database.Database.InitializeDatabase();
                Application.Run(new Form1());
                Database.Database.Dispose();
            }
            catch (Database.DBException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}