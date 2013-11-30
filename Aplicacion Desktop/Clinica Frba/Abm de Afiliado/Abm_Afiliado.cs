using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using Clinica_Frba.GrillaAfiliado;
using System.Data.SqlClient;
using Clinica_Frba.Utils;

namespace Clinica_Frba.Abm_Afiliado
{
    public partial class Amb_Afiliado_Form : Form
    {
        public static Clinica_Frba.DTO.AfiliadoDTO afiliado;
        public static char tipoDeFormularioSecundario;
        public Amb_Afiliado_Form()
        {
            InitializeComponent();
            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        this.Text = "Modificacion de Afiliado";
                        String[] direccion = afiliado.Direccion.Split(' ');
                        String[] fechaNacimiento = afiliado.FechaNacimiento.Split(' ')[0].Split('/');
                        dni.Text = afiliado.Dni;
                        nombre.Text = afiliado.Nombre;
                        apellido.Text = afiliado.Apellido;

                        /*  Buscar una función que discrimine letras de números.
                        if (direccion.Length == 2){
                            calle.Text = direccion[0];
                            nro.Text = direccion[1];
                        }
                        if (direccion.Length == 3){
                            calle.Text = direccion[0] + ' ' + direccion[1];
                            nro.Text = direccion[2];
                        }
                         */
                        telefono.Text = afiliado.Telefono;
                        mail.Text = afiliado.Mail;
                        diaNac.Text = fechaNacimiento[0];
                        mesNac.Text = fechaNacimiento[1];
                        añoNac.Text = fechaNacimiento[2];
                        if (afiliado.Sexo == "M") masculino.Checked = true; else femenino.Checked = true;
                        estadoCivil.SelectedItem = Clases.DB.ExecuteReader("Select esci_Descripcion from LOS_BORBOTONES.EstadoCivil where esci_CodEcivil = '" + afiliado.EstadoCivil + "'");
                    }
                    break;
                case 'A':
                    this.Text = "Alta de Afiliado";
                    afiliado = new AfiliadoDTO();
                    break;
                case 'B':
                    this.Text = "Busqueda de Afiliado";
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
            string fecNac = diaNac.Text  + mesNac.Text + añoNac.Text;
            int tel, nro_estadoCivil;
            long dni_afi;
            int.TryParse(telefono.Text, out tel);
            long.TryParse(dni.Text, out dni_afi);
            string estado_civil = (estadoCivil.SelectedItem != null) ? estadoCivil.SelectedItem.ToString() : "";

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        int valor = Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Afiliado set afi_Nombre = '" + afiliado.Nombre + "',afi_Apellido = '" + 
                            afiliado.Apellido + "', afi_Dni = '" + afiliado.Dni + "',afi_Direccion = '" + afiliado.Direccion + "',afi_Telefono = '" + 
                            afiliado.Telefono + "',afi_Mail = '" + afiliado.Mail + "',afi_FechaNacimiento = '" + afiliado.FechaNacimiento + "',afi_Sexo = '" + 
                            afiliado.Sexo + "',afi_EstadoCivil = '" + afiliado.EstadoCivil + "'"); 
                        MessageBox.Show("El profesional se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'A':
                    {
                        nro_estadoCivil = Clases.DB.ExecuteNonQuery("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Afiliado (afi_EstadoCivil,afi_Nombre,afi_Apellido ,afi_Dni,afi_Direccion,afi_Telefono,afi_Mail,afi_FechaNacimiento,afi_Sexo) 
                        values ( '" + nro_estadoCivil + "','" + nombre.Text + "','" + apellido.Text + "'," + dni_afi + ",'" + calle.Text + " " + nro.Text + "','" + tel + "','" + mail.Text + "','" + fecNac + "','" + sexo + "')");
                        MessageBox.Show("El afiliado se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'B':
                    {
                        nro_estadoCivil = Clases.DB.ExecuteCardinal("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Afiliado where afi_Apellido = '" + apellido.Text +
                            "' OR afi_Nombre = '" + nombre.Text + "' OR afi_Dni = '" + dni_afi + "' OR afi_Telefono = '" + tel +
                            "' OR afi_Mail = '" + mail.Text + "' OR afi_EstadoCivil = '" + nro_estadoCivil + 
                            "' OR afi_Direccion = '" + calle.Text + " " + nro.Text + "' OR afi_Sexo = '" + sexo + "' OR afi_FechaNacimiento = '" + fecNac + "'");

                        foreach (DataRow row in lista.Rows)
                        {
                            afiliado = new Clinica_Frba.DTO.AfiliadoDTO();
                            afiliado.IdAfiliado = row["afi_IdAfiliado"].ToString();
                            afiliado.NombreUsuario = row["afi_NombreUsuario"].ToString();
                            afiliado.Nombre = row["afi_Nombre"].ToString();
                            afiliado.Apellido = row["afi_Apellido"].ToString();
                            afiliado.EstadoCivil = row["afi_EstadoCivil"].ToString();
                            afiliado.IdPlan = row["afi_IdPlan"].ToString();
                            afiliado.Dni = row["afi_Dni"].ToString();
                            afiliado.FechaNacimiento = row["afi_FechaNacimiento"].ToString();
                            afiliado.Mail = row["afi_Mail"].ToString();
                            afiliado.Telefono = row["afi_Telefono"].ToString();
                            afiliado.Direccion = row["afi_Direccion"].ToString();
                            afiliado.Estado = row["afi_Estado"].ToString();
                            afiliado.Sexo = row["afi_Sexo"].ToString();
                            afiliado.CantidadConsultas = row["afi_CantidadConsultas"].ToString();
                            afiliado.CantPersonas = row["afi_CantPersonas"].ToString();
                            GrillaAfiliado.afiliadosAMostrar.Add(afiliado);
                        }
                        GrillaAfiliado.instancia.actualizarListadoAfiliados();                    
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
            validador.esAlfaNumerico(mail);
            validador.esAlfabetico(calle);
            validador.esNumerico(nro);

            radioButtons.Add(masculino);
            radioButtons.Add(femenino);

            validador.hayUnoChequeado("Sexo", radioButtons);
            validador.hayUnoSeleccionado("Estado Civil",estadoCivil);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
