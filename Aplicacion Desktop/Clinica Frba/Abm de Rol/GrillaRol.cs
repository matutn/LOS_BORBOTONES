using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using Clinica_Frba.Abm_Rol;

namespace Clinica_Frba.GrillaRol
{
    public partial class GrillaRol_Form : Form
    {
        //Variable Rol que es objeto Rol_DTO.
        public static Clinica_Frba.DTO.Rol_DTO Rol;

        //Variable RolesAMostrar que es una lista de objetos Rol_DTO.
        public static List<Rol_DTO> RolesAMostrar = new List<Rol_DTO>();        

        //Variable instancia que es un objeto GrillaRol_Form.
        public static GrillaRol_Form instancia;

        //Constructor
        public GrillaRol_Form()
        {
            InitializeComponent();
            GrillaRol_Form.instancia = this;
        }


       
        //---------------------COMIENZO Botones de la Grilla---------------------------

        private void B_Añadir_Click(object sender, EventArgs e)
        {
            Abm_Rol_Form.tipoDeFormularioSecundario = 'A';
            (new Abm_Rol_Form()).Show();
        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            Abm_Rol_Form.tipoDeFormularioSecundario = 'B';
            (new Abm_Rol_Form()).Show();
        }


        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            listadoRoles.Rows.Clear();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            if (listadoRoles.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoRoles.SelectedRows[0];
            Abm_Rol_Form.rol = new Rol_DTO
            (
            fila.Cells["txt_Codigo_Rol"].Value.ToString(),
            fila.Cells["txt_Nombre_Rol"].Value.ToString()
            );
            Abm_Rol_Form.tipoDeFormularioSecundario = 'M';

            (new Abm_Rol_Form()).Show();
        }

        private void B_EliminarClientes_Click(object sender, EventArgs e)
        {
            if (listadoRoles.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoRoles.SelectedRows[0];

            if ((bool)fila.Cells["Eliminado"].Value)
            {
                Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Afiliado set afi_Estado = '" + 0 + "' where afi_Dni = '" + fila.Cells["txt_Dni"].Value + "'");
                fila.Cells["Eliminado"].Value = false;
            }
            else
            {
                Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Afiliado set afi_Estado = '" + 1 + "' where afi_Dni = '" + fila.Cells["txt_Dni"].Value + "'");
                fila.Cells["Eliminado"].Value = true;
            }
        }
        //---------------------FIN Botones de la Grilla---------------------------





        //---------------------COMIENZO: FUNCIONES--------------------
        public void actualizarListadoAfiliados()
        {
            listadoRoles.Rows.Clear();
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[16];

            foreach (AfiliadoDTO afiliado in afiliadosAMostrar)
            {
                columnas[0] = afiliado.IdAfiliado;
                columnas[1] = afiliado.NombreUsuario;
                columnas[2] = afiliado.Nombre;
                columnas[3] = afiliado.Apellido;
                columnas[4] = afiliado.Dni;
                columnas[5] = afiliado.IdPlan;           
                columnas[6] = afiliado.Direccion;
                columnas[7] = afiliado.Telefono;
                columnas[8] = afiliado.Mail;
                columnas[9] = afiliado.FechaNacimiento;
                columnas[10] = afiliado.Sexo;
                columnas[11] = afiliado.EstadoCivil;
                columnas[12] = afiliado.CantPersonas;
                columnas[13] = afiliado.CantidadConsultas;
                columnas[14] = (afiliado.Estado == "True") ? true : false;
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listadoRoles, columnas);
            }
            listadoRoles.Rows.AddRange(filas.ToArray());
        }
        //----------------------------FIN FUNCIONES-----------------------




        //-------------------------COMIENZO: Eventos Innecesarios-------------------
   
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaAfiliado_Load(object sender, EventArgs e)
        {

        }

        
        //----------------------------FIN Eventos Innecesarios-----------------------
        




      
   
    }
}
