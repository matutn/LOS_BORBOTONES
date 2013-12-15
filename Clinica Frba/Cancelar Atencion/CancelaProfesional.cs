using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;


namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class CancelaProfesional : Form
    {
        public CancelaProfesional(int Id)
        {
            InitializeComponent();

            if (Id != 0)
            {
                txt_IdProf.Enabled = false;
                txt_IdProf.Text = Id.ToString();
            }
        }

        private void CancelaProfesional_Load(object sender, EventArgs e)
        {

        }

        private void B_Calendario2_Click(object sender, EventArgs e)
        {
            if (B_Calendario2.Text == "Calendario")
            {
                Calendario2.Enabled = true;
                Calendario2.Visible = true;
                B_Calendario2.Text = "Seleccionar";
                return;
            }
            if (B_Calendario2.Text == "Seleccionar")
            {
                txt_fechaAgenda.Text = Calendario2.SelectionEnd.ToShortDateString();

                Calendario2.Enabled = false;
                Calendario2.Visible = false;
                B_Calendario2.Text = "Calendario";
                return;
            }
        }

        private void B_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_DarDeBaja_Click(object sender, EventArgs e)
        {

            if (txt_IdProf.Text == "")
            {
                MessageBox.Show("Debe ingresar el Id de Profesional.");
                return;
            }
            if (txt_fechaAgenda.Text == "")
            {
                MessageBox.Show("Debe seleccionar una fecha del calendario.");
                return;
            }

            
            int updateAgenda = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Agenda set age_Estado = 0 " +
                                                    "where age_IdProfesional = '" + txt_IdProf.Text + "' And cast(age_Fecha as date) = '" +
                                                     txt_fechaAgenda.Text + "'");

            int updateTurnos = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Turno set tur_Estado = 'false' " +
                                                    "where tur_IdProf = '" + txt_IdProf.Text + "' And cast(tur_Fecha as date) = '" +
                                                     txt_fechaAgenda.Text + "'");

            MessageBox.Show("El día se canceló exitosamente.");
        }
    }
}
