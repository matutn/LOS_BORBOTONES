namespace Clinica_Frba.RegLlegada
{
    partial class RegLlegada_Form
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
            this.txt_Nom_Prof = new System.Windows.Forms.TextBox();
            this.txt_esp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Volver = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Id_Bono = new System.Windows.Forms.TextBox();
            this.FiltrosProf = new System.Windows.Forms.GroupBox();
            this.txt_Ape_Prof = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.grillaTurno = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Id_Afi = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nombre_Prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Afi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.FiltrosProf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nom_Prof
            // 
            this.txt_Nom_Prof.Location = new System.Drawing.Point(110, 19);
            this.txt_Nom_Prof.Name = "txt_Nom_Prof";
            this.txt_Nom_Prof.Size = new System.Drawing.Size(140, 20);
            this.txt_Nom_Prof.TabIndex = 1;
            // 
            // txt_esp
            // 
            this.txt_esp.Location = new System.Drawing.Point(110, 105);
            this.txt_esp.Name = "txt_esp";
            this.txt_esp.Size = new System.Drawing.Size(140, 20);
            this.txt_esp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Volver);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Id_Bono);
            this.groupBox1.Controls.Add(this.FiltrosProf);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.grillaTurno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Id_Afi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 514);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Llegada";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(307, 429);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 15;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(226, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nro de Bono Consulta:";
            // 
            // txt_Id_Bono
            // 
            this.txt_Id_Bono.Enabled = false;
            this.txt_Id_Bono.Location = new System.Drawing.Point(163, 471);
            this.txt_Id_Bono.Name = "txt_Id_Bono";
            this.txt_Id_Bono.Size = new System.Drawing.Size(138, 20);
            this.txt_Id_Bono.TabIndex = 12;
            this.txt_Id_Bono.TextChanged += new System.EventHandler(this.txt_Id_Bono_TextChanged);
            // 
            // FiltrosProf
            // 
            this.FiltrosProf.Controls.Add(this.txt_Ape_Prof);
            this.FiltrosProf.Controls.Add(this.label4);
            this.FiltrosProf.Controls.Add(this.label1);
            this.FiltrosProf.Controls.Add(this.txt_Nom_Prof);
            this.FiltrosProf.Controls.Add(this.txt_esp);
            this.FiltrosProf.Controls.Add(this.label3);
            this.FiltrosProf.Location = new System.Drawing.Point(9, 25);
            this.FiltrosProf.Name = "FiltrosProf";
            this.FiltrosProf.Size = new System.Drawing.Size(264, 140);
            this.FiltrosProf.TabIndex = 11;
            this.FiltrosProf.TabStop = false;
            this.FiltrosProf.Text = "Filtros de Profesional";
            // 
            // txt_Ape_Prof
            // 
            this.txt_Ape_Prof.Location = new System.Drawing.Point(110, 60);
            this.txt_Ape_Prof.Name = "txt_Ape_Prof";
            this.txt_Ape_Prof.Size = new System.Drawing.Size(140, 20);
            this.txt_Ape_Prof.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Especialidad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grillaTurno
            // 
            this.grillaTurno.AllowUserToAddRows = false;
            this.grillaTurno.AllowUserToDeleteRows = false;
            this.grillaTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Prof,
            this.Apellido_Profesional,
            this.Especialidad,
            this.Nombre_Afi,
            this.Apellido_Afiliado,
            this.Fecha,
            this.IdAfi,
            this.IdTurno});
            this.grillaTurno.Location = new System.Drawing.Point(9, 171);
            this.grillaTurno.Name = "grillaTurno";
            this.grillaTurno.ReadOnly = true;
            this.grillaTurno.Size = new System.Drawing.Size(821, 252);
            this.grillaTurno.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id del Afiliado:";
            // 
            // txt_Id_Afi
            // 
            this.txt_Id_Afi.Location = new System.Drawing.Point(109, 429);
            this.txt_Id_Afi.Name = "txt_Id_Afi";
            this.txt_Id_Afi.Size = new System.Drawing.Size(100, 20);
            this.txt_Id_Afi.TabIndex = 7;
            // 
            // Registrar
            // 
            this.Registrar.Location = new System.Drawing.Point(12, 532);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(75, 24);
            this.Registrar.TabIndex = 6;
            this.Registrar.Text = "Registrar";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nombre_Prof
            // 
            this.Nombre_Prof.HeaderText = "Nombre Profesional";
            this.Nombre_Prof.Name = "Nombre_Prof";
            this.Nombre_Prof.ReadOnly = true;
            // 
            // Apellido_Profesional
            // 
            this.Apellido_Profesional.HeaderText = "Apellido Profesional";
            this.Apellido_Profesional.Name = "Apellido_Profesional";
            this.Apellido_Profesional.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 200;
            // 
            // Nombre_Afi
            // 
            this.Nombre_Afi.HeaderText = "Nombre Afiliado";
            this.Nombre_Afi.Name = "Nombre_Afi";
            this.Nombre_Afi.ReadOnly = true;
            this.Nombre_Afi.ToolTipText = "No";
            // 
            // Apellido_Afiliado
            // 
            this.Apellido_Afiliado.HeaderText = "Apellido Afiliado";
            this.Apellido_Afiliado.Name = "Apellido_Afiliado";
            this.Apellido_Afiliado.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha del Turno";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 160;
            // 
            // IdAfi
            // 
            this.IdAfi.HeaderText = "IdAfi";
            this.IdAfi.Name = "IdAfi";
            this.IdAfi.ReadOnly = true;
            this.IdAfi.Visible = false;
            // 
            // IdTurno
            // 
            this.IdTurno.HeaderText = "IdTurno";
            this.IdTurno.Name = "IdTurno";
            this.IdTurno.ReadOnly = true;
            this.IdTurno.Visible = false;
            // 
            // RegLlegada_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 567);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegLlegada_Form";
            this.Text = "Registro de Llegada";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FiltrosProf.ResumeLayout(false);
            this.FiltrosProf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nom_Prof;
        private System.Windows.Forms.TextBox txt_esp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Id_Afi;
        private System.Windows.Forms.DataGridView grillaTurno;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox FiltrosProf;
        private System.Windows.Forms.TextBox txt_Ape_Prof;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Id_Bono;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Profesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Afi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTurno;
    }
}