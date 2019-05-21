using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPartsManagementSystem
{

    static class Program
    {

        public static string host = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Massimo\Documents\autopartsDB.mdf;Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
//https://www.codeproject.com/Articles/18042/Another-DataGridView-Printer
//DGVPrinter source