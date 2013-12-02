using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.GrillaRol;
using Clinica_Frba.DTO;
using System.Data.SqlClient;
using Clinica_Frba.Utils;


namespace Clinica_Frba.Abm_Rol
{
    public partial class Abm_Rol_Form : Form
    {

        public static Clinica_Frba.DTO.Rol_DTO rol;
        public static char tipoDeFormularioSecundario;
        public Abm_Rol_Form() {

            InitializeComponent();
            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {   
                        this.Text = "Modificacion de Afiliado";

                        txt_Nombre_Rol.Text = rol.rol_Nombre;

                        var listadoFunc = Clases.DB.ExecuteReader("Select * From LOS_BORBOTONES.Funcionalidad");
                        
                         foreach (DataRow dr in listadoFunc.Rows) {

                         LB_Funcionalidades.Items.Add(dr);
                         
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
        private void AñadirUsuario_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        
        }

        private void LB_Funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nombre_Rol_TextChanged(object sender, EventArgs e)
        {

        }

        
    
    }
}
