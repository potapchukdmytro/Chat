using Chat.Configuration;
using Chat.Forms.Auth;

namespace Chat
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
            Config config = new Config();
            Seeder.Seed(config.appDbContext);
            Application.Run(new MainForm(config));
        }
    }
}