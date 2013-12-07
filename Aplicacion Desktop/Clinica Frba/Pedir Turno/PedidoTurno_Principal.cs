using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class PedidoTurno_Principal : Form
    {
        public PedidoTurno_Principal()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Dni_Click(object sender, EventArgs e)
        {

        }

        private void button_Especialidad_Click(object sender, EventArgs e)
        {
            cargarProfesionales();
        }

        private void cargarProfesionales()
        {
            grillaProfesionales.Rows.Clear();
            var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Profesional");
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            foreach (DataRow row in lista.Rows)
            {
                columnas[0] = row["prof_Dni"];
                columnas[1] = row["prof_Nombre"];
                columnas[2] = row["prof_Apellido"];
                columnas[3] = row["cobo_MontoTotal"];
                columnas[4] = row["cobo_MontoTotal"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(grillaProfesionales, columnas);
            }
            grillaProfesionales.Rows.AddRange(filas.ToArray());
        }
    }
}
