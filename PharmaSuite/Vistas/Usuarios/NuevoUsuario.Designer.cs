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
            lNombre.Font = new Font("Century Gothic", 15.75F);
            lNombre.Location = new Point(175, 92);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(95, 24);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.Font = new Font("Century Gothic", 15.75F);
            txbNombre.Location = new Point(170, 118);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(196, 33);
            txbNombre.TabIndex = 1;
            // 
            // txbApellido
            // 
            txbApellido.Font = new Font("Century Gothic", 15.75F);
            txbApellido.Location = new Point(425, 116);
            txbApellido.Name = "txbApellido";
            txbApellido.Size = new Size(196, 33);
            txbApellido.TabIndex = 2;
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Century Gothic", 15.75F);
            lApellido.Location = new Point(428, 92);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(94, 24);
            lApellido.TabIndex = 2;
            lApellido.Text = "Apellido";
            // 
            // txbDni
            // 
            txbDni.Font = new Font("Century Gothic", 15.75F);
            txbDni.Location = new Point(170, 184);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(196, 33);
            txbDni.TabIndex = 3;
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Century Gothic", 15.75F);
            lDni.Location = new Point(170, 154);
            lDni.Name = "lDni";
            lDni.Size = new Size(47, 24);
            lDni.TabIndex = 4;
            lDni.Text = "DNI";
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Century Gothic", 15.75F);
            txbEmail.Location = new Point(170, 260);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(196, 33);
            txbEmail.TabIndex = 7;
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Century Gothic", 15.75F);
            lEmail.Location = new Point(170, 233);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(64, 24);
            lEmail.TabIndex = 6;
            lEmail.Text = "Email";
            // 
            // txbContra
            // 
            txbContra.Font = new Font("Century Gothic", 15.75F);
            txbContra.Location = new Point(428, 418);
            txbContra.Name = "txbContra";
            txbContra.PasswordChar = '*';
            txbContra.Size = new Size(196, 33);
            txbContra.TabIndex = 6;
            // 
            // lContra
            // 
            lContra.AutoSize = true;
            lContra.Font = new Font("Century Gothic", 15.75F);
            lContra.Location = new Point(428, 391);
            lContra.Name = "lContra";
            lContra.Size = new Size(130, 24);
            lContra.TabIndex = 10;
            lContra.Text = "Contraseña";
            // 
            // txbUsuario
            // 
            txbUsuario.Font = new Font("Century Gothic", 15.75F);
            txbUsuario.Location = new Point(170, 421);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(196, 33);
            txbUsuario.TabIndex = 5;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Font = new Font("Century Gothic", 15.75F);
            lUsuario.Location = new Point(170, 391);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(81, 24);
            lUsuario.TabIndex = 8;
            lUsuario.Text = "Usuario";
            // 
            // lSexo
            // 
            lSexo.AutoSize = true;
            lSexo.Font = new Font("Century Gothic", 15.75F);
            lSexo.Location = new Point(172, 296);
            lSexo.Name = "lSexo";
            lSexo.Size = new Size(58, 24);
            lSexo.TabIndex = 14;
            lSexo.Text = "Sexo";
            // 
            // txbTele
            // 
            txbTele.Font = new Font("Century Gothic", 15.75F);
            txbTele.Location = new Point(425, 184);
            txbTele.Name = "txbTele";
            txbTele.Size = new Size(196, 33);
            txbTele.TabIndex = 4;
            // 
            // lTele
            // 
            lTele.AutoSize = true;
            lTele.Font = new Font("Century Gothic", 15.75F);
            lTele.Location = new Point(428, 158);
            lTele.Name = "lTele";
            lTele.Size = new Size(99, 24);
            lTele.TabIndex = 12;
            lTele.Text = "Teléfono";
            // 
            // radioHombre
            // 
            radioHombre.AutoSize = true;
            radioHombre.Checked = true;
            radioHombre.Font = new Font("Century Gothic", 15.75F);
            radioHombre.Location = new Point(172, 323);
            radioHombre.Name = "radioHombre";
            radioHombre.Size = new Size(111, 28);
            radioHombre.TabIndex = 10;
            radioHombre.TabStop = true;
            radioHombre.Text = "Hombre";
            radioHombre.UseVisualStyleBackColor = true;
            // 
            // radioMujer
            // 
            radioMujer.AutoSize = true;
            radioMujer.Font = new Font("Century Gothic", 15.75F);
            radioMujer.Location = new Point(289, 323);
            radioMujer.Name = "radioMujer";
            radioMujer.Size = new Size(83, 28);
            radioMujer.TabIndex = 16;
            radioMujer.Text = "Mujer";
            radioMujer.UseVisualStyleBackColor = true;
            // 
            // radioOtro
            // 
            radioOtro.AutoSize = true;
            radioOtro.Font = new Font("Century Gothic", 15.75F);
            radioOtro.Location = new Point(175, 348);
            radioOtro.Name = "radioOtro";
            radioOtro.Size = new Size(73, 28);
            radioOtro.TabIndex = 17;
            radioOtro.Text = "Otro";
            radioOtro.UseVisualStyleBackColor = true;
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.Font = new Font("Century Gothic", 15.75F);
            lFecha.Location = new Point(428, 233);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(200, 24);
            lFecha.TabIndex = 18;
            lFecha.Text = "Fecha Nacimiento";
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Century Gothic", 15.75F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(428, 259);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(196, 33);
            dateFecha.TabIndex = 8;
            // 
            // lPerfil
            // 
            lPerfil.AutoSize = true;
            lPerfil.Font = new Font("Century Gothic", 15.75F);
            lPerfil.Location = new Point(170, 27);
            lPerfil.Name = "lPerfil";
            lPerfil.Size = new Size(57, 24);
            lPerfil.TabIndex = 21;
            lPerfil.Text = "Perfil";
            // 
            // comboPerfil
            // 
            comboPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPerfil.DropDownWidth = 270;
            comboPerfil.Font = new Font("Century Gothic", 15.75F);
            comboPerfil.FormattingEnabled = true;

            comboPerfil.Items.AddRange(new object[] { "Cliente", "Empleado", "Gerente", "Administrador" });
            comboPerfil.Location = new Point(170, 53);

            comboPerfil.Name = "comboPerfil";
            comboPerfil.Size = new Size(197, 32);
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
            btnGuardar.Location = new Point(200, 498);
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
            btnCancelar.Location = new Point(408, 498);
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
            btnMostrarContra.Font = new Font("Century Gothic", 15.75F);
            btnMostrarContra.ForeColor = Color.Black;
            btnMostrarContra.Image = (Image)resources.GetObject("btnMostrarContra.Image");
            btnMostrarContra.Location = new Point(630, 410);
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
            btnOcultarContra.Font = new Font("Century Gothic", 15.75F);
            btnOcultarContra.ForeColor = Color.Black;
            btnOcultarContra.Image = (Image)resources.GetObject("btnOcultarContra.Image");
            btnOcultarContra.Location = new Point(630, 410);
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
            panel1.Size = new Size(800, 614);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(257, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 39);
            label1.TabIndex = 42;
            label1.Text = "Nuevo usuario";
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 588);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
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