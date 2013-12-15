using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Utils;
using Clinica_Frba.DTO;
using Clinica_Frba.Clases;
using System.Security.Cryptography;

namespace Clinica_Frba.Login
{
    public partial class Login_Form : Form
    {
        public string nombreUsuario;

        public Login_Form()
        {
            InitializeComponent();

        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            if (TB_Usuario.Text == "" || TB_Contraseña.Text == "")
            {
                MessageBox.Show("Falta completar datos.");
                return;
            }

           
            DataTable dt = DB.ExecuteReader("SELECT * FROM LOS_BORBOTONES.Usuario WHERE usu_IdUsuario = '" + TB_Usuario.Text + "' " +
                "AND usu_Password = '" + encriptar(TB_Contraseña.Text) + "' ");

          

            if (dt.Rows.Count == 0)
            {
                DataTable dt2 = DB.ExecuteReader("Select * From LOS_BORBOTONES.Usuario WHERE usu_IdUsuario = '" + TB_Usuario.Text + "' ");

                string estadoUsu2 = "True";
                foreach (DataRow dr in dt2.Rows)
                {
                    estadoUsu2 = dr["usu_Estado"].ToString();
                }

                //false está activo. True está bloqueado.
                if (estadoUsu2 == "False")
                {
                if (dt2.Rows.Count != 0)
                {

                    int updateIntentos = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Usuario set usu_IntentosFallidos = usu_IntentosFallidos + 1 where usu_IdUsuario = '" + TB_Usuario.Text + "'");

                    int intentos = DB.ExecuteCardinal("Select usu_IntentosFallidos From LOS_BORBOTONES.Usuario where usu_IdUsuario = '" + TB_Usuario.Text + "'");


                    if (intentos == 3)
                    {
                        //esto tmb lo hace un trigger.
                        int updateUsuEstado = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Usuario set usu_Estado = 1 where usu_IdUsuario = '" + TB_Usuario.Text + "'");
                        MessageBox.Show("Ha llegado al máximo de intentos posibles. Por favor para volver a activar su cuenta contáctese con un administrador.");
                        return;
                    }

                    MessageBox.Show("La contraseña es incorrecta");
                    return;
                    }

                MessageBox.Show("El usuario es inexistente.");
                return;
                }

                if (dt2.Rows.Count != 0)
                {
                    MessageBox.Show("El usuario ha sido bloqueado. Por favor para volver a activar su cuenta contáctese con un administrador.");
                    return;
                }

               MessageBox.Show("El usuario es inexistente.");
                return;
                }
            

            string estadoUsu = "";
            foreach (DataRow dr in dt.Rows)
            {
                estadoUsu = dr["usu_Estado"].ToString();
            }

            if (estadoUsu == "True")
            {
                MessageBox.Show("El usuario ha sido bloqueado. Por favor para volver a activar su cuenta contáctese con un administrador.");
                return;
            }

            int updateIntentos2 = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Usuario set usu_IntentosFallidos = 0 where usu_IdUsuario = '" + TB_Usuario.Text + "'");
            
            nombreUsuario = TB_Usuario.Text;
            DialogResult = DialogResult.OK;

        }
        
        private string encriptar(string _pass)
        {
            SHA256Managed hashstring = new SHA256Managed();

            byte[] bytes = Encoding.Unicode.GetBytes(_pass);
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;

            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }

            return hashString;
                    
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
