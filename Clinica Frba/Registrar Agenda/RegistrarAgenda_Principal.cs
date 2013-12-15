using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class RegistrarAgenda_Principal : Form
    {
        public static int idProfesional;
        public RegistrarAgenda_Principal(int id)
        {
            InitializeComponent();
            this.Text = "Registrar Agenda";
            cargarRangoFechasProfesional();
        }

        private void cargarRangoFechasProfesional()
        {
            DataTable dt_agendaFechaDesde = Clases.DB.ExecuteReader("Select top 1 age_Fecha from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional);
            DataTable dt_agendaFechaHasta = Clases.DB.ExecuteReader("Select top 1 age_Fecha from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " order by age_Fecha desc");
            if (dt_agendaFechaDesde.Rows.Count > 0)
            {
                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[2];
                columnas[0] = dt_agendaFechaDesde.Rows[0]["age_Fecha"];
                columnas[1] = dt_agendaFechaHasta.Rows[0]["age_Fecha"];
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(grillaAgenda, columnas);
                grillaAgenda.Rows.AddRange(filas.ToArray());
            }  
        }

        private void button_CargarAgenda_Click(object sender, EventArgs e)
        {
            if (grillaAgenda.Rows.Count > 0)
            {
                MessageBox.Show("El Profesional ya tiene una agenda cargada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RegistrarAgenda_Secundario.tipoFormularioSecundario = 'C';
            (new RegistrarAgenda_Secundario()).Show();
        }

        private void button_VerAgenda_Click(object sender, EventArgs e)
        {
            if (grillaAgenda.SelectedRows.Count == 0)
                return;
            RegistrarAgenda_Secundario.tipoFormularioSecundario = 'V';
            (new RegistrarAgenda_Secundario()).Show();
        }

        private void RegistrarAgenda_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
