using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class PedidoTurno_Secundario : Form
    {
        public static int idAfiliado;
        public static string nombreProfesional;
        public static long dniProfesional;
        DataTable dt_idProf = Clases.DB.ExecuteReader("select prof_IdProfesional from LOS_BORBOTONES.Profesional where prof_Dni =" + dniProfesional);
       
        public PedidoTurno_Secundario()
        {
            InitializeComponent();
            this.Text = "Pedir Turno";
            if (idAfiliado != 0)
            {
                label_dni.Hide();
                txt_dniAfi.Hide();
            }
            txt_profesional.Text = nombreProfesional;
            DataTable dt_fechaMaxima = Clases.DB.ExecuteReader("select top 1 age_Fecha from LOS_BORBOTONES.Agenda where age_IdProfesional = " + dt_idProf.Rows[0]["prof_IdProfesional"] + " order by age_Fecha desc");
            DataTable dt_fechaMinima = Clases.DB.ExecuteReader("select top 1 age_Fecha from LOS_BORBOTONES.Agenda where age_IdProfesional = " + dt_idProf.Rows[0]["prof_IdProfesional"] + " order by age_Fecha");
            DateTime fechaMaxima = Convert.ToDateTime(dt_fechaMaxima.Rows[0]["age_Fecha"]);
            DateTime fechaMinima = Convert.ToDateTime(dt_fechaMinima.Rows[0]["age_Fecha"]);
            DateTime fechaSistema = Convert.ToDateTime(GetDateTime());
            if (fechaSistema.Date < fechaMinima.Date)
            {
                calendario_Profesional.MinDate = new DateTime(fechaMinima.Year, fechaMinima.Month, fechaMinima.Day);
            }
            else calendario_Profesional.MinDate = fechaSistema;

            if (fechaMaxima.Date > fechaSistema.Date)
            {
                calendario_Profesional.MaxDate = new DateTime(fechaMaxima.Year, fechaMaxima.Month, fechaMaxima.Day);
            }
            else calendario_Profesional.MaxDate = fechaSistema;
            
        }

        public string GetDateTime()
        {
            string path = "";

            StreamReader sr = new StreamReader(path + "fechaActual.txt");
            string aux = sr.ReadLine();

            sr.Close();
            sr.Dispose();

            return aux;
        }

        private void calendario_Profesional_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataTable dt_horarioFecha = Clases.DB.ExecuteReader(@"select age_HoraComienzo, isNull(age_MinutoComienzo,0) minComienzo, age_HorarioFin, isNull(age_MinutoFin,0) minFin from LOS_BORBOTONES.Agenda
                                                                  where age_IdProfesional = " + dt_idProf.Rows[0]["prof_IdProfesional"] + " AND cast( age_Fecha as date) = '" + calendario_Profesional.SelectionEnd.ToString("yyyy-MM-dd") + "'");
            if (dt_horarioFecha.Rows.Count == 0)
            {
                txt_InfoDia.Text = "El Profesional no trabaja dicho dia";
                txt_HoraDesde.Text = "";
                txt_HoraHasta.Text = "";
                txt_MinutoDesde.Text = "";
                txt_MinutoHasta.Text = "";
                return;
            }
            txt_HoraDesde.Text = dt_horarioFecha.Rows[0]["age_HoraComienzo"].ToString();
            txt_HoraHasta.Text = dt_horarioFecha.Rows[0]["age_HorarioFin"].ToString();
            txt_MinutoDesde.Text = dt_horarioFecha.Rows[0]["minComienzo"].ToString();
            txt_MinutoHasta.Text = dt_horarioFecha.Rows[0]["minFin"].ToString();

            txt_InfoDia.Text = "";
        }
   
        private void button_Confirmar_Click(object sender, EventArgs e)
        {
            if (txt_HoraHasta.Text == "" || txt_HoraDesde.Text == "")
                return;
            if ((txt_HoraConfirmar.Value < Convert.ToInt32(txt_HoraDesde.Text)) || (txt_HoraConfirmar.Value > Convert.ToInt32(txt_HoraHasta.Text))
                || ((txt_HoraConfirmar.Value == Convert.ToInt32(txt_HoraDesde.Text) && txt_MinutoConfirmar.Value < Convert.ToInt32(txt_MinutoDesde.Text)))
                || (txt_HoraConfirmar.Value == Convert.ToInt32(txt_HoraHasta.Text) && txt_MinutoConfirmar.Value > Convert.ToInt32(txt_MinutoHasta.Text)))
            {
                MessageBox.Show("El Profesional no atiende en la hora indicada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string hConf = "";
            string mConf = "";
            if (txt_HoraConfirmar.Value.ToString().Length == 2)
            {
                hConf = txt_HoraConfirmar.Value.ToString();
            }
            else hConf = "0" + txt_HoraConfirmar.Value.ToString();
            if (txt_MinutoConfirmar.Value.ToString().Length == 2)
            {
                mConf = txt_MinutoConfirmar.Value.ToString();
            }
            else mConf = "0" + txt_MinutoConfirmar.Value.ToString();
            DateTime fechaa= new DateTime(calendario_Profesional.SelectionEnd.Year, calendario_Profesional.SelectionEnd.Month, calendario_Profesional.SelectionEnd.Day);
            string fechaConfirmacionTurno = fechaa.ToString("yyyy-MM-dd") + " " + hConf + ":" + mConf + ":00.000";
            int afiliadoId = 0;
            if (idAfiliado == 0)
            {
                if (txt_dniAfi.Text == "")
                {
                    MessageBox.Show("Debe seleccionar un afiliado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataTable dt_afiliadoId = Clases.DB.ExecuteReader("select afi_IdAfiliado from LOS_BORBOTONES.Afiliado where afi_Dni ='" + txt_dniAfi.Text + "'");
                if (dt_afiliadoId.Rows.Count == 0)
                {
                    MessageBox.Show("El Afiliado indicado no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                afiliadoId = Convert.ToInt32(dt_afiliadoId.Rows[0]["afi_IdAfiliado"]);
            }
            else afiliadoId = idAfiliado;
            DataTable dt_especialidadProf = Clases.DB.ExecuteReader("select espr_CodEspecialidad from LOS_BORBOTONES.Especialidad_Profesional where espr_idProfesional =" + dt_idProf.Rows[0]["prof_IdProfesional"]);
            DataTable dt_turno = Clases.DB.ExecuteReader(@"select * from LOS_BORBOTONES.Turno where tur_IdAfi = " + afiliadoId + " AND tur_IdProf = " + dt_idProf.Rows[0]["prof_IdProfesional"] + " AND tur_Estado = " + 1 +
                " AND YEAR(tur_Fecha) = " + calendario_Profesional.SelectionEnd.Year + " AND MONTH(tur_Fecha) = " + calendario_Profesional.SelectionEnd.Month + " AND DAY(tur_Fecha) = " + calendario_Profesional.SelectionEnd.Day + " AND DATEPART(hh,tur_Fecha)=" + hConf + " AND DATEPART(mi,tur_Fecha)=" + mConf);

            if (dt_turno.Rows.Count == 0)
            {
                Clases.DB.ExecuteNonQuery("Insert into LOS_BORBOTONES.Turno (tur_IdProf,tur_IdAfi,tur_Especialidad,tur_Fecha,tur_Estado) values (" + dt_idProf.Rows[0]["prof_IdProfesional"] + "," + afiliadoId + "," + dt_especialidadProf.Rows[0]["espr_CodEspecialidad"] + ",'" + fechaConfirmacionTurno + "'," + 1 + ")");
                MessageBox.Show("El turno fue cargado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("El horario seleccionado ya se encuentra ocupado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }


        private void PedidoTurno_Secundario_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
