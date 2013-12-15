namespace Clinica_Frba.NewFolder9
{
    partial class BonosQueComproOtro
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Afiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Maxima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobo_CantBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobo_CantBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobo_MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mayo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Junio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Julio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Septiembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Octubre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Noviembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diciembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Semestre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(53, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2013, 12, 8, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Afiliado,
            this.Cantidad_Maxima,
            this.cobo_CantBC,
            this.cobo_CantBF,
            this.cobo_MontoTotal,
            this.Abril,
            this.Mayo,
            this.Junio,
            this.Julio,
            this.Agosto,
            this.Septiembre,
            this.Octubre,
            this.Noviembre,
            this.Diciembre});
            this.dataGridView1.Location = new System.Drawing.Point(10, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 145);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Afiliado
            // 
            this.Afiliado.HeaderText = "Afiliado";
            this.Afiliado.Name = "Afiliado";
            this.Afiliado.Visible = false;
            // 
            // Cantidad_Maxima
            // 
            this.Cantidad_Maxima.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad_Maxima.HeaderText = "Bonos de otro que usó";
            this.Cantidad_Maxima.Name = "Cantidad_Maxima";
            this.Cantidad_Maxima.Visible = false;
            // 
            // cobo_CantBC
            // 
            this.cobo_CantBC.HeaderText = "Enero";
            this.cobo_CantBC.Name = "cobo_CantBC";
            this.cobo_CantBC.Visible = false;
            // 
            // cobo_CantBF
            // 
            this.cobo_CantBF.HeaderText = "Febrero";
            this.cobo_CantBF.Name = "cobo_CantBF";
            this.cobo_CantBF.Visible = false;
            // 
            // cobo_MontoTotal
            // 
            this.cobo_MontoTotal.HeaderText = "Marzo";
            this.cobo_MontoTotal.Name = "cobo_MontoTotal";
            this.cobo_MontoTotal.Visible = false;
            // 
            // Abril
            // 
            this.Abril.HeaderText = "Abril";
            this.Abril.Name = "Abril";
            this.Abril.Visible = false;
            // 
            // Mayo
            // 
            this.Mayo.HeaderText = "Mayo";
            this.Mayo.Name = "Mayo";
            this.Mayo.Visible = false;
            // 
            // Junio
            // 
            this.Junio.HeaderText = "Junio";
            this.Junio.Name = "Junio";
            this.Junio.Visible = false;
            // 
            // Julio
            // 
            this.Julio.HeaderText = "Julio";
            this.Julio.Name = "Julio";
            this.Julio.Visible = false;
            // 
            // Agosto
            // 
            this.Agosto.HeaderText = "Agosto";
            this.Agosto.Name = "Agosto";
            this.Agosto.Visible = false;
            // 
            // Septiembre
            // 
            this.Septiembre.HeaderText = "Septiembre";
            this.Septiembre.Name = "Septiembre";
            this.Septiembre.Visible = false;
            // 
            // Octubre
            // 
            this.Octubre.HeaderText = "Octubre";
            this.Octubre.Name = "Octubre";
            this.Octubre.Visible = false;
            // 
            // Noviembre
            // 
            this.Noviembre.HeaderText = "Noviembre";
            this.Noviembre.Name = "Noviembre";
            this.Noviembre.Visible = false;
            // 
            // Diciembre
            // 
            this.Diciembre.HeaderText = "Diciembre";
            this.Diciembre.Name = "Diciembre";
            this.Diciembre.Visible = false;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(825, 190);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(75, 23);
            this.BotonCerrar.TabIndex = 5;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(825, 10);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 6;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Primer",
            "Segundo"});
            this.comboBox2.Location = new System.Drawing.Point(328, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Semestre
            // 
            this.Semestre.AutoSize = true;
            this.Semestre.Location = new System.Drawing.Point(271, 11);
            this.Semestre.Name = "Semestre";
            this.Semestre.Size = new System.Drawing.Size(51, 13);
            this.Semestre.TabIndex = 9;
            this.Semestre.Text = "Semestre";
            // 
            // BonosQueComproOtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 235);
            this.Controls.Add(this.Semestre);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "BonosQueComproOtro";
            this.Text = "Top 5 de afiliados que utilizaron bonos que ellos mismos no compraron";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Maxima;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobo_CantBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobo_CantBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobo_MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abril;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mayo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Junio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Julio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Septiembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Octubre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noviembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diciembre;
    }
}