namespace Clinica_Frba.GrillaRol
{
    partial class GrillaRol_Form
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
            this.listadoRoles = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.Codigo_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.B_Modificar = new System.Windows.Forms.Button();
            this.B_Añadir = new System.Windows.Forms.Button();
=======
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Volver = new System.Windows.Forms.Button();
>>>>>>> df0e8c842057534b500380d61b8cb3a09682c176
            this.B_EliminarClientes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRoles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoRoles
            // 
            this.listadoRoles.AllowUserToAddRows = false;
            this.listadoRoles.AllowUserToDeleteRows = false;
            this.listadoRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Estado});
            this.listadoRoles.Location = new System.Drawing.Point(12, 182);
            this.listadoRoles.Name = "listadoRoles";
            this.listadoRoles.Size = new System.Drawing.Size(354, 192);
            this.listadoRoles.TabIndex = 0;
            this.listadoRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
<<<<<<< HEAD
            // Codigo_Rol
            // 
            this.Codigo_Rol.HeaderText = "Codigo de Rol";
            this.Codigo_Rol.Name = "Codigo_Rol";
            // 
            // Nombre_Rol
            // 
            this.Nombre_Rol.HeaderText = "Nombre de Rol";
            this.Nombre_Rol.Name = "Nombre_Rol";
            this.Nombre_Rol.Width = 110;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 101;
            // 
            // B_Buscar
            // 
            this.B_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Buscar.Location = new System.Drawing.Point(20, 68);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(147, 35);
            this.B_Buscar.TabIndex = 36;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
=======
            // Codigo
>>>>>>> df0e8c842057534b500380d61b8cb3a09682c176
            // 
            this.Codigo.HeaderText = "Codigo de Rol";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Rol";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
<<<<<<< HEAD
            this.groupBox1.Controls.Add(this.B_Limpiar);
            this.groupBox1.Controls.Add(this.B_Modificar);
            this.groupBox1.Controls.Add(this.B_Buscar);
            this.groupBox1.Controls.Add(this.B_Añadir);
            this.groupBox1.Controls.Add(this.B_EliminarClientes);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 240);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Roles";
            // 
            // B_Limpiar
            // 
            this.B_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Limpiar.Location = new System.Drawing.Point(20, 187);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(147, 35);
            this.B_Limpiar.TabIndex = 46;
            this.B_Limpiar.Text = "Limpiar Lista";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            // 
            // B_Modificar
            // 
            this.B_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Modificar.Location = new System.Drawing.Point(20, 108);
            this.B_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Modificar.Name = "B_Modificar";
            this.B_Modificar.Size = new System.Drawing.Size(147, 35);
            this.B_Modificar.TabIndex = 45;
            this.B_Modificar.Text = "Modificar";
            this.B_Modificar.UseVisualStyleBackColor = true;
            // 
            // B_Añadir
=======
            // Estado
>>>>>>> df0e8c842057534b500380d61b8cb3a09682c176
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 101;
            // 
<<<<<<< HEAD
=======
            // B_Limpiar
            // 
            this.B_Limpiar.Location = new System.Drawing.Point(276, 150);
            this.B_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(90, 25);
            this.B_Limpiar.TabIndex = 28;
            this.B_Limpiar.Text = "Limpiar";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            this.B_Limpiar.Click += new System.EventHandler(this.B_Limpiar_Click);
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(13, 151);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(75, 23);
            this.B_Buscar.TabIndex = 36;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Funcionalidad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 133);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de Búsqueda";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Usuario:";
            // 
            // B_Volver
            // 
            this.B_Volver.Location = new System.Drawing.Point(470, 349);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(90, 25);
            this.B_Volver.TabIndex = 42;
            this.B_Volver.Text = "Cancelar";
            this.B_Volver.UseVisualStyleBackColor = true;
            // 
>>>>>>> df0e8c842057534b500380d61b8cb3a09682c176
            // B_EliminarClientes
            // 
            this.B_EliminarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_EliminarClientes.Location = new System.Drawing.Point(20, 127);
            this.B_EliminarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.B_EliminarClientes.Name = "B_EliminarClientes";
            this.B_EliminarClientes.Size = new System.Drawing.Size(147, 35);
            this.B_EliminarClientes.TabIndex = 29;
            this.B_EliminarClientes.Text = "Dar de Baja";
            this.B_EliminarClientes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.B_EliminarClientes);
            this.groupBox1.Location = new System.Drawing.Point(373, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 174);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Roles";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(20, 28);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 35);
            this.button3.TabIndex = 44;
            this.button3.Text = "Añadir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(20, 77);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 35);
            this.button4.TabIndex = 45;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // GrillaRollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.B_Buscar);
            this.Controls.Add(this.B_Volver);
            this.Controls.Add(this.listadoRoles);
            this.Controls.Add(this.B_Limpiar);
            this.Name = "GrillaRollForm";
            this.Text = "Roles";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GrillaAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoRoles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoRoles;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.Button B_EliminarClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;

    }
}