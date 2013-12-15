using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using System.IO;

namespace Clinica_Frba.NewFolder9
{
    public partial class BonosFarmaciaVencidos : Form
    {
        public BonosFarmaciaVencidos()
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

            string FechaArchivo = GetDateTime();

            int resultado = Clases.DB.ExecuteNonQuery(
                	"UPDATE LOS_BORBOTONES.FechaHoraDelSistema "+
            "SET    fec_FechaHora = ' " + FechaArchivo + "'" +
			"FROM    LOS_BORBOTONES.FechaHoraDelSistema FC "
                );

            if (comboBox2.SelectedItem/*.ToString()*/ == null)
            {
                return;
            }
            if (comboBox2.SelectedItem.ToString() == "Primer")
            {
           
            var lista = Clases.DB.ExecuteReader("SELECT TOP 5 Afiliado "+
            ",(SELECT COUNT(Afiliado) from LOS_BORBOTONES.vw_BonosVencidos where (DATEPART(MONTH, Fecha_vencimiento) BETWEEN 1 AND 6)AND Afiliado=AF.afi_IdAfiliado) Cantidad_Maxima " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=1)AND Afiliado=AF.afi_IdAfiliado) Enero " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=2)AND Afiliado=AF.afi_IdAfiliado) Febrero " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=3)AND Afiliado=AF.afi_IdAfiliado) Marzo " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=4)AND Afiliado=AF.afi_IdAfiliado) Abril " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=5)AND Afiliado=AF.afi_IdAfiliado) Mayo " +
            ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=6)AND Afiliado=AF.afi_IdAfiliado) Junio " + 
			"FROM LOS_BORBOTONES.vw_BonosVencidos "+
            "JOIN LOS_BORBOTONES.Afiliado AF on AF.afi_IdAfiliado = Afiliado " +
            "where DATEPART(YYYY,Fecha_vencimiento)= ' " + Anio+ "'/*@Año */ "+ 
            "GROUP BY Afiliado,AF.afi_IdAfiliado " + 	
	        "order by 2 DESC"                                     
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
                var lista = Clases.DB.ExecuteReader("SELECT TOP 5 Afiliado " +
               ",(SELECT COUNT(Afiliado) from LOS_BORBOTONES.vw_BonosVencidos where (DATEPART(MONTH, Fecha_vencimiento) BETWEEN 7 AND 12)AND Afiliado=AF.afi_IdAfiliado) Cantidad_Maxima" +
               ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=7)AND Afiliado=AF.afi_IdAfiliado) Julio " +
               ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=8)AND Afiliado=AF.afi_IdAfiliado) Agosto " +
               ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=9)AND Afiliado=AF.afi_IdAfiliado) Septiembre " +
               ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=10)AND Afiliado=AF.afi_IdAfiliado) Octubre " +
               ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=11)AND Afiliado=AF.afi_IdAfiliado) Noviembre " +
               ",(select COUNT(*) from LOS_BORBOTONES.vw_BonosVencidos WHERE (DATEPART(MONTH, Fecha_vencimiento)=12)AND Afiliado=AF.afi_IdAfiliado) Diciembre " +
               "FROM LOS_BORBOTONES.vw_BonosVencidos " +
               "JOIN LOS_BORBOTONES.Afiliado AF on AF.afi_IdAfiliado = Afiliado " +
               "where DATEPART(YYYY,Fecha_vencimiento)= ' " + Anio + "' /*@Año */" +
               "GROUP BY Afiliado,AF.afi_IdAfiliado " +
               "order by 2 DESC"
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

        public string GetDateTime()
        {
            string path = "";

            StreamReader sr = new StreamReader(path + "fechaActual.txt"); string aux = sr.ReadLine();

            sr.Close(); sr.Dispose();

            return aux;
        }


        }
        
       
}

