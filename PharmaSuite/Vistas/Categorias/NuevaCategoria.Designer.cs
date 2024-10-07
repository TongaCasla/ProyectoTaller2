namespace PharmaSuite.Vistas.Categorias
{
    partial class NuevaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaCategoria));
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            txbDescProd = new TextBox();
            txbNombreProd = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lTele = new Label();
            lDni = new Label();
            lNombreProd = new Label();
            txbCodProd = new TextBox();
            lCodigoProd = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txbDescProd);
            panel1.Controls.Add(txbNombreProd);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(lTele);
            panel1.Controls.Add(lDni);
            panel1.Controls.Add(lNombreProd);
            panel1.Controls.Add(txbCodProd);
            panel1.Controls.Add(lCodigoProd);
            panel1.Location = new Point(8, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F);
            label1.Location = new Point(257, 21);
            label1.Name = "label1";
            label1.Size = new Size(286, 39);
            label1.TabIndex = 41;
            label1.Text = "Nueva categoría";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Century Gothic", 14.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Activo", "Inactivo" });
            comboBox1.Location = new Point(425, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 30);
            comboBox1.TabIndex = 4;
            comboBox1.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 222, 251);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(372, 124);
            button1.Name = "button1";
            button1.Size = new Size(34, 31);
            button1.TabIndex = 40;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txbDescProd
            // 
            txbDescProd.Font = new Font("Century Gothic", 14.25F);
            txbDescProd.Location = new Point(226, 279);
            txbDescProd.Name = "txbDescProd";
            txbDescProd.Size = new Size(218, 31);
            txbDescProd.TabIndex = 3;
            // 
            // txbNombreProd
            // 
            txbNombreProd.Font = new Font("Century Gothic", 14.25F);
            txbNombreProd.Location = new Point(226, 209);
            txbNombreProd.Name = "txbNombreProd";
            txbNombreProd.Size = new Size(218, 31);
            txbNombreProd.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 18F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(425, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 40);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(217, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lTele
            // 
            lTele.AutoSize = true;
            lTele.Font = new Font("Century Gothic", 14.25F);
            lTele.Location = new Point(425, 98);
            lTele.Name = "lTele";
            lTele.Size = new Size(77, 22);
            lTele.TabIndex = 12;
            lTele.Text = "Estado:";
            lTele.Visible = false;
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Century Gothic", 14.25F);
            lDni.Location = new Point(226, 255);
            lDni.Name = "lDni";
            lDni.Size = new Size(121, 22);
            lDni.TabIndex = 4;
            lDni.Text = "Descripción:";
            // 
            // lNombreProd
            // 
            lNombreProd.AutoSize = true;
            lNombreProd.Font = new Font("Century Gothic", 14.25F);
            lNombreProd.Location = new Point(231, 184);
            lNombreProd.Name = "lNombreProd";
            lNombreProd.Size = new Size(89, 22);
            lNombreProd.TabIndex = 2;
            lNombreProd.Text = "Nombre:";
            // 
            // txbCodProd
            // 
            txbCodProd.Font = new Font("Century Gothic", 14.25F);
            txbCodProd.Location = new Point(226, 124);
            txbCodProd.Name = "txbCodProd";
            txbCodProd.ReadOnly = true;
            txbCodProd.Size = new Size(140, 31);
            txbCodProd.TabIndex = 1;
            // 
            // lCodigoProd
            // 
            lCodigoProd.AutoSize = true;
            lCodigoProd.Font = new Font("Century Gothic", 14.25F);
            lCodigoProd.Location = new Point(231, 98);
            lCodigoProd.Name = "lCodigoProd";
            lCodigoProd.Size = new Size(83, 22);
            lCodigoProd.TabIndex = 0;
            lCodigoProd.Text = "Código:";
            // 
            // NuevaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "NuevaCategoria";
            Text = "NuevaCategoria";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox txbDescProd;
        private TextBox txbNombreProd;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lTele;
        private Label lDni;
        private Label lNombreProd;
        private TextBox txbCodProd;
        private Label lCodigoProd;
        private Label label1;
    }
}