namespace PharmaSuite.Vistas.Reportes
{
    partial class NuevoReporte
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pSup = new Panel();
            button2 = new Button();
            dateFin = new DateTimePicker();
            label2 = new Label();
            dateInicio = new DateTimePicker();
            comboReporte = new ComboBox();
            lNombreProd = new Label();
            lCodigoProd = new Label();
            label1 = new Label();
            pInferior = new Panel();
            btnEliminar = new Button();
            btnImp = new Button();
            pCentral = new Panel();
            dataGridView1 = new DataGridView();
            lreporte = new Label();
            saveFileDialog1 = new SaveFileDialog();
            pSup.SuspendLayout();
            pInferior.SuspendLayout();
            pCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pSup
            // 
            pSup.Controls.Add(button2);
            pSup.Controls.Add(dateFin);
            pSup.Controls.Add(label2);
            pSup.Controls.Add(dateInicio);
            pSup.Controls.Add(comboReporte);
            pSup.Controls.Add(lNombreProd);
            pSup.Controls.Add(lCodigoProd);
            pSup.Controls.Add(label1);
            pSup.Dock = DockStyle.Top;
            pSup.Location = new Point(0, 0);
            pSup.Name = "pSup";
            pSup.Size = new Size(800, 134);
            pSup.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(187, 222, 251);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 18F);
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.avion_de_papel;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(667, 83);
            button2.Name = "button2";
            button2.Size = new Size(127, 40);
            button2.TabIndex = 47;
            button2.Text = "Enviar";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // dateFin
            // 
            dateFin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateFin.Font = new Font("Century Gothic", 15.75F);
            dateFin.Format = DateTimePickerFormat.Short;
            dateFin.Location = new Point(494, 87);
            dateFin.MaxDate = new DateTime(2024, 11, 2, 0, 0, 0, 0);
            dateFin.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(154, 33);
            dateFin.TabIndex = 46;
            dateFin.Value = new DateTime(2024, 11, 2, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F);
            label2.Location = new Point(494, 62);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 45;
            label2.Text = "Fecha de fin:";
            // 
            // dateInicio
            // 
            dateInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dateInicio.Font = new Font("Century Gothic", 15.75F);
            dateInicio.Format = DateTimePickerFormat.Short;
            dateInicio.Location = new Point(294, 87);
            dateInicio.MaxDate = new DateTime(2024, 11, 2, 0, 0, 0, 0);
            dateInicio.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(154, 33);
            dateInicio.TabIndex = 44;
            dateInicio.Value = new DateTime(2024, 11, 2, 0, 0, 0, 0);
            // 
            // comboReporte
            // 
            comboReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            comboReporte.Font = new Font("Century Gothic", 13F);
            comboReporte.FormattingEnabled = true;
            comboReporte.Location = new Point(12, 91);
            comboReporte.Name = "comboReporte";
            comboReporte.Size = new Size(256, 29);
            comboReporte.TabIndex = 44;
            // 
            // lNombreProd
            // 
            lNombreProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lNombreProd.AutoSize = true;
            lNombreProd.Font = new Font("Century Gothic", 15.75F);
            lNombreProd.Location = new Point(294, 62);
            lNombreProd.Name = "lNombreProd";
            lNombreProd.Size = new Size(170, 24);
            lNombreProd.TabIndex = 43;
            lNombreProd.Text = "Fecha de inicio:";
            // 
            // lCodigoProd
            // 
            lCodigoProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lCodigoProd.AutoSize = true;
            lCodigoProd.Font = new Font("Century Gothic", 15.75F);
            lCodigoProd.Location = new Point(12, 62);
            lCodigoProd.Name = "lCodigoProd";
            lCodigoProd.Size = new Size(169, 24);
            lCodigoProd.TabIndex = 43;
            lCodigoProd.Text = "Tipo de reporte:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F);
            label1.Location = new Point(268, 11);
            label1.Name = "label1";
            label1.Size = new Size(245, 39);
            label1.TabIndex = 42;
            label1.Text = "Nuevo reporte";
            // 
            // pInferior
            // 
            pInferior.Controls.Add(btnEliminar);
            pInferior.Controls.Add(btnImp);
            pInferior.Dock = DockStyle.Bottom;
            pInferior.Location = new Point(0, 371);
            pInferior.Name = "pInferior";
            pInferior.Size = new Size(800, 79);
            pInferior.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 18F);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Image = Properties.Resources.borrar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(413, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 40);
            btnEliminar.TabIndex = 48;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button1_Click;
            // 
            // btnImp
            // 
            btnImp.Anchor = AnchorStyles.None;
            btnImp.BackColor = Color.FromArgb(187, 222, 251);
            btnImp.BackgroundImageLayout = ImageLayout.None;
            btnImp.Cursor = Cursors.Hand;
            btnImp.FlatAppearance.BorderSize = 0;
            btnImp.FlatStyle = FlatStyle.Flat;
            btnImp.Font = new Font("Century Gothic", 18F);
            btnImp.ForeColor = Color.Black;
            btnImp.Image = Properties.Resources.disco;
            btnImp.ImageAlign = ContentAlignment.MiddleLeft;
            btnImp.Location = new Point(242, 17);
            btnImp.Name = "btnImp";
            btnImp.Size = new Size(163, 40);
            btnImp.TabIndex = 47;
            btnImp.Text = "Guardar";
            btnImp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnImp.UseVisualStyleBackColor = false;
            btnImp.Click += btnImp_Click;
            // 
            // pCentral
            // 
            pCentral.Controls.Add(dataGridView1);
            pCentral.Controls.Add(lreporte);
            pCentral.Dock = DockStyle.Fill;
            pCentral.Location = new Point(0, 134);
            pCentral.Margin = new Padding(3, 3, 20, 3);
            pCentral.Name = "pCentral";
            pCentral.Size = new Size(800, 237);
            pCentral.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(20, 3, 3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 237);
            dataGridView1.TabIndex = 61;
            dataGridView1.Visible = false;
            // 
            // lreporte
            // 
            lreporte.Anchor = AnchorStyles.Top;
            lreporte.AutoSize = true;
            lreporte.Font = new Font("Century Gothic", 24F);
            lreporte.Location = new Point(164, 110);
            lreporte.Name = "lreporte";
            lreporte.Size = new Size(473, 39);
            lreporte.TabIndex = 48;
            lreporte.Text = "Seleccione un nuevo reporte";
            // 
            // NuevoReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(pCentral);
            Controls.Add(pInferior);
            Controls.Add(pSup);
            Name = "NuevoReporte";
            Text = "NuevoReporte";
            pSup.ResumeLayout(false);
            pSup.PerformLayout();
            pInferior.ResumeLayout(false);
            pCentral.ResumeLayout(false);
            pCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSup;
        private Panel pInferior;
        private Panel pCentral;
        private Label label1;
        private ComboBox comboReporte;
        private Label lCodigoProd;
        private DateTimePicker dateInicio;
        private Label lNombreProd;
        private DateTimePicker dateFin;
        private Label label2;
        private Button button2;
        private Button btnEliminar;
        private Button btnImp;
        private Label lreporte;
        private DataGridView dataGridView1;
        private SaveFileDialog saveFileDialog1;
    }
}