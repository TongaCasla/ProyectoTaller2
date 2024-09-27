namespace Vistas
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            lNombre = new Label();
            txbNombre = new TextBox();
            txbApellido = new TextBox();
            lApellido = new Label();
            txbDni = new TextBox();
            lDni = new Label();
            txbEmail = new TextBox();
            lEmail = new Label();
            txbContra = new TextBox();
            lContra = new Label();
            txbUsuario = new TextBox();
            lUsuario = new Label();
            lSexo = new Label();
            txbTele = new TextBox();
            lTele = new Label();
            radioHombre = new RadioButton();
            radioMujer = new RadioButton();
            radioOtro = new RadioButton();
            lFecha = new Label();
            dateFecha = new DateTimePicker();
            lPerfil = new Label();
            comboPerfil = new ComboBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnMostrarContra = new Button();
            btnOcultarContra = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Microsoft Sans Serif", 12.75F);
            lNombre.Location = new Point(180, 37);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(68, 20);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Microsoft Sans Serif", 11F);
            txbNombre.Location = new Point(175, 63);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(196, 24);
            txbNombre.TabIndex = 1;
            txbNombre.TextChanged += txbNombre_TextChanged;
            // 
            // txbApellido
            // 
            txbApellido.Font = new Font("Microsoft Sans Serif", 11F);
            txbApellido.Location = new Point(430, 61);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(196, 24);
            txbApellido.TabIndex = 2;
            txbApellido.TextChanged += txbApellido_TextChanged;
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Microsoft Sans Serif", 12.75F);
            lApellido.Location = new Point(433, 37);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(68, 20);
            lApellido.TabIndex = 2;
            lApellido.Text = "Apellido";
            // 
            // txbDni
            // 
            txbDni.Font = new Font("Microsoft Sans Serif", 11F);
            txbDni.Location = new Point(175, 129);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(196, 24);
            txbDni.TabIndex = 3;
            txbDni.TextChanged += txbDni_TextChanged;
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Microsoft Sans Serif", 12.75F);
            lDni.Location = new Point(175, 103);
            lDni.Name = "lDni";
            lDni.Size = new Size(38, 20);
            lDni.TabIndex = 4;
            lDni.Text = "DNI";
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Microsoft Sans Serif", 11F);
            txbEmail.Location = new Point(175, 261);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(196, 24);
            txbEmail.TabIndex = 7;
            txbEmail.TextChanged += txbEmail_TextChanged;
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Microsoft Sans Serif", 12.75F);
            lEmail.Location = new Point(175, 235);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(51, 20);
            lEmail.TabIndex = 6;
            lEmail.Text = "Email";
            // 
            // txbContra
            // 
            txbContra.Font = new Font("Microsoft Sans Serif", 11F);
            txbContra.Location = new Point(430, 195);
            txbContra.Name = "txbContra";
            txbContra.PasswordChar = '*';
            txbContra.Size = new Size(196, 24);
            txbContra.TabIndex = 6;
            txbContra.TextChanged += txbContra_TextChanged;
            // 
            // lContra
            // 
            lContra.AutoSize = true;
            lContra.Font = new Font("Microsoft Sans Serif", 12.75F);
            lContra.Location = new Point(430, 169);
            lContra.Name = "lContra";
            lContra.Size = new Size(95, 20);
            lContra.TabIndex = 10;
            lContra.Text = "Contraseña";
            // 
            // txbUsuario
            // 
            txbUsuario.Font = new Font("Microsoft Sans Serif", 11F);
            txbUsuario.Location = new Point(175, 195);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(196, 24);
            txbUsuario.TabIndex = 5;
            txbUsuario.TextChanged += txbUsuario_TextChanged;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Font = new Font("Microsoft Sans Serif", 12.75F);
            lUsuario.Location = new Point(175, 169);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(67, 20);
            lUsuario.TabIndex = 8;
            lUsuario.Text = "Usuario";
            // 
            // lSexo
            // 
            lSexo.AutoSize = true;
            lSexo.Font = new Font("Microsoft Sans Serif", 12.75F);
            lSexo.Location = new Point(433, 301);
            lSexo.Name = "lSexo";
            lSexo.Size = new Size(46, 20);
            lSexo.TabIndex = 14;
            lSexo.Text = "Sexo";
            // 
            // txbTele
            // 
            txbTele.Font = new Font("Microsoft Sans Serif", 11F);
            txbTele.Location = new Point(430, 129);
            txbTele.Name = "txbTele";
            txbTele.Size = new Size(196, 24);
            txbTele.TabIndex = 4;
            txbTele.TextChanged += txbTele_TextChanged;
            // 
            // lTele
            // 
            lTele.AutoSize = true;
            lTele.Font = new Font("Microsoft Sans Serif", 12.75F);
            lTele.Location = new Point(433, 103);
            lTele.Name = "lTele";
            lTele.Size = new Size(73, 20);
            lTele.TabIndex = 12;
            lTele.Text = "Teléfono";
            // 
            // radioHombre
            // 
            radioHombre.AutoSize = true;
            radioHombre.Checked = true;
            radioHombre.Font = new Font("Microsoft Sans Serif", 12F);
            radioHombre.Location = new Point(430, 331);
            radioHombre.Name = "radioHombre";
            radioHombre.Size = new Size(84, 24);
            radioHombre.TabIndex = 10;
            radioHombre.TabStop = true;
            radioHombre.Text = "Hombre";
            radioHombre.UseVisualStyleBackColor = true;
            radioHombre.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioMujer
            // 
            radioMujer.AutoSize = true;
            radioMujer.Font = new Font("Microsoft Sans Serif", 12F);
            radioMujer.Location = new Point(528, 331);
            radioMujer.Name = "radioMujer";
            radioMujer.Size = new Size(66, 24);
            radioMujer.TabIndex = 16;
            radioMujer.Text = "Mujer";
            radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioOtro
            // 
            radioOtro.AutoSize = true;
            radioOtro.Font = new Font("Microsoft Sans Serif", 12F);
            radioOtro.Location = new Point(605, 331);
            radioOtro.Name = "radioOtro";
            radioOtro.Size = new Size(58, 24);
            radioOtro.TabIndex = 17;
            radioOtro.Text = "Otro";
            radioOtro.UseVisualStyleBackColor = true;
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.Font = new Font("Microsoft Sans Serif", 12.75F);
            lFecha.Location = new Point(430, 235);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(144, 20);
            lFecha.TabIndex = 18;
            lFecha.Text = "Fecha Nacimiento";
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Microsoft Sans Serif", 11F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(430, 261);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(196, 24);
            dateFecha.TabIndex = 8;
            dateFecha.ValueChanged += dateFecha_ValueChanged;
            // 
            // lPerfil
            // 
            lPerfil.AutoSize = true;
            lPerfil.Font = new Font("Microsoft Sans Serif", 12.75F);
            lPerfil.Location = new Point(174, 301);
            lPerfil.Name = "lPerfil";
            lPerfil.Size = new Size(48, 20);
            lPerfil.TabIndex = 21;
            lPerfil.Text = "Perfil";
            // 
            // comboPerfil
            // 
            comboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPerfil.DropDownWidth = 270;
            comboPerfil.Font = new Font("Microsoft Sans Serif", 12.75F);
            comboPerfil.FormattingEnabled = true;
            comboPerfil.Items.AddRange(new object[] { "Gerente", "Administrador Usuarios", "Administrador Productos", "Empleado", "Cliente" });
            comboPerfil.Location = new Point(174, 327);
            comboPerfil.Name = "comboPerfil";
            comboPerfil.Size = new Size(197, 28);
            comboPerfil.TabIndex = 9;
            comboPerfil.SelectedIndexChanged += comboPerfil_SelectedIndexChanged;
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
            btnGuardar.Location = new Point(205, 421);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnCancelar.Location = new Point(413, 421);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 40);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnMostrarContra
            // 
            btnMostrarContra.BackColor = Color.Azure;
            btnMostrarContra.BackgroundImageLayout = ImageLayout.None;
            btnMostrarContra.Cursor = Cursors.Hand;
            btnMostrarContra.FlatAppearance.BorderSize = 0;
            btnMostrarContra.FlatStyle = FlatStyle.Flat;
            btnMostrarContra.Font = new Font("Microsoft Sans Serif", 18F);
            btnMostrarContra.ForeColor = Color.Black;
            btnMostrarContra.Image = (Image)resources.GetObject("btnMostrarContra.Image");
            btnMostrarContra.Location = new Point(632, 187);
            btnMostrarContra.Name = "btnMostrarContra";
            btnMostrarContra.Size = new Size(37, 37);
            btnMostrarContra.TabIndex = 25;
            btnMostrarContra.UseVisualStyleBackColor = false;
            btnMostrarContra.Click += btnMostrarContra_Click;
            // 
            // btnOcultarContra
            // 
            btnOcultarContra.BackColor = Color.Azure;
            btnOcultarContra.BackgroundImageLayout = ImageLayout.None;
            btnOcultarContra.Cursor = Cursors.Hand;
            btnOcultarContra.FlatAppearance.BorderSize = 0;
            btnOcultarContra.FlatStyle = FlatStyle.Flat;
            btnOcultarContra.Font = new Font("Microsoft Sans Serif", 18F);
            btnOcultarContra.ForeColor = Color.Black;
            btnOcultarContra.Image = (Image)resources.GetObject("btnOcultarContra.Image");
            btnOcultarContra.Location = new Point(632, 187);
            btnOcultarContra.Name = "btnOcultarContra";
            btnOcultarContra.Size = new Size(37, 37);
            btnOcultarContra.TabIndex = 26;
            btnOcultarContra.UseVisualStyleBackColor = false;
            btnOcultarContra.Visible = false;
            btnOcultarContra.Click += btnOcultarContra_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.Controls.Add(btnOcultarContra);
            panel1.Controls.Add(btnMostrarContra);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(comboPerfil);
            panel1.Controls.Add(lPerfil);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(lFecha);
            panel1.Controls.Add(radioOtro);
            panel1.Controls.Add(radioMujer);
            panel1.Controls.Add(radioHombre);
            panel1.Controls.Add(lSexo);
            panel1.Controls.Add(txbTele);
            panel1.Controls.Add(lTele);
            panel1.Controls.Add(txbContra);
            panel1.Controls.Add(lContra);
            panel1.Controls.Add(txbUsuario);
            panel1.Controls.Add(lUsuario);
            panel1.Controls.Add(txbEmail);
            panel1.Controls.Add(lEmail);
            panel1.Controls.Add(txbDni);
            panel1.Controls.Add(lDni);
            panel1.Controls.Add(txbApellido);
            panel1.Controls.Add(lApellido);
            panel1.Controls.Add(txbNombre);
            panel1.Controls.Add(lNombre);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 574);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 42;
            label1.Text = "Nuevo usuario";
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 548);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNombre;
        private TextBox txbNombre;
        private TextBox txbApellido;
        private Label lApellido;
        private TextBox txbDni;
        private Label lDni;
        private TextBox txbEmail;
        private Label lEmail;
        private TextBox txbContra;
        private Label lContra;
        private TextBox txbUsuario;
        private Label lUsuario;
        private Label lSexo;
        private TextBox txbTele;
        private Label lTele;
        private RadioButton radioHombre;
        private RadioButton radioMujer;
        private RadioButton radioOtro;
        private Label lFecha;
        private DateTimePicker dateFecha;
        private Label lPerfil;
        private ComboBox comboPerfil;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnMostrarContra;
        private Button btnOcultarContra;
        private Panel panel1;
        private Label label1;
    }
}