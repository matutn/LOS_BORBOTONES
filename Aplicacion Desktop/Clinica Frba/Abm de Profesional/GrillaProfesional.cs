using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DataTransferObjects;

namespace Clinica_Frba.AbmProfesional
{
    public partial class GrillaProfesional : Form
    {
        public static List<Profesional> profesionalesAMostrar = new List<Profesional>();
        public static GrillaProfesional instancia;

        public GrillaProfesional()
        {
            InitializeComponent();
            GrillaProfesional.instancia = this;
        }

        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            listadoProfesionales.Rows.Clear();
        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            FormProfesional.tipoDeFormularioSecundario = 'B';
            (new FormProfesional()).Show();           
        }

        public void actualizarListadoDeProfesionales()
        {
            listadoProfesionales.Rows.Clear();
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[16];

            foreach (Profesional profesional in profesionalesAMostrar)
            {
                columnas[0] = profesional.prof_NombreUsuario;
                columnas[1] = profesional.prof_Matricula;
                columnas[2] = profesional.prof_Dni;
                columnas[3] = profesional.prof_Nombre;
                columnas[4] = profesional.prof_Apellido;
                columnas[5] = profesional.prof_FechaNacimiento;
                columnas[6] = profesional.prof_Mail;
                columnas[7] = profesional.prof_Telefono;
                columnas[8] = profesional.prof_Direccion;
                columnas[9] = profesional.prof_Sexo;
                columnas[10] = (profesional.Eliminado == "True") ? true : false;
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listadoProfesionales, columnas);
            }
            listadoProfesionales.Rows.AddRange(filas.ToArray());
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            FormProfesional.tipoDeFormularioSecundario = 'A';
            (new FormProfesional()).Show();     
        }
        
        private void B_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listadoProfesionales_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow fila = listadoProfesionales.SelectedRows[0];
            FormProfesional.profesional = new Profesional
            (
            "",
            fila.Cells["matricula"].Value.ToString(),
            fila.Cells["dni"].Value.ToString(),
            fila.Cells["nombre"].Value.ToString(),
            fila.Cells["apellido"].Value.ToString(),
            fila.Cells["direccion"].Value.ToString(),
            fila.Cells["telefono"].Value.ToString(),
            fila.Cells["mail"].Value.ToString(),
            fila.Cells["fecha_nacimiento"].Value.ToString(),
            fila.Cells["sexo"].Value.ToString()
            );
            FormProfesional.tipoDeFormularioSecundario = 'M';

            (new FormProfesional()).Show();
        }

        private void B_EliminarClientes_Click(object sender, EventArgs e)
        {
            this.eliminarProfesionalesLogicamente();
            this.darAltaProfesionalesEliminadosLogicamente();
        }

        private void darAltaProfesionalesEliminadosLogicamente()
        {
            SqlServerDAO<Profesional, Profesional> daoProfesional = SqlServerDAO<Profesional, Profesional>.Instance;

            Profesional.primaryKeys = new List<String>();
            Profesional.primaryKeys.Clear();
            Profesional.campoDeCambioDeEstado = "Eliminado";
            Profesional.valorCampoDeCambioDeEstado = "0";

            for (int i = 0; i < listadoProfesionales.Rows.Count; i++)
                if (!(bool)listadoProfesionales.Rows[i].Cells["eliminar"].Value)
                    Profesional.primaryKeys.Add((String)listadoProfesionales.Rows[i].Cells["DNI"].Value);

            daoProfesional.cambioDeEstado();
        }

        private void eliminarProfesionalesLogicamente()
        {
            SqlServerDAO<Profesional, Profesional> daoProfesional = SqlServerDAO<Profesional, Profesional>.Instance;

            Profesional.primaryKeys = new List<String>();
            Profesional.primaryKeys.Clear();
            Profesional.campoDeCambioDeEstado = "Eliminado";
            Profesional.valorCampoDeCambioDeEstado = "1";

            for (int i = 0; i < listadoProfesionales.Rows.Count; i++)
                if ((bool)listadoProfesionales.Rows[i].Cells["eliminar"].Value)
                    Profesional.primaryKeys.Add((String)listadoProfesionales.Rows[i].Cells["DNI"].Value);

            daoProfesional.cambioDeEstado();
        }

        private void checkAll_Click(object sender, EventArgs e)
        {
            bool todosChequeados = true;

            for (int i = 0; i < listadoProfesionales.Rows.Count; i++)
                todosChequeados &= (bool) listadoProfesionales.Rows[i].Cells["eliminar"].Value;

            for (int i = 0; i < listadoProfesionales.Rows.Count; i++)
                listadoProfesionales.Rows[i].Cells["eliminar"].Value = !todosChequeados;
        }

        private void AbmProfesionalPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listadoProfesionales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
