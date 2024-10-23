namespace PharmaSuite.Vistas.Productos
{
    partial class ListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCliente = new Button();
            btnBuscar = new Button();
            labelTituloTabla = new Label();
            btnMostrarInactivos = new Button();
            btnMostrarActivos = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            CodBarra = new DataGridViewTextBoxColumn();
            NombreP = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(labelTituloTabla);
            panel1.Controls.Add(btnMostrarInactivos);
            panel1.Controls.Add(btnMostrarActivos);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 168);
            panel1.TabIndex = 0;
            // 
            // btnCliente
            // 
            btnCliente.Anchor = AnchorStyles.Top;
            btnCliente.BackColor = Color.FromArgb(187, 222, 251);
            btnCliente.BackgroundImageLayout = ImageLayout.None;
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Microsoft Sans Serif", 18F);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Image = Properties.Resources.carrito_de_compras;
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(85, 100);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(178, 40);
            btnCliente.TabIndex = 67;
            btnCliente.Text = "Productos";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 18F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(653, 100);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(42, 40);
            btnBuscar.TabIndex = 66;
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(236, 29);
            labelTituloTabla.Name = "labelTituloTabla";
            labelTituloTabla.Size = new Size(328, 42);
            labelTituloTabla.TabIndex = 65;
            labelTituloTabla.Text = "Lista de Productos";
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
            btnMostrarInactivos.Location = new Point(464, 100);
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
            btnMostrarActivos.Location = new Point(282, 100);
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
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 282);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CodBarra, NombreP, categoria, Precio, Stock, EstadoPersona, Modificar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(20, 3, 3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 282);
            dataGridView1.TabIndex = 60;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // CodBarra
            // 
            CodBarra.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CodBarra.HeaderText = "Cod.";
            CodBarra.Name = "CodBarra";
            CodBarra.ReadOnly = true;
            CodBarra.Width = 67;
            // 
            // NombreP
            // 
            NombreP.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            NombreP.HeaderText = "Nombre";
            NombreP.Name = "NombreP";
            NombreP.ReadOnly = true;
            NombreP.Width = 90;
            // 
            // categoria
            // 
            categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            categoria.HeaderText = "Categoria";
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 103;
            // 
            // Precio
            // 
            Precio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 78;
            // 
            // Stock
            // 
            Stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 75;
            // 
            // EstadoPersona
            // 
            EstadoPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EstadoPersona.HeaderText = "Activo";
            EstadoPersona.Name = "EstadoPersona";
            EstadoPersona.ReadOnly = true;
            EstadoPersona.Width = 77;
            // 
            // Modificar
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Azure;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            Modificar.DefaultCellStyle = dataGridViewCellStyle2;
            Modificar.HeaderText = "Modificar";
            Modificar.Name = "Modificar";
            Modificar.ReadOnly = true;
            Modificar.Resizable = DataGridViewTriState.True;
            Modificar.SortMode = DataGridViewColumnSortMode.Automatic;
            Modificar.Text = "Ver";
            Modificar.Width = 98;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Text = "Cambiar";
            Eliminar.Width = 90;
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ListaProductos";
            Text = "ListaProductos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnCliente;
        private Button btnBuscar;
        private Label labelTituloTabla;
        private Button btnMostrarInactivos;
        private Button btnMostrarActivos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CodBarra;
        private DataGridViewTextBoxColumn NombreP;
        private DataGridViewTextBoxColumn categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}