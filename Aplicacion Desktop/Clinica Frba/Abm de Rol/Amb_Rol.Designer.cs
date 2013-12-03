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
            this.L_Funcionalidad = new System.Windows.Forms.Label();
            this.DG_GrillaFunc = new System.Windows.Forms.DataGridView();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncAgregada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.txt_Nombre_Rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.GB_Rol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_GrillaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Rol
            // 
            this.GB_Rol.Controls.Add(this.L_Funcionalidad);
            this.GB_Rol.Controls.Add(this.DG_GrillaFunc);
            this.GB_Rol.Controls.Add(this.button2);
            this.GB_Rol.Enabled = false;
            this.GB_Rol.Location = new System.Drawing.Point(18, 38);
            this.GB_Rol.Name = "GB_Rol";
            this.GB_Rol.Size = new System.Drawing.Size(382, 211);
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
            // DG_GrillaFunc
            // 
            this.DG_GrillaFunc.AllowUserToAddRows = false;
            this.DG_GrillaFunc.AllowUserToDeleteRows = false;
            this.DG_GrillaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_GrillaFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Funcionalidad,
            this.FuncAgregada});
            this.DG_GrillaFunc.Location = new System.Drawing.Point(135, 19);
            this.DG_GrillaFunc.Name = "DG_GrillaFunc";
            this.DG_GrillaFunc.Size = new System.Drawing.Size(240, 150);
            this.DG_GrillaFunc.TabIndex = 50;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Limpiar Funcionalidades";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(297, 255);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(90, 23);
            this.B_Cancelar.TabIndex = 44;
            this.B_Cancelar.Text = "Cerrar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_Nombre_Rol
            // 
            this.txt_Nombre_Rol.Location = new System.Drawing.Point(147, 12);
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
            // Abm_Rol_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 289);
            this.Controls.Add(this.GB_Rol);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.txt_Nombre_Rol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B_Aceptar);
            this.Enabled = false;
            this.Location = new System.Drawing.Point(12, 78);
            this.Name = "Abm_Rol_Form";
            this.Text = "Rol";
            this.GB_Rol.ResumeLayout(false);
            this.GB_Rol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_GrillaFunc)).EndInit();
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
        private System.Windows.Forms.DataGridView DG_GrillaFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FuncAgregada;
        private System.Windows.Forms.Label L_Funcionalidad;
    }
}