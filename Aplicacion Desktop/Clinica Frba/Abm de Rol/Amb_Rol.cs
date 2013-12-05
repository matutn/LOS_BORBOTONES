﻿using System;
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
                        this.Text = "Modificacion de Afiliado";

                        txt_Nombre_Rol.Text = rol.rol_Nombre;

                DataTable listadoFuncRol = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Func_Rol fr, LOS_BORBOTONES.Funcionalidad f where	"+ rol.rol_CodRol+" = fr.furo_CodRol AND f.fun_CodFuncionalidad = fr.furo_CodFuncionalidad");
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

                    this.Text = "Alta de Afiliado";

                  
                    DataTable listadoFuncTot2 = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Funcionalidad f");


                    grillaFunc.Rows.Clear();
                    
                    Object[] columnas2 = new Object[3];

                    foreach (DataRow regft in listadoFuncTot2.Rows)
                    {
                        columnas2[0] = regft["fun_Descripcion"].ToString();
                        columnas2[1] = false;

                        grillaFunc.Rows.Add(columnas2[0], columnas2[1]);
                    }
              
                        
                    break;


                case 'B':
                    this.Text = "Busqueda de Afiliado";
                    GB_Rol.Enabled = false;
                    break;
            }
        }
  

        private void txt_Nombre_Rol_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
             switch (tipoDeFormularioSecundario)
            {
                case 'M':
                    {


                        int valor = Clases.DB.ExecuteNonQuery("Update LOS_BORBOTONES.Rol set rol_Nombre = '" + txt_Nombre_Rol +
                                                                "where LOS_BORBOTONES.Rol.rol_CodRol = '"+ rol.rol_CodRol+"'");
                        int valor2 = Clases.DB.ExecuteNonQuery("Delete From LOS_BORBOTONES.Func_Rol Where LOS_BORBOTONES.Func_Rol.furo_CodRol = '"+
                                                                rol.rol_CodRol + "'");

                foreach (DataRow dr in grillaFunc.Rows)
                {
                    if(((CheckBox)dr["FuncAgregada"]).Checked){

                        int valor3 = Clases.DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Func_Rol (furo_CodRol,furo_CodFuncionalidad) Values ("+
                                                                  rol.rol_CodRol +", "+dr["IdFunc"].ToString()+")"); 
                    }
                }
               MessageBox.Show("El Rol se modifico correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                       

                    }
                    break;
                     
                case 'A':
                    {
                        int valor = Clases.DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Rol (rol_CodRol,rol_Nombre,rol_Estado) Values (null, '" +
                                                                 txt_Nombre_Rol + "' , true)");
                        int valor2 = Clases.DB.ExecuteNonQuery("Delete From LOS_BORBOTONES.Func_Rol Where LOS_BORBOTONES.Func_Rol.furo_CodRol = '" +
                                                                rol.rol_CodRol + "'");

                        foreach (DataRow dr in grillaFunc.Rows)
                        {
                            if (((CheckBox)dr["FuncAgregada"]).Checked)
                            {

                                int valor3 = Clases.DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Func_Rol (furo_CodRol,furo_CodFuncionalidad) Values (" +
                                                                          rol.rol_CodRol + ", " + dr["IdFunc"].ToString() + ")");
                            }
                        }
                        MessageBox.Show("El Rol se agregó correctamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'B':
                    {
                        DataTable buscados = Clases.DB.ExecuteReader("Select * From LOS_BORBOTONES.Rol Where LOS_BORBOTONES.Rol.rol_Nombre like '%"+txt_Nombre_Rol+"%'");

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
                   
        }
    
    }

