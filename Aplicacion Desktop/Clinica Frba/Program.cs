using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;
using Clinica_Frba.Compra_de_Bono;
//using Clinica_Frba.AbmProfesional;
<<<<<<< HEAD
using Clinica_Frba.GrillaRol;
using Clinica_Frba.Abm_Rol;
using Clinica_Frba.Login;
using Clinica_Frba.Compra_de_Bono;
=======
>>>>>>> fdb04937829614f6ad85aed48e16b3e6def6bae2

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
            Application.Run(new SelecFunc());
=======
            Application.Run(new FormPrincipal());
>>>>>>> fdb04937829614f6ad85aed48e16b3e6def6bae2
        }
    }
}
