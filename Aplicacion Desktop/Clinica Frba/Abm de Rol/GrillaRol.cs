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

            DataTable listadoRoles = Clases.DB.ExecuteReader("Select * From LOS_BORBOTONES.Rol");
            GrillaRol_Form.instancia = this;
            Object[] columnas = new Object[4];

            foreach (DataRow dr in listadoRoles.Rows)
            {
                columnas[0] = dr["rol_CodRol"].ToString();
                columnas[1] = dr["rol_Nombre"].ToString();
                columnas[2] =(dr["rol_CodRol"].ToString() == "True") ? true : false;

                grillaRoles.Rows.Add(columnas[0], columnas[1], columnas[2]);
            }
        }


       
        //---------------------COMIENZO Botones de la Grilla---------------------------

        // Botón Añadir Rol
        private void B_Añadir_Click(object sender, EventArgs e)
        {
            Abm_Rol_Form.tipoDeFormularioSecundario = 'A';
            (new Abm_Rol_Form()).Show();
        }

        // Botón Buscar Rol
        private void B_Buscar_Click(object sender, EventArgs e)
        {
            Abm_Rol_Form.tipoDeFormularioSecundario = 'B';
            (new Abm_Rol_Form()).Show();
        }

        // Botón Limpiar GrillaRoles
        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            grillaRoles.Rows.Clear();
        }

        // Botón Cerrar Formulario de Roles
        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Botón Modificar Rol (El nombre y/o sus funcionalidades
        private void B_Modificar_Click(object sender, EventArgs e)
        {
            //Si no seleccionó ningun registro retorna.
            if (grillaRoles.SelectedRows.Count == 0)
                return;

            //Le asigno a reg el registro seleccionado.
            DataGridViewRow reg = grillaRoles.SelectedRows[0];

            //Creo un Rol_DTO y como parametros le doy los datos del registro del datagrid.
            Abm_Rol_Form.rol = new Rol_DTO
            (
            reg.Cells["Codigo_Rol"].Value.ToString(),
            reg.Cells["Nombre_Rol"].Value.ToString(),
            ""
            );
            //Las Celdas del registro de arriba va con los nombres(no los que muestra) de las columnas de grillaRolles
            
            //Se puede darle valor a la clase antes de crear la instrancia porque es una variable de clase.
            Abm_Rol_Form.tipoDeFormularioSecundario = 'M';

            (new Abm_Rol_Form()).Show();
        }


        private void B_BajaRol_Click(object sender, EventArgs e)
        {
            if (grillaRoles.SelectedRows.Count == 0)
                return;

            DataGridViewRow reg = grillaRoles.SelectedRows[0];

            if ((bool)reg.Cells["Eliminado"].Value)
            {
                Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Rol set rol_Estado = '" + 0 + "' where rol_CodRol = '" + reg.Cells["Codigo_Rol"].Value + "'");
                reg.Cells["Eliminado"].Value = false;
            }
            else
            {
                Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Rol set rol_Estado = '" + 1 + "' where rol_CodRol = '" + reg.Cells["Codigo_Rol"].Value + "'");
                reg.Cells["Eliminado"].Value = true;
            }
        }
        //---------------------FIN Botones de la Grilla---------------------------





        //---------------------COMIENZO: FUNCIONES--------------------
        public void actualizarGrillaRoles()
        {
            grillaRoles.Rows.Clear();
           
            Object[] columnas = new Object[4];

            foreach (Rol_DTO rol in RolesAMostrar)
            {
                columnas[0] = rol.rol_CodRol;
                columnas[1] = rol.rol_Nombre;
                columnas[2] = (rol.rol_Estado == "True") ? true : false;

                grillaRoles.Rows.Add(columnas[0], columnas[1], columnas[2]);
            }
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
