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
            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        this.Text = "Modificacion de Profesional";
                        String[] direccion = profesional.Direccion.Split(' ');
                        String[] fechaNacimiento = profesional.FechaNacimiento.Split(' ')[0].Split('/');
                        dni.Text = profesional.Dni;
                        nombre.Text = profesional.Nombre;
                        apellido.Text = profesional.Apellido;
                        calle.Text = profesional.Direccion;
                        telefono.Text = profesional.Telefono;
                        mail.Text = profesional.Mail;
                        matricula.Text = profesional.NroMatricula;
                        diaNac.Text = fechaNacimiento[0];
                        mesNac.Text = fechaNacimiento[1];
                        añoNac.Text = fechaNacimiento[2];
                        if (profesional.Sexo == "M") masculino.Checked = true; else femenino.Checked = true;
                    }
                    break;
                case 'A':
                    this.Text = "Alta de Profesional";
                    profesional = new ProfesionalDTO();
                    break;
                case 'B':
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
            string fecNac = añoNac.Text + diaNac.Text + mesNac.Text;
            int tel, matr = 0;
            long dni_prof,idPlan;
            int.TryParse(telefono.Text, out tel);
            long.TryParse(dni.Text, out dni_prof);

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        int valor = Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Profesional set prof_Nombre = '" + nombre.Text + "',prof_Apellido = '" +
                            apellido.Text + "',prof_Direccion = '" + calle.Text + "',prof_Telefono = '" + profesional.Telefono + "',prof_Mail = '" + mail.Text +
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
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Profesional (prof_Matricula,prof_Nombre,prof_Apellido ,prof_Dni,prof_Direccion,prof_Telefono,prof_Mail,prof_FechaNacimiento,prof_Sexo) 
                        values ( '" + matricula.Text + "','" + nombre.Text + "','" + apellido.Text + "'," + dni_prof + ",'" + calle.Text + "','" + tel + "','" + mail.Text + "','" + fecNac + "','" + sexo + "')");
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
                        var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Profesional where prof_Apellido = '" + apellido.Text +
                            "' OR prof_Nombre = '" + nombre.Text + "' OR prof_Dni = '" + dni_prof + "' OR prof_Telefono = '" + tel +
                            "' OR prof_Mail = '" + mail.Text + "' OR prof_Matricula = '" + matr +
                            "' OR prof_Direccion = '" + calle.Text + "' OR prof_Sexo = '" + sexo + "' OR prof_FechaNacimiento = '" + fecNac + "'");

                        foreach (DataRow row in lista.Rows)
                        {
                            profesional = new Clinica_Frba.DTO.ProfesionalDTO();
                            profesional.IdProfesional = row["prof_IdProfesional"].ToString();
                            profesional.NombreUsuario = row["prof_NombreUsuario"].ToString();
                            profesional.Nombre = row["prof_Nombre"].ToString();
                            profesional.Apellido = row["prof_Apellido"].ToString();
                            profesional.NroMatricula = row["prof_Matricula"].ToString();
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
            validador.esNumerico(dni);
            validador.esNumerico(diaNac);
            validador.esNumerico(mesNac);
            validador.esNumerico(añoNac);
            validador.esNumerico(telefono);
            validador.esMail(mail);
            validador.esAlfaNumerico(calle);

            radioButtons.Add(masculino);
            radioButtons.Add(femenino);

            validador.hayUnoChequeado("Sexo", radioButtons);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
