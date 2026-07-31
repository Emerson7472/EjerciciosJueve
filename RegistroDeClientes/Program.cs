using System;
using System.Windows.Forms;

namespace RegistroDeClientes
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Inicia la aplicación cargando Form1
            Application.Run(new Form1());
        }
    }
}