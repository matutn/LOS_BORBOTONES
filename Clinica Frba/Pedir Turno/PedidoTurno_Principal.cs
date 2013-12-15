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
        public PedidoTurno_Principal( int id)
        {
            PedidoTurno_Secundario.idAfiliado = id;
            InitializeComponent();
            cargarProfesionales();
        }

        private void cargarProfesionales()
        {
            grillaProfesionales.Rows.Clear();
            var lista = Clases.DB.ExecuteReader(@"select p.prof_Dni,p.prof_Nombre,p.prof_Apellido,e.esp_Descripcion,tp.ties_Descripcion
                                                          from LOS_BORBOTONES.Profesional p
                                                          join LOS_BORBOTONES.Especialidad_Profesional ep on p.prof_IdProfesional = ep.espr_idProfesional
                                                          join LOS_BORBOTONES.Especialidad e on ep.espr_CodEspecialidad = e.esp_CodEspecialidad
                                                          join LOS_BORBOTONES.Tipo_Especialidad tp on e.esp_TipoEspecialidad = tp.ties_CodTipo");
            cargarGrillaProfesionales(lista); 
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            var especialidad_prof = "";
            long dni_prof;
            long.TryParse(txt_Dni.Text, out dni_prof);
            grillaProfesionales.Rows.Clear();
            if (txt_Especialidad.Text == "")
            {
                especialidad_prof = "''";
            }
            else especialidad_prof = txt_Especialidad.Text;
            var lista = Clases.DB.ExecuteReader(@"select p.prof_Dni,p.prof_Nombre,p.prof_Apellido,e.esp_Descripcion,tp.ties_Descripcion
                                                          from LOS_BORBOTONES.Profesional p
                                                          join LOS_BORBOTONES.Especialidad_Profesional ep on p.prof_IdProfesional = ep.espr_idProfesional
                                                          join LOS_BORBOTONES.Especialidad e on ep.espr_CodEspecialidad = e.esp_CodEspecialidad
                                                          join LOS_BORBOTONES.Tipo_Especialidad tp on e.esp_TipoEspecialidad = tp.ties_CodTipo 
                                                          where p.prof_Dni = " + dni_prof + " OR p.prof_Apellido = '" + txt_Apellido.Text + "' OR e.esp_Descripcion like '%" + especialidad_prof + "%'");
            cargarGrillaProfesionales(lista); 
        }

         private void cargarGrillaProfesionales(DataTable lista)
        {
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[5];

            foreach (DataRow row in lista.Rows)
            {
                columnas[0] = row["prof_Dni"];
                columnas[1] = row["prof_Nombre"];
                columnas[2] = row["prof_Apellido"];
                columnas[3] = row["esp_Descripcion"];
                columnas[4] = row["ties_Descripcion"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(grillaProfesionales, columnas);
            }
            grillaProfesionales.Rows.AddRange(filas.ToArray());
        }

         private void button_Turno_Click(object sender, EventArgs e)
         {
             if (grillaProfesionales.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = grillaProfesionales.SelectedRows[0];
            PedidoTurno_Secundario.nombreProfesional = fila.Cells["apellido"].Value.ToString() + "," + fila.Cells["nombre"].Value.ToString();
            PedidoTurno_Secundario.dniProfesional = Convert.ToInt64(fila.Cells["dni"].Value);
             (new PedidoTurno_Secundario()).Show(); 
         }

         private void button_Actualizar_Click(object sender, EventArgs e)
         {
             cargarProfesionales();
         } 

    }
}
