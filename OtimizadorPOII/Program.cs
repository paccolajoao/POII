using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.TC:\Users\paccola\Documents\UNESP\POII\POII\OtimizadorPOII\Form1.csasks;
using System.Windows.Forms;

namespace OtimizadorPOII
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
