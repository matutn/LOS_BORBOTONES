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
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.txt_Especialidad = new System.Windows.Forms.TextBox();
            this.button_Turno = new System.Windows.Forms.Button();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Actualizar = new System.Windows.Forms.Button();
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
            this.grillaProfesionales.Location = new System.Drawing.Point(16, 40);
            this.grillaProfesionales.Name = "grillaProfesionales";
            this.grillaProfesionales.Size = new System.Drawing.Size(737, 171);
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
            this.nombre.Width = 110;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 110;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.Width = 200;
            // 
            // tipoEspecialidad
            // 
            this.tipoEspecialidad.HeaderText = "Tipo Especialidad";
            this.tipoEspecialidad.Name = "tipoEspecialidad";
            this.tipoEspecialidad.Width = 180;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(51, 11);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(84, 20);
            this.txt_Dni.TabIndex = 1;
            // 
            // txt_Especialidad
            // 
            this.txt_Especialidad.Location = new System.Drawing.Point(385, 13);
            this.txt_Especialidad.Name = "txt_Especialidad";
            this.txt_Especialidad.Size = new System.Drawing.Size(84, 20);
            this.txt_Especialidad.TabIndex = 3;
            // 
            // button_Turno
            // 
            this.button_Turno.Location = new System.Drawing.Point(678, 11);
            this.button_Turno.Name = "button_Turno";
            this.button_Turno.Size = new System.Drawing.Size(75, 23);
            this.button_Turno.TabIndex = 6;
            this.button_Turno.Text = "Pedir Turno";
            this.button_Turno.UseVisualStyleBackColor = true;
            this.button_Turno.Click += new System.EventHandler(this.button_Turno_Click);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(516, 11);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 8;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(197, 11);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(103, 20);
            this.txt_Apellido.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "DNI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Especialidad :";
            // 
            // button_Actualizar
            // 
            this.button_Actualizar.Location = new System.Drawing.Point(597, 11);
            this.button_Actualizar.Name = "button_Actualizar";
            this.button_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_Actualizar.TabIndex = 12;
            this.button_Actualizar.Text = "Actualizar";
            this.button_Actualizar.UseVisualStyleBackColor = true;
            this.button_Actualizar.Click += new System.EventHandler(this.button_Actualizar_Click);
            // 
            // PedidoTurno_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 223);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Buscar);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.button_Turno);
            this.Controls.Add(this.txt_Especialidad);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.grillaProfesionales);
            this.Name = "PedidoTurno_Principal";
            this.Text = "PedidoTurno";
            ((System.ComponentModel.ISupportInitialize)(this.grillaProfesionales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaProfesionales;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.TextBox txt_Especialidad;
        private System.Windows.Forms.Button button_Turno;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEspecialidad;
        private System.Windows.Forms.Button button_Actualizar;
    }
}