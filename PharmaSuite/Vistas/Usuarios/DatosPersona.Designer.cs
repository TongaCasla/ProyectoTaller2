namespace PharmaSuite.Vistas.Usuarios
{
    partial class DatosPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosPersona));
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            comboPerfil = new ComboBox();
            lPerfil = new Label();
            comboSexo = new ComboBox();
            lSexo = new Label();
            dateFecha = new DateTimePicker();
            lFechaNac = new Label();
            txbDni = new TextBox();
            lDni = new Label();
            txbUsuario = new TextBox();
            lUsuario = new Label();
            txbEmail = new TextBox();
            lEmail = new Label();
            txbTele = new TextBox();
            lTelefono = new Label();
            txbApellido = new TextBox();
            lApellido = new Label();
            txbNombre = new TextBox();
            lNombre = new Label();
            labelPersona = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(comboPerfil);
            panel1.Controls.Add(lPerfil);
            panel1.Controls.Add(comboSexo);
            panel1.Controls.Add(lSexo);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(lFechaNac);
            panel1.Controls.Add(txbDni);
            panel1.Controls.Add(lDni);
            panel1.Controls.Add(txbUsuario);
            panel1.Controls.Add(lUsuario);
            panel1.Controls.Add(txbEmail);
            panel1.Controls.Add(lEmail);
            panel1.Controls.Add(txbTele);
            panel1.Controls.Add(lTelefono);
            panel1.Controls.Add(txbApellido);
            panel1.Controls.Add(lApellido);
            panel1.Controls.Add(txbNombre);
            panel1.Controls.Add(lNombre);
            panel1.Controls.Add(labelPersona);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 450);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 18F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(401, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 40);
            btnCancelar.TabIndex = 48;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(193, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 47;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // comboPerfil
            // 
            comboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPerfil.DropDownWidth = 270;
            comboPerfil.Enabled = false;
            comboPerfil.Font = new Font("Microsoft Sans Serif", 12F);
            comboPerfil.FormattingEnabled = true;
            comboPerfil.Items.AddRange(new object[] { "Cliente", "Empleado", "Gerente", "Administrador" });
            comboPerfil.Location = new Point(559, 280);
            comboPerfil.Name = "comboPerfil";
            comboPerfil.Size = new Size(234, 28);
            comboPerfil.TabIndex = 45;
            // 
            // lPerfil
            // 
            lPerfil.AutoSize = true;
            lPerfil.Font = new Font("Microsoft Sans Serif", 15.75F);
            lPerfil.Location = new Point(559, 252);
            lPerfil.Name = "lPerfil";
            lPerfil.Size = new Size(61, 25);
            lPerfil.TabIndex = 46;
            lPerfil.Text = "Perfil";
            // 
            // comboSexo
            // 
            comboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSexo.DropDownWidth = 270;
            comboSexo.Font = new Font("Microsoft Sans Serif", 12F);
            comboSexo.FormattingEnabled = true;
            comboSexo.Items.AddRange(new object[] { "Hombre", "Mujer", "Otro" });
            comboSexo.Location = new Point(302, 279);
            comboSexo.Name = "comboSexo";
            comboSexo.Size = new Size(234, 28);
            comboSexo.TabIndex = 44;
            // 
            // lSexo
            // 
            lSexo.AutoSize = true;
            lSexo.Font = new Font("Microsoft Sans Serif", 15.75F);
            lSexo.Location = new Point(302, 252);
            lSexo.Name = "lSexo";
            lSexo.Size = new Size(61, 25);
            lSexo.TabIndex = 43;
            lSexo.Text = "Sexo";
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Microsoft Sans Serif", 12F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(35, 279);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(234, 26);
            dateFecha.TabIndex = 42;
            // 
            // lFechaNac
            // 
            lFechaNac.AutoSize = true;
            lFechaNac.Font = new Font("Microsoft Sans Serif", 15.75F);
            lFechaNac.Location = new Point(35, 252);
            lFechaNac.Name = "lFechaNac";
            lFechaNac.Size = new Size(191, 25);
            lFechaNac.TabIndex = 40;
            lFechaNac.Text = "Fecha Nacimiento:";
            // 
            // txbDni
            // 
            txbDni.Enabled = false;
            txbDni.Font = new Font("Microsoft Sans Serif", 12F);
            txbDni.Location = new Point(35, 110);
            txbDni.Name = "txbDni";
            txbDni.ReadOnly = true;
            txbDni.Size = new Size(234, 26);
            txbDni.TabIndex = 39;
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Microsoft Sans Serif", 15.75F);
            lDni.Location = new Point(35, 86);
            lDni.Name = "lDni";
            lDni.Size = new Size(99, 25);
            lDni.TabIndex = 38;
            lDni.Text = "Nro. DNI:";
            // 
            // txbUsuario
            // 
            txbUsuario.Enabled = false;
            txbUsuario.Font = new Font("Microsoft Sans Serif", 12F);
            txbUsuario.Location = new Point(559, 110);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.ReadOnly = true;
            txbUsuario.Size = new Size(234, 26);
            txbUsuario.TabIndex = 37;
            txbUsuario.Visible = false;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Font = new Font("Microsoft Sans Serif", 15.75F);
            lUsuario.Location = new Point(559, 86);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(92, 25);
            lUsuario.TabIndex = 36;
            lUsuario.Text = "Usuario:";
            lUsuario.Visible = false;
            // 
            // txbEmail
            // 
            txbEmail.Enabled = false;
            txbEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txbEmail.Location = new Point(300, 110);
            txbEmail.Name = "txbEmail";
            txbEmail.ReadOnly = true;
            txbEmail.Size = new Size(234, 26);
            txbEmail.TabIndex = 35;
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Microsoft Sans Serif", 15.75F);
            lEmail.Location = new Point(300, 86);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(71, 25);
            lEmail.TabIndex = 34;
            lEmail.Text = "Email:";
            // 
            // txbTele
            // 
            txbTele.Font = new Font("Microsoft Sans Serif", 12F);
            txbTele.Location = new Point(559, 198);
            txbTele.Name = "txbTele";
            txbTele.ReadOnly = true;
            txbTele.Size = new Size(234, 26);
            txbTele.TabIndex = 33;
            // 
            // lTelefono
            // 
            lTelefono.AutoSize = true;
            lTelefono.Font = new Font("Microsoft Sans Serif", 15.75F);
            lTelefono.Location = new Point(559, 174);
            lTelefono.Name = "lTelefono";
            lTelefono.Size = new Size(102, 25);
            lTelefono.TabIndex = 32;
            lTelefono.Text = "Teléfono:";
            // 
            // txbApellido
            // 
            txbApellido.Font = new Font("Microsoft Sans Serif", 12F);
            txbApellido.Location = new Point(302, 198);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(234, 26);
            txbApellido.TabIndex = 31;
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Microsoft Sans Serif", 15.75F);
            lApellido.Location = new Point(302, 174);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(95, 25);
            lApellido.TabIndex = 30;
            lApellido.Text = "Apellido:";
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Microsoft Sans Serif", 12F);
            txbNombre.Location = new Point(35, 198);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(234, 26);
            txbNombre.TabIndex = 29;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Microsoft Sans Serif", 15.75F);
            lNombre.Location = new Point(35, 174);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(93, 25);
            lNombre.TabIndex = 28;
            lNombre.Text = "Nombre:";
            // 
            // labelPersona
            // 
            labelPersona.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelPersona.AutoSize = true;
            labelPersona.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPersona.Location = new Point(222, 19);
            labelPersona.Name = "labelPersona";
            labelPersona.Size = new Size(178, 42);
            labelPersona.TabIndex = 27;
            labelPersona.Text = "Datos de ";
            // 
            // DatosPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(804, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatosPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosUsuario";
            KeyDown += DatosPersona_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelPersona;
        private TextBox txbEmail;
        private Label lEmail;
        private TextBox txbTele;
        private Label lTelefono;
        private TextBox txbApellido;
        private Label lApellido;
        private TextBox txbNombre;
        private Label lNombre;
        private TextBox txbUsuario;
        private Label lUsuario;
        private TextBox txbDni;
        private Label lDni;
        private Label lFechaNac;
        private DateTimePicker dateFecha;
        private ComboBox comboSexo;
        private Label lSexo;
        private ComboBox comboPerfil;
        private Label lPerfil;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}