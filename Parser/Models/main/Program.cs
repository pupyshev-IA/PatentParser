using System;
using System.Windows.Forms;
using Parser.Models.FileOperations;
using Parser.UI;

namespace Parser.Models.main
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Directories.DirectoriesCheck();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainContainer());
        }
    }
}
