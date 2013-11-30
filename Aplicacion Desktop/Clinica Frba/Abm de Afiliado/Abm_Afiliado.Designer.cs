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
            this.femenino = new System.Windows.Forms.RadioButton();
            this.mail = new System.Windows.Forms.TextBox();
            this.masculino = new System.Windows.Forms.RadioButton();
            this.LSexo = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.L_Mes = new System.Windows.Forms.Label();
            this.mesNac = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.L_Año = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.añoNac = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.diaNac = new System.Windows.Forms.TextBox();
            this.LMail = new System.Windows.Forms.Label();
            this.LFechaNacimiento = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNro = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.LCalle = new System.Windows.Forms.Label();
            this.nro = new System.Windows.Forms.TextBox();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.plan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.ForeColor = System.Drawing.Color.Black;
            this.femenino.Location = new System.Drawing.Point(202, 223);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(71, 17);
            this.femenino.TabIndex = 109;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(111, 168);
            this.mail.MaxLength = 25;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(249, 20);
            this.mail.TabIndex = 91;
            this.mail.Tag = "Mail";
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.ForeColor = System.Drawing.Color.Black;
            this.masculino.Location = new System.Drawing.Point(110, 223);
            this.masculino.Name = "masculino";
            this.masculino.Size = new System.Drawing.Size(73, 17);
            this.masculino.TabIndex = 108;
            this.masculino.TabStop = true;
            this.masculino.Text = "Masculino";
            this.masculino.UseVisualStyleBackColor = true;
            // 
            // LSexo
            // 
            this.LSexo.AutoSize = true;
            this.LSexo.ForeColor = System.Drawing.Color.Black;
            this.LSexo.Location = new System.Drawing.Point(12, 223);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(31, 13);
            this.LSexo.TabIndex = 107;
            this.LSexo.Text = "Sexo";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.ForeColor = System.Drawing.Color.Black;
            this.LDni.Location = new System.Drawing.Point(12, 61);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 92;
            this.LDni.Text = "DNI";
            this.LDni.Click += new System.EventHandler(this.LDni_Click);
            // 
            // L_Mes
            // 
            this.L_Mes.AutoSize = true;
            this.L_Mes.ForeColor = System.Drawing.Color.Black;
            this.L_Mes.Location = new System.Drawing.Point(147, 115);
            this.L_Mes.Name = "L_Mes";
            this.L_Mes.Size = new System.Drawing.Size(12, 13);
            this.L_Mes.TabIndex = 106;
            this.L_Mes.Text = "/";
            // 
            // mesNac
            // 
            this.mesNac.Location = new System.Drawing.Point(165, 112);
            this.mesNac.MaxLength = 2;
            this.mesNac.Name = "mesNac";
            this.mesNac.Size = new System.Drawing.Size(30, 20);
            this.mesNac.TabIndex = 102;
            this.mesNac.Tag = "Mes de Nacimiento";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(110, 6);
            this.nombre.MaxLength = 20;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(250, 20);
            this.nombre.TabIndex = 87;
            this.nombre.Tag = "Nombre";
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // L_Año
            // 
            this.L_Año.AutoSize = true;
            this.L_Año.ForeColor = System.Drawing.Color.Black;
            this.L_Año.Location = new System.Drawing.Point(201, 115);
            this.L_Año.Name = "L_Año";
            this.L_Año.Size = new System.Drawing.Size(12, 13);
            this.L_Año.TabIndex = 105;
            this.L_Año.Text = "/";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(111, 32);
            this.apellido.MaxLength = 30;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(249, 20);
            this.apellido.TabIndex = 88;
            this.apellido.Tag = "Apellido";
            // 
            // añoNac
            // 
            this.añoNac.ForeColor = System.Drawing.Color.Black;
            this.añoNac.Location = new System.Drawing.Point(219, 112);
            this.añoNac.MaxLength = 4;
            this.añoNac.Name = "añoNac";
            this.añoNac.Size = new System.Drawing.Size(40, 20);
            this.añoNac.TabIndex = 103;
            this.añoNac.Tag = "Año de Nacimiento";
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
            // diaNac
            // 
            this.diaNac.ForeColor = System.Drawing.Color.Black;
            this.diaNac.Location = new System.Drawing.Point(111, 112);
            this.diaNac.MaxLength = 2;
            this.diaNac.Name = "diaNac";
            this.diaNac.Size = new System.Drawing.Size(30, 20);
            this.diaNac.TabIndex = 101;
            this.diaNac.Tag = "Dia de Nacimiento";
            // 
            // LMail
            // 
            this.LMail.AutoSize = true;
            this.LMail.ForeColor = System.Drawing.Color.Black;
            this.LMail.Location = new System.Drawing.Point(12, 171);
            this.LMail.Name = "LMail";
            this.LMail.Size = new System.Drawing.Size(26, 13);
            this.LMail.TabIndex = 97;
            this.LMail.Text = "Mail";
            // 
            // LFechaNacimiento
            // 
            this.LFechaNacimiento.AutoSize = true;
            this.LFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.LFechaNacimiento.Location = new System.Drawing.Point(12, 115);
            this.LFechaNacimiento.Name = "LFechaNacimiento";
            this.LFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LFechaNacimiento.TabIndex = 104;
            this.LFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.ForeColor = System.Drawing.Color.Black;
            this.LDireccion.Location = new System.Drawing.Point(12, 197);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(52, 13);
            this.LDireccion.TabIndex = 96;
            this.LDireccion.Text = "Dirección";
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.SystemColors.Window;
            this.dni.Location = new System.Drawing.Point(110, 58);
            this.dni.MaxLength = 10;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(250, 20);
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
            this.telefono.Location = new System.Drawing.Point(110, 142);
            this.telefono.MaxLength = 10;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(249, 20);
            this.telefono.TabIndex = 89;
            this.telefono.Tag = "Telefono";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.ForeColor = System.Drawing.Color.Black;
            this.LTelefono.Location = new System.Drawing.Point(12, 145);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 100;
            this.LTelefono.Text = "Telefono";
            // 
            // LNro
            // 
            this.LNro.AutoSize = true;
            this.LNro.ForeColor = System.Drawing.Color.Black;
            this.LNro.Location = new System.Drawing.Point(290, 197);
            this.LNro.Name = "LNro";
            this.LNro.Size = new System.Drawing.Size(19, 13);
            this.LNro.TabIndex = 99;
            this.LNro.Text = "Nº";
            // 
            // calle
            // 
            this.calle.ForeColor = System.Drawing.Color.Black;
            this.calle.Location = new System.Drawing.Point(138, 194);
            this.calle.MaxLength = 35;
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(146, 20);
            this.calle.TabIndex = 93;
            this.calle.Tag = "Calle";
            // 
            // LCalle
            // 
            this.LCalle.AutoSize = true;
            this.LCalle.ForeColor = System.Drawing.Color.Black;
            this.LCalle.Location = new System.Drawing.Point(107, 197);
            this.LCalle.Name = "LCalle";
            this.LCalle.Size = new System.Drawing.Size(30, 13);
            this.LCalle.TabIndex = 98;
            this.LCalle.Text = "Calle";
            // 
            // nro
            // 
            this.nro.ForeColor = System.Drawing.Color.Black;
            this.nro.Location = new System.Drawing.Point(315, 194);
            this.nro.MaxLength = 6;
            this.nro.Name = "nro";
            this.nro.Size = new System.Drawing.Size(45, 20);
            this.nro.TabIndex = 110;
            this.nro.Tag = "Numero de Calle";
            // 
            // estadoCivil
            // 
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Viudo",
            "Casado",
            "Divorciado",
            "Separado"});
            this.estadoCivil.Location = new System.Drawing.Point(110, 248);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(149, 21);
            this.estadoCivil.TabIndex = 111;
            this.estadoCivil.Text = "Seleccione el Estado Civil";
            this.estadoCivil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Estado Civil";
            // 
            // limpiar
            // 
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(15, 295);
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
            this.cancelar.Location = new System.Drawing.Point(300, 295);
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
            this.aceptar.Location = new System.Drawing.Point(236, 295);
            this.aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(60, 22);
            this.aceptar.TabIndex = 113;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // plan
            // 
            this.plan.AutoSize = true;
            this.plan.ForeColor = System.Drawing.Color.Black;
            this.plan.Location = new System.Drawing.Point(13, 89);
            this.plan.Name = "plan";
            this.plan.Size = new System.Drawing.Size(28, 13);
            this.plan.TabIndex = 117;
            this.plan.Text = "Plan";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(111, 86);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 116;
            this.textBox1.Tag = "Dni";
            // 
            // Amb_Afiliado_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 328);
            this.Controls.Add(this.plan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.nro);
            this.Controls.Add(this.femenino);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.L_Mes);
            this.Controls.Add(this.mesNac);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.L_Año);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.añoNac);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.diaNac);
            this.Controls.Add(this.LMail);
            this.Controls.Add(this.LFechaNacimiento);
            this.Controls.Add(this.LDireccion);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LNro);
            this.Controls.Add(this.calle);
            this.Controls.Add(this.LCalle);
            this.Name = "Amb_Afiliado_Form";
            this.Text = "FormAfiliado";
            this.Load += new System.EventHandler(this.FormAfiliado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton femenino;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.RadioButton masculino;
        private System.Windows.Forms.Label LSexo;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label L_Mes;
        private System.Windows.Forms.TextBox mesNac;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label L_Año;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox añoNac;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox diaNac;
        private System.Windows.Forms.Label LMail;
        private System.Windows.Forms.Label LFechaNacimiento;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LNro;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.Label LCalle;
        private System.Windows.Forms.TextBox nro;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label plan;
        private System.Windows.Forms.TextBox textBox1;
    }
}