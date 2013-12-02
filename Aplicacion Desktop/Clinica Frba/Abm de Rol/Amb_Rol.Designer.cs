namespace Clinica_Frba.Abm_Rol
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Nombre_Rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncAgregada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GB_Rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Rol
            // 
            this.GB_Rol.Controls.Add(this.dataGridView1);
            this.GB_Rol.Controls.Add(this.B_Cancelar);
            this.GB_Rol.Controls.Add(this.checkBox1);
            this.GB_Rol.Controls.Add(this.button2);
            this.GB_Rol.Controls.Add(this.txt_Nombre_Rol);
            this.GB_Rol.Controls.Add(this.label2);
            this.GB_Rol.Controls.Add(this.button1);
            this.GB_Rol.Location = new System.Drawing.Point(12, 12);
            this.GB_Rol.Name = "GB_Rol";
            this.GB_Rol.Size = new System.Drawing.Size(433, 357);
            this.GB_Rol.TabIndex = 43;
            this.GB_Rol.TabStop = false;
            this.GB_Rol.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(20, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 49;
            this.checkBox1.Text = "Funcionalidad:";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Limpiar Funcionalidades";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_Nombre_Rol
            // 
            this.txt_Nombre_Rol.Location = new System.Drawing.Point(145, 29);
            this.txt_Nombre_Rol.Name = "txt_Nombre_Rol";
            this.txt_Nombre_Rol.Size = new System.Drawing.Size(142, 20);
            this.txt_Nombre_Rol.TabIndex = 44;
            this.txt_Nombre_Rol.TextChanged += new System.EventHandler(this.txt_Nombre_Rol_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre del Rol:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(233, 326);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(90, 25);
            this.B_Cancelar.TabIndex = 44;
            this.B_Cancelar.Text = "Cerrar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidad,
            this.FuncAgregada});
            this.dataGridView1.Location = new System.Drawing.Point(145, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 50;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Width = 97;
            // 
            // FuncAgregada
            // 
            this.FuncAgregada.HeaderText = "Agregada";
            this.FuncAgregada.Name = "FuncAgregada";
            // 
            // Abm_Rol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.Controls.Add(this.GB_Rol);
            this.Name = "Abm_Rol_Form";
            this.Text = "Rol";
            this.Load += new System.EventHandler(this.AñadirUsuario_Load);
            this.GB_Rol.ResumeLayout(false);
            this.GB_Rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Rol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Nombre_Rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FuncAgregada;
    }
}