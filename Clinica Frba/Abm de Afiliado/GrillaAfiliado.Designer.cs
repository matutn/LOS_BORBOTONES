﻿namespace Clinica_Frba.GrillaAfiliado
{
    partial class GrillaAfiliado_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listadoAfiliados = new System.Windows.Forms.DataGridView();
            this.txt_IdAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TipoDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_IdPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CantPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CantidadConsultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.agregar = new System.Windows.Forms.Button();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.B_EliminarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoAfiliados
            // 
            this.listadoAfiliados.AllowUserToAddRows = false;
            this.listadoAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_IdAfiliado,
            this.txt_NombreUsuario,
            this.txt_Nombre,
            this.txt_Apellido,
            this.txt_TipoDni,
            this.txt_Dni,
            this.txt_IdPlan,
            this.txt_Direccion,
            this.txt_Telefono,
            this.txt_Mail,
            this.txt_FechaNacimiento,
            this.txt_Sexo,
            this.txt_EstadoCivil,
            this.txt_CantPersonas,
            this.txt_CantidadConsultas,
            this.Eliminado});
            this.listadoAfiliados.Location = new System.Drawing.Point(12, 41);
            this.listadoAfiliados.Name = "listadoAfiliados";
            this.listadoAfiliados.Size = new System.Drawing.Size(1240, 247);
            this.listadoAfiliados.TabIndex = 0;
            this.listadoAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // txt_IdAfiliado
            // 
            this.txt_IdAfiliado.HeaderText = "Id Afiliado";
            this.txt_IdAfiliado.Name = "txt_IdAfiliado";
            this.txt_IdAfiliado.Width = 80;
            // 
            // txt_NombreUsuario
            // 
            this.txt_NombreUsuario.HeaderText = "Username";
            this.txt_NombreUsuario.Name = "txt_NombreUsuario";
            this.txt_NombreUsuario.Width = 70;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.HeaderText = "Nombre";
            this.txt_Nombre.Name = "txt_Nombre";
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.HeaderText = "Apellido";
            this.txt_Apellido.Name = "txt_Apellido";
            // 
            // txt_TipoDni
            // 
            this.txt_TipoDni.HeaderText = "Tipo Dni";
            this.txt_TipoDni.Name = "txt_TipoDni";
            this.txt_TipoDni.Width = 80;
            // 
            // txt_Dni
            // 
            this.txt_Dni.HeaderText = "Dni";
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Width = 60;
            // 
            // txt_IdPlan
            // 
            this.txt_IdPlan.HeaderText = "Plan";
            this.txt_IdPlan.Name = "txt_IdPlan";
            this.txt_IdPlan.Width = 60;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.HeaderText = "Direccion";
            this.txt_Direccion.Name = "txt_Direccion";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.HeaderText = "Telefono";
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Width = 60;
            // 
            // txt_Mail
            // 
            this.txt_Mail.HeaderText = "Mail";
            this.txt_Mail.Name = "txt_Mail";
            // 
            // txt_FechaNacimiento
            // 
            this.txt_FechaNacimiento.HeaderText = "FechaNacimiento";
            this.txt_FechaNacimiento.Name = "txt_FechaNacimiento";
            // 
            // txt_Sexo
            // 
            this.txt_Sexo.HeaderText = "Sexo";
            this.txt_Sexo.Name = "txt_Sexo";
            this.txt_Sexo.Width = 40;
            // 
            // txt_EstadoCivil
            // 
            this.txt_EstadoCivil.HeaderText = "Estado Civil";
            this.txt_EstadoCivil.Name = "txt_EstadoCivil";
            this.txt_EstadoCivil.Width = 60;
            // 
            // txt_CantPersonas
            // 
            this.txt_CantPersonas.HeaderText = "N° Personas";
            this.txt_CantPersonas.Name = "txt_CantPersonas";
            this.txt_CantPersonas.Width = 60;
            // 
            // txt_CantidadConsultas
            // 
            this.txt_CantidadConsultas.HeaderText = "N° Consultas";
            this.txt_CantidadConsultas.Name = "txt_CantidadConsultas";
            this.txt_CantidadConsultas.Width = 60;
            // 
            // Eliminado
            // 
            this.Eliminado.HeaderText = "Eliminado";
            this.Eliminado.Name = "Eliminado";
            this.Eliminado.ReadOnly = true;
            this.Eliminado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminado.Width = 60;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 12);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 23);
            this.agregar.TabIndex = 31;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(203, 12);
            this.B_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(90, 25);
            this.B_Buscar.TabIndex = 27;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // B_Limpiar
            // 
            this.B_Limpiar.Location = new System.Drawing.Point(391, 12);
            this.B_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(90, 25);
            this.B_Limpiar.TabIndex = 28;
            this.B_Limpiar.Text = "Limpiar";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            this.B_Limpiar.Click += new System.EventHandler(this.B_Limpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 33;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_EliminarClientes
            // 
            this.B_EliminarClientes.Location = new System.Drawing.Point(297, 12);
            this.B_EliminarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.B_EliminarClientes.Name = "B_EliminarClientes";
            this.B_EliminarClientes.Size = new System.Drawing.Size(90, 25);
            this.B_EliminarClientes.TabIndex = 29;
            this.B_EliminarClientes.Text = "Cambiar Estado";
            this.B_EliminarClientes.UseVisualStyleBackColor = true;
            this.B_EliminarClientes.Click += new System.EventHandler(this.B_EliminarClientes_Click);
            // 
            // GrillaAfiliado_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.B_EliminarClientes);
            this.Controls.Add(this.B_Buscar);
            this.Controls.Add(this.B_Limpiar);
            this.Controls.Add(this.listadoAfiliados);
            this.Name = "GrillaAfiliado_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GrillaAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoAfiliados;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_IdAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_TipoDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_IdPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_CantPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_CantidadConsultas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminado;
        private System.Windows.Forms.Button B_EliminarClientes;

    }
}