namespace PharmaSuite.Vistas.Productos
{
    partial class NuevoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProducto));
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            txbDescProd = new TextBox();
            txbNombreProd = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dateFecha = new DateTimePicker();
            lFecha = new Label();
            lTele = new Label();
            lDni = new Label();
            lNombreProd = new Label();
            txbCodProd = new TextBox();
            lCodigoProd = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbDescProd);
            panel1.Controls.Add(txbNombreProd);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(lFecha);
            panel1.Controls.Add(lTele);
            panel1.Controls.Add(lDni);
            panel1.Controls.Add(lNombreProd);
            panel1.Controls.Add(txbCodProd);
            panel1.Controls.Add(lCodigoProd);
            panel1.Location = new Point(0, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 514);
            panel1.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(606, 202);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(49, 29);
            comboBox2.TabIndex = 41;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(515, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 29);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 222, 251);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 18F);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(317, 62);
            button1.Name = "button1";
            button1.Size = new Size(34, 25);
            button1.TabIndex = 40;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Century Gothic", 12.75F);
            numericUpDown2.Location = new Point(340, 280);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(140, 28);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Century Gothic", 12.75F);
            numericUpDown1.Location = new Point(176, 281);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(135, 28);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12.75F);
            label5.Location = new Point(340, 257);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 37;
            label5.Text = "Stock max.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12.75F);
            label4.Location = new Point(176, 257);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 36;
            label4.Text = "Stock min.";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 11F);
            textBox3.Location = new Point(515, 202);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(85, 25);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12.75F);
            label3.Location = new Point(515, 178);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 34;
            label3.Text = "Presentación:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 11F);
            textBox2.Location = new Point(340, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 25);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12.75F);
            label2.Location = new Point(340, 178);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 32;
            label2.Text = "Precio venta:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 11F);
            textBox1.Location = new Point(171, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 25);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12.75F);
            label1.Location = new Point(171, 178);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 30;
            label1.Text = "Precio lista:";
            // 
            // txbDescProd
            // 
            txbDescProd.Font = new Font("Century Gothic", 11F);
            txbDescProd.Location = new Point(340, 127);
            txbDescProd.Name = "txbDescProd";
            txbDescProd.Size = new Size(140, 25);
            txbDescProd.TabIndex = 3;
            // 
            // txbNombreProd
            // 
            txbNombreProd.Font = new Font("Century Gothic", 11F);
            txbNombreProd.Location = new Point(171, 127);
            txbNombreProd.Name = "txbNombreProd";
            txbNombreProd.Size = new Size(140, 25);
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
            btnCancelar.Location = new Point(421, 373);
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
            btnGuardar.Location = new Point(213, 373);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Century Gothic", 11F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(515, 281);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(140, 25);
            dateFecha.TabIndex = 10;
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.Font = new Font("Century Gothic", 12.75F);
            lFecha.Location = new Point(515, 257);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(167, 21);
            lFecha.TabIndex = 18;
            lFecha.Text = "Fecha caducidad:";
            // 
            // lTele
            // 
            lTele.AutoSize = true;
            lTele.Font = new Font("Century Gothic", 12.75F);
            lTele.Location = new Point(515, 103);
            lTele.Name = "lTele";
            lTele.Size = new Size(101, 21);
            lTele.TabIndex = 12;
            lTele.Text = "Categoría:";
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Century Gothic", 12.75F);
            lDni.Location = new Point(340, 103);
            lDni.Name = "lDni";
            lDni.Size = new Size(112, 21);
            lDni.TabIndex = 4;
            lDni.Text = "Descripción:";
            // 
            // lNombreProd
            // 
            lNombreProd.AutoSize = true;
            lNombreProd.Font = new Font("Century Gothic", 12.75F);
            lNombreProd.Location = new Point(171, 103);
            lNombreProd.Name = "lNombreProd";
            lNombreProd.Size = new Size(82, 21);
            lNombreProd.TabIndex = 2;
            lNombreProd.Text = "Nombre:";
            // 
            // txbCodProd
            // 
            txbCodProd.Font = new Font("Century Gothic", 11F);
            txbCodProd.Location = new Point(171, 62);
            txbCodProd.Name = "txbCodProd";
            txbCodProd.Size = new Size(140, 25);
            txbCodProd.TabIndex = 1;
            // 
            // lCodigoProd
            // 
            lCodigoProd.AutoSize = true;
            lCodigoProd.Font = new Font("Century Gothic", 12.75F);
            lCodigoProd.Location = new Point(176, 36);
            lCodigoProd.Name = "lCodigoProd";
            lCodigoProd.Size = new Size(77, 21);
            lCodigoProd.TabIndex = 0;
            lCodigoProd.Text = "Código:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 24F);
            label6.Location = new Point(257, 9);
            label6.Name = "label6";
            label6.Size = new Size(276, 39);
            label6.TabIndex = 42;
            label6.Text = "Nuevo producto";
            // 
            // NuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 514);
            Controls.Add(label6);
            Controls.Add(panel1);
            Name = "NuevoProducto";
            Text = "NuevoProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lTele;
        private Label lDni;
        private Label lNombreProd;
        private TextBox txbCodProd;
        private Label lCodigoProd;
        private TextBox txbNombreProd;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox txbDescProd;
        private DateTimePicker dateFecha;
        private Label lFecha;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
    }
}