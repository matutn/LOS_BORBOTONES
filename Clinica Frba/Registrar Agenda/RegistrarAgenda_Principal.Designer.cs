namespace Clinica_Frba.Registrar_Agenda
{
    partial class RegistrarAgenda_Principal
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
            this.grillaAgenda = new System.Windows.Forms.DataGridView();
            this.fechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_CargarAgenda = new System.Windows.Forms.Button();
            this.button_VerAgenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaAgenda
            // 
            this.grillaAgenda.AllowUserToAddRows = false;
            this.grillaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDesde,
            this.fechaHasta});
            this.grillaAgenda.Location = new System.Drawing.Point(119, 25);
            this.grillaAgenda.Name = "grillaAgenda";
            this.grillaAgenda.Size = new System.Drawing.Size(258, 72);
            this.grillaAgenda.TabIndex = 0;
            // 
            // fechaDesde
            // 
            this.fechaDesde.HeaderText = "Fecha Desde";
            this.fechaDesde.Name = "fechaDesde";
            // 
            // fechaHasta
            // 
            this.fechaHasta.HeaderText = "Fecha Hasta";
            this.fechaHasta.Name = "fechaHasta";
            // 
            // button_CargarAgenda
            // 
            this.button_CargarAgenda.Location = new System.Drawing.Point(12, 25);
            this.button_CargarAgenda.Name = "button_CargarAgenda";
            this.button_CargarAgenda.Size = new System.Drawing.Size(101, 23);
            this.button_CargarAgenda.TabIndex = 1;
            this.button_CargarAgenda.Text = "Cargar Agenda";
            this.button_CargarAgenda.UseVisualStyleBackColor = true;
            this.button_CargarAgenda.Click += new System.EventHandler(this.button_CargarAgenda_Click);
            // 
            // button_VerAgenda
            // 
            this.button_VerAgenda.Location = new System.Drawing.Point(12, 54);
            this.button_VerAgenda.Name = "button_VerAgenda";
            this.button_VerAgenda.Size = new System.Drawing.Size(101, 23);
            this.button_VerAgenda.TabIndex = 2;
            this.button_VerAgenda.Text = "Ver Agenda";
            this.button_VerAgenda.UseVisualStyleBackColor = true;
            this.button_VerAgenda.Click += new System.EventHandler(this.button_VerAgenda_Click);
            // 
            // RegistrarAgenda_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 129);
            this.Controls.Add(this.button_VerAgenda);
            this.Controls.Add(this.button_CargarAgenda);
            this.Controls.Add(this.grillaAgenda);
            this.Name = "RegistrarAgenda_Principal";
            this.Text = "RegistrarAgenda_Principal";
            this.Load += new System.EventHandler(this.RegistrarAgenda_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHasta;
        private System.Windows.Forms.Button button_CargarAgenda;
        private System.Windows.Forms.Button button_VerAgenda;
    }
}