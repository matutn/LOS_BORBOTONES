﻿namespace Clinica_Frba.Abm_Rol
{
    partial class Abm_Rol_Form
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
            this.GB_Rol = new System.Windows.Forms.GroupBox();
            this.L_Funcionalidad = new System.Windows.Forms.Label();
            this.grillaFunc = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.txt_Nombre_Rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IdFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncAgregada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GB_Rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Rol
            // 
            this.GB_Rol.Controls.Add(this.button1);
            this.GB_Rol.Controls.Add(this.L_Funcionalidad);
            this.GB_Rol.Controls.Add(this.grillaFunc);
            this.GB_Rol.Controls.Add(this.button2);
            this.GB_Rol.Location = new System.Drawing.Point(18, 38);
            this.GB_Rol.Name = "GB_Rol";
            this.GB_Rol.Size = new System.Drawing.Size(410, 211);
            this.GB_Rol.TabIndex = 43;
            this.GB_Rol.TabStop = false;
            // 
            // L_Funcionalidad
            // 
            this.L_Funcionalidad.AutoSize = true;
            this.L_Funcionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Funcionalidad.Location = new System.Drawing.Point(6, 19);
            this.L_Funcionalidad.Name = "L_Funcionalidad";
            this.L_Funcionalidad.Size = new System.Drawing.Size(115, 17);
            this.L_Funcionalidad.TabIndex = 51;
            this.L_Funcionalidad.Text = "Funcionalidades:";
            // 
            // grillaFunc
            // 
            this.grillaFunc.AllowUserToAddRows = false;
            this.grillaFunc.AllowUserToDeleteRows = false;
            this.grillaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFunc,
            this.Funcionalidad,
            this.FuncAgregada});
            this.grillaFunc.Location = new System.Drawing.Point(127, 19);
            this.grillaFunc.Name = "grillaFunc";
            this.grillaFunc.Size = new System.Drawing.Size(277, 150);
            this.grillaFunc.TabIndex = 50;
            this.grillaFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaFunc_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Quitar Todas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(300, 255);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(90, 23);
            this.B_Cancelar.TabIndex = 44;
            this.B_Cancelar.Text = "Cerrar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click_1);
            // 
            // txt_Nombre_Rol
            // 
            this.txt_Nombre_Rol.Location = new System.Drawing.Point(145, 12);
            this.txt_Nombre_Rol.Name = "txt_Nombre_Rol";
            this.txt_Nombre_Rol.Size = new System.Drawing.Size(142, 20);
            this.txt_Nombre_Rol.TabIndex = 44;
            this.txt_Nombre_Rol.TextChanged += new System.EventHandler(this.txt_Nombre_Rol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre del Rol:";
            // 
            // B_Aceptar
            // 
            this.B_Aceptar.Location = new System.Drawing.Point(18, 255);
            this.B_Aceptar.Name = "B_Aceptar";
            this.B_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_Aceptar.TabIndex = 0;
            this.B_Aceptar.Text = "Aceptar";
            this.B_Aceptar.UseVisualStyleBackColor = true;
            this.B_Aceptar.Click += new System.EventHandler(this.B_Aceptar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Añadir Todas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IdFunc
            // 
            this.IdFunc.HeaderText = "Id Funcionalidad";
            this.IdFunc.Name = "IdFunc";
            this.IdFunc.Visible = false;
            this.IdFunc.Width = 93;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Width = 130;
            // 
            // FuncAgregada
            // 
            this.FuncAgregada.HeaderText = "Agregada";
            this.FuncAgregada.Name = "FuncAgregada";
            this.FuncAgregada.Width = 95;
            // 
            // Abm_Rol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 289);
            this.Controls.Add(this.GB_Rol);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.txt_Nombre_Rol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Aceptar);
            this.Name = "Abm_Rol_Form";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.Abm_Rol_Form_Load);
            this.GB_Rol.ResumeLayout(false);
            this.GB_Rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Rol;
        private System.Windows.Forms.Button B_Aceptar;
        private System.Windows.Forms.TextBox txt_Nombre_Rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.DataGridView grillaFunc;
        private System.Windows.Forms.Label L_Funcionalidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FuncAgregada;
    }
}