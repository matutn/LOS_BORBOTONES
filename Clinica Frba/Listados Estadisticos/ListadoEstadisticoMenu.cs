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
using Clinica_Frba.NewFolder9;


namespace Clinica_Frba
{
    public partial class ListadoEstadisticoMenu : Form
    {
        public ListadoEstadisticoMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new CancelacionesPorEspecialidad()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new BonosFarmaciaVencidos()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new BonosFarmaciaPorEspecialidad()).Show();
        }

        private void ListadoEstadisticoMenu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new BonosQueComproOtro()).Show();
        }

        private void ListadoEstadisticoMenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
