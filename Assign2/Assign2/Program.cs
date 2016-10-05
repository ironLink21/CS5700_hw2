using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Common;

namespace Assign2
{
    static class Program
    {
        public static MainBox mainBox { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainBox = new MainBox();
            Application.Run(mainBox);
            System.Environment.Exit(1);
        }
    }
}
