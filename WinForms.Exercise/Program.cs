using WinForms.Exercise.Glavna;
using WinForms.Exercise.Ispit18._02._2021;

namespace WinForms.Exercise
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmPretragaIB230125());
        }
    }
}