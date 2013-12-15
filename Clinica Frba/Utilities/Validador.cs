using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System.Security.Cryptography;
//using Clinica_Frba.DataAccesObjects;
using Clinica_Frba.DTO;

namespace Clinica_Frba.Utils
{
    class Validador
    {
        private static Validador instance;
        private List<String> errores;


        public Validador()
        {
            this.errores = new List<String>();
        }

        public static Validador Instance
        {
            get
            {
                if (instance == null) instance = new Validador();
                return instance;
            }
        }

        public void estaVacioOEsNulo(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text.Replace(" ", "")))
            {
                errores.Add("El campo <" + textBox.Tag + "> esta vacio o es nulo");
                return;
            }
        }

        public void esNumerico(TextBox textBox)
        {

            if (!this.esNumerico(textBox.Text))
            {

                errores.Add("El campo <" + textBox.Tag + "> no es numerico");
            }

        }

        public void esMail(TextBox textBox)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(textBox.Text);
            }
            catch
            {
                errores.Add("El campo <" + textBox.Tag + "> no es un mail");
                return;
            }
        }

        public void esAlfabetico(TextBox textBox)
        {
            String text = textBox.Text;

            foreach (char car in text)
            {
                if (!Char.IsLetter(car) && ' ' != car)
                {
                    errores.Add("El campo <" + textBox.Tag + "> no es alfabetico");
                    return;
                }
            }
        }

        public void esAlfaNumerico(TextBox textBox)
        {
            String text = textBox.Text;

            foreach (char car in text)
            {
                if (!Char.IsLetterOrDigit(car) && ' ' != car)
                {
                    errores.Add("El campo <" + textBox.Tag + "> no es alfanumerico");
                    return;
                }
            }
        }

        public void hayUnoChequeado(String nombreCampo, List<RadioButton> radioButtons)
        {
            bool bandera = true;

            foreach (RadioButton radioButton in radioButtons)
                if (!(bandera &= !radioButton.Checked))
                    return;
            errores.Add("No se selecciono ninguna opcion para el campo <" + nombreCampo + ">");
        }

        public void mostrarErrores()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Ocurrieron algunos errores de validacion:\n\n");
            foreach (String error in errores)
                stringBuilder.Append(error + "\n");

            MessageBox.Show(stringBuilder.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            errores.Clear();

        }

        private bool esNumerico(String cadena)
        {
            foreach (char car in cadena)
            {
                if (!Char.IsDigit(car))
                {
                    return false;
                }
            }
            return true;
        }

        public void esElementoFechaValida(TextBox textBox, int limiteInferior, int limiteSuperior)
        {

            String text = textBox.Text;
            if (this.esNumerico(text) && text != "")
            {

                int num = int.Parse(text);
                if (num > limiteSuperior || num < limiteInferior)
                {
                    errores.Add("El campo <" + textBox.Tag + "> no pertenece a un rango valido");
                }

            }
        }

        public bool hayErrores()
        {
            return this.errores.Count != 0;
        }

        public void agregarError(String error)
        {
            this.errores.Add(error);
        }

        public void hayUnoSeleccionado(string nombreCampo, ComboBox estadoCivil)
        {
            if (estadoCivil.SelectedItem == null)
            {
                errores.Add("No se selecciono ninguna opcion para el campo <" + nombreCampo + ">");
            }
        }
    }
}