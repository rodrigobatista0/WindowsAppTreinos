using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreinosJC
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            FormDetalhes fd = new FormDetalhes();
            fd.ShowDialog();

            int tamanho = fd.NumeroTreinos;

            Application.Run(new Form1(tamanho));
        }
    }
}
