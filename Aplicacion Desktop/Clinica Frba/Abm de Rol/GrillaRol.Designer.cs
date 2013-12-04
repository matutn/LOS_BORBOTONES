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
            this.grillaRoles = new System.Windows.Forms.DataGridView();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.B_Modificar = new System.Windows.Forms.Button();
            this.B_Añadir = new System.Windows.Forms.Button();
            this.B_BajaRol = new System.Windows.Forms.Button();
            this.Codigo_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaRoles
            // 
            this.grillaRoles.AllowUserToAddRows = false;
            this.grillaRoles.AllowUserToDeleteRows = false;
            this.grillaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Rol,
            this.Nombre_Rol,
            this.Eliminado});
            this.grillaRoles.Location = new System.Drawing.Point(202, 12);
            this.grillaRoles.Name = "grillaRoles";
            this.grillaRoles.Size = new System.Drawing.Size(255, 192);
            this.grillaRoles.TabIndex = 0;
            this.grillaRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(367, 227);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(90, 25);
            this.B_Cancelar.TabIndex = 42;
            this.B_Cancelar.Text = "Cerrar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_Limpiar);
            this.groupBox1.Controls.Add(this.B_Modificar);
            this.groupBox1.Controls.Add(this.B_Buscar);
            this.groupBox1.Controls.Add(this.B_Añadir);
            this.groupBox1.Controls.Add(this.B_BajaRol);
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
            // 
            this.B_Añadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Añadir.Location = new System.Drawing.Point(20, 28);
            this.B_Añadir.Margin = new System.Windows.Forms.Padding(2);
            this.B_Añadir.Name = "B_Añadir";
            this.B_Añadir.Size = new System.Drawing.Size(147, 35);
            this.B_Añadir.TabIndex = 44;
            this.B_Añadir.Text = "Añadir";
            this.B_Añadir.UseVisualStyleBackColor = true;
            // 
            // B_BajaRol
            // 
            this.B_BajaRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_BajaRol.Location = new System.Drawing.Point(20, 147);
            this.B_BajaRol.Margin = new System.Windows.Forms.Padding(2);
            this.B_BajaRol.Name = "B_BajaRol";
            this.B_BajaRol.Size = new System.Drawing.Size(147, 35);
            this.B_BajaRol.TabIndex = 29;
            this.B_BajaRol.Text = "Dar de Baja";
            this.B_BajaRol.UseVisualStyleBackColor = true;
            // 
            // Codigo_Rol
            // 
            this.Codigo_Rol.HeaderText = "Codigo de Rol";
            this.Codigo_Rol.Name = "Codigo_Rol";
            this.Codigo_Rol.Visible = false;
            // 
            // Nombre_Rol
            // 
            this.Nombre_Rol.HeaderText = "Nombre de Rol";
            this.Nombre_Rol.Name = "Nombre_Rol";
            this.Nombre_Rol.Width = 110;
            // 
            // Eliminado
            // 
            this.Eliminado.HeaderText = "Eliminado";
            this.Eliminado.Name = "Eliminado";
            this.Eliminado.Width = 101;
            // 
            // GrillaRol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.grillaRoles);
            this.Name = "GrillaRol_Form";
            this.Text = "Roles";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GrillaAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaRoles;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.Button B_Añadir;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.Button B_BajaRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminado;

    }
}