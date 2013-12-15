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
        public string nombreUsuario;
        public string rol1;
        //List<Rol_DTO> rolesAMostrar = new List<Rol_DTO>();
        public static Clinica_Frba.DTO.Rol_DTO rol;

        public Ingreso()
        {
            InitializeComponent();

            Login_Form login = new Login_Form();
            if (login.ShowDialog() != DialogResult.OK)
            { this.Close(); }

            nombreUsuario = login.nombreUsuario;
            //Estado=0 es activo. 1 eliminado.
            DataTable dt = DB.ExecuteReader("Select r.rol_CodRol,r.rol_nombre,r.rol_Estado From LOS_BORBOTONES.Rol_Usuario ru JOIN LOS_BORBOTONES.Rol r ON r.rol_CodRol = ru.rous_CodRol where ru.rous_IdUsuario = '"+login.nombreUsuario+"' AND ru.rous_Estado = 0 AND r.rol_Estado = 0");

            foreach (DataRow dr in dt.Rows)
            {


                rol = new Rol_DTO();
                rol.rol_CodRol=  dr["rol_CodRol"].ToString();
                rol.rol_Nombre = dr["rol_nombre"].ToString();
                rol.rol_Estado = dr["rol_Estado"].ToString();

                LB_Roles.Items.Add(rol.rol_Nombre.ToString());
            }



           
            
            
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            
        }

        private void B_Entrar_Click(object sender, EventArgs e)
        {
            if (LB_Roles.SelectedItems.Count != 0)
            {
                rol1 = LB_Roles.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Debe seleccionar un rol");
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LB_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
