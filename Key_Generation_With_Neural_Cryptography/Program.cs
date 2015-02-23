using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Key_Generation_With_Neural_Cryptography
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NeuralCryptographyForm());
        }
    }
}
