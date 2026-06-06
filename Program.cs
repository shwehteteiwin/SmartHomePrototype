using main.Forms;
using SmartHomeSideMenubar.DBQuery;
using SmartHomeSideMenubar.Forms;
using System.Windows.Forms;

namespace SmartHomeSideMenubar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DbHelper.CreateDatabase();
            DbHelper.CreateTables();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new FormWelcome());
        }
    }
}