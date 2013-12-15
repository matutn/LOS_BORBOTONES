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
    public partial class BonosFarmaciaPorEspecialidad : Form
    {
        public BonosFarmaciaPorEspecialidad()
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
                
                "SELECT TOP 5 VB.Especialidad "+
			",(SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad where (DATEPART(MONTH, FECHA) BETWEEN 1 AND 6)AND VB.Especialidad=Especialidad) Cantidad_Maxima "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=1)AND VB.Especialidad=Especialidad) Enero " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=2)AND VB.Especialidad=Especialidad) Febrero " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=3)AND VB.Especialidad=Especialidad) Marzo " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=4)AND VB.Especialidad=Especialidad) Abril " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=5)AND VB.Especialidad=Especialidad) Mayo " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=6)AND VB.Especialidad=Especialidad) Junio " +
			"FROM LOS_BORBOTONES.vw_BonoFarmacia_Especialidad VB "+
            "where DATEPART(YYYY,FECHA)= ' " + Anio + "' AND (SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad where (DATEPART(MONTH, FECHA) BETWEEN 1 AND 6)AND VB.Especialidad=Especialidad)>0 " +
	        " GROUP BY Especialidad	"+
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
                var lista = Clases.DB.ExecuteReader( "SELECT TOP 5 VB.Especialidad " +
			",(SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad where (DATEPART(MONTH, FECHA) BETWEEN 7 AND 12)AND VB.Especialidad=Especialidad) Cantidad_Maxima " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=7)AND VB.Especialidad=Especialidad) Julio " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=8)AND VB.Especialidad=Especialidad) Agosto " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=9)AND VB.Especialidad=Especialidad) Septiembre " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=10)AND VB.Especialidad=Especialidad) Octubre " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=11)AND VB.Especialidad=Especialidad) Noviembre " +
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad WHERE (DATEPART(MONTH, FECHA)=12)AND VB.Especialidad=Especialidad) Diciembre " +
			"FROM LOS_BORBOTONES.vw_BonoFarmacia_Especialidad VB " +
            "where DATEPART(YYYY,FECHA)= ' " + Anio + "'/*@Año */ AND (SELECT COUNT(Especialidad) from LOS_BORBOTONES.vw_BonoFarmacia_Especialidad where (DATEPART(MONTH, FECHA) BETWEEN 7 AND 12)AND VB.Especialidad=Especialidad)>0 " +
	        "GROUP BY Especialidad " +	
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

