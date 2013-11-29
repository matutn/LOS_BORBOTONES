namespace Clinica_Frba.GrillaRoll
{
    partial class GrillaRollForm
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
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAll = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.B_Volver = new System.Windows.Forms.Button();
            this.B_EliminarClientes = new System.Windows.Forms.Button();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.Eliminado,
            this.Estado});
            this.listadoAfiliados.Location = new System.Drawing.Point(130, 31);
            this.listadoAfiliados.Name = "listadoAfiliados";
            this.listadoAfiliados.Size = new System.Drawing.Size(1228, 259);
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
            this.txt_EstadoCivil.HeaderText = "EstadoCivil";
            this.txt_EstadoCivil.Name = "txt_EstadoCivil";
            this.txt_EstadoCivil.Width = 80;
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
            this.Eliminado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminado.Width = 60;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 50;
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(12, 117);
            this.checkAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(90, 25);
            this.checkAll.TabIndex = 32;
            this.checkAll.Text = "Check All";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 31);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 23);
            this.agregar.TabIndex = 31;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // B_Volver
            // 
            this.B_Volver.Location = new System.Drawing.Point(13, 176);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(90, 25);
            this.B_Volver.TabIndex = 30;
            this.B_Volver.Text = "Cancelar";
            this.B_Volver.UseVisualStyleBackColor = true;
            this.B_Volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // B_EliminarClientes
            // 
            this.B_EliminarClientes.Location = new System.Drawing.Point(12, 88);
            this.B_EliminarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.B_EliminarClientes.Name = "B_EliminarClientes";
            this.B_EliminarClientes.Size = new System.Drawing.Size(90, 25);
            this.B_EliminarClientes.TabIndex = 29;
            this.B_EliminarClientes.Text = "Cambiar Estado";
            this.B_EliminarClientes.UseVisualStyleBackColor = true;
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(13, 59);
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
            this.B_Limpiar.Location = new System.Drawing.Point(12, 146);
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
            this.button1.Location = new System.Drawing.Point(13, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 33;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrillaRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.B_Volver);
            this.Controls.Add(this.B_EliminarClientes);
            this.Controls.Add(this.B_Buscar);
            this.Controls.Add(this.B_Limpiar);
            this.Controls.Add(this.listadoAfiliados);
            this.Name = "GrillaRollForm";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GrillaAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoAfiliados;
        private System.Windows.Forms.Button checkAll;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.Button B_EliminarClientes;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_IdAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Apellido;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;

    }
}