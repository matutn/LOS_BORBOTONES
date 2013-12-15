using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;
using Clinica_Frba.GenerarReceta;

namespace Clinica_Frba.ResultadoAtencion
{
    public partial class Resultado_Atencion_Form : Form
    {
        public string IdAfi;
        public string IdConsulta;

        public Resultado_Atencion_Form(int Id)
        {
            InitializeComponent();

            if (Id != 0)
            {
                txt_Id_Prof.Enabled = false;
                txt_Id_Prof.Text = Id.ToString();
            }

            grillaAtenciones.Rows.Clear();
            DataTable listadoTurnos= Clases.DB.ExecuteReader("Select a.afi_Apellido, a.afi_Nombre,t.tur_Fecha, a.afi_IdAfiliado, t.tur_IdTurno, c.con_IdConsulta "+
                                                               "From LOS_BORBOTONES.Turno t, LOS_BORBOTONES.Consulta c, LOS_BORBOTONES.Afiliado a, LOS_BORBOTONES.Profesional p "+
                                                               "where t.tur_IdConsulta = c.con_IdConsulta "+
                                                               "And c.con_Sintomas = '' And t.tur_IdAfi = a.afi_IdAfiliado And p.prof_IdProfesional = '"+txt_Id_Prof.Text+"' And p.prof_IdProfesional = t.tur_IdProf");
           

            Object[] columnas = new Object[6];

            foreach (DataRow dr in listadoTurnos.Rows)
            {
                columnas[0] = dr["afi_Apellido"].ToString();
                columnas[1] = dr["afi_Nombre"].ToString();
                columnas[2] = dr["tur_Fecha"].ToString();
                columnas[3] = dr["afi_IdAfiliado"].ToString();
                columnas[4] = dr["tur_IdTurno"].ToString();
                columnas[5] = dr["con_IdConsulta"].ToString();

                grillaAtenciones.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3], columnas[4], columnas[5]);
            }

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Resultado_Atencion_Form_Load(object sender, EventArgs e)
        {

        }

        private void B_Cargar_Atencion_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Cargar_Atencion_Click_1(object sender, EventArgs e)
        {

            if (grillaAtenciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una atención.");
                return;
            }

            IdAfi = grillaAtenciones.SelectedRows[0].Cells["Id_Afi"].ToString();
            IdConsulta = grillaAtenciones.SelectedRows[0].Cells["Id_Consulta"].ToString();

            if (B_Cargar_Atencion.Text == "Cargar Atención")
            {
                grillaAtenciones.Enabled = false;
                GB_Carga.Enabled = true;
                B_Cargar_Atencion.Text = "Volver";
                return;
            }
            if (B_Cargar_Atencion.Text == "Volver")
            {
                grillaAtenciones.Enabled = true;
                GB_Carga.Enabled = false;
                B_Cargar_Atencion.Text = "Cargar Atención";
                return;
            }

            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GB_Concreto.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GB_Concreto.Enabled = false;
        }

        //Botón Guardar Atención
        private void button1_Click(object sender, EventArgs e)
        {
            string dia = DTP_Dia.Value.ToShortDateString();
            string horario = DTP_Horario.Value.Hour + ":" + DTP_Horario.Value.Minute + ":" + DTP_Horario.Value.Second;
            string diaHorario = dia +" "+ horario;

            if (TB_Sintomas.Text == "")
            {
                MessageBox.Show("Debe ingresar al menos un sintoma.");
                return;
            }
            if (TB_Diagnostico.Text == "")
            {
                MessageBox.Show("Debe ingresar un diagnóstico.");
                return;
            }


            int updateDiagnostico = DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Diagnostico (diag_IdConsulta, diag_Diagnostico,diag_FechaDeLlegada)" +
                                                            "Values ('"+grillaAtenciones.SelectedRows[0].Cells["Id_Consulta"].ToString()+"','"+ TB_Diagnostico.Text +"','"+diaHorario+"')");

            int updateConsulta = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Consulta set con_Sintomas = '" + TB_Sintomas.Text + "' where con_IdConsulta = '" +
                                                        grillaAtenciones.SelectedRows[0].Cells["Id_Consulta"].ToString() + "'");

            MessageBox.Show("La Atención fue cargada correctamente");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Generar_Receta receta = new Generar_Receta(IdAfi,IdConsulta);
            if (receta.ShowDialog() != DialogResult.OK)
            { this.Close(); }

        }

        private void Resultado_Atencion_Form_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
