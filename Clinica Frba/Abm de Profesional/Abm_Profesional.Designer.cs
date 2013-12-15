namespace Clinica_Frba.Abm_Profesional
{
    partial class Amb_Profesional_Form
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LMail = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.direc = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.matriculatexto = new System.Windows.Forms.Label();
            this.matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_Nac = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_Especialidad = new System.Windows.Forms.ComboBox();
            this.especialidadesCargadas = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button_CargarEspecialidad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // femenino
            // 
            this.femenino.AutoSize = true;
            this.femenino.ForeColor = System.Drawing.Color.Black;
            this.femenino.Location = new System.Drawing.Point(201, 190);
            this.femenino.Name = "femenino";
            this.femenino.Size = new System.Drawing.Size(71, 17);
            this.femenino.TabIndex = 109;
            this.femenino.TabStop = true;
            this.femenino.Text = "Femenino";
            this.femenino.UseVisualStyleBackColor = true;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(111, 138);
            this.mail.MaxLength = 25;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(216, 20);
            this.mail.TabIndex = 91;
            this.mail.Tag = "Mail";
            // 
            // masculino
            // 
            this.masculino.AutoSize = true;
            this.masculino.ForeColor = System.Drawing.Color.Black;
            this.masculino.Location = new System.Drawing.Point(109, 190);
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
            this.LSexo.Location = new System.Drawing.Point(11, 190);
            this.LSexo.Name = "LSexo";
            this.LSexo.Size = new System.Drawing.Size(31, 13);
            this.LSexo.TabIndex = 107;
            this.LSexo.Text = "Sexo";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(110, 6);
            this.nombre.MaxLength = 20;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(217, 20);
            this.nombre.TabIndex = 87;
            this.nombre.Tag = "Nombre";
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
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
            this.LMail.Location = new System.Drawing.Point(12, 141);
            this.LMail.Name = "LMail";
            this.LMail.Size = new System.Drawing.Size(26, 13);
            this.LMail.TabIndex = 97;
            this.LMail.Text = "Mail";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.ForeColor = System.Drawing.Color.Black;
            this.LDireccion.Location = new System.Drawing.Point(12, 167);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(52, 13);
            this.LDireccion.TabIndex = 96;
            this.LDireccion.Text = "Dirección";
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
            this.telefono.Location = new System.Drawing.Point(110, 112);
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
            this.LTelefono.Location = new System.Drawing.Point(12, 115);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(49, 13);
            this.LTelefono.TabIndex = 100;
            this.LTelefono.Text = "Telefono";
            // 
            // direc
            // 
            this.direc.ForeColor = System.Drawing.Color.Black;
            this.direc.Location = new System.Drawing.Point(111, 164);
            this.direc.MaxLength = 35;
            this.direc.Name = "direc";
            this.direc.Size = new System.Drawing.Size(216, 20);
            this.direc.TabIndex = 93;
            this.direc.Tag = "Dirección";
            // 
            // limpiar
            // 
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.Location = new System.Drawing.Point(14, 338);
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
            this.cancelar.Location = new System.Drawing.Point(266, 338);
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
            this.aceptar.Location = new System.Drawing.Point(202, 338);
            this.aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(60, 22);
            this.aceptar.TabIndex = 113;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // matriculatexto
            // 
            this.matriculatexto.AutoSize = true;
            this.matriculatexto.ForeColor = System.Drawing.Color.Black;
            this.matriculatexto.Location = new System.Drawing.Point(13, 89);
            this.matriculatexto.Name = "matriculatexto";
            this.matriculatexto.Size = new System.Drawing.Size(73, 13);
            this.matriculatexto.TabIndex = 117;
            this.matriculatexto.Text = "Nro. Matricula";
            // 
            // matricula
            // 
            this.matricula.BackColor = System.Drawing.SystemColors.Window;
            this.matricula.Location = new System.Drawing.Point(111, 86);
            this.matricula.MaxLength = 10;
            this.matricula.Name = "matricula";
            this.matricula.Size = new System.Drawing.Size(216, 20);
            this.matricula.TabIndex = 116;
            this.matricula.Tag = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "Tipo Dni";
            // 
            // tipoDni
            // 
            this.tipoDni.BackColor = System.Drawing.SystemColors.Window;
            this.tipoDni.Location = new System.Drawing.Point(110, 58);
            this.tipoDni.MaxLength = 3;
            this.tipoDni.Name = "tipoDni";
            this.tipoDni.Size = new System.Drawing.Size(72, 20);
            this.tipoDni.TabIndex = 122;
            this.tipoDni.Tag = "Tipo Dni";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.ForeColor = System.Drawing.Color.Black;
            this.LDni.Location = new System.Drawing.Point(189, 61);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(26, 13);
            this.LDni.TabIndex = 121;
            this.LDni.Text = "DNI";
            // 
            // dni
            // 
            this.dni.BackColor = System.Drawing.SystemColors.Window;
            this.dni.Location = new System.Drawing.Point(218, 58);
            this.dni.MaxLength = 10;
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(108, 20);
            this.dni.TabIndex = 120;
            this.dni.Tag = "Dni";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Fecha Nacimiento";
            // 
            // dateTime_Nac
            // 
            this.dateTime_Nac.Location = new System.Drawing.Point(111, 213);
            this.dateTime_Nac.Name = "dateTime_Nac";
            this.dateTime_Nac.Size = new System.Drawing.Size(216, 20);
            this.dateTime_Nac.TabIndex = 134;
            this.dateTime_Nac.ValueChanged += new System.EventHandler(this.dateTime_Nac_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Especialidades";
            // 
            // combo_Especialidad
            // 
            this.combo_Especialidad.FormattingEnabled = true;
            this.combo_Especialidad.Location = new System.Drawing.Point(111, 243);
            this.combo_Especialidad.Name = "combo_Especialidad";
            this.combo_Especialidad.Size = new System.Drawing.Size(215, 21);
            this.combo_Especialidad.TabIndex = 136;
            // 
            // especialidadesCargadas
            // 
            this.especialidadesCargadas.Location = new System.Drawing.Point(113, 300);
            this.especialidadesCargadas.Name = "especialidadesCargadas";
            this.especialidadesCargadas.Size = new System.Drawing.Size(214, 20);
            this.especialidadesCargadas.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = "Especialidades";
            // 
            // button_CargarEspecialidad
            // 
            this.button_CargarEspecialidad.Location = new System.Drawing.Point(150, 270);
            this.button_CargarEspecialidad.Name = "button_CargarEspecialidad";
            this.button_CargarEspecialidad.Size = new System.Drawing.Size(122, 23);
            this.button_CargarEspecialidad.TabIndex = 139;
            this.button_CargarEspecialidad.Text = "Cargar Especialidad";
            this.button_CargarEspecialidad.UseVisualStyleBackColor = true;
            this.button_CargarEspecialidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 140;
            this.label5.Text = "Existentes";
            // 
            // Amb_Profesional_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 371);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_CargarEspecialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.especialidadesCargadas);
            this.Controls.Add(this.combo_Especialidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTime_Nac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoDni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.matriculatexto);
            this.Controls.Add(this.matricula);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.femenino);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.masculino);
            this.Controls.Add(this.LSexo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LDireccion);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.direc);
            this.Name = "Amb_Profesional_Form";
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
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LMail;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.TextBox direc;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label matriculatexto;
        private System.Windows.Forms.TextBox matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipoDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_Nac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_Especialidad;
        private System.Windows.Forms.DomainUpDown especialidadesCargadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CargarEspecialidad;
        private System.Windows.Forms.Label label5;
    }
}