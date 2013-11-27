using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DataTransferObjects;
//using Clinica_Frba.Utils;
//using Clinica_Frba.AbmRol;

namespace Clinica_Frba.AbmProfesional
{
    public partial class FormProfesional : Form
    {
        public static Profesional profesional;
        public static char tipoDeFormularioSecundario;

        public FormProfesional()
        {
            InitializeComponent();

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                {
                    this.Text = "Modificacion de Profesional";
                    String[] direccion = profesional.prof_Direccion.Split(' ');
                    String[] fechaNacimiento = profesional.prof_FechaNacimiento.Split(' ')[0].Split('/');

                    nroMatricula.Text = profesional.prof_Matricula;
                    dni.Text = profesional.prof_Dni;
                    nombre.Text = profesional.prof_Nombre;
                    apellido.Text = profesional.prof_Apellido;
                    calle.Text = direccion[0];
                    if (direccion.Length > 1) nro.Text = direccion[1];
                    telefono.Text = profesional.prof_Telefono;
                    mail.Text = profesional.prof_Mail;
                    añoNac.Text = fechaNacimiento[0];
                    if (direccion.Length > 1) mesNac.Text = fechaNacimiento[1];
                    if (fechaNacimiento.Length > 2) diaNac.Text = fechaNacimiento[2];
                    if (profesional.prof_Sexo == "M") masculino.Checked = true; else femenino.Checked = true;
                }
                break;
                case 'A':
                    this.Text = "Alta de Profesional";
                    profesional = new Profesional();
                break;
                case 'B':
                    this.Text = "Busqueda de Profesional";
                    profesional = new Profesional();
                break;
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox) ((TextBox)control).Text = "";
                if (control is RadioButton) ((RadioButton)control).Checked = false;
            }
        }

        private void validarFormulario()
        {
            Validador validador = Validador.Instance;
            List<RadioButton> radioButtons = new List<RadioButton>();

            foreach (Control control in Controls)
                if (control is TextBox) validador.estaVacioOEsNulo((TextBox)control);

            validador.esNumerico(nroMatricula);
            validador.esNumerico(dni);
            validador.esAlfabetico(nombre);
            validador.esAlfabetico(apellido);
            validador.esNumerico(diaNac);
            validador.esNumerico(mesNac);
            validador.esNumerico(añoNac);
            validador.esNumerico(telefono);
            validador.esAlfaNumerico(mail);
            validador.esAlfabetico(calle);
            validador.esNumerico(nro);

            radioButtons.Add(masculino);
            radioButtons.Add(femenino);

            validador.hayUnoChequeado("Sexo", radioButtons);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
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

            SqlServerDAO<Profesional, Profesional> daoProfesional = SqlServerDAO<Profesional, Profesional>.Instance;
                        
            profesional.prof_Matricula = nroMatricula.Text;
            profesional.prof_NombreUsuario = dni.Text;
            profesional.prof_Dni = dni.Text;
            profesional.prof_Nombre = nombre.Text;
            profesional.prof_Apellido = apellido.Text;
            profesional.prof_Direccion = calle.Text + " " + nro.Text;
            profesional.prof_Telefono = telefono.Text;
            profesional.prof_Mail = mail.Text;
            profesional.prof_Telefono = telefono.Text;
            profesional.prof_FechaNacimiento = diaNac.Text + "-" + mesNac.Text + "-" + añoNac.Text;
            profesional.prof_Sexo = (masculino.Checked) ? "M" : "F";

            daoProfesional.TransObjInput = profesional;
            
            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                {
                    daoProfesional.modificacion();
                    MessageBox.Show("El profesional se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                break;
                case 'A':
                {
                    daoProfesional.alta();
                    MessageBox.Show("El profesional se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                break;
                case 'B':
                {
                    this.Text = "Busqueda de Profesional";
                    profesional.prof_NombreUsuario = null;
                    profesional.prof_FechaNacimiento = ("--" == profesional.prof_FechaNacimiento) ? null : profesional.prof_FechaNacimiento;
                    profesional.prof_Sexo = ("F" == profesional.prof_Sexo) ? null : profesional.prof_Sexo;
                    profesional.prof_Direccion = (" " == profesional.prof_Direccion) ? null : profesional.prof_Direccion;
                    GrillaProfesional.profesionalesAMostrar = daoProfesional.busqueda();
                    GrillaProfesional.instancia.actualizarListadoDeProfesionales();
                }
                break;
            }
            
            Close();
        }

        private void AbmProfesionalSecundario_Load(object sender, EventArgs e)
        {

        }
    }
}
