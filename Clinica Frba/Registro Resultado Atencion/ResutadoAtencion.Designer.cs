namespace Clinica_Frba.ResultadoAtencion
{
    partial class Resultado_Atencion_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id_Prof = new System.Windows.Forms.TextBox();
            this.grillaAtenciones = new System.Windows.Forms.DataGridView();
            this.afi_Ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afi_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Afi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Cargar_Atencion = new System.Windows.Forms.Button();
            this.GB_Carga = new System.Windows.Forms.GroupBox();
            this.GB_Concreto = new System.Windows.Forms.GroupBox();
            this.TB_Sintomas = new System.Windows.Forms.TextBox();
            this.DTP_Dia = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DTP_Horario = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Diagnostico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAtenciones)).BeginInit();
            this.GB_Carga.SuspendLayout();
            this.GB_Concreto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id del Profesional:";
            // 
            // txt_Id_Prof
            // 
            this.txt_Id_Prof.Location = new System.Drawing.Point(192, 15);
            this.txt_Id_Prof.Name = "txt_Id_Prof";
            this.txt_Id_Prof.Size = new System.Drawing.Size(100, 20);
            this.txt_Id_Prof.TabIndex = 1;
            // 
            // grillaAtenciones
            // 
            this.grillaAtenciones.AllowUserToAddRows = false;
            this.grillaAtenciones.AllowUserToDeleteRows = false;
            this.grillaAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAtenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.afi_Ape,
            this.Afi_Nom,
            this.Fecha_Turno,
            this.Id_Turno,
            this.Id_Afi,
            this.Id_Consulta});
            this.grillaAtenciones.Location = new System.Drawing.Point(192, 41);
            this.grillaAtenciones.Name = "grillaAtenciones";
            this.grillaAtenciones.ReadOnly = true;
            this.grillaAtenciones.Size = new System.Drawing.Size(429, 150);
            this.grillaAtenciones.TabIndex = 2;
            // 
            // afi_Ape
            // 
            this.afi_Ape.HeaderText = "Apellido del Afiliado";
            this.afi_Ape.Name = "afi_Ape";
            this.afi_Ape.ReadOnly = true;
            this.afi_Ape.Width = 120;
            // 
            // Afi_Nom
            // 
            this.Afi_Nom.HeaderText = "Nombre del Afiliado";
            this.Afi_Nom.Name = "Afi_Nom";
            this.Afi_Nom.ReadOnly = true;
            this.Afi_Nom.Width = 120;
            // 
            // Fecha_Turno
            // 
            this.Fecha_Turno.HeaderText = "Fecha del Turno";
            this.Fecha_Turno.Name = "Fecha_Turno";
            this.Fecha_Turno.ReadOnly = true;
            this.Fecha_Turno.Width = 130;
            // 
            // Id_Turno
            // 
            this.Id_Turno.HeaderText = "Id_Turno";
            this.Id_Turno.Name = "Id_Turno";
            this.Id_Turno.ReadOnly = true;
            this.Id_Turno.Visible = false;
            // 
            // Id_Afi
            // 
            this.Id_Afi.HeaderText = "Id_Afi";
            this.Id_Afi.Name = "Id_Afi";
            this.Id_Afi.ReadOnly = true;
            this.Id_Afi.Visible = false;
            // 
            // Id_Consulta
            // 
            this.Id_Consulta.HeaderText = "Id_Consulta";
            this.Id_Consulta.Name = "Id_Consulta";
            this.Id_Consulta.ReadOnly = true;
            this.Id_Consulta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Atenciones del Profesional:";
            // 
            // B_Cargar_Atencion
            // 
            this.B_Cargar_Atencion.Location = new System.Drawing.Point(17, 167);
            this.B_Cargar_Atencion.Name = "B_Cargar_Atencion";
            this.B_Cargar_Atencion.Size = new System.Drawing.Size(150, 24);
            this.B_Cargar_Atencion.TabIndex = 4;
            this.B_Cargar_Atencion.Text = "Cargar Atención";
            this.B_Cargar_Atencion.UseVisualStyleBackColor = true;
            this.B_Cargar_Atencion.Click += new System.EventHandler(this.B_Cargar_Atencion_Click_1);
            // 
            // GB_Carga
            // 
            this.GB_Carga.Controls.Add(this.GB_Concreto);
            this.GB_Carga.Controls.Add(this.button3);
            this.GB_Carga.Controls.Add(this.button2);
            this.GB_Carga.Controls.Add(this.button1);
            this.GB_Carga.Controls.Add(this.label3);
            this.GB_Carga.Controls.Add(this.radioButton2);
            this.GB_Carga.Controls.Add(this.radioButton1);
            this.GB_Carga.Enabled = false;
            this.GB_Carga.Location = new System.Drawing.Point(12, 223);
            this.GB_Carga.Name = "GB_Carga";
            this.GB_Carga.Size = new System.Drawing.Size(632, 414);
            this.GB_Carga.TabIndex = 5;
            this.GB_Carga.TabStop = false;
            // 
            // GB_Concreto
            // 
            this.GB_Concreto.Controls.Add(this.TB_Sintomas);
            this.GB_Concreto.Controls.Add(this.DTP_Dia);
            this.GB_Concreto.Controls.Add(this.label4);
            this.GB_Concreto.Controls.Add(this.DTP_Horario);
            this.GB_Concreto.Controls.Add(this.label6);
            this.GB_Concreto.Controls.Add(this.TB_Diagnostico);
            this.GB_Concreto.Controls.Add(this.label7);
            this.GB_Concreto.Enabled = false;
            this.GB_Concreto.Location = new System.Drawing.Point(41, 82);
            this.GB_Concreto.Name = "GB_Concreto";
            this.GB_Concreto.Size = new System.Drawing.Size(580, 231);
            this.GB_Concreto.TabIndex = 24;
            this.GB_Concreto.TabStop = false;
            // 
            // TB_Sintomas
            // 
            this.TB_Sintomas.Location = new System.Drawing.Point(142, 60);
            this.TB_Sintomas.Multiline = true;
            this.TB_Sintomas.Name = "TB_Sintomas";
            this.TB_Sintomas.Size = new System.Drawing.Size(246, 76);
            this.TB_Sintomas.TabIndex = 16;
            // 
            // DTP_Dia
            // 
            this.DTP_Dia.Location = new System.Drawing.Point(142, 13);
            this.DTP_Dia.Name = "DTP_Dia";
            this.DTP_Dia.Size = new System.Drawing.Size(206, 20);
            this.DTP_Dia.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de Atención:";
            // 
            // DTP_Horario
            // 
            this.DTP_Horario.CustomFormat = "";
            this.DTP_Horario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_Horario.Location = new System.Drawing.Point(354, 13);
            this.DTP_Horario.Name = "DTP_Horario";
            this.DTP_Horario.ShowUpDown = true;
            this.DTP_Horario.Size = new System.Drawing.Size(94, 20);
            this.DTP_Horario.TabIndex = 22;
            this.DTP_Horario.Value = new System.DateTime(2013, 12, 13, 13, 52, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Síntomas:";
            // 
            // TB_Diagnostico
            // 
            this.TB_Diagnostico.Location = new System.Drawing.Point(142, 142);
            this.TB_Diagnostico.Multiline = true;
            this.TB_Diagnostico.Name = "TB_Diagnostico";
            this.TB_Diagnostico.Size = new System.Drawing.Size(246, 75);
            this.TB_Diagnostico.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Diagnóstico:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 24);
            this.button3.TabIndex = 21;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Generar Receta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar Atención";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "La atención:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(41, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(225, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Se concretó satisfactoriamente.";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(41, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No se concretó.";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grillaAtenciones);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.B_Cargar_Atencion);
            this.groupBox2.Controls.Add(this.txt_Id_Prof);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(632, 205);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Resultado_Atencion_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_Carga);
            this.Name = "Resultado_Atencion_Form";
            this.Text = "Resultado Atención";
            this.Load += new System.EventHandler(this.Resultado_Atencion_Form_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grillaAtenciones)).EndInit();
            this.GB_Carga.ResumeLayout(false);
            this.GB_Carga.PerformLayout();
            this.GB_Concreto.ResumeLayout(false);
            this.GB_Concreto.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id_Prof;
        private System.Windows.Forms.DataGridView grillaAtenciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Cargar_Atencion;
        private System.Windows.Forms.GroupBox GB_Carga;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Diagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Sintomas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn afi_Ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afi_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Afi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Consulta;
        private System.Windows.Forms.DateTimePicker DTP_Dia;
        private System.Windows.Forms.DateTimePicker DTP_Horario;
        private System.Windows.Forms.GroupBox GB_Concreto;
    }
}