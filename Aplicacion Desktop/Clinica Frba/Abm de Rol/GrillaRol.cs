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
        public static Clinica_Frba.DTO.Rol_DTO Rol;
        public static List<Rol_DTO> RolesAMostrar = new List<Rol_DTO>();        

        public static GrillaRol_Form instancia;
        public GrillaRol_Form()

        {
            InitializeComponent();
            GrillaRol_Form.instancia = this;
        }

       
        //---------------------COMIENZO Botones de la Grilla---------------------------
        
        //Botón Añadir Rol
        private void agregar_Click(object sender, EventArgs e)
        {
            GrillaRol_Form.tipoDeFormularioSecundario = 'A';
            (new FormAfiliado()).Show())
            ;
        }

        //Botón Buscar Rol
        private void B_Buscar_Click(object sender, EventArgs e)
        {
            FormAfiliado.tipoDeFormularioSecundario = 'B';
            (new FormAfiliado()).Show();
        }

        //Botón Limpiar Roles
        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            listadoRoles.Rows.Clear();
        }


        //Botón Cancelar (Cerrar Grilla)
        private void B_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Botón Modificar Rol
        private void Modificar_Click(object sender, EventArgs e)
        {
            if (listadoRoles.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoRoles.SelectedRows[0];
            //FormAfiliado.idAfiliado = fila.Cells["IdAfiliado"].Value.ToString();
            FormAfiliado.afiliado = new AfiliadoDTO
            (
            fila.Cells["txt_IdAfiliado"].Value.ToString(),
            "",
            fila.Cells["txt_Nombre"].Value.ToString(),
            fila.Cells["txt_Apellido"].Value.ToString(),
            "",
            fila.Cells["txt_Dni"].Value.ToString(),
            fila.Cells["txt_IdPlan"].Value.ToString(),
            fila.Cells["txt_Direccion"].Value.ToString(),
            fila.Cells["txt_Telefono"].Value.ToString(),
            fila.Cells["txt_Mail"].Value.ToString(),
            fila.Cells["txt_FechaNacimiento"].Value.ToString(),
            fila.Cells["txt_Sexo"].Value.ToString(),
            fila.Cells["txt_EstadoCivil"].Value.ToString(),
            fila.Cells["txt_CantPersonas"].Value.ToString(),
            fila.Cells["txt_CantidadConsultas"].Value.ToString(),
            ""
            );
            FormAfiliado.tipoDeFormularioSecundario = 'M';

            (new FormAfiliado()).Show();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaAfiliado_Load(object sender, EventArgs e)
        {

        }

        
        //----------------------------FIN Eventos Innecesarios-----------------------
        




      
   
    }
}
