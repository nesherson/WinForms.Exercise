using WinForms.Exercise.Auth;
using WinForms.Exercise.Ispit01._02._2024;
using WinForms.Exercise.Ispit22._02._2024;
using WinForms.Exercise.Ispit30._01._2023;

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
            Application.Run(new frmPocetnaIB230003());
        }
    }
}