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
        public Abm_Rol_Form()
        {

            InitializeComponent();


        

            switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {   
                        this.Text = "Modificacion de Rol";

                        txt_Nombre_Rol.Text = rol.rol_Nombre;

                        DataTable listadoFuncRol = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Func_Rol fr, LOS_BORBOTONES.Funcionalidad f where	'" + rol.rol_CodRol.ToString() + "' = fr.furo_CodRol AND f.fun_CodFuncionalidad = fr.furo_CodFuncionalidad");
                DataTable listadoFuncTot = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Funcionalidad f");


                grillaFunc.Rows.Clear();
                Object[] columnas = new Object[4];

                foreach (DataRow regft in listadoFuncTot.Rows)
                {   
                  
                    columnas[0]= regft["fun_CodFuncionalidad"].ToString();
                    columnas[1] = regft["fun_Descripcion"].ToString();

                    foreach (DataRow regfr in listadoFuncRol.Rows)

                        if (regfr["fun_CodFuncionalidad"].ToString() == regft["fun_CodFuncionalidad"].ToString())
                          {
                            columnas[2] = true;
                            break;
                            }
                        else {columnas[2] = false; }

                    grillaFunc.Rows.Add(columnas[0], columnas[1],columnas[2]);
                 
                }
                    }
                    break;

                case 'A':

                    this.Text = "Alta de Rol";

                  
                    DataTable listadoFuncTot2 = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Funcionalidad f");


                    grillaFunc.Rows.Clear();
                    
                    Object[] columnas2 = new Object[3];

                    foreach (DataRow regft in listadoFuncTot2.Rows)
                    {
                        columnas2[0] = regft["fun_CodFuncionalidad"].ToString();
                        columnas2[1] = regft["fun_Descripcion"].ToString();
                        columnas2[2] = false;

                        grillaFunc.Rows.Add(columnas2[0], columnas2[1], columnas2[2]);
                    }
              
                        
                    break;


                case 'B':
                    this.Text = "Busqueda de Rol";
                    GB_Rol.Enabled = false;
                    break;
            }
        }



        //---------------------COMIENZO Botones de la Grilla---------------------------

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
                 

             switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {

                        int valor = Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Rol set rol_Nombre = '" + txt_Nombre_Rol.Text +
                                                                "' where LOS_BORBOTONES.Rol.rol_CodRol = '"+ rol.rol_CodRol.ToString() +"'");
                        int valor2 = Clases.DB.ExecuteNonQuery("Delete From LOS_BORBOTONES.Func_Rol Where LOS_BORBOTONES.Func_Rol.furo_CodRol = '"+
                                                                rol.rol_CodRol.ToString() + "'");
                        //DataGridViewRow
                foreach (DataGridViewRow dr in grillaFunc.Rows)
                {
                    

                    if(dr.Cells["FuncAgregada"].Value != null){

                        int valor3 = Clases.DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Func_Rol (furo_CodRol,furo_CodFuncionalidad) Values ("+
                                                                  rol.rol_CodRol.ToString() + ", " + dr.Cells["IdFunc"].Value.ToString() + ")"); 
                    }
                }
               MessageBox.Show("El Rol se modifico correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                       

                    }
                    break;

                case 'A':
                    {
                        if (txt_Nombre_Rol.Text == "")
                        {
                            MessageBox.Show("El nombre no puede estar vacío.");
                            return;
                        }

                         DataTable listadoRoles = Clases.DB.ExecuteReader("Select * From LOS_BORBOTONES.Rol");

                         foreach (DataRow dr in listadoRoles.Rows)
                         {
                             if(txt_Nombre_Rol.Text == dr["rol_nombre"].ToString())
                             {
                                 MessageBox.Show("El nombre de ese rol ya existe. Por favor, elija uno nuevo.");
                                 return;
                             }
                         }

                            int valor = Clases.DB.ExecuteCardinal("Insert Into LOS_BORBOTONES.Rol (rol_Nombre,rol_Estado) Values ('" +
                                                                     txt_Nombre_Rol.Text + "' , 'false'); select scope_identity()");


                            foreach (DataGridViewRow dr in grillaFunc.Rows)
                            {
                                if (dr.Cells["FuncAgregada"].Value != null)
                                {

                                    int valor3 = Clases.DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Func_Rol (furo_CodRol,furo_CodFuncionalidad) Values (" +
                                                                             valor.ToString() + ", " + dr.Cells["IdFunc"].Value.ToString() + ")");
                                }
                            }
                            MessageBox.Show("El Rol se agregó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    
             
                case 'B':
                    {
                       
                        DataTable buscados = Clases.DB.ExecuteReader("Select * From LOS_BORBOTONES.Rol Where LOS_BORBOTONES.Rol.rol_Nombre like '%"+txt_Nombre_Rol.Text+"%'");
                        GrillaRol_Form.RolesAMostrar.Clear();

                        foreach (DataRow dr in buscados.Rows)
                        {
                            rol = new Rol_DTO();
                            rol.rol_CodRol = dr["rol_CodRol"].ToString();
                            rol.rol_Nombre = dr["rol_Nombre"].ToString();
                            rol.rol_Estado = dr["rol_Estado"].ToString();

                            GrillaRol_Form.RolesAMostrar.Add(rol);
                        }
                        GrillaRol_Form.instancia.actualizarGrillaRoles();
                        
                        
                    }
                    break;
            }

            Close();
           
        }

        //Botón Cancelar
        private void B_Cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        //Botón Limpiar Funcionalidades
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in grillaFunc.Rows)
            {
                if ((bool)dr.Cells["FuncAgregada"].Value == true)
                {
                    dr.Cells["FuncAgregada"].Value = false;

                }
            }
        }

        //Botón Añadir Todas
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in grillaFunc.Rows)
            {
                if ((bool)dr.Cells["FuncAgregada"].Value == false)
                {
                    dr.Cells["FuncAgregada"].Value = true;

                }
            }
        }

        //---------------------FIN Botones de la Grilla---------------------------


        //-------------------------COMIENZO: Eventos Innecesarios-------------------
        private void Abm_Rol_Form_Load(object sender, EventArgs e)
        {
        
        }

        private void DG_GrillaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void GB_Rol_Enter_1(object sender, EventArgs e)
        {

        }
        private void txt_Nombre_Rol_TextChanged(object sender, EventArgs e)
        {

        }

        private void grillaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

       

       

        //----------------------------FIN Eventos Innecesarios-----------------------

       }
        
    }

