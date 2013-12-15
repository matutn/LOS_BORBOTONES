using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;
using Clinica_Frba.GrillaRol;
using Clinica_Frba.RegLlegada;
using Clinica_Frba.Compra_de_Bono;
using Clinica_Frba.Clases;
using Clinica_Frba.Cancelar_Atencion;
using Clinica_Frba.Pedir_Turno;
using Clinica_Frba.Registrar_Agenda;
using Clinica_Frba.ResultadoAtencion;

namespace Clinica_Frba.Login
{
    public partial class SelecFunc : Form
    {
        public int Id;

        public SelecFunc()
        {
            InitializeComponent();

            Ingreso ingreso = new Ingreso();
            if (ingreso.ShowDialog() != DialogResult.OK)
            {  this.Close(); }

            switch (ingreso.rol1)
            {
                
                case "Afiliado":
                    {
                        Id = DB.ExecuteCardinal("Select a.afi_IdAfiliado " +
                            "From LOS_BORBOTONES.Afiliado a, LOS_BORBOTONES.Usuario u, LOS_BORBOTONES.Rol_Usuario ru " +
                            "Where u.usu_IdUsuario = '" + ingreso.nombreUsuario + "' AND u.usu_IdUsuario = a.afi_NombreUsuario "+
                            "AND u.usu_IdUsuario = ru.rous_IdUsuario And ru.rous_CodRol = 15"); 
                        profesional.Enabled = false;
                        administrativo.Enabled = false;
                        break;
                    }
                case "Profesional":
                    {
                        Id = DB.ExecuteCardinal("Select p.prof_IdProfesional " +
                            "From LOS_BORBOTONES.Profesional p, LOS_BORBOTONES.Usuario u, LOS_BORBOTONES.Rol_Usuario ru " +
                            "Where u.usu_IdUsuario = '" + ingreso.nombreUsuario + "' AND u.usu_IdUsuario = p.prof_NombreUsuario " +
                            "AND u.usu_IdUsuario = ru.rous_IdUsuario And ru.rous_CodRol = 18");
                        afiliado.Enabled = false;
                        administrativo.Enabled = false;
                        break;
                    }
                case "Administrativo":
                    {
                        Id = 0;
                        break;
                    }


            }
        }

        private void registroDeLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ListadoEstadisticoMenu()).Show(); 
        }

        private void profesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abmAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GrillaAfiliado_Form()).Show(); 
        }

        private void abmProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GrillaProfesional_Form()).Show();
        }

        private void abmRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GrillaRol_Form()).Show();
        }

        private void SelecFunc_Load(object sender, EventArgs e)
        {

        }

        private void afiliado_Click(object sender, EventArgs e)
        {

        }

        private void registroDeLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new RegLlegada_Form()).Show();
        }

        private void compraDeBonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraBono_Principal.idAfi = Id;
            (new CompraBono_Principal(Id)).Show();
        }

        private void compraDeBonosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompraBono_Principal.idAfi = Id;
            (new CompraBono_Principal(Id)).Show();
        }

        private void cancelarAtenciónToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            (new CancelaProfesional(Id)).Show();
        }

        private void pedirTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Cancelar_Turno_Afiliado(Id)).Show();
        }

        private void cancelarAtenciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new CancelaProfesional(Id)).Show();
        }

        private void cancelarAtenciónAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Cancelar_Turno_Afiliado(Id)).Show();
        }

        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            (new SelecFunc()).Show();
            this.Close();
        }

        private void cancelarAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new PedidoTurno_Principal(Id)).Show();
        }

        private void registrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarAgenda_Principal.idProfesionall = Id;
            (new RegistrarAgenda_Principal(Id)).Show();
        }

        private void registroResultadoAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Resultado_Atencion_Form(Id)).Show();
        }
    }
}
