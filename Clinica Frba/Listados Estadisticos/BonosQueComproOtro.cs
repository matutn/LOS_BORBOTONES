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
    public partial class BonosQueComproOtro : Form
    {
        public BonosQueComproOtro()
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
                
               "SELECT TOP 10 Afiliado "+
			",(SELECT COUNT(Afiliado) from LOS_BORBOTONES.vw_BonosQueComproOtro BO where (DATEPART(MONTH, Fecha_Utilizacion) BETWEEN 1 AND 6)AND BO.Afiliado= VW.Afiliado) Cantidad_Maxima "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=1)AND BO.Afiliado= VW.Afiliado) Enero "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=2)AND BO.Afiliado= VW.Afiliado) Febrero "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=3)AND BO.Afiliado= VW.Afiliado) Marzo "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=4)AND BO.Afiliado= VW.Afiliado) Abril "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=5)AND BO.Afiliado= VW.Afiliado) Mayo "+
			",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=6)AND BO.Afiliado= VW.Afiliado) Junio "+		
	        "FROM LOS_BORBOTONES.vw_BonosQueComproOtro VW "+
            "where DATEPART(YYYY,Fecha_Utilizacion)= ' " + Anio + "'  AND (SELECT COUNT(Afiliado) from LOS_BORBOTONES.vw_BonosQueComproOtro BO where (DATEPART(MONTH, Fecha_Utilizacion) BETWEEN 1 AND 6)AND BO.Afiliado= VW.Afiliado)>0 " +
	        "GROUP BY AFILIADO "+	
	        "order by 2 DESC "	 
                                    
            );


            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[8];
            
            foreach (DataRow row in lista.Rows)
            {
                columnas[0] = row["Afiliado"];
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
                          "SELECT TOP 10 Afiliado " +
            ",(SELECT COUNT(Afiliado) from LOS_BORBOTONES.vw_BonosQueComproOtro BO where (DATEPART(MONTH, Fecha_Utilizacion) BETWEEN 6 AND 12)AND BO.Afiliado= VW.Afiliado) Cantidad_Maxima " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=7)AND BO.Afiliado= VW.Afiliado) Julio " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=8)AND BO.Afiliado= VW.Afiliado) Agosto " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=9)AND BO.Afiliado= VW.Afiliado) Septiembre " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=10)AND BO.Afiliado= VW.Afiliado) Octubre " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=11)AND BO.Afiliado= VW.Afiliado) Noviembre " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosQueComproOtro BO WHERE (DATEPART(MONTH, Fecha_Utilizacion)=12)AND BO.Afiliado= VW.Afiliado) Diciembre " +
            "FROM LOS_BORBOTONES.vw_BonosQueComproOtro VW " +
            "where DATEPART(YYYY,Fecha_Utilizacion)= ' " + Anio + "'  AND (SELECT COUNT(Afiliado) from LOS_BORBOTONES.vw_BonosQueComproOtro BO where (DATEPART(MONTH, Fecha_Utilizacion) BETWEEN 7 AND 12)AND BO.Afiliado= VW.Afiliado)>0 " +
            "GROUP BY AFILIADO " +
            "order by 2 DESC "	 

               );


                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[14];

                foreach (DataRow row in lista.Rows)
                {
                    columnas[0] = row["Afiliado"];
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

