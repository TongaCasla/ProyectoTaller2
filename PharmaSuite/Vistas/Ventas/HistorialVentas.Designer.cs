namespace PharmaSuite.Vistas.Ventas
{
    partial class HistorialVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialVentas));
            panel1 = new Panel();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            btnGuardarReporte = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateFecha = new DateTimePicker();
            lNombreProd = new Label();
            labelTituloBusqueda = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnGuardarReporte);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateFecha);
            panel1.Controls.Add(lNombreProd);
            panel1.Controls.Add(labelTituloBusqueda);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 490);
            panel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 15.75F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(521, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 32);
            btnBuscar.TabIndex = 52;
            btnBuscar.Text = "Enviar";
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 277);
            dataGridView1.TabIndex = 51;
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
            btnSalir.Location = new Point(406, 424);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(166, 40);
            btnSalir.TabIndex = 50;
            btnSalir.Text = "Cancelar";
            btnSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSalir.UseVisualStyleBackColor = false;
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
            btnGuardarReporte.Location = new Point(200, 424);
            btnGuardarReporte.Name = "btnGuardarReporte";
            btnGuardarReporte.Size = new Size(166, 40);
            btnGuardarReporte.TabIndex = 49;
            btnGuardarReporte.Text = "Guardar";
            btnGuardarReporte.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardarReporte.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateTimePicker1.Font = new Font("Century Gothic", 15.75F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(325, 102);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 33);
            dateTimePicker1.TabIndex = 48;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F);
            label2.Location = new Point(325, 74);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 47;
            label2.Text = "Fecha de fin:";
            // 
            // dateFecha
            // 
            dateFecha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateFecha.Font = new Font("Century Gothic", 15.75F);
            dateFecha.Format = DateTimePickerFormat.Short;
            dateFecha.Location = new Point(108, 101);
            dateFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(170, 33);
            dateFecha.TabIndex = 46;
            // 
            // lNombreProd
            // 
            lNombreProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lNombreProd.AutoSize = true;
            lNombreProd.Font = new Font("Century Gothic", 15.75F);
            lNombreProd.Location = new Point(108, 74);
            lNombreProd.Name = "lNombreProd";
            lNombreProd.Size = new Size(170, 24);
            lNombreProd.TabIndex = 45;
            lNombreProd.Text = "Fecha de inicio:";
            // 
            // labelTituloBusqueda
            // 
            labelTituloBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelTituloBusqueda.AutoSize = true;
            labelTituloBusqueda.Font = new Font("Century Gothic", 24F);
            labelTituloBusqueda.Location = new Point(236, 9);
            labelTituloBusqueda.Name = "labelTituloBusqueda";
            labelTituloBusqueda.Size = new Size(299, 39);
            labelTituloBusqueda.TabIndex = 44;
            labelTituloBusqueda.Text = "Historial de ventas";
            // 
            // HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 490);
            Controls.Add(panel1);
            Name = "HistorialVentas";
            Text = "HistorialVentas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTituloBusqueda;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateFecha;
        private Label lNombreProd;
        private Button btnSalir;
        private Button btnGuardarReporte;
        private DataGridView dataGridView1;
        private Button btnBuscar;
    }
}