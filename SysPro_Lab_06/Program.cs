using System;
using System.Windows.Forms;

namespace SysPro_Lab_06
{
    static class Program
    {
        internal static readonly int numberOfRooms = 20;
        internal static Random rand = new Random();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
