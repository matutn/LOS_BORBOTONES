using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;

namespace Clinica_Frba.NewFolder9
{
    public partial class CancelacionesPorEspecialidad : Form
    {
        public CancelacionesPorEspecialidad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            /*
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 26 Feb 2001".
            dateTimePicker1.CustomFormat = "yyyy"; */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            generaListadoEstadistico();
        }
        private void generaListadoEstadistico()
        {
               
            dataGridView1.Rows.Clear();
            int Anio = dateTimePicker1.Value.Year;
            

            if (comboBox2.SelectedItem/*.ToString()*/ == null)
            {
                return;
            }
            if (comboBox2.SelectedItem.ToString() == "Primer")
            {
           
            var lista = Clases.DB.ExecuteReader(
                "SELECT TOP 5 Especialidad "+
            ",(SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_cancelaciones_especialidad where (DATEPART(MONTH, fechaCancelacion) BETWEEN 1 AND 6)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Cantidad_Maxima " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=1)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Enero " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=2)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Febrero " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=3)AND Especialidad = espe.esp_Descripcion  AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Marzo " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=4)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Abril " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=5)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Mayo " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=6)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Junio " +
			"FROM LOS_BORBOTONES.vw_cancelaciones_especialidad " +
	        "Join LOS_BORBOTONES.Especialidad espe on espe.esp_Descripcion = Especialidad " +
            "where DATEPART(YYYY,fechaCancelacion)= ' " + Anio + "' AND (DATEPART(MONTH, fechaCancelacion) BETWEEN 1 AND 6) AND (SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_cancelaciones_especialidad where (DATEPART(MONTH, fechaCancelacion) BETWEEN 7 AND 12)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)= ' " + Anio + "'))>0 /*@Año */ " +
	        "GROUP BY Especialidad, espe.esp_Descripcion "+	
	        "order by 2 DESC " 	                
            );


            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[8];
            
            foreach (DataRow row in lista.Rows)
            {
                columnas[0] = row["Especialidad"];
                columnas[1] = row["Cantidad_Maxima"];
                columnas[2] = row["Enero"];
                columnas[3] = row["Febrero"];
                columnas[4] = row["Marzo"];
                columnas[5] = row["Abril"];
                columnas[6] = row["Mayo"];
                columnas[7] = row["Junio"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(dataGridView1, columnas);
            }
           
            
            dataGridView1.Rows.AddRange(filas.ToArray());
            

                for (int i = 0; i <= 7; i++)
                {
                    this.dataGridView1.Columns[i].Visible = true; 
                }
                for (int i = 8; i <= 13; i++)
                {
                    this.dataGridView1.Columns[i].Visible = false;
                }
                
                
            

           
            }
            if (comboBox2.SelectedItem.ToString() == "Segundo")
            {
                var lista = Clases.DB.ExecuteReader(
                        "SELECT TOP 5 Especialidad " +
            ",(SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_cancelaciones_especialidad where (DATEPART(MONTH, fechaCancelacion) BETWEEN 7 AND 12)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Cantidad_Maxima " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=7)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Julio " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=8)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Agosto " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=9)AND Especialidad = espe.esp_Descripcion  AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Septiembre " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=10)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Octubre " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=11)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Noviembre " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_cancelaciones_especialidad WHERE (DATEPART(MONTH, fechaCancelacion)=12)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)='" + Anio + "')) Diciembre " +
            "FROM LOS_BORBOTONES.vw_cancelaciones_especialidad " +
            "Join LOS_BORBOTONES.Especialidad espe on espe.esp_Descripcion = Especialidad " +
            "where DATEPART(YYYY,fechaCancelacion)= ' " + Anio + "' AND (DATEPART(MONTH, fechaCancelacion) BETWEEN 7 AND 12) AND (SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_cancelaciones_especialidad where (DATEPART(MONTH, fechaCancelacion) BETWEEN 7 AND 12)AND Especialidad = espe.esp_Descripcion AND(DATEPART(YEAR, fechaCancelacion)= ' " + Anio + "'))>0 /*@Año */ " +
            "GROUP BY Especialidad, espe.esp_Descripcion " +
            "order by 2 DESC " 	

               );


                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[14];

                foreach (DataRow row in lista.Rows)
                {
                    columnas[0] = row["Especialidad"];
                    columnas[1] = row["Cantidad_Maxima"];
                    columnas[8] = row["Julio"];
                    columnas[9] = row["Agosto"];
                    columnas[10] = row["Septiembre"];
                    columnas[11] = row["Octubre"];
                    columnas[12] = row["Noviembre"];
                    columnas[13] = row["Diciembre"];

                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(dataGridView1, columnas);
                }


                dataGridView1.Rows.AddRange(filas.ToArray());


                for (int i = 2; i <= 7; i++)
                {
                    this.dataGridView1.Columns[i].Visible = false;
                }
                this.dataGridView1.Columns[0].Visible = true;
                this.dataGridView1.Columns[1].Visible = true;
                for (int i = 8; i <= 13; i++)
                {
                    this.dataGridView1.Columns[i].Visible = true;
                }
                
                



            }
               
            }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
        }
        }
        
       
}

