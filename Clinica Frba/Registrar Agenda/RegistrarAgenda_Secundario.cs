using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class RegistrarAgenda_Secundario : Form
    {
        public static char tipoFormularioSecundario;
        public static int idProfesional = 2;
        public RegistrarAgenda_Secundario()
        {
            InitializeComponent();
            switch (tipoFormularioSecundario)
            {
                case 'C':
                    {
                        this.Text = "Cargar datos de la Agenda";
                        DateTime fecDesde = Convert.ToDateTime(GetDateTime());
                        DateTime fecHasta = Convert.ToDateTime(GetDateTime());
                        dateTime_Desde.MinDate = new DateTime(fecDesde.Year,fecDesde.Month,fecDesde.Day);
                        dateTime_Hasta.MinDate = new DateTime(fecHasta.Year, fecHasta.Month, fecHasta.Day);
                        break;
                    }
                case 'V':
                    {
                        this.Text = "Datos de la Agenda";
                        button_CargarAgenda.Hide();
                        cargarDatosAgenda();
                        break;
                    }
            }
 
        }

        private void cargarDatosAgenda()
        {
            DataTable dt_fechaDesde = Clases.DB.ExecuteReader("Select top 1 age_Fecha from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional);
            DataTable dt_fechaHasta = Clases.DB.ExecuteReader("Select top 1 age_Fecha from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " order by age_Fecha desc");
            DataTable dt_lunes = Clases.DB.ExecuteReader("Select top 1 * from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " and age_IdDia = " + 1);
            DataTable dt_martes = Clases.DB.ExecuteReader("Select top 1 * from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " and age_IdDia = " + 2);
            DataTable dt_miercoles = Clases.DB.ExecuteReader("Select top 1 * from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " and age_IdDia = " + 3);
            DataTable dt_jueves = Clases.DB.ExecuteReader("Select top 1 * from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " and age_IdDia = " + 4);
            DataTable dt_viernes = Clases.DB.ExecuteReader("Select top 1 * from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " and age_IdDia = " + 5);
            DataTable dt_sabado = Clases.DB.ExecuteReader("Select top 1 * from LOS_BORBOTONES.Agenda where age_IdProfesional = " + idProfesional + " and age_IdDia = " + 6);
            dateTime_Desde.Value = Convert.ToDateTime(dt_fechaDesde.Rows[0]["age_Fecha"]);
            dateTime_Hasta.Value = Convert.ToDateTime(dt_fechaHasta.Rows[0]["age_Fecha"]);

            if (dt_lunes.Rows.Count > 0)
            {
                lunes_HoraDesde.Value = Convert.ToDecimal(dt_lunes.Rows[0]["age_HoraComienzo"]);
                lunes_HoraHasta.Value = Convert.ToDecimal(dt_lunes.Rows[0]["age_HorarioFin"]);
                lunes_MinutoDesde.Value = Convert.ToDecimal(dt_lunes.Rows[0]["age_MinutoComienzo"]);
                lunes_MinutoHasta.Value = Convert.ToDecimal(dt_lunes.Rows[0]["age_MinutoFin"]);
            }
            if (dt_martes.Rows.Count > 0)
            {
                martes_HoraDesde.Value = Convert.ToDecimal(dt_martes.Rows[0]["age_HoraComienzo"]);
                martes_HoraHasta.Value = Convert.ToDecimal(dt_martes.Rows[0]["age_HorarioFin"]);
                martes_MinutoDesde.Value = Convert.ToDecimal(dt_martes.Rows[0]["age_MinutoComienzo"]);
                martes_MinutoHasta.Value = Convert.ToDecimal(dt_martes.Rows[0]["age_MinutoFin"]);
            }
            if (dt_miercoles.Rows.Count > 0)
            {
                miercoles_HoraDesde.Value = Convert.ToDecimal(dt_miercoles.Rows[0]["age_HoraComienzo"]);
                miercoles_HoraHasta.Value = Convert.ToDecimal(dt_miercoles.Rows[0]["age_HorarioFin"]);
                miercoles_MinutoDesde.Value = Convert.ToDecimal(dt_miercoles.Rows[0]["age_MinutoComienzo"]);
                miercoles_MinutoHasta.Value = Convert.ToDecimal(dt_miercoles.Rows[0]["age_MinutoFin"]);
            }
            if (dt_jueves.Rows.Count > 0)
            {
                jueves_HoraDesde.Value = Convert.ToDecimal(dt_jueves.Rows[0]["age_HoraComienzo"]);
                jueves_HoraHasta.Value = Convert.ToDecimal(dt_jueves.Rows[0]["age_HorarioFin"]);
                jueves_MinutoDesde.Value = Convert.ToDecimal(dt_jueves.Rows[0]["age_MinutoComienzo"]);
                jueves_MinutoHasta.Value = Convert.ToDecimal(dt_jueves.Rows[0]["age_MinutoFin"]);
            }
            if (dt_viernes.Rows.Count > 0)
            {
                viernes_HoraDesde.Value = Convert.ToDecimal(dt_viernes.Rows[0]["age_HoraComienzo"]);
                viernes_HoraHasta.Value = Convert.ToDecimal(dt_viernes.Rows[0]["age_HorarioFin"]);
                viernes_MinutoDesde.Value = Convert.ToDecimal(dt_viernes.Rows[0]["age_MinutoComienzo"]);
                viernes_MinutoHasta.Value = Convert.ToDecimal(dt_viernes.Rows[0]["age_MinutoFin"]);
            }
            if (dt_sabado.Rows.Count > 0)
            {
                sabado_HoraDesde.Value = Convert.ToDecimal(dt_sabado.Rows[0]["age_HoraComienzo"]);
                sabado_HoraHasta.Value = Convert.ToDecimal(dt_sabado.Rows[0]["age_HorarioFin"]);
                sabado_MinutoDesde.Value = Convert.ToDecimal(dt_sabado.Rows[0]["age_MinutoComienzo"]);
                sabado_MinutoHasta.Value = Convert.ToDecimal(dt_sabado.Rows[0]["age_MinutoFin"]);
            }

        } 

        private void button_CargarAgenda_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde;
            DateTime fechaHasta;

            if((lunes_HoraHasta.Value*60 + lunes_MinutoHasta.Value) < (lunes_HoraDesde.Value*60 + miercoles_MinutoDesde.Value))
                MessageBox.Show("El horario del día Lunes es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((martes_HoraHasta.Value * 60 + martes_MinutoHasta.Value) < (martes_HoraDesde.Value * 60 + martes_MinutoDesde.Value))
                MessageBox.Show("El horario del día Martes es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((miercoles_HoraHasta.Value * 60 + miercoles_MinutoHasta.Value) < (miercoles_HoraDesde.Value * 60 + miercoles_MinutoDesde.Value))
                MessageBox.Show("El horario del día Miércoles es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((jueves_HoraHasta.Value * 60 + jueves_MinutoHasta.Value) < (jueves_HoraDesde.Value * 60 + jueves_MinutoDesde.Value))
                MessageBox.Show("El horario del día Jueves es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((viernes_HoraHasta.Value * 60 + viernes_MinutoHasta.Value) < (viernes_HoraDesde.Value * 60 + viernes_MinutoDesde.Value))
                MessageBox.Show("El horario del día Viernes es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if ((sabado_HoraHasta.Value * 60 + sabado_MinutoHasta.Value) < (sabado_HoraDesde.Value * 60 + sabado_MinutoDesde.Value))
                MessageBox.Show("El horario del día Sábado es incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dateTime_Desde.Value > dateTime_Hasta.Value)
            {
                MessageBox.Show("La Fecha Desde no puede ser mayor que la Fecha Hasta", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((dateTime_Hasta.Value - dateTime_Desde.Value).TotalDays > 120)
            {
                MessageBox.Show("La cantidad de días del rango de fechas no puede ser mayor a 120", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ( ((lunes_HoraHasta.Value - lunes_HoraDesde.Value + martes_HoraHasta.Value - martes_HoraDesde.Value + miercoles_HoraHasta.Value - miercoles_HoraDesde.Value + 
                jueves_HoraHasta.Value - jueves_HoraDesde.Value + viernes_HoraHasta.Value - viernes_MinutoDesde.Value + sabado_HoraHasta.Value - sabado_HoraDesde.Value)*60 + 
                lunes_MinutoHasta.Value - lunes_MinutoDesde.Value + martes_MinutoHasta.Value - martes_MinutoDesde.Value + miercoles_MinutoHasta.Value - miercoles_MinutoDesde.Value + 
                jueves_MinutoHasta.Value - jueves_MinutoDesde.Value + viernes_MinutoHasta.Value - viernes_MinutoDesde.Value + sabado_MinutoHasta.Value - sabado_MinutoDesde.Value) > (48*60))
            {
                MessageBox.Show("El Profesional no puede trabajar mas de 48 hs por semana", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable dt_especialidades = Clases.DB.ExecuteReader("Select espr_CodEspecialidad from LOS_BORBOTONES.Especialidad_Profesional where espr_idProfesional = " + idProfesional);
            fechaDesde = dateTime_Desde.Value;
            fechaHasta = dateTime_Hasta.Value;
            while (fechaDesde.Date <= fechaHasta.Date)
            {
                int dia = 0;
                int horaInicio = 0,minutoInicio = 0,horaFin = 0,minutoFin = 0;
                if (fechaDesde.DayOfWeek == DayOfWeek.Monday){
                    dia = 1;
                    horaInicio = Convert.ToInt32(lunes_HoraDesde.Value);
                    horaFin = Convert.ToInt32(lunes_HoraHasta.Value);
                    minutoInicio = Convert.ToInt32(lunes_MinutoDesde.Value);
                    minutoFin = Convert.ToInt32(lunes_MinutoHasta.Value);
                }
                if (fechaDesde.DayOfWeek == DayOfWeek.Tuesday){
                    dia = 2;
                    horaInicio = Convert.ToInt32(martes_HoraDesde.Value);
                    horaFin = Convert.ToInt32(martes_HoraHasta.Value);
                    minutoInicio = Convert.ToInt32(martes_MinutoDesde.Value);
                    minutoFin = Convert.ToInt32(martes_MinutoHasta.Value);
                }
                if (fechaDesde.DayOfWeek == DayOfWeek.Wednesday)
                {
                    dia = 3;
                    horaInicio = Convert.ToInt32(miercoles_HoraDesde.Value);
                    horaFin = Convert.ToInt32(miercoles_HoraHasta.Value);
                    minutoInicio = Convert.ToInt32(miercoles_MinutoDesde.Value);
                    minutoFin = Convert.ToInt32(miercoles_MinutoHasta.Value);
                }
                if (fechaDesde.DayOfWeek == DayOfWeek.Thursday){
                    dia = 4;
                    horaInicio = Convert.ToInt32(jueves_HoraDesde.Value);
                    horaFin = Convert.ToInt32(jueves_HoraHasta.Value);
                    minutoInicio = Convert.ToInt32(jueves_MinutoDesde.Value);
                    minutoFin = Convert.ToInt32(jueves_MinutoHasta.Value);
                }
                if (fechaDesde.DayOfWeek == DayOfWeek.Friday){
                    dia = 5;
                    horaInicio = Convert.ToInt32(viernes_HoraDesde.Value);
                    horaFin = Convert.ToInt32(viernes_HoraHasta.Value);
                    minutoInicio = Convert.ToInt32(viernes_MinutoDesde.Value);
                    minutoFin = Convert.ToInt32(viernes_MinutoHasta.Value);
                }
                if (fechaDesde.DayOfWeek == DayOfWeek.Saturday){
                    dia = 6;
                    horaInicio = Convert.ToInt32(sabado_HoraDesde.Value);
                    horaFin = Convert.ToInt32(sabado_HoraHasta.Value);
                    minutoInicio = Convert.ToInt32(sabado_MinutoDesde.Value);
                    minutoFin = Convert.ToInt32(sabado_MinutoHasta.Value);
                }
                foreach (DataRow row in dt_especialidades.Rows)
                {
                   Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Agenda (age_IdProfesional,age_Especialidad,age_IdDia,age_Fecha,age_HoraComienzo,age_MinutoComienzo,age_HorarioFin,age_MinutoFin,age_Estado) 
                                              values (" + idProfesional + "," + row["espr_CodEspecialidad"] + "," + dia + ",'" + fechaDesde.ToString("yyyy-MM-dd") + "'," + horaInicio + "," + minutoInicio + "," + horaFin + "," + minutoFin + "," + 0 + ")" ); 
                }
                fechaDesde = fechaDesde.AddDays(1);
            }
            MessageBox.Show("Agenda cargada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void MISA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void HFSA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HISA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MFSA_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
