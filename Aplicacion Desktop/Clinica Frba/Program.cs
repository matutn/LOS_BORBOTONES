using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;
//using Clinica_Frba.Compra_de_Bono;
//using Clinica_Frba.AbmProfesional;
using Clinica_Frba.GrillaRol;
using Clinica_Frba.Abm_Rol;

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
<<<<<<< HEAD
            Application.Run(new FormPrincipal());
=======
            Application.Run(new GrillaRol_Form());
>>>>>>> 22bc21a047546129a0025f8595b0bfaafae8fa6c
        }
    }
}
