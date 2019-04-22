using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_3ra_Unidad.Vista;

namespace Proyecto_3ra_Unidad
{
    static class Program
    {
        public static Form1 formaInicio = null;
        public static FormaAcercaDe formaAcercaDe = null;
        public static FormaComoJugar formaComoJugar = null;
        public static FormaIniciarSesion formaIniciarSesion = null;
        public static FormaJuego formaJuego = null;
        public static FormaResultados formaResultados = null;
        public static SplashScreen splashScreen = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formaInicio = new Form1();
            formaAcercaDe = new FormaAcercaDe();
            formaComoJugar = new FormaComoJugar();
            formaIniciarSesion = new FormaIniciarSesion();
            formaJuego = new FormaJuego();
            formaResultados = new FormaResultados();
            splashScreen = new SplashScreen();
            Application.Run(splashScreen);
        }
    }
}
