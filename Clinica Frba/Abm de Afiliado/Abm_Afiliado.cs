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
                        calle.Text = afiliado.Direccion;
                        telefono.Text = afiliado.Telefono;
                        mail.Text = afiliado.Mail;
                        plan.Text = afiliado.IdPlan;
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
            string fecNac = añoNac.Text + diaNac.Text + mesNac.Text;
            int tel, nro_estadoCivil;
            long dni_afi,idPlan;
            int.TryParse(telefono.Text, out tel);
            long.TryParse(dni.Text, out dni_afi);
            long.TryParse(plan.Text, out idPlan);
            string estado_civil = (estadoCivil.SelectedItem != null) ? estadoCivil.SelectedItem.ToString() : "";

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        nro_estadoCivil = Clases.DB.ExecuteCardinal("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Afiliado set afi_Nombre = '" + nombre.Text + "',afi_Apellido = '" + 
                            apellido.Text  + "',afi_Direccion = '" + calle.Text + "',afi_Telefono = '" + afiliado.Telefono + "',afi_Mail = '" + mail.Text +
                            afiliado.Sexo + "',afi_IdPlan = '" + idPlan + "',afi_EstadoCivil = '" + nro_estadoCivil + "' where afi_Dni = '" + long.Parse(afiliado.Dni) + "'"); 
                        MessageBox.Show("El Afiliado se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'A':
                    {
                        DataTable dt_plan  = Clases.DB.ExecuteReader("Select 1 from LOS_BORBOTONES.Plan_Medico where plan_IdPlan = '" + idPlan + "'");
                        if (dt_plan.Rows.Count == 0)
                        {
                            MessageBox.Show("El Plan ingresado no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        nro_estadoCivil = Clases.DB.ExecuteCardinal("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Afiliado (afi_IdPlan,afi_EstadoCivil,afi_Nombre,afi_Apellido ,afi_Dni,afi_Direccion,afi_Telefono,afi_Mail,afi_FechaNacimiento,afi_Sexo) 
                        values ( '" + idPlan + "','" + nro_estadoCivil + "','" + nombre.Text + "','" + apellido.Text + "'," + dni_afi + ",'" + calle.Text + "','" + tel + "','" + mail.Text + "','" + fecNac + "','" + sexo + "')");
                        MessageBox.Show("El Afiliado se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'B':
                    {
                        GrillaAfiliado_Form.afiliadosAMostrar.Clear();
                        if (estado_civil == "")
                        {
                            nro_estadoCivil = 0;
                        }
                        else nro_estadoCivil = Clases.DB.ExecuteCardinal("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");   
                        var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Afiliado where afi_Apellido = '" + apellido.Text +
                            "' OR afi_Nombre = '" + nombre.Text + "' OR afi_Dni = '" + dni_afi + "' OR afi_Telefono = '" + tel +
                            "' OR afi_Mail = '" + mail.Text + "' OR afi_EstadoCivil = '" + nro_estadoCivil + "' OR afi_IdPlan = '" + idPlan +
                            "' OR afi_Direccion = '" + calle.Text + "' OR afi_Sexo = '" + sexo + "' OR afi_FechaNacimiento = '" + fecNac + "'");

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
                            GrillaAfiliado_Form.afiliadosAMostrar.Add(afiliado);
                        }
                        GrillaAfiliado_Form.instancia.actualizarListadoAfiliados();                    
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
            validador.esNumerico(plan);
            validador.esNumerico(diaNac);
            validador.esNumerico(mesNac);
            validador.esNumerico(añoNac);
            validador.esNumerico(telefono);
            validador.esMail(mail);
            validador.esAlfaNumerico(calle);

            radioButtons.Add(masculino);
            radioButtons.Add(femenino);

            validador.hayUnoChequeado("Sexo", radioButtons);
            validador.hayUnoSeleccionado("Estado Civil",estadoCivil);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void añoNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_Año_Click(object sender, EventArgs e)
        {

        }

        private void mesNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_Mes_Click(object sender, EventArgs e)
        {

        }

        private void diaNac_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
