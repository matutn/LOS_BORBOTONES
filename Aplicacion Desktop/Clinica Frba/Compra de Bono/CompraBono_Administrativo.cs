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
    public partial class CompraBono_Administrativo : Form
    {
        public CompraBono_Administrativo()
        {
            InitializeComponent();
            DataTable lista = Clases.DB.ExecuteReader("Select afi_Dni from LOS_BORBOTONES.Afiliado order by 1");
            comboBoxAfiliado.DataSource = lista;
            comboBoxAfiliado.DisplayMember = lista.Columns["afi_Dni"].ToString();
            comboBoxAfiliado.ValueMember = lista.Columns["afi_Dni"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CompraBono_Administrativo_Load(object sender, EventArgs e)
        {

        }

        private void button_Comprar_Click(object sender, EventArgs e)
        {
            if (comboBoxAfiliado.SelectedValue.ToString() == "")
            {
                return;
            }
            string plan_afi = Clases.DB.ExecuteCardinal("Select isNull(afi_IdPlan,0) from LOS_BORBOTONES.Afiliado where afi_Dni = '" + comboBoxAfiliado.SelectedValue.ToString() + "'").ToString();
            if (plan_afi == "0")
            {
                MessageBox.Show("El afiliado no posee plan", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CompraBono.dniAfiliado = comboBoxAfiliado.SelectedValue.ToString();
                (new CompraBono()).Show();
            }
             
        }

        private void button_Actualizar_Click(object sender, EventArgs e)
        {
            cargarComprasAfiliado();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxAfiliado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarComprasAfiliado();
        }

        private void cargarComprasAfiliado()
        {
            compraBonos.Rows.Clear();
            if (comboBoxAfiliado.SelectedValue.ToString() == "")
            {
                return;
            }
            int idAfiliado = Clases.DB.ExecuteCardinal("Select afi_IdAfiliado from LOS_BORBOTONES.Afiliado where afi_Dni = '" + comboBoxAfiliado.SelectedValue.ToString() + "'");
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
    }
}
