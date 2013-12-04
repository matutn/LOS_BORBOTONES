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

                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(grillaFunc, columnas);
                }
                grillaFunc.Rows.AddRange(filas.ToArray());
                        
                       

                    }
                    break;

                case 'A':

                    this.Text = "Alta de Afiliado";

                  
                    DataTable listadoFuncTot2 = Clases.DB.ExecuteReader("Select f.fun_Descripcion, f.fun_CodFuncionalidad From LOS_BORBOTONES.Funcionalidad f");


                    grillaFunc.Rows.Clear();
                    List<DataGridViewRow> filas2 = new List<DataGridViewRow>();
                    Object[] columnas2 = new Object[3];

                    foreach (DataRow regft in listadoFuncTot2.Rows)
                    {
                        columnas2[0] = regft["fun_Descripcion"].ToString();
                        columnas2[1] = false;

                        filas2.Add(new DataGridViewRow());
                        filas2[filas2.Count - 1].CreateCells(grillaFunc, columnas2);
                    }
                    grillaFunc.Rows.AddRange(filas2.ToArray());
                        
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
                    if(dr["FuncAgregada"].ToString() == "True"){

                        int valor3 = Clases.DB.ExecuteNonQuery("Insert Into LOS_BORBOTONES.Func_Rol (furo_CodRol,furo_CodFuncionalidad) Values ("+
                                                                  rol.rol_CodRol +", "+dr["Funcionalidad"].ToString()+")"); 
                    }


                    filas.Add(new DataGridViewRow());
                    filas[filas.Count - 1].CreateCells(grillaFunc, columnas);
                }
                grillaFunc.Rows.AddRange(filas.ToArray());
                        
                       

                    }
                    break;
                        int valor = Clases.DB.ExecuteNonQuery(@"Update LOS_BORBOTONES.Afiliado set afi_Nombre = '" + nombre.Text + "',afi_Apellido = '" + 
                            apellido.Text  + "',afi_Direccion = '" + calle.Text + "',afi_Telefono = '" + afiliado.Telefono + "',afi_Mail = '" + mail.Text +
                            afiliado.Sexo + "',afi_IdPlan = '" + idPlan + "',afi_EstadoCivil = '" + nro_estadoCivil + "' where afi_Dni = '" + long.Parse(afiliado.Dni) + "'"); 
                        MessageBox.Show("El Afiliado se modifico correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'A':
                    {
                        DataTable dt_plan  = Clases.DB.ExecuteReader("Select 1 from LOS_BORBOTONES.Plan_Medico where plan_IdPlan = '" + idPlan + "'");
                        if (dt_plan.Rows.Count == 0)
                        {
                            MessageBox.Show("El Plan ingresado no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        nro_estadoCivil = Clases.DB.ExecuteCardinal("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");
                        int valor = Clases.DB.ExecuteNonQuery(@"Insert into LOS_BORBOTONES.Afiliado (afi_IdPlan,afi_EstadoCivil,afi_Nombre,afi_Apellido ,afi_Dni,afi_Direccion,afi_Telefono,afi_Mail,afi_FechaNacimiento,afi_Sexo) 
                        values ( '" + idPlan + "','" + nro_estadoCivil + "','" + nombre.Text + "','" + apellido.Text + "'," + dni_afi + ",'" + calle.Text + "','" + tel + "','" + mail.Text + "','" + fecNac + "','" + sexo + "')");
                        MessageBox.Show("El Afiliado se dio de alta correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 'B':
                    {
                        GrillaAfiliado_Form.afiliadosAMostrar.Clear();
                        if (estado_civil == "")
                        {
                            nro_estadoCivil = 0;
                        }
                        else nro_estadoCivil = Clases.DB.ExecuteCardinal("Select esci_CodEcivil from LOS_BORBOTONES.EstadoCivil where esci_Descripcion = '" + estado_civil + "'");   
                        var lista = Clases.DB.ExecuteReader("Select * from LOS_BORBOTONES.Afiliado where afi_Apellido = '" + apellido.Text +
                            "' OR afi_Nombre = '" + nombre.Text + "' OR afi_Dni = '" + dni_afi + "' OR afi_Telefono = '" + tel +
                            "' OR afi_Mail = '" + mail.Text + "' OR afi_EstadoCivil = '" + nro_estadoCivil + "' OR afi_IdPlan = '" + idPlan +
                            "' OR afi_Direccion = '" + calle.Text + "' OR afi_Sexo = '" + sexo + "' OR afi_FechaNacimiento = '" + fecNac + "'");

                        foreach (DataRow row in lista.Rows)
                        {
                            afiliado = new Clinica_Frba.DTO.AfiliadoDTO();
                            afiliado.IdAfiliado = row["afi_IdAfiliado"].ToString();
                            afiliado.NombreUsuario = row["afi_NombreUsuario"].ToString();
                            afiliado.Nombre = row["afi_Nombre"].ToString();
                            afiliado.Apellido = row["afi_Apellido"].ToString();
                            afiliado.EstadoCivil = row["afi_EstadoCivil"].ToString();
                            afiliado.IdPlan = row["afi_IdPlan"].ToString();
                            afiliado.Dni = row["afi_Dni"].ToString();
                            afiliado.FechaNacimiento = row["afi_FechaNacimiento"].ToString();
                            afiliado.Mail = row["afi_Mail"].ToString();
                            afiliado.Telefono = row["afi_Telefono"].ToString();
                            afiliado.Direccion = row["afi_Direccion"].ToString();
                            afiliado.Estado = row["afi_Estado"].ToString();
                            afiliado.Sexo = row["afi_Sexo"].ToString();
                            afiliado.CantidadConsultas = row["afi_CantidadConsultas"].ToString();
                            afiliado.CantPersonas = row["afi_CantPersonas"].ToString();
                            GrillaAfiliado_Form.afiliadosAMostrar.Add(afiliado);
                        }
                        GrillaAfiliado_Form.instancia.actualizarListadoAfiliados();                    
                    }
                    break;
            }

            Close();
        }
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
