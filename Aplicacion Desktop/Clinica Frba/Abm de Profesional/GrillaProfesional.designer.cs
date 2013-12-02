namespace Clinica_Frba.AbmProfesional
{
    partial class GrillaProfesional
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
            this.B_Volver = new System.Windows.Forms.Button();
            this.B_EliminarClientes = new System.Windows.Forms.Button();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.listadoProfesionales = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.leyendaBusqueda = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Volver
            // 
            this.B_Volver.Location = new System.Drawing.Point(12, 156);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(90, 25);
            this.B_Volver.TabIndex = 23;
            this.B_Volver.Text = "Cancelar";
            this.B_Volver.UseVisualStyleBackColor = true;
            this.B_Volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // B_EliminarClientes
            // 
            this.B_EliminarClientes.Location = new System.Drawing.Point(11, 68);
            this.B_EliminarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.B_EliminarClientes.Name = "B_EliminarClientes";
            this.B_EliminarClientes.Size = new System.Drawing.Size(90, 25);
            this.B_EliminarClientes.TabIndex = 20;
            this.B_EliminarClientes.Text = "Cambiar Estado";
            this.B_EliminarClientes.UseVisualStyleBackColor = true;
            this.B_EliminarClientes.Click += new System.EventHandler(this.B_EliminarClientes_Click);
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(12, 39);
            this.B_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(90, 25);
            this.B_Buscar.TabIndex = 18;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // listadoProfesionales
            // 
            this.listadoProfesionales.AllowUserToAddRows = false;
            this.listadoProfesionales.AllowUserToDeleteRows = false;
            this.listadoProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.Matricula,
            this.dni,
            this.nombre,
            this.apellido,
            this.fecha_nacimiento,
            this.mail,
            this.telefono,
            this.direccion,
            this.Sexo,
            this.eliminar});
            this.listadoProfesionales.Location = new System.Drawing.Point(110, 11);
            this.listadoProfesionales.Margin = new System.Windows.Forms.Padding(2);
            this.listadoProfesionales.Name = "listadoProfesionales";
            this.listadoProfesionales.RowTemplate.Height = 24;
            this.listadoProfesionales.Size = new System.Drawing.Size(1084, 300);
            this.listadoProfesionales.TabIndex = 24;
            this.listadoProfesionales.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listadoProfesionales_RowHeaderMouseDoubleClick_1);
            this.listadoProfesionales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoProfesionales_CellContentClick);
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 80;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 51;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 69;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.HeaderText = "Fecha Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "Mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 74;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminado";
            this.eliminar.Name = "eliminar";
            // 
            // B_Limpiar
            // 
            this.B_Limpiar.Location = new System.Drawing.Point(11, 126);
            this.B_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(90, 25);
            this.B_Limpiar.TabIndex = 19;
            this.B_Limpiar.Text = "Limpiar";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            this.B_Limpiar.Click += new System.EventHandler(this.B_Limpiar_Click);
            // 
            // leyendaBusqueda
            // 
            this.leyendaBusqueda.AutoSize = true;
            this.leyendaBusqueda.Location = new System.Drawing.Point(351, 313);
            this.leyendaBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leyendaBusqueda.Name = "leyendaBusqueda";
            this.leyendaBusqueda.Size = new System.Drawing.Size(576, 13);
            this.leyendaBusqueda.TabIndex = 22;
            this.leyendaBusqueda.Text = "Para modificar un registro haga doble click sobre la primera columna de la izquie" +
                "rda (flecha) en la fila que desea modificar";
            this.leyendaBusqueda.Visible = false;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(12, 11);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 23);
            this.agregar.TabIndex = 25;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(11, 97);
            this.checkAll.Margin = new System.Windows.Forms.Padding(2);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(90, 25);
            this.checkAll.TabIndex = 26;
            this.checkAll.Text = "Check All";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.checkAll_Click);
            // 
            // AbmProfesionalPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 340);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.B_Volver);
            this.Controls.Add(this.B_EliminarClientes);
            this.Controls.Add(this.leyendaBusqueda);
            this.Controls.Add(this.B_Buscar);
            this.Controls.Add(this.listadoProfesionales);
            this.Controls.Add(this.B_Limpiar);
            this.Name = "AbmProfesionalPrincipal";
            this.Text = "ABMProfesionalPrincipal";
            this.Load += new System.EventHandler(this.AbmProfesionalPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.Button B_EliminarClientes;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.DataGridView listadoProfesionales;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.Label leyendaBusqueda;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button checkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eliminar;


    }
}