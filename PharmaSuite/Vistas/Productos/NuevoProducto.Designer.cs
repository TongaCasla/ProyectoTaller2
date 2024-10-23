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
            VentaLibreNoBtn = new RadioButton();
            VentaLibreSiBtn = new RadioButton();
            label7 = new Label();
            comboMedida = new ComboBox();
            comboCategoria = new ComboBox();
            button1 = new Button();
            stockMax = new NumericUpDown();
            stockMin = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            txbPresentacion = new TextBox();
            label3 = new Label();
            txbPrecVenta = new TextBox();
            label2 = new Label();
            txbPrecLista = new TextBox();
            label1 = new Label();
            txbNombreProd = new TextBox();
            dateFecha = new DateTimePicker();
            lFecha = new Label();
            lTele = new Label();
            lNombreProd = new Label();
            txbCodProd = new TextBox();
            lCodigoProd = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stockMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockMin).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(VentaLibreNoBtn);
            panel1.Controls.Add(VentaLibreSiBtn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboMedida);
            panel1.Controls.Add(comboCategoria);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(stockMax);
            panel1.Controls.Add(stockMin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbPresentacion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbPrecVenta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbPrecLista);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbNombreProd);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(lFecha);
            panel1.Controls.Add(lTele);
            panel1.Controls.Add(lNombreProd);
            panel1.Controls.Add(txbCodProd);
            panel1.Controls.Add(lCodigoProd);
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 498);
            panel1.TabIndex = 28;
            // 
            // VentaLibreNoBtn
            // 
            VentaLibreNoBtn.AutoSize = true;
            VentaLibreNoBtn.Font = new Font("Century Gothic", 18F);
            VentaLibreNoBtn.Location = new Point(677, 136);
            VentaLibreNoBtn.Name = "VentaLibreNoBtn";
            VentaLibreNoBtn.Size = new Size(65, 34);
            VentaLibreNoBtn.TabIndex = 45;
            VentaLibreNoBtn.Text = "No";
            VentaLibreNoBtn.UseVisualStyleBackColor = true;
            // 
            // VentaLibreSiBtn
            // 
            VentaLibreSiBtn.AutoSize = true;
            VentaLibreSiBtn.Checked = true;
            VentaLibreSiBtn.Font = new Font("Century Gothic", 18F);
            VentaLibreSiBtn.Location = new Point(587, 136);
            VentaLibreSiBtn.Name = "VentaLibreSiBtn";
            VentaLibreSiBtn.Size = new Size(49, 34);
            VentaLibreSiBtn.TabIndex = 44;
            VentaLibreSiBtn.TabStop = true;
            VentaLibreSiBtn.Text = "Si";
            VentaLibreSiBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F);
            label7.Location = new Point(592, 100);
            label7.Name = "label7";
            label7.Size = new Size(150, 30);
            label7.TabIndex = 43;
            label7.Text = "Venta libre:";
            // 
            // comboMedida
            // 
            comboMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMedida.Font = new Font("Century Gothic", 16F);
            comboMedida.FormattingEnabled = true;
            comboMedida.Items.AddRange(new object[] { "Kg", "Gr", "L", "Ml" });
            comboMedida.Location = new Point(693, 230);
            comboMedida.Name = "comboMedida";
            comboMedida.Size = new Size(67, 32);
            comboMedida.TabIndex = 41;
            // 
            // comboCategoria
            // 
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.Font = new Font("Century Gothic", 16F);
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(317, 133);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(211, 32);
            comboCategoria.TabIndex = 4;
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
            button1.Location = new Point(210, 50);
            button1.Name = "button1";
            button1.Size = new Size(33, 37);
            button1.TabIndex = 40;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stockMax
            // 
            stockMax.Font = new Font("Century Gothic", 16F);
            stockMax.Location = new Point(326, 330);
            stockMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            stockMax.Name = "stockMax";
            stockMax.Size = new Size(140, 34);
            stockMax.TabIndex = 9;
            stockMax.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // stockMin
            // 
            stockMin.Font = new Font("Century Gothic", 16F);
            stockMin.Location = new Point(64, 327);
            stockMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            stockMin.Name = "stockMin";
            stockMin.Size = new Size(135, 34);
            stockMin.TabIndex = 8;
            stockMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F);
            label5.Location = new Point(323, 294);
            label5.Name = "label5";
            label5.Size = new Size(143, 30);
            label5.TabIndex = 37;
            label5.Text = "Stock max.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F);
            label4.Location = new Point(64, 294);
            label4.Name = "label4";
            label4.Size = new Size(136, 30);
            label4.TabIndex = 36;
            label4.Text = "Stock min.";
            // 
            // txbPresentacion
            // 
            txbPresentacion.Font = new Font("Century Gothic", 16F);
            txbPresentacion.Location = new Point(597, 230);
            txbPresentacion.Name = "txbPresentacion";
            txbPresentacion.Size = new Size(85, 34);
            txbPresentacion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F);
            label3.Location = new Point(592, 197);
            label3.Name = "label3";
            label3.Size = new Size(175, 30);
            label3.TabIndex = 34;
            label3.Text = "Presentación:";
            // 
            // txbPrecVenta
            // 
            txbPrecVenta.Font = new Font("Century Gothic", 16F);
            txbPrecVenta.Location = new Point(317, 230);
            txbPrecVenta.Name = "txbPrecVenta";
            txbPrecVenta.PlaceholderText = "Ej. 1500,40";
            txbPrecVenta.Size = new Size(199, 34);
            txbPrecVenta.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F);
            label2.Location = new Point(317, 197);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 32;
            label2.Text = "Precio venta:";
            // 
            // txbPrecLista
            // 
            txbPrecLista.Font = new Font("Century Gothic", 16F);
            txbPrecLista.Location = new Point(64, 230);
            txbPrecLista.Name = "txbPrecLista";
            txbPrecLista.PlaceholderText = "Ej. 1500,40";
            txbPrecLista.Size = new Size(211, 34);
            txbPrecLista.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.Location = new Point(64, 197);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 30;
            label1.Text = "Precio lista:";
            // 
            // txbNombreProd
            // 
            txbNombreProd.Font = new Font("Century Gothic", 16F);
            txbNombreProd.Location = new Point(64, 133);
            txbNombreProd.Name = "txbNombreProd";
            txbNombreProd.Size = new Size(211, 34);
            txbNombreProd.TabIndex = 2;
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Century Gothic", 16F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(602, 330);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(140, 34);
            dateFecha.TabIndex = 10;
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.Font = new Font("Century Gothic", 18F);
            lFecha.Location = new Point(597, 294);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(235, 30);
            lFecha.TabIndex = 18;
            lFecha.Text = "Fecha caducidad:";
            // 
            // lTele
            // 
            lTele.AutoSize = true;
            lTele.Font = new Font("Century Gothic", 18F);
            lTele.Location = new Point(326, 100);
            lTele.Name = "lTele";
            lTele.Size = new Size(141, 30);
            lTele.TabIndex = 12;
            lTele.Text = "Categoría:";
            // 
            // lNombreProd
            // 
            lNombreProd.AutoSize = true;
            lNombreProd.Font = new Font("Century Gothic", 18F);
            lNombreProd.Location = new Point(64, 100);
            lNombreProd.Name = "lNombreProd";
            lNombreProd.Size = new Size(117, 30);
            lNombreProd.TabIndex = 2;
            lNombreProd.Text = "Nombre:";
            // 
            // txbCodProd
            // 
            txbCodProd.Font = new Font("Century Gothic", 16F);
            txbCodProd.Location = new Point(64, 50);
            txbCodProd.Name = "txbCodProd";
            txbCodProd.ReadOnly = true;
            txbCodProd.Size = new Size(140, 34);
            txbCodProd.TabIndex = 1;
            // 
            // lCodigoProd
            // 
            lCodigoProd.AutoSize = true;
            lCodigoProd.Font = new Font("Century Gothic", 18F);
            lCodigoProd.Location = new Point(64, 17);
            lCodigoProd.Name = "lCodigoProd";
            lCodigoProd.Size = new Size(110, 30);
            lCodigoProd.TabIndex = 0;
            lCodigoProd.Text = "Código:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 18F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(461, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 40);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
            btnGuardar.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(253, 11);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 30F);
            label6.Location = new Point(297, 9);
            label6.Name = "label6";
            label6.Size = new Size(344, 49);
            label6.TabIndex = 42;
            label6.Text = "Nuevo producto";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 66);
            panel2.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnGuardar);
            panel3.Controls.Add(btnCancelar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 472);
            panel3.Name = "panel3";
            panel3.Size = new Size(880, 92);
            panel3.TabIndex = 44;
            // 
            // NuevoProducto
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(880, 564);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "NuevoProducto";
            Text = "NuevoProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)stockMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockMin).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lTele;
        private Label lNombreProd;
        private TextBox txbCodProd;
        private Label lCodigoProd;
        private TextBox txbNombreProd;
        private TextBox txbPrecVenta;
        private Label label2;
        private TextBox txbPrecLista;
        private Label label1;
        private DateTimePicker dateFecha;
        private Label lFecha;
        private Label label5;
        private Label label4;
        private TextBox txbPresentacion;
        private Label label3;
        private Button button1;
        private NumericUpDown stockMax;
        private NumericUpDown stockMin;
        private ComboBox comboMedida;
        private ComboBox comboCategoria;
        private Label label6;
        private Label label7;
        private RadioButton VentaLibreNoBtn;
        private RadioButton VentaLibreSiBtn;
        private Panel panel2;
        private Panel panel3;
    }
}