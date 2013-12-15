namespace Clinica_Frba.Abm_Afiliado
{
    partial class Amb_Afiliado_Form
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
            this.mail = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LMail = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.direc = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoDni = new System.Windows.Forms.TextBox();
            this.cantFamiliares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.planTexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.femenino = new System.Windows.Forms.RadioButton();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.LSexo = new System.Windows.Forms.Label();
            this.combo_Plan = new System.Windows.Forms.ComboBox();
            this.dateTime_Nac = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(111, 110);
            this.mail.MaxLength = 25;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(216, 20);
            this.mail.TabIndex = 91;
            this.mail.Tag = "Mail";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.ForeColor = System.Drawing.Color.Black;
            this.LDni.Location = new System.Drawing.Point(190, 61);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 92;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.LDni_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(110, 6);
            this.nombre.MaxLength = 20;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 20);
            this.nombre.TabIndex = 87;
            this.nombre.Tag = "Nombre";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(111, 32);
            this.apellido.MaxLength = 30;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(216, 20);
            this.apellido.TabIndex = 88;
            this.apellido.Tag = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.ForeColor = System.Drawing.Color.Black;
            this.LNombre.Location = new System.Drawing.Point(12, 9);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 94;
            this.LNombre.Text = "Nombre";
            // 
            // LMail
            // 
            this.LMail.AutoSize = true;
            this.LMail.ForeColor = System.Drawing.Color.Black;
            this.LMail.Location = new System.Drawing.Point(12, 113);
            this.LMail.Name = "LMail";
            this.LMail.Size = new System.Drawing.Size(26, 13);
            this.LMail.TabIndex = 97;
            this.LMail.Text = "Mail";
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.LFechaNacimiento.Location = new System.Drawing.Point(12, 165);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LFechaNacimiento.TabIndex = 104;
            this.LFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.ForeColor = System.Drawing.Color.Black;
            this.LDireccion.Location = new System.Drawing.Point(12, 139);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(52, 13);
            this.LDireccion.TabIndex = 96;
            this.LDireccion.Text = "Dirección";
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.SystemColors.Window;
            this.dni.Location = new System.Drawing.Point(219, 58);
            this.dni.MaxLength = 10;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(108, 20);
            this.dni.TabIndex = 86;
            this.dni.Tag = "Dni";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.ForeColor = System.Drawing.Color.Black;
            this.LApellido.Location = new System.Drawing.Point(12, 35);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(44, 13);
            this.LApellido.TabIndex = 95;
            this.LApellido.Text = "Apellido";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(110, 84);
            this.telefono.MaxLength = 10;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(217, 20);
            this.telefono.TabIndex = 89;
            this.telefono.Tag = "Telefono";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.ForeColor = System.Drawing.Color.Black;
            this.LTelefono.Location = new System.Drawing.Point(12, 87);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 100;
            this.LTelefono.Text = "Telefono";
            // 
            // direc
            // 
            this.direc.ForeColor = System.Drawing.Color.Black;
            this.direc.Location = new System.Drawing.Point(110, 136);
            this.direc.MaxLength = 35;
            this.direc.Name = "direc";
            this.direc.Size = new System.Drawing.Size(217, 20);
            this.direc.TabIndex = 93;
            this.direc.Tag = "Dirección";
            // 
            // limpiar
            // 
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(18, 319);
            this.limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(60, 22);
            this.limpiar.TabIndex = 115;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // cancelar
            // 
            this.cancelar.ForeColor = System.Drawing.Color.Black;
            this.cancelar.Location = new System.Drawing.Point(270, 319);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(60, 22);
            this.cancelar.TabIndex = 114;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.ForeColor = System.Drawing.Color.Black;
            this.aceptar.Location = new System.Drawing.Point(206, 319);
            this.aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(60, 22);
            this.aceptar.TabIndex = 113;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 119;
            this.label2.Text = "Tipo Dni";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tipoDni
            // 
            this.tipoDni.BackColor = System.Drawing.SystemColors.Window;
            this.tipoDni.Location = new System.Drawing.Point(111, 58);
            this.tipoDni.MaxLength = 3;
            this.tipoDni.Name = "tipoDni";
            this.tipoDni.Size = new System.Drawing.Size(72, 20);
            this.tipoDni.TabIndex = 118;
            this.tipoDni.Tag = "Tipo Dni";
            // 
            // cantFamiliares
            // 
            this.cantFamiliares.Location = new System.Drawing.Point(110, 269);
            this.cantFamiliares.MaxLength = 10;
            this.cantFamiliares.Name = "cantFamiliares";
            this.cantFamiliares.Size = new System.Drawing.Size(151, 20);
            this.cantFamiliares.TabIndex = 131;
            this.cantFamiliares.Tag = "N° Familiares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 132;
            this.label3.Text = "N° Familiares";
            // 
            // planTexto
            // 
            this.planTexto.AutoSize = true;
            this.planTexto.ForeColor = System.Drawing.Color.Black;
            this.planTexto.Location = new System.Drawing.Point(15, 246);
            this.planTexto.Name = "planTexto";
            this.planTexto.Size = new System.Drawing.Size(28, 13);
            this.planTexto.TabIndex = 129;
            this.planTexto.Text = "Plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "Estado Civil";
            // 
            // estadoCivil
            // 
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.estadoCivil.Location = new System.Drawing.Point(111, 216);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(149, 21);
            this.estadoCivil.TabIndex = 127;
            this.estadoCivil.Text = "Seleccione el Estado Civil";
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.ForeColor = System.Drawing.Color.Black;
            this.femenino.Location = new System.Drawing.Point(205, 190);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(71, 17);
            this.femenino.TabIndex = 126;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.ForeColor = System.Drawing.Color.Black;
            this.masculino.Location = new System.Drawing.Point(113, 190);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 125;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.ForeColor = System.Drawing.Color.Black;
            this.LSexo.Location = new System.Drawing.Point(15, 190);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(31, 13);
            this.LSexo.TabIndex = 124;
            this.LSexo.Text = "Sexo";
            // 
            // combo_Plan
            // 
            this.combo_Plan.FormattingEnabled = true;
            this.combo_Plan.Location = new System.Drawing.Point(110, 242);
            this.combo_Plan.Name = "combo_Plan";
            this.combo_Plan.Size = new System.Drawing.Size(151, 21);
            this.combo_Plan.TabIndex = 130;
            this.combo_Plan.Text = "Seleccione Plan Médico";
            // 
            // dateTime_Nac
            // 
            this.dateTime_Nac.Location = new System.Drawing.Point(110, 162);
            this.dateTime_Nac.Name = "dateTime_Nac";
            this.dateTime_Nac.Size = new System.Drawing.Size(220, 20);
            this.dateTime_Nac.TabIndex = 133;
            // 
            // Amb_Afiliado_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 362);
            this.Controls.Add(this.dateTime_Nac);
            this.Controls.Add(this.cantFamiliares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.planTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.femenino);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.combo_Plan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoDni);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LMail);
            this.Controls.Add(this.LFechaNacimiento);
            this.Controls.Add(this.LDireccion);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.direc);
            this.Name = "Amb_Afiliado_Form";
            this.Text = "FormAfiliado";
            this.Load += new System.EventHandler(this.FormAfiliado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LMail;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox direc;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipoDni;
        private System.Windows.Forms.TextBox cantFamiliares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label planTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.ComboBox combo_Plan;
        private System.Windows.Forms.DateTimePicker dateTime_Nac;
    }
}