namespace PharmaSuite.Vistas.Categorias
{
    partial class ListaCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaCategorias));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label1 = new Label();
            btnGuardar = new Button();
            txbNombreCat = new TextBox();
            lUsuario = new Label();
            btnCategorias = new Button();
            labelTituloTabla = new Label();
            btnMostrarInactivos = new Button();
            btnMostrarActivos = new Button();
            panel3 = new Panel();
            lTablaVacia = new Label();
            dataGridView1 = new DataGridView();
            Cod = new DataGridViewTextBoxColumn();
            NombrePersona = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(txbNombreCat);
            panel2.Controls.Add(lUsuario);
            panel2.Controls.Add(btnCategorias);
            panel2.Controls.Add(labelTituloTabla);
            panel2.Controls.Add(btnMostrarInactivos);
            panel2.Controls.Add(btnMostrarActivos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 140);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 26);
            label1.TabIndex = 71;
            label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(183, 73);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(41, 31);
            btnGuardar.TabIndex = 70;
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txbNombreCat
            // 
            txbNombreCat.Font = new Font("Microsoft Sans Serif", 15.75F);
            txbNombreCat.Location = new Point(12, 73);
            txbNombreCat.Name = "txbNombreCat";
            txbNombreCat.PlaceholderText = "Categoría";
            txbNombreCat.Size = new Size(165, 31);
            txbNombreCat.TabIndex = 68;
            // 
            // lUsuario
            // 
            lUsuario.AutoSize = true;
            lUsuario.Font = new Font("Microsoft Sans Serif", 20F);
            lUsuario.Location = new Point(12, 9);
            lUsuario.Name = "lUsuario";
            lUsuario.Size = new Size(212, 31);
            lUsuario.TabIndex = 69;
            lUsuario.Text = "Nueva categoría";
            // 
            // btnCategorias
            // 
            btnCategorias.Anchor = AnchorStyles.Top;
            btnCategorias.BackColor = Color.FromArgb(187, 222, 251);
            btnCategorias.BackgroundImageLayout = ImageLayout.None;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Microsoft Sans Serif", 18F);
            btnCategorias.ForeColor = Color.Black;
            btnCategorias.Image = Properties.Resources.etiqueta;
            btnCategorias.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Location = new Point(319, 73);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(130, 40);
            btnCategorias.TabIndex = 67;
            btnCategorias.Text = "Todas";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(370, 9);
            labelTituloTabla.Name = "labelTituloTabla";
            labelTituloTabla.Size = new Size(332, 42);
            labelTituloTabla.TabIndex = 65;
            labelTituloTabla.Text = "Lista de categorías";
            // 
            // btnMostrarInactivos
            // 
            btnMostrarInactivos.Anchor = AnchorStyles.Top;
            btnMostrarInactivos.BackColor = Color.LightCoral;
            btnMostrarInactivos.BackgroundImageLayout = ImageLayout.None;
            btnMostrarInactivos.Cursor = Cursors.Hand;
            btnMostrarInactivos.FlatAppearance.BorderSize = 0;
            btnMostrarInactivos.FlatStyle = FlatStyle.Flat;
            btnMostrarInactivos.Font = new Font("Microsoft Sans Serif", 18F);
            btnMostrarInactivos.ForeColor = Color.Black;
            btnMostrarInactivos.Image = Properties.Resources.marcar_mensaje__1_;
            btnMostrarInactivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarInactivos.Location = new Point(641, 73);
            btnMostrarInactivos.Name = "btnMostrarInactivos";
            btnMostrarInactivos.Size = new Size(159, 40);
            btnMostrarInactivos.TabIndex = 64;
            btnMostrarInactivos.Text = "Inactivos";
            btnMostrarInactivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarInactivos.UseVisualStyleBackColor = false;
            btnMostrarInactivos.Click += btnMostrarInactivos_Click;
            // 
            // btnMostrarActivos
            // 
            btnMostrarActivos.Anchor = AnchorStyles.Top;
            btnMostrarActivos.BackColor = Color.PaleGreen;
            btnMostrarActivos.BackgroundImageLayout = ImageLayout.None;
            btnMostrarActivos.Cursor = Cursors.Hand;
            btnMostrarActivos.FlatAppearance.BorderSize = 0;
            btnMostrarActivos.FlatStyle = FlatStyle.Flat;
            btnMostrarActivos.Font = new Font("Microsoft Sans Serif", 18F);
            btnMostrarActivos.ForeColor = Color.Black;
            btnMostrarActivos.Image = Properties.Resources.comenta_alt_check__1_;
            btnMostrarActivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.Location = new Point(466, 73);
            btnMostrarActivos.Name = "btnMostrarActivos";
            btnMostrarActivos.Size = new Size(159, 40);
            btnMostrarActivos.TabIndex = 63;
            btnMostrarActivos.Text = "Activos";
            btnMostrarActivos.TextAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarActivos.UseVisualStyleBackColor = false;
            btnMostrarActivos.Click += btnMostrarActivos_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.Controls.Add(lTablaVacia);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 310);
            panel3.TabIndex = 4;
            // 
            // lTablaVacia
            // 
            lTablaVacia.AutoSize = true;
            lTablaVacia.Font = new Font("Microsoft Sans Serif", 20F);
            lTablaVacia.Location = new Point(292, 109);
            lTablaVacia.Name = "lTablaVacia";
            lTablaVacia.Size = new Size(394, 31);
            lTablaVacia.TabIndex = 60;
            lTablaVacia.Text = "No se encontraron resultados...";
            lTablaVacia.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cod, NombrePersona, EstadoPersona, Eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 310);
            dataGridView1.TabIndex = 61;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // Cod
            // 
            Cod.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cod.HeaderText = "Código";
            Cod.Name = "Cod";
            Cod.Width = 84;
            // 
            // NombrePersona
            // 
            NombrePersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombrePersona.HeaderText = "Nombre";
            NombrePersona.Name = "NombrePersona";
            // 
            // EstadoPersona
            // 
            EstadoPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EstadoPersona.HeaderText = "Activo";
            EstadoPersona.Name = "EstadoPersona";
            EstadoPersona.Width = 77;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Cambiar";
            Eliminar.Width = 90;
            // 
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(978, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "ListaCategorias";
            Text = "ListaCategorias";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button btnCategorias;
        private Label labelTituloTabla;
        private Button btnMostrarInactivos;
        private Button btnMostrarActivos;
        private Label lTablaVacia;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnGuardar;
        private TextBox txbNombreCat;
        private Label lUsuario;
        private DataGridViewTextBoxColumn Cod;
        private DataGridViewTextBoxColumn NombrePersona;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewButtonColumn Eliminar;
    }
}