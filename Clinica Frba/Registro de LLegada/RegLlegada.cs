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

namespace Clinica_Frba.RegLlegada
{
    public partial class RegLlegada_Form : Form
    {
        public RegLlegada_Form()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Botón Buscar
        private void button3_Click(object sender, EventArgs e)
        {
            grillaTurno.Rows.Clear();

            if (txt_Ape_Prof.Text == "" && txt_Nom_Prof.Text == "" && txt_esp.Text == "")
            {
                MessageBox.Show("Debe completar algún filtro de búsqueda.");
                return;
            }
            
            DataTable turnos = DB.ExecuteReader("Select p.prof_Nombre, p.prof_Apellido, a.afi_Nombre, a.afi_Apellido,t.tur_Fecha, t.tur_IdAfi, e.esp_Descripcion, t.tur_IdTurno "+
                                        "From LOS_BORBOTONES.Profesional p, LOS_BORBOTONES.Afiliado a, LOS_BORBOTONES.Turno t, LOS_BORBOTONES.Especialidad e" +
                                        " where p.prof_Nombre like '%" + txt_Nom_Prof.Text + "%' AND p.prof_Apellido like '%" + txt_Ape_Prof.Text + "%' " +
                                        " AND e.esp_Descripcion like '%" + txt_esp.Text + "%' AND t.tur_IdProf = p.prof_IdProfesional " +
                                        " AND t.tur_estado = 'true' AND t.tur_IdAfi = a.afi_IdAfiliado "+
                                        "AND e.esp_CodEspecialidad = t.tur_Especialidad AND DATEDIFF(minute,'" + GetDateTime() + "',t.tur_Fecha)>15" +
                                        "AND cast(t.tur_Fecha as date) = cast('"+GetDateTime()+"' as date) AND t.tur_IdConsulta is NULL");
            
            Object[] columnas = new Object[8];

            foreach (DataRow dr in turnos.Rows)
            {
                columnas[0] = dr["prof_Nombre"].ToString().Trim();
                columnas[1] = dr["prof_Apellido"].ToString().Trim();
                columnas[2] = dr["esp_Descripcion"].ToString().Trim();
                columnas[3] = dr["afi_Nombre"].ToString().Trim();
                columnas[4] = dr["afi_Apellido"].ToString().Trim();
                columnas[5] = dr["tur_Fecha"].ToString();
                columnas[6] = dr["tur_IdAfi"].ToString();
                columnas[7] = dr["tur_IdTurno"].ToString();

                grillaTurno.Rows.Add(columnas[0], columnas[1], columnas[2],columnas[3], columnas[4], columnas[5],columnas[6],columnas[7]);
            }
            if (grillaTurno.RowCount == 0)
            {
                MessageBox.Show("La búsqueda no obtuvo resultados.");
                return;
            }

        }

        // Botón Confirmar
        private void button4_Click(object sender, EventArgs e)
        {

            if (txt_Id_Afi.Text == ""  || grillaTurno.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro e ingresar un Id de Afiliado.");
                return;
            }

            if (txt_Id_Afi.Text != grillaTurno.SelectedRows[0].Cells["IdAfi"].Value.ToString())
            {
                MessageBox.Show("El afiliado no coincide con el turno seleccionado.");
                return;
            }

            
            txt_Id_Bono.Enabled = true;
            txt_Id_Afi.Enabled = false;
            button3.Enabled = false; //botón Buscar
            button4.Enabled = false;//botón Confirmar
            FiltrosProf.Enabled = false;
            grillaTurno.Enabled = false;
            MessageBox.Show("El afiliado se verificó correctamente. Por favor, ingrese el bono consulta a utilizar.");
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            if (txt_Id_Bono.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de Bono Consulta");
                return;
            }
            
            int idPlanAfi = DB.ExecuteCardinal("Select a.afi_IdPlan From LOS_BORBOTONES.Afiliado a where a.afi_IdAfiliado = '"+
                                               txt_Id_Afi.Text + "'");

            DataTable bono = DB.ExecuteReader("Select * From LOS_BORBOTONES.Bono_Consulta b, LOS_BORBOTONES.Afiliado a where b.boco_IdBonoConsulta = '" +
                                               txt_Id_Bono.Text + "' AND a.afi_IdAfiliado = '"+ txt_Id_Afi.Text +"' AND a.afi_IdAfiliado = b.boco_IdAfiliado AND b.boco_Estado = 0");

          

            if (bono.Rows.Count == 0)
            {
                MessageBox.Show("El Nro. de bono " + txt_Id_Bono.Text + " para el afiliado confirmado no existe, expiró o ya ha utilizado su bono.");
                return;
            }


            DateTime fechaActual = Convert.ToDateTime(GetDateTime().ToString()).Date;
            

            foreach (DataRow dr in bono.Rows)
            {
                DateTime fechaBono = Convert.ToDateTime(dr["boco_FechaImpresion"].ToString()).Date;
                if((fechaActual-fechaBono).Days > 60)
                {
                    MessageBox.Show("El bono expiró");
                    int updateBonoC = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Bono_Consulta set boco_Estado = " + 1 + " where boco_IdBonoConsulta = '" + txt_Id_Bono.Text + "'");
                    return;
                }
            }

            int idPlanBono = DB.ExecuteCardinal("Select b.boco_IdPlan From LOS_BORBOTONES.Bono_Consulta b where b.boco_IdBonoConsulta = '"+
                                               txt_Id_Bono.Text + "'");
            
            if (idPlanAfi != idPlanBono)
            {
                MessageBox.Show("El plan del afiliado no es el mismo que el plan del bono consulta.");
                return;
            }

            

            int idConsulta = DB.ExecuteCardinal("Insert into LOS_BORBOTONES.Consulta (con_IdBonoConsulta,con_FechaLlegada,con_Sintomas) values ('"+txt_Id_Bono.Text+"', '"+GetDateTime()+"', ''); select scope_identity()");
            
            
            int updateAfi = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Afiliado set afi_CantidadConsultas = afi_CantidadConsultas+1 where afi_IdAfiliado = '" + txt_Id_Afi.Text + "'");
            int cantConsultas = DB.ExecuteCardinal("Select a.afi_CantidadConsultas From LOS_BORBOTONES.Afiliado a where a.afi_IdAfiliado = '" + txt_Id_Afi.Text + "'");
            
            int updateBonoC2 = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Bono_Consulta set boco_Estado = 'true' , boco_ConsultasAfiliado = '"+cantConsultas+"' where boco_IdBonoConsulta = '" + txt_Id_Bono.Text + "'");
            int updateTurno = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Turno set tur_Estado = 'false' , tur_IdConsulta = " + idConsulta + " where tur_IdTurno = '" + grillaTurno.SelectedRows[0].Cells["IdTurno"].Value.ToString() + "'");
            MessageBox.Show("La consulta se registró existosamente.");
        }

        //Botón Cerrar
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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

         private void Volver_Click(object sender, EventArgs e)
         {
             txt_Id_Bono.Enabled = false;
             txt_Id_Afi.Enabled = true;
             button3.Enabled = true; //botón Buscar
             button4.Enabled = true; //botón Confirmar
             FiltrosProf.Enabled = true;
             grillaTurno.Enabled = true;
         }

         private void txt_Id_Bono_TextChanged(object sender, EventArgs e)
         {
         }

        
    }
}
