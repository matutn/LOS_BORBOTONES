using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Clases;
using System.IO;


namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class Cancelar_Turno_Afiliado : Form
    {
        public Cancelar_Turno_Afiliado(int Id)
        {
            InitializeComponent();

            if (Id != 0)
            {
                txt_Id_Afi.Enabled = false;
                txt_Id_Afi.Text = Id.ToString();
            }


            DataTable tipoCanc = Clases.DB.ExecuteReader("Select cati_IdTipoCancelacion,cati_Descripcion from LOS_BORBOTONES.TipoCancelacion order by 1");
            //DataRow row = planes.NewRow();
            //row["plan_IdPlan"] = DBNull.Value;
            //planes.Rows.InsertAt(row, 0);
            CB_Cancelaciones.DataSource = tipoCanc;
            CB_Cancelaciones.DisplayMember = tipoCanc.Columns["cati_Descripcion"].ToString();
            CB_Cancelaciones.ValueMember = tipoCanc.Columns["cati_Descripcion"].ToString();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            grillaTurnos.Rows.Clear();

            if (txt_Id_Afi.Text == "")
            {
                MessageBox.Show("Debe completar los campos obligatorios(*).");
                return;
            }

            DataTable turnos;

            if (txt_fecha.Text != "")
            {
                 turnos = DB.ExecuteReader("Select p.prof_Nombre, p.prof_Apellido, a.afi_Nombre, a.afi_Apellido,t.tur_Fecha, t.tur_IdAfi, e.esp_Descripcion, t.tur_IdTurno " +
                                            "From LOS_BORBOTONES.Profesional p, LOS_BORBOTONES.Afiliado a, LOS_BORBOTONES.Turno t, LOS_BORBOTONES.Especialidad e" +
                                            " where p.prof_Nombre like '%" + txt_Nom_Prof.Text + "%' AND p.prof_Apellido like '%" + txt_Ape_Prof.Text + "%' " +
                                            " AND e.esp_Descripcion like '%" + txt_esp.Text + "%' AND t.tur_IdProf = p.prof_IdProfesional " +
                                            " AND t.tur_estado = 'true' AND t.tur_IdAfi = a.afi_IdAfiliado " +
                                            "AND e.esp_CodEspecialidad = t.tur_Especialidad AND a.afi_IdAfiliado = '" + txt_Id_Afi.Text + "'" +
                                            "AND cast(t.tur_Fecha as date) = '" + txt_fecha.Text + "' AND t.tur_IdConsulta is NULL");
            }
            else
            {
                 turnos = DB.ExecuteReader("Select p.prof_Nombre, p.prof_Apellido, a.afi_Nombre, a.afi_Apellido,t.tur_Fecha, t.tur_IdAfi, e.esp_Descripcion, t.tur_IdTurno " +
                                            "From LOS_BORBOTONES.Profesional p, LOS_BORBOTONES.Afiliado a, LOS_BORBOTONES.Turno t, LOS_BORBOTONES.Especialidad e" +
                                            " where p.prof_Nombre like '%" + txt_Nom_Prof.Text + "%' AND p.prof_Apellido like '%" + txt_Ape_Prof.Text + "%' " +
                                            " AND e.esp_Descripcion like '%" + txt_esp.Text + "%' AND t.tur_IdProf = p.prof_IdProfesional " +
                                            " AND t.tur_estado = 'true' AND t.tur_IdAfi = a.afi_IdAfiliado " +
                                            "AND e.esp_CodEspecialidad = t.tur_Especialidad AND a.afi_IdAfiliado = '" + txt_Id_Afi.Text + "'" +
                                            "AND t.tur_IdConsulta is NULL");
                
            }
            
            Object[] columnas = new Object[8];

            foreach (DataRow dr in turnos.Rows)
            {
                columnas[0] = dr["afi_Nombre"].ToString().Trim();
                columnas[1] = dr["afi_Apellido"].ToString().Trim();
                columnas[2] = dr["esp_Descripcion"].ToString().Trim();
                columnas[3] = dr["prof_Nombre"].ToString().Trim();
                columnas[4] = dr["prof_Apellido"].ToString().Trim();
                columnas[5] = dr["tur_Fecha"].ToString();
                columnas[6] = dr["tur_IdAfi"].ToString();
                columnas[7] = dr["tur_IdTurno"].ToString();

                grillaTurnos.Rows.Add(columnas[0], columnas[1], columnas[2], columnas[3], columnas[4], columnas[5], columnas[6], columnas[7]);
            }
            if (grillaTurnos.RowCount == 0)
            {
                MessageBox.Show("La búsqueda no obtuvo resultados.");
                return;
            }

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Calendario_Click(object sender, EventArgs e)
        {

            if (B_Calendario.Text == "Calendario")
            {
                Calendario.Enabled = true;
                Calendario.Visible = true;
                B_Calendario.Text = "Seleccionar";
                return;
            }
            if (B_Calendario.Text == "Seleccionar")
            {
                txt_fecha.Text = Calendario.SelectionEnd.ToShortDateString();

       

                Calendario.Enabled = false;
                Calendario.Visible = false;
                B_Calendario.Text = "Calendario";
                return;
            }
        }

        private void Cancelar_Turno_Afiliado_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Turno_Click(object sender, EventArgs e)
        {
            if (grillaTurnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un turno.");
                return;
            }
            if (txt_motivo.Text == "")
            {
                MessageBox.Show("Debe ingresar un motivo.");
                return;

            }
            //if (CB_Cancelaciones.Text == "")
            //{
            //    MessageBox.Show("Debe ingresar un tipo de cancelación");
            //    return;
            //}

            string fechaTurno = grillaTurnos.SelectedRows[0].Cells["Fecha_Turno"].Value.ToString().Substring(0, 10);

            if (((Convert.ToDateTime(GetDateTime()).Year == Convert.ToDateTime(fechaTurno).Year) && (Convert.ToDateTime(GetDateTime()).DayOfYear >= Convert.ToDateTime(fechaTurno).DayOfYear)) || (Convert.ToDateTime(GetDateTime()).Year > Convert.ToDateTime(fechaTurno).Year))
            {
                MessageBox.Show("Los turnos se deben cancelar con uno o más días de antelación a la fecha del turno.");
                return;
            }


            int updateTurno= DB.ExecuteNonQuery("Update LOS_BORBOTONES.Turno set tur_Estado = 'false' " +
                                                    "where tur_IdTurno= '" + grillaTurnos.SelectedRows[0].Cells["Id_Turno"].Value.ToString() + "'");



            DataTable tipoCanc = Clases.DB.ExecuteReader("Select cati_IdTipoCancelacion,cati_Descripcion from LOS_BORBOTONES.TipoCancelacion");

            string idTipoCanc = "";

            foreach (DataRow dr in tipoCanc.Rows)
            {
                if (CB_Cancelaciones.Text == dr["cati_Descripcion"].ToString())
                {
                    idTipoCanc = dr["cati_IdTipoCancelacion"].ToString();
                }

            }
            

            int idCancelacion = DB.ExecuteCardinal("Insert Into LOS_BORBOTONES.Cancelacion (can_Motivo,can_Tipo) Values ('" + txt_motivo.Text + "','" + idTipoCanc + "'); select scope_identity()");

            

            int insertCancelacionTurno = DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Cancelacion_Turno (catu_IdCancelacion, catu_IdTurno ,catu_FechaCancelacion) Values ('" + idCancelacion.ToString() + "' ,'" + grillaTurnos.SelectedRows[0].Cells["Id_Turno"].Value.ToString() + "',cast('" + fechaTurno + "' as date))");

            MessageBox.Show("El turno se canceló exitosamente.");
            
            
        }

    }
}
