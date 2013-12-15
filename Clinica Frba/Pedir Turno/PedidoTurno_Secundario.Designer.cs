namespace Clinica_Frba.Pedir_Turno
{
    partial class PedidoTurno_Secundario
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
            this.calendario_Profesional = new System.Windows.Forms.MonthCalendar();
            this.txt_HoraDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_profesional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Confirmar = new System.Windows.Forms.Button();
            this.txt_HoraConfirmar = new System.Windows.Forms.NumericUpDown();
            this.txt_MinutoConfirmar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_HoraHasta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_InfoDia = new System.Windows.Forms.TextBox();
            this.txt_MinutoDesde = new System.Windows.Forms.TextBox();
            this.txt_MinutoHasta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoraConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MinutoConfirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // calendario_Profesional
            // 
            this.calendario_Profesional.Location = new System.Drawing.Point(17, 27);
            this.calendario_Profesional.MinDate = new System.DateTime(2013, 12, 12, 0, 0, 0, 0);
            this.calendario_Profesional.Name = "calendario_Profesional";
            this.calendario_Profesional.TabIndex = 0;
            this.calendario_Profesional.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_Profesional_DateChanged);
            // 
            // txt_HoraDesde
            // 
            this.txt_HoraDesde.Location = new System.Drawing.Point(300, 78);
            this.txt_HoraDesde.Name = "txt_HoraDesde";
            this.txt_HoraDesde.ReadOnly = true;
            this.txt_HoraDesde.Size = new System.Drawing.Size(22, 20);
            this.txt_HoraDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horario de atención :";
            // 
            // txt_profesional
            // 
            this.txt_profesional.Location = new System.Drawing.Point(260, 27);
            this.txt_profesional.Name = "txt_profesional";
            this.txt_profesional.ReadOnly = true;
            this.txt_profesional.Size = new System.Drawing.Size(156, 20);
            this.txt_profesional.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profesional :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccionar horario disponible :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calendario Profesional";
            // 
            // button_Confirmar
            // 
            this.button_Confirmar.Location = new System.Drawing.Point(344, 218);
            this.button_Confirmar.Name = "button_Confirmar";
            this.button_Confirmar.Size = new System.Drawing.Size(117, 23);
            this.button_Confirmar.TabIndex = 8;
            this.button_Confirmar.Text = "Confirmar Turno";
            this.button_Confirmar.UseVisualStyleBackColor = true;
            this.button_Confirmar.Click += new System.EventHandler(this.button_Confirmar_Click);
            // 
            // txt_HoraConfirmar
            // 
            this.txt_HoraConfirmar.Location = new System.Drawing.Point(297, 189);
            this.txt_HoraConfirmar.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txt_HoraConfirmar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_HoraConfirmar.Name = "txt_HoraConfirmar";
            this.txt_HoraConfirmar.Size = new System.Drawing.Size(44, 20);
            this.txt_HoraConfirmar.TabIndex = 9;
            this.txt_HoraConfirmar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_HoraConfirmar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txt_MinutoConfirmar
            // 
            this.txt_MinutoConfirmar.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txt_MinutoConfirmar.Location = new System.Drawing.Point(398, 189);
            this.txt_MinutoConfirmar.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txt_MinutoConfirmar.Name = "txt_MinutoConfirmar";
            this.txt_MinutoConfirmar.Size = new System.Drawing.Size(44, 20);
            this.txt_MinutoConfirmar.TabIndex = 10;
            this.txt_MinutoConfirmar.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Desde :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Hasta :";
            // 
            // txt_HoraHasta
            // 
            this.txt_HoraHasta.Location = new System.Drawing.Point(300, 108);
            this.txt_HoraHasta.Name = "txt_HoraHasta";
            this.txt_HoraHasta.ReadOnly = true;
            this.txt_HoraHasta.Size = new System.Drawing.Size(22, 20);
            this.txt_HoraHasta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hora :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Minuto :";
            // 
            // txt_InfoDia
            // 
            this.txt_InfoDia.Location = new System.Drawing.Point(260, 134);
            this.txt_InfoDia.Name = "txt_InfoDia";
            this.txt_InfoDia.ReadOnly = true;
            this.txt_InfoDia.Size = new System.Drawing.Size(156, 20);
            this.txt_InfoDia.TabIndex = 16;
            // 
            // txt_MinutoDesde
            // 
            this.txt_MinutoDesde.Location = new System.Drawing.Point(340, 78);
            this.txt_MinutoDesde.Name = "txt_MinutoDesde";
            this.txt_MinutoDesde.ReadOnly = true;
            this.txt_MinutoDesde.Size = new System.Drawing.Size(22, 20);
            this.txt_MinutoDesde.TabIndex = 17;
            // 
            // txt_MinutoHasta
            // 
            this.txt_MinutoHasta.Location = new System.Drawing.Point(340, 108);
            this.txt_MinutoHasta.Name = "txt_MinutoHasta";
            this.txt_MinutoHasta.ReadOnly = true;
            this.txt_MinutoHasta.Size = new System.Drawing.Size(22, 20);
            this.txt_MinutoHasta.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = ":";
            // 
            // PedidoTurno_Secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 253);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_MinutoHasta);
            this.Controls.Add(this.txt_MinutoDesde);
            this.Controls.Add(this.txt_InfoDia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_HoraHasta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MinutoConfirmar);
            this.Controls.Add(this.txt_HoraConfirmar);
            this.Controls.Add(this.button_Confirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_profesional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_HoraDesde);
            this.Controls.Add(this.calendario_Profesional);
            this.Name = "PedidoTurno_Secundario";
            this.Text = "PedidoTurno_Secundario";
            this.Load += new System.EventHandler(this.PedidoTurno_Secundario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoraConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MinutoConfirmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendario_Profesional;
        private System.Windows.Forms.TextBox txt_HoraDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_profesional;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Confirmar;
        private System.Windows.Forms.NumericUpDown txt_HoraConfirmar;
        private System.Windows.Forms.NumericUpDown txt_MinutoConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_HoraHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_InfoDia;
        private System.Windows.Forms.TextBox txt_MinutoDesde;
        private System.Windows.Forms.TextBox txt_MinutoHasta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}