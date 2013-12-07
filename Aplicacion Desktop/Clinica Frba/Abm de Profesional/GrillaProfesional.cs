using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using Clinica_Frba.Abm_Afiliado;
using Clinica_Frba.Abm_Profesional;

namespace Clinica_Frba.GrillaProfesional
{
    public partial class GrillaProfesional_Form : Form
    {
        public static List<ProfesionalDTO> profesionalesAMostrar = new List<ProfesionalDTO>();
        public static GrillaProfesional_Form instancia;
        public GrillaProfesional_Form()
        {
            InitializeComponent();
            GrillaProfesional_Form.instancia = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            Amb_Profesional_Form.tipoDeFormularioSecundario = 'B';
            (new Amb_Profesional_Form()).Show(); 
        }

        public void actualizarListadoProfesionales()
        {
            listadoProfesionales.Rows.Clear();
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[16];

            foreach (ProfesionalDTO profesional in profesionalesAMostrar)
            {
                columnas[0] = profesional.IdProfesional;
                columnas[1] = profesional.NombreUsuario;
                columnas[2] = profesional.Nombre;
                columnas[3] = profesional.Apellido;
                columnas[4] = profesional.Dni;
                columnas[5] = profesional.NroMatricula;
                columnas[6] = profesional.Direccion;
                columnas[7] = profesional.Telefono;
                columnas[8] = profesional.Mail;
                columnas[9] = profesional.FechaNacimiento;
                columnas[10] = profesional.Sexo;
                columnas[11] = (profesional.Estado == "True") ? true : false;
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listadoProfesionales, columnas);
            }
            listadoProfesionales.Rows.AddRange(filas.ToArray());
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Amb_Profesional_Form.tipoDeFormularioSecundario = 'A';
            (new Amb_Profesional_Form()).Show(); 
        }

        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            listadoProfesionales.Rows.Clear();
        }

        private void B_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listadoProfesionales.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoProfesionales.SelectedRows[0];
            Amb_Profesional_Form.profesional = new ProfesionalDTO
            (
            fila.Cells["txt_IdProfesional"].Value.ToString(),
            "",
            fila.Cells["txt_Nombre"].Value.ToString(),
            fila.Cells["txt_Apellido"].Value.ToString(),
            "",
            fila.Cells["txt_Dni"].Value.ToString(),
            fila.Cells["txt_Matricula"].Value.ToString(),
            fila.Cells["txt_Direccion"].Value.ToString(),
            fila.Cells["txt_Telefono"].Value.ToString(),
            fila.Cells["txt_Mail"].Value.ToString(),
            fila.Cells["txt_FechaNacimiento"].Value.ToString(),
            fila.Cells["txt_Sexo"].Value.ToString(),
            ""
            );
            Amb_Profesional_Form.tipoDeFormularioSecundario = 'M';

            (new Amb_Profesional_Form()).Show();
        }

        private void B_EliminarClientes_Click(object sender, EventArgs e)
        {
            if (listadoProfesionales.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoProfesionales.SelectedRows[0];

            if ((bool)fila.Cells["Eliminado"].Value)
            {
                Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Profesional set prof_Estado = '" + 0 + "' where prof_IdProfesional = '" + fila.Cells["txt_IdProfesional"].Value + "'");
                fila.Cells["Eliminado"].Value = false;
            }
            else
            {
                Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Profesional set prof_Estado = '" + 1 + "' where prof_IdProfesional = '" + fila.Cells["txt_IdProfesional"].Value + "'");
                fila.Cells["Eliminado"].Value = true;
            }
        }
    }
}
