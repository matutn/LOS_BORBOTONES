namespace Clinica_Frba.Pedir_Turno
{
    partial class PedidoTurno_Principal
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
            this.grillaProfesionales = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text_Dni = new System.Windows.Forms.TextBox();
            this.button_Dni = new System.Windows.Forms.Button();
            this.button_Especialidad = new System.Windows.Forms.Button();
            this.txt_Especialidad = new System.Windows.Forms.TextBox();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_Turno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaProfesionales
            // 
            this.grillaProfesionales.AllowUserToAddRows = false;
            this.grillaProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProfesionales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.nombre,
            this.apellido,
            this.especialidad,
            this.tipoEspecialidad});
            this.grillaProfesionales.Location = new System.Drawing.Point(12, 48);
            this.grillaProfesionales.Name = "grillaProfesionales";
            this.grillaProfesionales.Size = new System.Drawing.Size(545, 150);
            this.grillaProfesionales.TabIndex = 0;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.Width = 70;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            // 
            // tipoEspecialidad
            // 
            this.tipoEspecialidad.HeaderText = "Tipo Especialidad";
            this.tipoEspecialidad.Name = "tipoEspecialidad";
            this.tipoEspecialidad.Width = 130;
            // 
            // text_Dni
            // 
            this.text_Dni.Location = new System.Drawing.Point(12, 12);
            this.text_Dni.Name = "text_Dni";
            this.text_Dni.Size = new System.Drawing.Size(84, 20);
            this.text_Dni.TabIndex = 1;
            this.text_Dni.Text = "Dni Profesional";
            // 
            // button_Dni
            // 
            this.button_Dni.Location = new System.Drawing.Point(102, 10);
            this.button_Dni.Name = "button_Dni";
            this.button_Dni.Size = new System.Drawing.Size(75, 23);
            this.button_Dni.TabIndex = 2;
            this.button_Dni.Text = "Buscar";
            this.button_Dni.UseVisualStyleBackColor = true;
            this.button_Dni.Click += new System.EventHandler(this.button_Dni_Click);
            // 
            // button_Especialidad
            // 
            this.button_Especialidad.Location = new System.Drawing.Point(295, 10);
            this.button_Especialidad.Name = "button_Especialidad";
            this.button_Especialidad.Size = new System.Drawing.Size(75, 23);
            this.button_Especialidad.TabIndex = 4;
            this.button_Especialidad.Text = "Buscar";
            this.button_Especialidad.UseVisualStyleBackColor = true;
            this.button_Especialidad.Click += new System.EventHandler(this.button_Especialidad_Click);
            // 
            // txt_Especialidad
            // 
            this.txt_Especialidad.Location = new System.Drawing.Point(205, 12);
            this.txt_Especialidad.Name = "txt_Especialidad";
            this.txt_Especialidad.Size = new System.Drawing.Size(84, 20);
            this.txt_Especialidad.TabIndex = 3;
            this.txt_Especialidad.Text = "Especialidad";
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(482, 204);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 5;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // button_Turno
            // 
            this.button_Turno.Location = new System.Drawing.Point(482, 12);
            this.button_Turno.Name = "button_Turno";
            this.button_Turno.Size = new System.Drawing.Size(75, 23);
            this.button_Turno.TabIndex = 6;
            this.button_Turno.Text = "Pedir Turno";
            this.button_Turno.UseVisualStyleBackColor = true;
            // 
            // PedidoTurno_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 248);
            this.Controls.Add(this.button_Turno);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.button_Especialidad);
            this.Controls.Add(this.txt_Especialidad);
            this.Controls.Add(this.button_Dni);
            this.Controls.Add(this.text_Dni);
            this.Controls.Add(this.grillaProfesionales);
            this.Name = "PedidoTurno_Principal";
            this.Text = "PedidoTurno";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProfesionales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEspecialidad;
        private System.Windows.Forms.TextBox text_Dni;
        private System.Windows.Forms.Button button_Dni;
        private System.Windows.Forms.Button button_Especialidad;
        private System.Windows.Forms.TextBox txt_Especialidad;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_Turno;
    }
}