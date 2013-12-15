using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Compra_de_Bono;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;
using Clinica_Frba.Pedir_Turno;
using Clinica_Frba.Registrar_Agenda;

namespace Clinica_Frba
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new GrillaAfiliado_Form()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new GrillaProfesional_Form()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new CompraBono_Administrativo()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new PedidoTurno_Principal()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new RegistrarAgenda_Principal()).Show();
        }
    }
}
