namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelaProfesional
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
            this.Calendario2 = new System.Windows.Forms.MonthCalendar();
            this.GB_Agenda_Prof = new System.Windows.Forms.GroupBox();
            this.B_Cerrar = new System.Windows.Forms.Button();
            this.B_Calendario2 = new System.Windows.Forms.Button();
            this.txt_fechaAgenda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.B_DarDeBaja = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IdProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.CB_Cancelaciones = new System.Windows.Forms.ComboBox();
            this.GB_Agenda_Prof.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendario2
            // 
            this.Calendario2.Location = new System.Drawing.Point(387, 62);
            this.Calendario2.Name = "Calendario2";
            this.Calendario2.TabIndex = 19;
            this.Calendario2.Visible = false;
            // 
            // GB_Agenda_Prof
            // 
            this.GB_Agenda_Prof.Controls.Add(this.label7);
            this.GB_Agenda_Prof.Controls.Add(this.label8);
            this.GB_Agenda_Prof.Controls.Add(this.txt_motivo);
            this.GB_Agenda_Prof.Controls.Add(this.CB_Cancelaciones);
            this.GB_Agenda_Prof.Controls.Add(this.B_Cerrar);
            this.GB_Agenda_Prof.Controls.Add(this.Calendario2);
            this.GB_Agenda_Prof.Controls.Add(this.B_Calendario2);
            this.GB_Agenda_Prof.Controls.Add(this.txt_fechaAgenda);
            this.GB_Agenda_Prof.Controls.Add(this.label5);
            this.GB_Agenda_Prof.Controls.Add(this.B_DarDeBaja);
            this.GB_Agenda_Prof.Controls.Add(this.label4);
            this.GB_Agenda_Prof.Controls.Add(this.txt_IdProf);
            this.GB_Agenda_Prof.Location = new System.Drawing.Point(12, 12);
            this.GB_Agenda_Prof.Name = "GB_Agenda_Prof";
            this.GB_Agenda_Prof.Size = new System.Drawing.Size(576, 329);
            this.GB_Agenda_Prof.TabIndex = 15;
            this.GB_Agenda_Prof.TabStop = false;
            this.GB_Agenda_Prof.Text = "Filtros de Búsqueda";
            // 
            // B_Cerrar
            // 
            this.B_Cerrar.Location = new System.Drawing.Point(403, 275);
            this.B_Cerrar.Name = "B_Cerrar";
            this.B_Cerrar.Size = new System.Drawing.Size(155, 34);
            this.B_Cerrar.TabIndex = 20;
            this.B_Cerrar.Text = "Cerrar";
            this.B_Cerrar.UseVisualStyleBackColor = true;
            this.B_Cerrar.Click += new System.EventHandler(this.B_Cerrar_Click);
            // 
            // B_Calendario2
            // 
            this.B_Calendario2.Location = new System.Drawing.Point(289, 62);
            this.B_Calendario2.Name = "B_Calendario2";
            this.B_Calendario2.Size = new System.Drawing.Size(86, 23);
            this.B_Calendario2.TabIndex = 11;
            this.B_Calendario2.Text = "Calendario";
            this.B_Calendario2.UseVisualStyleBackColor = true;
            this.B_Calendario2.Click += new System.EventHandler(this.B_Calendario2_Click);
            // 
            // txt_fechaAgenda
            // 
            this.txt_fechaAgenda.Enabled = false;
            this.txt_fechaAgenda.Location = new System.Drawing.Point(153, 65);
            this.txt_fechaAgenda.Name = "txt_fechaAgenda";
            this.txt_fechaAgenda.Size = new System.Drawing.Size(116, 20);
            this.txt_fechaAgenda.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha del Turno:";
            // 
            // B_DarDeBaja
            // 
            this.B_DarDeBaja.Location = new System.Drawing.Point(11, 275);
            this.B_DarDeBaja.Name = "B_DarDeBaja";
            this.B_DarDeBaja.Size = new System.Drawing.Size(155, 34);
            this.B_DarDeBaja.TabIndex = 0;
            this.B_DarDeBaja.Text = "Cancelar Día";
            this.B_DarDeBaja.UseVisualStyleBackColor = true;
            this.B_DarDeBaja.Click += new System.EventHandler(this.B_DarDeBaja_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id del Profesional:";
            // 
            // txt_IdProf
            // 
            this.txt_IdProf.Location = new System.Drawing.Point(153, 28);
            this.txt_IdProf.Name = "txt_IdProf";
            this.txt_IdProf.Size = new System.Drawing.Size(116, 20);
            this.txt_IdProf.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Motivo de Cancelación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tipo de Cancelación:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.Location = new System.Drawing.Point(9, 167);
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(293, 102);
            this.txt_motivo.TabIndex = 24;
            // 
            // CB_Cancelaciones
            // 
            this.CB_Cancelaciones.FormattingEnabled = true;
            this.CB_Cancelaciones.Location = new System.Drawing.Point(153, 111);
            this.CB_Cancelaciones.Name = "CB_Cancelaciones";
            this.CB_Cancelaciones.Size = new System.Drawing.Size(116, 21);
            this.CB_Cancelaciones.TabIndex = 23;
            // 
            // CancelaProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 349);
            this.Controls.Add(this.GB_Agenda_Prof);
            this.Name = "CancelaProfesional";
            this.Text = "CancelaProfesional";
            this.Load += new System.EventHandler(this.CancelaProfesional_Load);
            this.GB_Agenda_Prof.ResumeLayout(false);
            this.GB_Agenda_Prof.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario2;
        private System.Windows.Forms.GroupBox GB_Agenda_Prof;
        private System.Windows.Forms.Button B_Calendario2;
        private System.Windows.Forms.TextBox txt_fechaAgenda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_DarDeBaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdProf;
        private System.Windows.Forms.Button B_Cerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.ComboBox CB_Cancelaciones;
    }
}