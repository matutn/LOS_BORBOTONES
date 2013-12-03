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

                DataTable listadoFuncRol = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Func_Rol fr, LOS_BORBOTONES.Funcionalidad f where	"+ rol.rol_CodRol+" = fr.furo_CodRol AND f.fun_CodFuncionalidad = fr.furo_CodFuncionalidad");
                DataTable listadoFuncTot = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Funcionalidad f");


                grillaFunc.Rows.Clear();
                List<DataGridViewRow> filas = new List<DataGridViewRow>();
                Object[] columnas = new Object[3];

                foreach (DataRow regft in listadoFuncTot.Rows)
                {
                    columnas[0] = regft["fun_Descripcion"].ToString();

                    foreach (DataRow regfr in listadoFuncRol.Rows)

                        if (regfr["fun_CodFuncionalidad"].ToString() == regft["fun_CodFuncionalidad"].ToString())
                        {

                            columnas[1] = true;
                            break;
                        }
                        else {columnas[1] = false; }

                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(grillaFunc, columnas);
                }
                grillaFunc.Rows.AddRange(filas.ToArray());
                        
                       

                    }
                    break;

                case 'A':

                    this.Text = "Alta de Afiliado";

                  
                    DataTable listadoFuncTot2 = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Funcionalidad f");


                    DG_GrillaFunc.Rows.Clear();
                    List<DataGridViewRow> filas2 = new List<DataGridViewRow>();
                    Object[] columnas2 = new Object[3];

                    foreach (DataRow regft in listadoFuncTot2.Rows)
                    {
                        columnas2[0] = regft["fun_Descripcion"].ToString();
                        columnas2[1] = false;

                        filas2.Add(new DataGridViewRow());
                        filas2[filas2.Count - 1].CreateCells(DG_GrillaFunc, columnas2);
                    }
                    DG_GrillaFunc.Rows.AddRange(filas2.ToArray());
                        
                    break;


                case 'B':
                    this.Text = "Busqueda de Afiliado";
                    GB_Rol.Enabled = false;
                    break;
            }
        }
  

        private void GB_Rol_Enter(object sender, EventArgs e)
        {
        
        }

        private void txt_Nombre_Rol_TextChanged(object sender, EventArgs e)
        {

        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {

        }

        
    
    }
}
