﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using Clinica_Frba.Abm_Afiliado;

namespace Clinica_Frba.GrillaAfiliado
{
    public partial class GrillaAfiliado_Form : Form
    {
        public static List<AfiliadoDTO> afiliadosAMostrar = new List<AfiliadoDTO>();
        public static GrillaAfiliado_Form instancia;
        public GrillaAfiliado_Form()
        {
            InitializeComponent();
            GrillaAfiliado_Form.instancia = this;
            this.Text = "Abm Afiliado";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void B_Buscar_Click(object sender, EventArgs e)
        {
            Amb_Afiliado_Form.tipoDeFormularioSecundario = 'B';
            (new Amb_Afiliado_Form()).Show(); 
        }

        public void actualizarListadoAfiliados()
        {
            listadoAfiliados.Rows.Clear();
            List<DataGridViewRow> filas = new List<DataGridViewRow>();
            Object[] columnas = new Object[16];

            foreach (AfiliadoDTO afiliado in afiliadosAMostrar)
            {
                columnas[0] = afiliado.IdAfiliado;
                columnas[1] = afiliado.NombreUsuario;
                columnas[2] = afiliado.Nombre;
                columnas[3] = afiliado.Apellido;
                columnas[4] = afiliado.TipoDni;
                columnas[5] = afiliado.Dni;
                columnas[6] = afiliado.IdPlan;           
                columnas[7] = afiliado.Direccion;
                columnas[8] = afiliado.Telefono;
                columnas[9] = afiliado.Mail;
                columnas[10] = afiliado.FechaNacimiento;
                columnas[11] = afiliado.Sexo;
                columnas[12] = afiliado.EstadoCivil;
                columnas[13] = afiliado.CantPersonas;
                columnas[14] = afiliado.CantidadConsultas;
                columnas[15] = (afiliado.Estado == "True") ? true : false;
                filas.Add(new DataGridViewRow());
                filas[filas.Count - 1].CreateCells(listadoAfiliados, columnas);
            }
            listadoAfiliados.Rows.AddRange(filas.ToArray());
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Amb_Afiliado_Form.tipoDeFormularioSecundario = 'A';
            (new Amb_Afiliado_Form()).Show(); 
        }

        private void B_Limpiar_Click(object sender, EventArgs e)
        {
            listadoAfiliados.Rows.Clear();
        }

        private void B_Volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listadoAfiliados.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoAfiliados.SelectedRows[0];
            Amb_Afiliado_Form.afiliado = new AfiliadoDTO
            (
            fila.Cells["txt_IdAfiliado"].Value.ToString(),
            "",
            fila.Cells["txt_Nombre"].Value.ToString(),
            fila.Cells["txt_Apellido"].Value.ToString(),
            fila.Cells["txt_TipoDni"].Value.ToString(),
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
            Amb_Afiliado_Form.tipoDeFormularioSecundario = 'M';

            (new Amb_Afiliado_Form()).Show();
        }

        private void B_EliminarClientes_Click(object sender, EventArgs e)
        {
            if (listadoAfiliados.SelectedRows.Count == 0)
                return;
            DataGridViewRow fila = listadoAfiliados.SelectedRows[0];

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
    }
}
