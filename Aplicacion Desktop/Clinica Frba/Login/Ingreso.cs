using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using Clinica_Frba.Clases;

namespace Clinica_Frba.Login
{
    public partial class Ingreso : Form
    {
        string rol;
        List<Rol_DTO> roles = new List<Rol_DTO>();

        public Ingreso()
        {
            InitializeComponent();

            Login_Form login = new Login_Form();
            if (login.ShowDialog() != DialogResult.OK)
                this.Close();

            DataTable dt = DB.ExecuteReader("Select r.rol_CodRol rol_CodRol,r.rol_nombre rol_nombre,r.rol_Estado rol_Estado From LOS_BORBOTONES.Rol_Usuario ru JOIN LOS_BORBOTONES.Rol r ON r.rol_CodRol = ru.rous_CodRol where ru.rous_IdUsuario = '"+login.nombreUsuario+"' AND ru.rous_Estado = 1 AND r.rol_Estado = 1");

            List<Rol_DTO> roles = new List<Rol_DTO>();

            foreach (DataRow dr in dt.Rows)
            {


                roles.Add(new Rol_DTO(dr["rol_CodRol"].ToString(),
                                      dr["rol_nombre"].ToString(),
                                      dr["rol_Estado"].ToString()));
            }

        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            LB_Roles.Items.AddRange(roles.ToArray());
        }

        private void B_Entrar_Click(object sender, EventArgs e)
        {
            if (LB_Roles.SelectedItems.Count != 0)
            {
                rol = ((Rol_DTO)LB_Roles.SelectedItem).rol_CodRol;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Debe seleccionar un rol");
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
