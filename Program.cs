using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rDocumentos
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
            //Application.Run(new frmMantenimiento());
            //Application.Run(new frmDocumentos());
            //Application.Run(new Mantenimiento());
            //Application.Run(new ConexionDatos());
            //frmDocumentos ddd = new frmDocumentos();
            //ddd.Show();
            //Application.Run(new frmLogin());
            //Application.Run(new MtoEmpresas());
            
            
            //Application.Run(new Principal());
            Application.Run(new frmLogin());
        }
    }
}
