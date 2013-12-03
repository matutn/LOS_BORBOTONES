using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Utils;

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class CompraBono : Form
    {
        public static string dniAfiliado;
        long precioBC,precioBF;
        public CompraBono()
        {
            InitializeComponent();
            dniAfi.Text = dniAfiliado;
            idPlan.Text = Clases.DB.ExecuteCardinal("Select isNull(afi_IdPlan,0) from LOS_BORBOTONES.Afiliado where afi_Dni = '" + dniAfiliado + "'").ToString();      
        }

        private void CompraBono_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            
            this.validarFormulario();
            if (Validador.Instance.hayErrores())
            {
                Validador.Instance.mostrarErrores();
                return;
            }
            DateTime fecha = new DateTime(Convert.ToInt16(añoCompra.Text), Convert.ToInt16(mesCompra.Text), Convert.ToInt16(diaCompra.Text));
            if (cantBC.Value == 0 && cantBF.Value == 0)
            {
                MessageBox.Show("Se debe cargar al menos un Bono", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          
            if (fecha < DateTime.Today)
            {
                MessageBox.Show("La Fecha de la Compra no puede ser menor a la fecha actual", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            precioBC = Clases.DB.ExecuteCardinal("Select plan_PrecioBC from LOS_BORBOTONES.Plan_Medico where plan_IdPlan = '" + idPlan.Text + "'");
            precioBF = Clases.DB.ExecuteCardinal("Select plan_PrecioBF from LOS_BORBOTONES.Plan_Medico where plan_IdPlan = '" + idPlan.Text + "'");
            int idAfiliado = Clases.DB.ExecuteCardinal("Select afi_IdAfiliado from LOS_BORBOTONES.Afiliado where afi_Dni = '" + dniAfi.Text + "'");
            montoTotal.Text = (precioBC * cantBC.Value + precioBF * cantBF.Value).ToString();

            int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Compra_Bono (cobo_IdAfi,cobo_CantBC,cobo_CantBF,cobo_MontoTotal,cobo_FechaCompra) values ('" + idAfiliado + "','" + cantBC.Value + "','" + cantBF.Value + "','" + montoTotal.Text + "','" +  añoCompra.Text + diaCompra.Text + mesCompra.Text + "')");
            MessageBox.Show("La compra se realizo correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void validarFormulario()
        {
            Validador validador = Validador.Instance;
            validador.estaVacioOEsNulo(diaCompra);
            validador.estaVacioOEsNulo(mesCompra);
            validador.estaVacioOEsNulo(añoCompra);
            validador.esNumerico(diaCompra);
            validador.esNumerico(mesCompra);
            validador.esNumerico(añoCompra);
        }

        private void cantBC_ValueChanged(object sender, EventArgs e)
        {
            actualizarMontoCompra();  
        }

        private void actualizarMontoCompra()
        {
            precioBC = Clases.DB.ExecuteCardinal("Select plan_PrecioBC from LOS_BORBOTONES.Plan_Medico where plan_IdPlan = '" + idPlan.Text + "'");
            precioBF = Clases.DB.ExecuteCardinal("Select plan_PrecioBF from LOS_BORBOTONES.Plan_Medico where plan_IdPlan = '" + idPlan.Text + "'");
            montoTotal.Text = (precioBC * cantBC.Value + precioBF * cantBF.Value).ToString();
        }

        private void cantBF_ValueChanged(object sender, EventArgs e)
        {
            actualizarMontoCompra();  
        }
    }
}
