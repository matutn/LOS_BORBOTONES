namespace Clinica_Frba.Login
{
    partial class Ingreso
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
            this.LB_Roles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Entrar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Roles
            // 
            this.LB_Roles.FormattingEnabled = true;
            this.LB_Roles.Location = new System.Drawing.Point(84, 41);
            this.LB_Roles.Name = "LB_Roles";
            this.LB_Roles.Size = new System.Drawing.Size(120, 95);
            this.LB_Roles.TabIndex = 0;
            this.LB_Roles.SelectedIndexChanged += new System.EventHandler(this.LB_Roles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar un  Rol";
            // 
            // B_Entrar
            // 
            this.B_Entrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Entrar.Location = new System.Drawing.Point(12, 154);
            this.B_Entrar.Name = "B_Entrar";
            this.B_Entrar.Size = new System.Drawing.Size(75, 23);
            this.B_Entrar.TabIndex = 4;
            this.B_Entrar.Text = "Entrar";
            this.B_Entrar.UseVisualStyleBackColor = false;
            this.B_Entrar.Click += new System.EventHandler(this.B_Entrar_Click);
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.B_Cancelar.Location = new System.Drawing.Point(190, 154);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_Cancelar.TabIndex = 5;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = false;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(285, 189);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Entrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Roles);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Roles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Entrar;
        private System.Windows.Forms.Button B_Cancelar;
    }
}