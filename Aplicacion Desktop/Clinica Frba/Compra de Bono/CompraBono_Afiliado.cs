using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class CompraBono_Afiliado : Form
    {
        public CompraBono_Afiliado()
        {
            InitializeComponent();
            dni.Text = "27282973";
            cargarComprasAfiliado();
        }

        private void cargarComprasAfiliado()
        {
            int idAfiliado = Clases.DB.ExecuteCardinal("Select afi_IdAfiliado from LOS_BORBOTONES.Afiliado where afi_Dni = '" + dni.Text + "'");
            var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Compra_Bono where cobo_IdAfi = ' " + idAfiliado + "'");
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[4];

            foreach (DataRow row in lista.Rows)
            {
                columnas[0] = row["cobo_FechaCompra"];
                columnas[1] = row["cobo_CantBC"];
                columnas[2] = row["cobo_CantBF"];
                columnas[3] = row["cobo_MontoTotal"];

                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(compraBonos, columnas);
            }
            compraBonos.Rows.AddRange(filas.ToArray());
        }

        private void CompraBono_Afiliado_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Comprar_Click(object sender, EventArgs e)
        {
            CompraBono.dniAfiliado = dni.Text;
            (new CompraBono()).Show(); 
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            cargarComprasAfiliado();
        }
    }
}
