namespace Clinica_Frba.Compra_de_Bono
{
    partial class CompraBono_Administrativo
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
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_Actualizar = new System.Windows.Forms.Button();
            this.button_Comprar = new System.Windows.Forms.Button();
            this.compraBonos = new System.Windows.Forms.DataGridView();
            this.txt_FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CantidadBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CantidadBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxAfiliado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compraBonos)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(535, 196);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 17;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // button_Actualizar
            // 
            this.button_Actualizar.Location = new System.Drawing.Point(535, 11);
            this.button_Actualizar.Name = "button_Actualizar";
            this.button_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.button_Actualizar.TabIndex = 16;
            this.button_Actualizar.Text = "Actualizar";
            this.button_Actualizar.UseVisualStyleBackColor = true;
            this.button_Actualizar.Click += new System.EventHandler(this.button_Actualizar_Click);
            // 
            // button_Comprar
            // 
            this.button_Comprar.Location = new System.Drawing.Point(417, 11);
            this.button_Comprar.Name = "button_Comprar";
            this.button_Comprar.Size = new System.Drawing.Size(112, 23);
            this.button_Comprar.TabIndex = 15;
            this.button_Comprar.Text = "Comprar bono";
            this.button_Comprar.UseVisualStyleBackColor = true;
            this.button_Comprar.Click += new System.EventHandler(this.button_Comprar_Click);
            // 
            // compraBonos
            // 
            this.compraBonos.AllowUserToAddRows = false;
            this.compraBonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraBonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_FechaCompra,
            this.txt_CantidadBC,
            this.txt_CantidadBF,
            this.txt_Monto});
            this.compraBonos.Location = new System.Drawing.Point(12, 40);
            this.compraBonos.Name = "compraBonos";
            this.compraBonos.Size = new System.Drawing.Size(598, 150);
            this.compraBonos.TabIndex = 12;
            // 
            // txt_FechaCompra
            // 
            this.txt_FechaCompra.HeaderText = "Fecha Compra";
            this.txt_FechaCompra.Name = "txt_FechaCompra";
            this.txt_FechaCompra.Width = 110;
            // 
            // txt_CantidadBC
            // 
            this.txt_CantidadBC.HeaderText = "Cantidad Bonos Consulta";
            this.txt_CantidadBC.Name = "txt_CantidadBC";
            this.txt_CantidadBC.Width = 160;
            // 
            // txt_CantidadBF
            // 
            this.txt_CantidadBF.HeaderText = "Cantidad Bonos Farmacia";
            this.txt_CantidadBF.Name = "txt_CantidadBF";
            this.txt_CantidadBF.Width = 160;
            // 
            // txt_Monto
            // 
            this.txt_Monto.HeaderText = "Monto";
            this.txt_Monto.Name = "txt_Monto";
            // 
            // comboBoxAfiliado
            // 
            this.comboBoxAfiliado.FormattingEnabled = true;
            this.comboBoxAfiliado.Location = new System.Drawing.Point(50, 11);
            this.comboBoxAfiliado.Name = "comboBoxAfiliado";
            this.comboBoxAfiliado.Size = new System.Drawing.Size(113, 21);
            this.comboBoxAfiliado.TabIndex = 18;
            this.comboBoxAfiliado.Text = "Seleccione Afiliado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "DNI :";
            // 
            // CompraBono_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 261);
            this.Controls.Add(this.comboBoxAfiliado);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.button_Actualizar);
            this.Controls.Add(this.button_Comprar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compraBonos);
            this.Name = "CompraBono_Administrativo";
            this.Text = "CompraBono_Administrativo";
            this.Load += new System.EventHandler(this.CompraBono_Administrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_Actualizar;
        private System.Windows.Forms.Button button_Comprar;
        private System.Windows.Forms.DataGridView compraBonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_CantidadBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_CantidadBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_Monto;
        private System.Windows.Forms.ComboBox comboBoxAfiliado;
        private System.Windows.Forms.Label label1;
    }
}