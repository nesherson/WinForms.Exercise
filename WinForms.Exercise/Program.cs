using WinForms.Exercise.Glavna;
using WinForms.Exercise.IspitIB230123;

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
            Application.Run(new frmPretragaIB230123());
        }
    }
}