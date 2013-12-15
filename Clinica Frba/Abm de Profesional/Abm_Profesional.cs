using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using System.Data.SqlClient;
using Clinica_Frba.Utils;
using Clinica_Frba.GrillaAfiliado;
using Clinica_Frba.GrillaProfesional;

namespace Clinica_Frba.Abm_Profesional
{
    public partial class Amb_Profesional_Form : Form
    {
        public static Clinica_Frba.DTO.ProfesionalDTO profesional;
        public static char tipoDeFormularioSecundario;
        public Amb_Profesional_Form()
        {
            InitializeComponent();
            DataTable dt_especialidadesExistentes = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Especialidad");
            combo_Especialidad.DataSource = dt_especialidadesExistentes;
            combo_Especialidad.DisplayMember = dt_especialidadesExistentes.Columns["esp_Descripcion"].ToString();
            combo_Especialidad.ValueMember = dt_especialidadesExistentes.Columns["esp_CodEspecialidad"].ToString();
            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        button_CargarEspecialidad.Hide();
                        this.Text = "Modificacion de Profesional";
                        String[] direccion = profesional.Direccion.Split(' ');
                        dateTime_Nac.Text = Convert.ToDateTime(profesional.FechaNacimiento).ToString().Split(' ')[0];
                        tipoDni.Text = profesional.TipoDni;
                        dni.Text = profesional.Dni;
                        nombre.Text = profesional.Nombre;
                        apellido.Text = profesional.Apellido;
                        direc.Text = profesional.Direccion;
                        telefono.Text = profesional.Telefono;
                        mail.Text = profesional.Mail;
                        matricula.Text = profesional.NroMatricula;
                        if (profesional.Sexo == "M") masculino.Checked = true; else femenino.Checked = true;
                        DataTable dt_id = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Profesional where prof_Dni = '" + Convert.ToInt64(profesional.Dni) + "'");
                        DataTable dt_espProf = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Especialidad_Profesional where espr_IdProfesional = " + dt_id.Rows[0]["prof_IdProfesional"]);
                        foreach( DataRow row in dt_espProf.Rows)
                        {
                            DataTable dt_e = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Especialidad where esp_CodEspecialidad = " + row["espr_CodEspecialidad"]);
                            especialidadesCargadas.Items.Add(dt_e.Rows[0]["esp_Descripcion"]);
                        }
                    }
                    break;
                case 'A':
                    this.Text = "Alta de Profesional";
                    profesional = new ProfesionalDTO();
                    break;
                case 'B':
                    button_CargarEspecialidad.Hide();
                    this.Text = "Busqueda de Profesional";
                    break;
            }
        }

        private void FormAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (tipoDeFormularioSecundario != 'B')
            {
                this.validarFormulario();
                if (Validador.Instance.hayErrores())
                {
                    Validador.Instance.mostrarErrores();
                    return;
                }
            }
            string sexo = (masculino.Checked) ? "M" : "F";
            int tel, matr = 0;
            long dni_prof;
            int.TryParse(telefono.Text, out tel);
            long.TryParse(dni.Text, out dni_prof);

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        int valor = Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Profesional set prof_TipoDni = '" + tipoDni.Text + 
                            "',prof_Direccion = '" + direc.Text + "',prof_Telefono = '" + telefono.Text + "',prof_Mail = '" + mail.Text +
                            profesional.Sexo + "' where prof_Dni = '" + long.Parse(profesional.Dni) + "'");
                        MessageBox.Show("El Profesional se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'A':
                    {
                        if (matricula.Text == "")
                        {
                            MessageBox.Show("La matricula no puede tener valor cero", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        DataTable dt_matricula = Clases.DB.ExecuteReader("Select 1 from LOS_BORBOTONES.Profesional where prof_Matricula = '" + matricula.Text + "'");
                        if (dt_matricula.Rows.Count > 0)
                        {
                            MessageBox.Show("La matricula ingresado ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (especialidadesCargadas.Items.Count == 0)
                        {
                            MessageBox.Show("Debe ingregar al menos una Especialidad", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        DataTable dt_dni = Clases.DB.ExecuteReader("Select 1 from LOS_BORBOTONES.Profesional where prof_Dni = '" + dni_prof + "'");
                        if (dt_dni.Rows.Count > 0)
                        {
                            MessageBox.Show("El Dni ingresado ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Profesional (prof_Matricula,prof_Nombre,prof_Apellido,prof_TipoDni,prof_Dni,prof_Direccion,prof_Telefono,prof_Mail,prof_FechaNacimiento,prof_Sexo) 
                        values ( '" + matricula.Text + "','" + nombre.Text + "','" + apellido.Text + "','" + tipoDni.Text + "'," + dni_prof + ",'" + direc.Text + "','" + tel + "','" + mail.Text + "','" + dateTime_Nac.Value.ToString("yyyy-MM-dd") + "','" + sexo + "')");
                        Array array_especialidad = especialidadesCargadas.Items.ToArray();
                        DataTable dt_idprof = Clases.DB.ExecuteReader("Select prof_IdProfesional from LOS_BORBOTONES.Profesional where prof_Dni = " + dni_prof);
                        foreach (string array in array_especialidad)
                        {
                            DataTable dt_esp = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Especialidad where esp_Descripcion = '" + array + "'");
                            Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Especialidad_Profesional (espr_CodEspecialidad,espr_IdProfesional) values (" + dt_esp.Rows[0]["esp_CodEspecialidad"] + "," + dt_idprof.Rows[0]["prof_IdProfesional"] + ")");
                        }
                        MessageBox.Show("El Profesional se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    }
                    break;
                case 'B':
                    {
                        GrillaProfesional_Form.profesionalesAMostrar.Clear();
                        if (matricula.Text == "")
                        {
                            matr = -1;
                        }
                        else matr = Convert.ToInt32(matricula.Text);
                        var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Profesional where prof_Apellido = '" + apellido.Text +
                            "' OR prof_Nombre = '" + nombre.Text + "' OR prof_Dni = '" + dni_prof + "' OR prof_Telefono = '" + tel +
                            "' OR prof_Mail = '" + mail.Text + "' OR prof_Matricula = " + matr +
                            " OR prof_Direccion = '" + direc.Text + "' OR prof_Sexo = '" + sexo + "' OR prof_TipoDni = '" + tipoDni.Text + "' OR prof_FechaNacimiento = '" + dateTime_Nac.Value.ToString("yyyy-MM-dd") + "'");

                        foreach (DataRow row in lista.Rows)
                        {
                            profesional = new Clinica_Frba.DTO.ProfesionalDTO();
                            profesional.IdProfesional = row["prof_IdProfesional"].ToString();
                            profesional.NombreUsuario = row["prof_NombreUsuario"].ToString();
                            profesional.Nombre = row["prof_Nombre"].ToString();
                            profesional.Apellido = row["prof_Apellido"].ToString();
                            profesional.NroMatricula = row["prof_Matricula"].ToString();
                            profesional.TipoDni = row["prof_TipoDni"].ToString();
                            profesional.Dni = row["prof_Dni"].ToString();
                            profesional.FechaNacimiento = row["prof_FechaNacimiento"].ToString();
                            profesional.Mail = row["prof_Mail"].ToString();
                            profesional.Telefono = row["prof_Telefono"].ToString();
                            profesional.Direccion = row["prof_Direccion"].ToString();
                            profesional.Estado = row["prof_Estado"].ToString();
                            profesional.Sexo = row["prof_Sexo"].ToString();
                            GrillaProfesional_Form.profesionalesAMostrar.Add(profesional);
                        }
                        GrillaProfesional_Form.instancia.actualizarListadoProfesionales();                    
                    }
                    break;
            }

            Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox) ((TextBox)control).Text = "";
                if (control is RadioButton) ((RadioButton)control).Checked = false;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LDni_Click(object sender, EventArgs e)
        {

        }

        private void validarFormulario()
        {
            Validador validador = Validador.Instance;
            List<RadioButton> radioButtons = new List<RadioButton>();
            foreach (Control control in Controls)
                if (control is TextBox) validador.estaVacioOEsNulo((TextBox)control);
           
            validador.esAlfabetico(nombre);
            validador.esAlfabetico(apellido);
            validador.esAlfabetico(tipoDni);
            validador.esNumerico(dni);
            validador.esNumerico(matricula);
            validador.esNumerico(telefono);
            validador.esMail(mail);
            validador.esAlfaNumerico(direc);

            radioButtons.Add(masculino);
            radioButtons.Add(femenino);

            validador.hayUnoChequeado("Sexo", radioButtons);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codEsp = Convert.ToInt32(combo_Especialidad.SelectedValue);
            DataTable dt_esp = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Especialidad where esp_CodEspecialidad = " + codEsp);
            
            Array array_esp = especialidadesCargadas.Items.ToArray();
            int count = 0;
            foreach (string arr in array_esp)
            {
                if (arr == dt_esp.Rows[0]["esp_Descripcion"].ToString())
                {
                    count++;
                }
            }
            if (count == 0)
            {
                especialidadesCargadas.Items.Add(dt_esp.Rows[0]["esp_Descripcion"]);
            }
        }

        private void dateTime_Nac_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
