namespace PharmaSuite.Vistas.Reportes
{
    partial class ReporteBorrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteBorrador));
            panel1 = new Panel();
            btnSalir = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnGuardarReporte = new Button();
            label2 = new Label();
            dateFecha = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lNombreProd = new Label();
            lCodigoProd = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnGuardarReporte);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(lNombreProd);
            panel1.Controls.Add(lCodigoProd);
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 404);
            panel1.TabIndex = 31;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom;
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Century Gothic", 18F);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(699, 670);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(166, 40);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "Cancelar";
            btnSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 15.75F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(431, 209);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 33);
            dateTimePicker1.TabIndex = 44;
            // 
            // btnGuardarReporte
            // 
            btnGuardarReporte.Anchor = AnchorStyles.Bottom;
            btnGuardarReporte.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardarReporte.BackgroundImageLayout = ImageLayout.None;
            btnGuardarReporte.Cursor = Cursors.Hand;
            btnGuardarReporte.FlatAppearance.BorderSize = 0;
            btnGuardarReporte.FlatStyle = FlatStyle.Flat;
            btnGuardarReporte.Font = new Font("Century Gothic", 18F);
            btnGuardarReporte.ForeColor = Color.Black;
            btnGuardarReporte.Image = (Image)resources.GetObject("btnGuardarReporte.Image");
            btnGuardarReporte.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarReporte.Location = new Point(491, 670);
            btnGuardarReporte.Name = "btnGuardarReporte";
            btnGuardarReporte.Size = new Size(166, 40);
            btnGuardarReporte.TabIndex = 31;
            btnGuardarReporte.Text = "Guardar";
            btnGuardarReporte.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardarReporte.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F);
            label2.Location = new Point(431, 184);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 43;
            label2.Text = "Fecha de fin:";
            // 
            // dateFecha
            // 
            dateFecha.Font = new Font("Century Gothic", 15.75F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(238, 209);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(154, 33);
            dateFecha.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F);
            label1.Location = new Point(217, 29);
            label1.Name = "label1";
            label1.Size = new Size(245, 39);
            label1.TabIndex = 41;
            label1.Text = "Nuevo reporte";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Century Gothic", 15.75F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(238, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 32);
            comboBox1.TabIndex = 4;
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
            btnCancelar.Location = new Point(1005, 1036);
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
            btnGuardar.Location = new Point(797, 1036);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lNombreProd
            // 
            lNombreProd.AutoSize = true;
            lNombreProd.Font = new Font("Century Gothic", 15.75F);
            lNombreProd.Location = new Point(237, 184);
            lNombreProd.Name = "lNombreProd";
            lNombreProd.Size = new Size(170, 24);
            lNombreProd.TabIndex = 2;
            lNombreProd.Text = "Fecha de inicio:";
            // 
            // lCodigoProd
            // 
            lCodigoProd.AutoSize = true;
            lCodigoProd.Font = new Font("Century Gothic", 15.75F);
            lCodigoProd.Location = new Point(238, 96);
            lCodigoProd.Name = "lCodigoProd";
            lCodigoProd.Size = new Size(169, 24);
            lCodigoProd.TabIndex = 0;
            lCodigoProd.Text = "Tipo de reporte:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.LightCoral;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 18F);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.borrar;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(400, 296);
            button1.Name = "button1";
            button1.Size = new Size(42, 40);
            button1.TabIndex = 46;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(187, 222, 251);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 18F);
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.imprimir;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(348, 296);
            button2.Name = "button2";
            button2.Size = new Size(44, 40);
            button2.TabIndex = 45;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // ReporteBorrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "ReporteBorrador";
            Text = "ReporteBorrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardarReporte;
        private Label label2;
        private DateTimePicker dateFecha;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lNombreProd;
        private Label lCodigoProd;
        private Button button1;
        private Button button2;
    }
}