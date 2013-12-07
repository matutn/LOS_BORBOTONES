using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;
using Clinica_Frba.GrillaRol;


namespace Clinica_Frba.Login
{
    public partial class SelecFunc : Form
    {


        public SelecFunc()
        {
            InitializeComponent();

            Ingreso ingreso = new Ingreso();
            if (ingreso.ShowDialog() != DialogResult.OK)
                this.Close();



        }

        private void registroDeLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abmAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GrillaAfiliado_Form()).Show(); 
        }

        private void abmProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GrillaProfesional_Form()).Show();
        }

        private void abmRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GrillaRol_Form()).Show();
        }
    }
}
