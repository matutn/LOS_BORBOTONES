namespace Clinica_Frba.Login
{
    partial class Login_Form
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
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.TB_Contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Location = new System.Drawing.Point(122, 30);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TB_Usuario.TabIndex = 0;
            // 
            // TB_Contraseña
            // 
            this.TB_Contraseña.Location = new System.Drawing.Point(122, 67);
            this.TB_Contraseña.Name = "TB_Contraseña";
            this.TB_Contraseña.Size = new System.Drawing.Size(100, 20);
            this.TB_Contraseña.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // B_Aceptar
            // 
            this.B_Aceptar.Location = new System.Drawing.Point(86, 108);
            this.B_Aceptar.Name = "B_Aceptar";
            this.B_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.B_Aceptar.TabIndex = 4;
            this.B_Aceptar.Text = "Aceptar";
            this.B_Aceptar.UseVisualStyleBackColor = true;
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.Location = new System.Drawing.Point(86, 137);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.B_Cancelar.TabIndex = 5;
            this.B_Cancelar.Text = "Cancelar";
            this.B_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 170);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Aceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Contraseña);
            this.Controls.Add(this.TB_Usuario);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.TextBox TB_Contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_Aceptar;
        private System.Windows.Forms.Button B_Cancelar;
    }
}