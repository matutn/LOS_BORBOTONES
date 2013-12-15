using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;
using Clinica_Frba.Compra_de_Bono;
using Clinica_Frba.Abm_Rol;
using Clinica_Frba.GrillaRol;
using Clinica_Frba.RegLlegada;
using Clinica_Frba.Login;
using Clinica_Frba.Cancelar_Atencion;
//using Clinica_Frba.ResultadoAtencion;
//using Clinica_Frba.GenerarReceta;

namespace Clinica_Frba
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
            Application.Run(new SelecFunc());
        }
    }
}
