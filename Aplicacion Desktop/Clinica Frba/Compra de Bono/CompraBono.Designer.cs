﻿namespace Clinica_Frba.Compra_de_Bono
{
    partial class CompraBono
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
            this.dniAfi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.montoTotal = new System.Windows.Forms.TextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idPlan = new System.Windows.Forms.TextBox();
            this.cantBC = new System.Windows.Forms.NumericUpDown();
            this.cantBF = new System.Windows.Forms.NumericUpDown();
            this.fechaCompra = new System.Windows.Forms.Label();
            this.L_Mes = new System.Windows.Forms.Label();
            this.mesCompra = new System.Windows.Forms.TextBox();
            this.L_Año = new System.Windows.Forms.Label();
            this.añoCompra = new System.Windows.Forms.TextBox();
            this.diaCompra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cantBC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantBF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI :";
            // 
            // dniAfi
            // 
            this.dniAfi.Location = new System.Drawing.Point(53, 12);
            this.dniAfi.Name = "dniAfi";
            this.dniAfi.ReadOnly = true;
            this.dniAfi.Size = new System.Drawing.Size(100, 20);
            this.dniAfi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad a comprar de Bonos Consulta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad a comprar de Bonos Farmacia :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Monto Total:";
            // 
            // montoTotal
            // 
            this.montoTotal.Location = new System.Drawing.Point(88, 141);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Size = new System.Drawing.Size(100, 20);
            this.montoTotal.TabIndex = 16;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(246, 173);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 17;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(165, 173);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 18;
            this.button_Aceptar.Text = "Comprar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Plan :";
            // 
            // idPlan
            // 
            this.idPlan.Location = new System.Drawing.Point(221, 12);
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            this.idPlan.Size = new System.Drawing.Size(100, 20);
            this.idPlan.TabIndex = 20;
            // 
            // cantBC
            // 
            this.cantBC.Location = new System.Drawing.Point(218, 79);
            this.cantBC.Name = "cantBC";
            this.cantBC.Size = new System.Drawing.Size(100, 20);
            this.cantBC.TabIndex = 21;
            this.cantBC.ValueChanged += new System.EventHandler(this.cantBC_ValueChanged);
            // 
            // cantBF
            // 
            this.cantBF.Location = new System.Drawing.Point(218, 109);
            this.cantBF.Name = "cantBF";
            this.cantBF.Size = new System.Drawing.Size(100, 20);
            this.cantBF.TabIndex = 22;
            this.cantBF.ValueChanged += new System.EventHandler(this.cantBF_ValueChanged);
            // 
            // fechaCompra
            // 
            this.fechaCompra.AutoSize = true;
            this.fechaCompra.Location = new System.Drawing.Point(15, 51);
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.Size = new System.Drawing.Size(82, 13);
            this.fechaCompra.TabIndex = 24;
            this.fechaCompra.Text = "Fecha Compra :";
            // 
            // L_Mes
            // 
            this.L_Mes.AutoSize = true;
            this.L_Mes.ForeColor = System.Drawing.Color.Black;
            this.L_Mes.Location = new System.Drawing.Point(137, 51);
            this.L_Mes.Name = "L_Mes";
            this.L_Mes.Size = new System.Drawing.Size(12, 13);
            this.L_Mes.TabIndex = 111;
            this.L_Mes.Text = "/";
            // 
            // mesCompra
            // 
            this.mesCompra.Location = new System.Drawing.Point(155, 48);
            this.mesCompra.MaxLength = 2;
            this.mesCompra.Name = "mesCompra";
            this.mesCompra.Size = new System.Drawing.Size(30, 20);
            this.mesCompra.TabIndex = 108;
            this.mesCompra.Tag = "Mes";
            // 
            // L_Año
            // 
            this.L_Año.AutoSize = true;
            this.L_Año.ForeColor = System.Drawing.Color.Black;
            this.L_Año.Location = new System.Drawing.Point(191, 51);
            this.L_Año.Name = "L_Año";
            this.L_Año.Size = new System.Drawing.Size(12, 13);
            this.L_Año.TabIndex = 110;
            this.L_Año.Text = "/";
            // 
            // añoCompra
            // 
            this.añoCompra.ForeColor = System.Drawing.Color.Black;
            this.añoCompra.Location = new System.Drawing.Point(209, 48);
            this.añoCompra.MaxLength = 4;
            this.añoCompra.Name = "añoCompra";
            this.añoCompra.Size = new System.Drawing.Size(40, 20);
            this.añoCompra.TabIndex = 109;
            this.añoCompra.Tag = "Año";
            // 
            // diaCompra
            // 
            this.diaCompra.ForeColor = System.Drawing.Color.Black;
            this.diaCompra.Location = new System.Drawing.Point(101, 48);
            this.diaCompra.MaxLength = 2;
            this.diaCompra.Name = "diaCompra";
            this.diaCompra.Size = new System.Drawing.Size(30, 20);
            this.diaCompra.TabIndex = 107;
            this.diaCompra.Tag = "Dia";
            // 
            // CompraBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 217);
            this.Controls.Add(this.L_Mes);
            this.Controls.Add(this.mesCompra);
            this.Controls.Add(this.L_Año);
            this.Controls.Add(this.añoCompra);
            this.Controls.Add(this.diaCompra);
            this.Controls.Add(this.fechaCompra);
            this.Controls.Add(this.cantBF);
            this.Controls.Add(this.cantBC);
            this.Controls.Add(this.idPlan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.montoTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dniAfi);
            this.Name = "CompraBono";
            this.Text = "CompraBono";
            this.Load += new System.EventHandler(this.CompraBono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantBC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantBF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniAfi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox montoTotal;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idPlan;
        private System.Windows.Forms.NumericUpDown cantBC;
        private System.Windows.Forms.NumericUpDown cantBF;
        private System.Windows.Forms.Label fechaCompra;
        private System.Windows.Forms.Label L_Mes;
        private System.Windows.Forms.TextBox mesCompra;
        private System.Windows.Forms.Label L_Año;
        private System.Windows.Forms.TextBox añoCompra;
        private System.Windows.Forms.TextBox diaCompra;
    }
}