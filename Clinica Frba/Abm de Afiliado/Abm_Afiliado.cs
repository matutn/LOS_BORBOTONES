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
        public static int idAfi;
        public static int countFamiliar;

        public Amb_Afiliado_Form()
        {
            InitializeComponent();
            DataTable planes = Clases.DB.ExecuteReader("Select plan_IdPlan from LOS_BORBOTONES.Plan_Medico order by 1");
            DataRow row = planes.NewRow();
            row["plan_IdPlan"] = DBNull.Value;
            planes.Rows.InsertAt(row, 0);
            combo_Plan.DataSource = planes;
            combo_Plan.DisplayMember = planes.Columns["plan_IdPlan"].ToString();
            combo_Plan.ValueMember = planes.Columns["plan_IdPlan"].ToString();
            
            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        this.Text = "Modificacion de Afiliado";
                        String[] direccion = afiliado.Direccion.Split(' ');
                        dateTime_Nac.Text = Convert.ToDateTime(afiliado.FechaNacimiento).ToString().Split(' ')[0];
                        tipoDni.Text = afiliado.TipoDni;
                        dni.Text = afiliado.Dni;
                        nombre.Text = afiliado.Nombre;
                        apellido.Text = afiliado.Apellido;
                        direc.Text = afiliado.Direccion;
                        telefono.Text = afiliado.Telefono;
                        mail.Text = afiliado.Mail;
                        cantFamiliares.Text = afiliado.CantPersonas;
                        combo_Plan.SelectedValue = afiliado.IdPlan;
                        if (afiliado.Sexo == "M") masculino.Checked = true; else femenino.Checked = true;
                        DataTable dt_estadoCivil = Clases.DB.ExecuteReader("Select esci_Descripcion from LOS_BORBOTONES.EstadoCivil where esci_CodEcivil = '" + afiliado.EstadoCivil + "'");
                        if (dt_estadoCivil.Rows.Count > 0)
                        {
                            estadoCivil.SelectedItem = dt_estadoCivil.Rows[0]["esci_Descripcion"];
                        }
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
            int tel, nro_estadoCivil;
            DataTable dt_estCiv;
            long dni_afi;
            int.TryParse(telefono.Text, out tel);
            long.TryParse(dni.Text, out dni_afi);
            string estado_civil = (estadoCivil.SelectedItem != null) ? estadoCivil.SelectedItem.ToString() : "";

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {
                        if (combo_Plan.SelectedValue.ToString() == "")
                        {
                            MessageBox.Show("Debe ingresar un Plan Médico", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        dt_estCiv = Clases.DB.ExecuteReader("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Afiliado set afi_TipoDni='" + tipoDni.Text + "',afi_Direccion = '" + direc.Text + "',afi_Telefono = '" + telefono.Text + "',afi_Mail = '" + mail.Text +
                            afiliado.Sexo + "',afi_IdPlan = '" + combo_Plan.SelectedValue + "',afi_EstadoCivil = '" + dt_estCiv.Rows[0]["esci_CodEcivil"] + "', afi_CantidadConsultas = " + 0 + " where afi_Dni = '" + long.Parse(afiliado.Dni) + "'"); 
                        MessageBox.Show("El Afiliado se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'A':
                    {
                        
                        DataTable dt_dni = Clases.DB.ExecuteReader("Select 1 from LOS_BORBOTONES.Afiliado where afi_Dni = '" + dni_afi + "'");
                        if (dt_dni.Rows.Count > 0)
                        {
                            MessageBox.Show("El Dni ingresado ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (combo_Plan.SelectedValue.ToString() == "")
                        {
                            MessageBox.Show("Debe ingresar un Plan Médico", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        dt_estCiv = Clases.DB.ExecuteReader("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Afiliado (afi_IdPlan,afi_EstadoCivil,afi_Nombre,afi_Apellido ,afi_TipoDni,afi_Dni,afi_Direccion,afi_Telefono,afi_Mail,afi_FechaNacimiento,afi_Sexo,afi_CantPersonas) 
                        values ( '" + combo_Plan.SelectedValue + "','" + dt_estCiv.Rows[0]["esci_CodEcivil"] + "','" + nombre.Text + "','" + apellido.Text + "','" + tipoDni.Text + "'," + dni_afi + ",'" + direc.Text + "','" + tel + "','" + mail.Text + "','" + dateTime_Nac.Value.ToString("yyyy-MM-dd") + "','" + sexo + "'," + cantFamiliares.Text + ")");
                        MessageBox.Show("El Afiliado se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable dt_idAfi = Clases.DB.ExecuteReader("Select afi_IdAfiliado from LOS_BORBOTONES.Afiliado where afi_Dni =" + dni_afi);
                        if (Convert.ToInt16(cantFamiliares.Text) > 0 || Convert.ToInt32(dt_estCiv.Rows[0]["esci_CodECivil"]) == 4)
                        {
                            Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Afiliado set afi_IdFamiliar = '" + dt_idAfi.Rows[0]["afi_IdAfiliado"] + "01' where afi_IdAfiliado = " + Convert.ToInt32(dt_idAfi.Rows[0]["afi_IdAfiliado"]));
                            MessageBox.Show("Proceda a cargar los datos de los familiares", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Amb_Afiliado_Form.countFamiliar = 1;
                        for (int hijos = 1; hijos <= Convert.ToInt16(cantFamiliares.Text); hijos++)
                        {
                            Amb_Afiliado_Form.tipoDeFormularioSecundario = 'F';
                            
                            Amb_Afiliado_Form.idAfi = Convert.ToInt32(dt_idAfi.Rows[0]["afi_IdAfiliado"]);
                            (new Amb_Afiliado_Form() { Text = "Alta de Familiar" }).Show();
                        }
                        if (Convert.ToInt32(dt_estCiv.Rows[0]["esci_CodECivil"]) == 4)
                        {
                            Amb_Afiliado_Form.tipoDeFormularioSecundario = 'F';
                            Amb_Afiliado_Form.idAfi = Convert.ToInt32(dt_idAfi.Rows[0]["afi_IdAfiliado"]);
                            (new Amb_Afiliado_Form() { Text = "Alta de Familiar" }).Show();
                        }
                    }
                    break;
                case 'B':
                    {
                        GrillaAfiliado_Form.afiliadosAMostrar.Clear();
                        if (estado_civil == "")
                        {
                            nro_estadoCivil = 0;
                        }
                        else
                        {
                            dt_estCiv = Clases.DB.ExecuteReader("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                            nro_estadoCivil = Convert.ToInt16(dt_estCiv.Rows[0]["esci_CodEcivil"]);
                        }
                        int comboPlanValue = 0;
                        if (combo_Plan.SelectedValue == null)
                        {
                            return;
                        }
                        if (combo_Plan.SelectedValue.ToString() == "")
                        {
                            comboPlanValue = 0;
                        }
                        else comboPlanValue = Convert.ToInt32(combo_Plan.SelectedValue);
                        var lista = Clases.DB.ExecuteReader("Select * ,isNull(afi_CantPersonas,0) afiCantPersonas from LOS_BORBOTONES.Afiliado where afi_Apellido = '" + apellido.Text +
                            "' OR afi_Nombre = '" + nombre.Text + "' OR afi_Dni = '" + dni_afi + "' OR afi_Telefono = '" + tel +
                            "' OR afi_Mail = '" + mail.Text + "' OR afi_EstadoCivil = '" + nro_estadoCivil + "' OR afi_IdPlan = '" + comboPlanValue +
                            "' OR afi_Direccion = '" + direc.Text + "' OR afi_Sexo = '" + sexo + "' OR afi_TipoDni = '" + tipoDni.Text + "' OR afi_FechaNacimiento ='" + dateTime_Nac.Value.ToString("yyyy-MM-dd") + "' OR afi_CantPersonas ='" + cantFamiliares.Text + "'");

                        foreach (DataRow row in lista.Rows)
                        {
                            afiliado = new Clinica_Frba.DTO.AfiliadoDTO();
                            afiliado.IdAfiliado = row["afi_IdAfiliado"].ToString();
                            afiliado.NombreUsuario = row["afi_NombreUsuario"].ToString();
                            afiliado.Nombre = row["afi_Nombre"].ToString();
                            afiliado.Apellido = row["afi_Apellido"].ToString();
                            afiliado.EstadoCivil = row["afi_EstadoCivil"].ToString();
                            afiliado.IdPlan = row["afi_IdPlan"].ToString();
                            afiliado.TipoDni = row["afi_TipoDni"].ToString();
                            afiliado.Dni = row["afi_Dni"].ToString();
                            afiliado.FechaNacimiento = row["afi_FechaNacimiento"].ToString();
                            afiliado.Mail = row["afi_Mail"].ToString();
                            afiliado.Telefono = row["afi_Telefono"].ToString();
                            afiliado.Direccion = row["afi_Direccion"].ToString();
                            afiliado.Estado = row["afi_Estado"].ToString();
                            afiliado.Sexo = row["afi_Sexo"].ToString();
                            afiliado.CantidadConsultas = row["afi_CantidadConsultas"].ToString();
                            afiliado.CantPersonas = row["afiCantPersonas"].ToString();
                            GrillaAfiliado_Form.afiliadosAMostrar.Add(afiliado);
                        }
                        GrillaAfiliado_Form.instancia.actualizarListadoAfiliados();                    
                    }
                    break;
                case 'F':
                    {
                        countFamiliar++;
                        DataTable dt_dni = Clases.DB.ExecuteReader("Select 1 from LOS_BORBOTONES.Afiliado where afi_Dni = '" + dni_afi + "'");
                        if (dt_dni.Rows.Count > 0)
                        {
                            MessageBox.Show("El Dni ingresado ya existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        dt_estCiv = Clases.DB.ExecuteReader("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Afiliado (afi_IdFamiliar,afi_IdPlan,afi_EstadoCivil,afi_Nombre,afi_Apellido ,afi_TipoDni,afi_Dni,afi_Direccion,afi_Telefono,afi_Mail,afi_FechaNacimiento,afi_Sexo,afi_CantidadConsultas) 
                        values ( '" + idAfi + "0" + countFamiliar + "','" + combo_Plan.SelectedValue + "','" + dt_estCiv.Rows[0]["esci_CodEcivil"] + "','" + nombre.Text + "','" + apellido.Text + "','" + tipoDni.Text + "'," + dni_afi + ",'" + direc.Text + "','" + tel + "','" + mail.Text + "','" + dateTime_Nac.Value.ToString("yyyy-MM-dd") + "','" + sexo + "'," + 0 + ")");
                        MessageBox.Show("El Familiar se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
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

        private void FormAfiliado_Load(object sender, EventArgs e)
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
            validador.esAlfabetico(tipoDni);
            validador.esNumerico(telefono);
            validador.esNumerico(cantFamiliares);
            validador.esMail(mail);
            validador.esAlfaNumerico(direc);

            radioButtons.Add(masculino);
            radioButtons.Add(femenino);

            validador.hayUnoChequeado("Sexo", radioButtons);
            validador.hayUnoSeleccionado("Estado Civil",estadoCivil);
        }

        private void combo_Plan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



    }
}
