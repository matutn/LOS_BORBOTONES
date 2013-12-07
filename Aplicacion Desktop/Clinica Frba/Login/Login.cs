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
                MessageBox.Show("El usuario y/o la contraseña son incorrectas.");
                return;
            }

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

    }
}
