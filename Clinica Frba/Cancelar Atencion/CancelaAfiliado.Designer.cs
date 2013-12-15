namespace Clinica_Frba.Cancelar_Atencion
{
    partial class Cancelar_Turno_Afiliado
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
            this.B_Buscar = new System.Windows.Forms.Button();
            this.GB_Filtros = new System.Windows.Forms.GroupBox();
            this.B_Calendario = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nom_Prof = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_esp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id_Afi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ape_Prof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.grillaTurnos = new System.Windows.Forms.DataGridView();
            this.Nombre_Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Afi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancelar_Turno = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.CB_Cancelaciones = new System.Windows.Forms.ComboBox();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(393, 105);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(155, 34);
            this.B_Buscar.TabIndex = 0;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // GB_Filtros
            // 
            this.GB_Filtros.Controls.Add(this.B_Calendario);
            this.GB_Filtros.Controls.Add(this.label6);
            this.GB_Filtros.Controls.Add(this.txt_fecha);
            this.GB_Filtros.Controls.Add(this.label5);
            this.GB_Filtros.Controls.Add(this.B_Buscar);
            this.GB_Filtros.Controls.Add(this.txt_Nom_Prof);
            this.GB_Filtros.Controls.Add(this.label4);
            this.GB_Filtros.Controls.Add(this.txt_esp);
            this.GB_Filtros.Controls.Add(this.label3);
            this.GB_Filtros.Controls.Add(this.txt_Id_Afi);
            this.GB_Filtros.Controls.Add(this.label2);
            this.GB_Filtros.Controls.Add(this.txt_Ape_Prof);
            this.GB_Filtros.Controls.Add(this.label1);
            this.GB_Filtros.Location = new System.Drawing.Point(12, 12);
            this.GB_Filtros.Name = "GB_Filtros";
            this.GB_Filtros.Size = new System.Drawing.Size(745, 153);
            this.GB_Filtros.TabIndex = 1;
            this.GB_Filtros.TabStop = false;
            this.GB_Filtros.Text = "Filtros de Búsqueda";
            // 
            // B_Calendario
            // 
            this.B_Calendario.Location = new System.Drawing.Point(264, 111);
            this.B_Calendario.Name = "B_Calendario";
            this.B_Calendario.Size = new System.Drawing.Size(86, 23);
            this.B_Calendario.TabIndex = 11;
            this.B_Calendario.Text = "Calendario";
            this.B_Calendario.UseVisualStyleBackColor = true;
            this.B_Calendario.Click += new System.EventHandler(this.B_Calendario_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "* (Campos Obligatorios)";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(128, 113);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(116, 20);
            this.txt_fecha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha del Turno:";
            // 
            // txt_Nom_Prof
            // 
            this.txt_Nom_Prof.Location = new System.Drawing.Point(427, 25);
            this.txt_Nom_Prof.Name = "txt_Nom_Prof";
            this.txt_Nom_Prof.Size = new System.Drawing.Size(121, 20);
            this.txt_Nom_Prof.TabIndex = 7;
            this.txt_Nom_Prof.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "* Id del Afiliado:";
            // 
            // txt_esp
            // 
            this.txt_esp.Location = new System.Drawing.Point(128, 68);
            this.txt_esp.Name = "txt_esp";
            this.txt_esp.Size = new System.Drawing.Size(116, 20);
            this.txt_esp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Especialidad:";
            // 
            // txt_Id_Afi
            // 
            this.txt_Id_Afi.Location = new System.Drawing.Point(128, 25);
            this.txt_Id_Afi.Name = "txt_Id_Afi";
            this.txt_Id_Afi.Size = new System.Drawing.Size(116, 20);
            this.txt_Id_Afi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido del Profesional:";
            // 
            // txt_Ape_Prof
            // 
            this.txt_Ape_Prof.Location = new System.Drawing.Point(427, 68);
            this.txt_Ape_Prof.Name = "txt_Ape_Prof";
            this.txt_Ape_Prof.Size = new System.Drawing.Size(121, 20);
            this.txt_Ape_Prof.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Profesional:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(276, 158);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 14;
            this.Calendario.Visible = false;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // grillaTurnos
            // 
            this.grillaTurnos.AllowUserToAddRows = false;
            this.grillaTurnos.AllowUserToDeleteRows = false;
            this.grillaTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Afiliado,
            this.Apellido_Afiliado,
            this.Especialidad,
            this.Nombre_Profesional,
            this.Apellido_Profesional,
            this.Fecha_Turno,
            this.Id_Afi,
            this.Id_Turno});
            this.grillaTurnos.Location = new System.Drawing.Point(10, 171);
            this.grillaTurnos.Name = "grillaTurnos";
            this.grillaTurnos.ReadOnly = true;
            this.grillaTurnos.Size = new System.Drawing.Size(747, 197);
            this.grillaTurnos.TabIndex = 2;
            // 
            // Nombre_Afiliado
            // 
            this.Nombre_Afiliado.HeaderText = "Nombre del Afiliado";
            this.Nombre_Afiliado.Name = "Nombre_Afiliado";
            this.Nombre_Afiliado.ReadOnly = true;
            // 
            // Apellido_Afiliado
            // 
            this.Apellido_Afiliado.HeaderText = "Apellido del Afiliado";
            this.Apellido_Afiliado.Name = "Apellido_Afiliado";
            this.Apellido_Afiliado.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 150;
            // 
            // Nombre_Profesional
            // 
            this.Nombre_Profesional.HeaderText = "Nombre del Profesional";
            this.Nombre_Profesional.Name = "Nombre_Profesional";
            this.Nombre_Profesional.ReadOnly = true;
            // 
            // Apellido_Profesional
            // 
            this.Apellido_Profesional.HeaderText = "Apellido del Profesional";
            this.Apellido_Profesional.Name = "Apellido_Profesional";
            this.Apellido_Profesional.ReadOnly = true;
            // 
            // Fecha_Turno
            // 
            this.Fecha_Turno.HeaderText = "Fecha del Turno";
            this.Fecha_Turno.Name = "Fecha_Turno";
            this.Fecha_Turno.ReadOnly = true;
            this.Fecha_Turno.Width = 130;
            // 
            // Id_Afi
            // 
            this.Id_Afi.HeaderText = "Id_Afi";
            this.Id_Afi.Name = "Id_Afi";
            this.Id_Afi.ReadOnly = true;
            this.Id_Afi.Visible = false;
            // 
            // Id_Turno
            // 
            this.Id_Turno.HeaderText = "Id_Turno";
            this.Id_Turno.Name = "Id_Turno";
            this.Id_Turno.ReadOnly = true;
            this.Id_Turno.Visible = false;
            // 
            // Cancelar_Turno
            // 
            this.Cancelar_Turno.Location = new System.Drawing.Point(12, 531);
            this.Cancelar_Turno.Name = "Cancelar_Turno";
            this.Cancelar_Turno.Size = new System.Drawing.Size(129, 41);
            this.Cancelar_Turno.TabIndex = 3;
            this.Cancelar_Turno.Text = "Cancelar Turno";
            this.Cancelar_Turno.UseVisualStyleBackColor = true;
            this.Cancelar_Turno.Click += new System.EventHandler(this.Cancelar_Turno_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(620, 531);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(131, 41);
            this.Cerrar.TabIndex = 4;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // CB_Cancelaciones
            // 
            this.CB_Cancelaciones.FormattingEnabled = true;
            this.CB_Cancelaciones.Location = new System.Drawing.Point(178, 388);
            this.CB_Cancelaciones.Name = "CB_Cancelaciones";
            this.CB_Cancelaciones.Size = new System.Drawing.Size(293, 21);
            this.CB_Cancelaciones.TabIndex = 15;
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(178, 423);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(293, 102);
            this.txt_motivo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Motivo de Cancelación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo de Cancelación:";
            // 
            // Cancelar_Turno_Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.CB_Cancelaciones);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.GB_Filtros);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Cancelar_Turno);
            this.Controls.Add(this.grillaTurnos);
            this.Name = "Cancelar_Turno_Afiliado";
            this.Text = "Cancelar Turno Afilado";
            this.Load += new System.EventHandler(this.Cancelar_Turno_Afiliado_Load);
            this.GB_Filtros.ResumeLayout(false);
            this.GB_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.GroupBox GB_Filtros;
        private System.Windows.Forms.TextBox txt_Nom_Prof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_esp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id_Afi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ape_Prof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaTurnos;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancelar_Turno;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Button B_Calendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Afi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Turno;
        private System.Windows.Forms.ComboBox CB_Cancelaciones;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}