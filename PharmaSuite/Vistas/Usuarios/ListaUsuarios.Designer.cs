namespace PharmaSuite.Vistas.Usuarios
{
    partial class ListaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelTipo = new Label();
            btnEmpleado = new Button();
            btnCliente = new Button();
            lTablaVacia = new Label();
            btnBuscar = new Button();
            labelTituloTabla = new Label();
            btnMostrarInactivos = new Button();
            btnMostrarActivos = new Button();
            dataGridView1 = new DataGridView();
            DnI = new DataGridViewTextBoxColumn();
            NombrePersona = new DataGridViewTextBoxColumn();
            ape = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TipoPerfilPersona = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTipo);
            panel1.Controls.Add(btnEmpleado);
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(lTablaVacia);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(labelTituloTabla);
            panel1.Controls.Add(btnMostrarInactivos);
            panel1.Controls.Add(btnMostrarActivos);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 516);
            panel1.TabIndex = 0;
            // 
            // labelTipo
            // 
            labelTipo.Anchor = AnchorStyles.Top;
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(374, 24);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(153, 42);
            labelTipo.TabIndex = 62;
            labelTipo.Text = "Clientes";
            // 
            // btnEmpleado
            // 
            btnEmpleado.Anchor = AnchorStyles.Top;
            btnEmpleado.BackColor = Color.FromArgb(187, 222, 251);
            btnEmpleado.BackgroundImageLayout = ImageLayout.None;
            btnEmpleado.Cursor = Cursors.Hand;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Microsoft Sans Serif", 18F);
            btnEmpleado.ForeColor = Color.Black;
            btnEmpleado.Image = (Image)resources.GetObject("btnEmpleado.Image");
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(191, 95);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(179, 40);
            btnEmpleado.TabIndex = 61;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
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
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(7, 95);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(178, 40);
            btnCliente.TabIndex = 60;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // lTablaVacia
            // 
            lTablaVacia.AutoSize = true;
            lTablaVacia.Font = new Font("Microsoft Sans Serif", 20F);
            lTablaVacia.Location = new Point(81, 270);
            lTablaVacia.Name = "lTablaVacia";
            lTablaVacia.Size = new Size(394, 31);
            lTablaVacia.TabIndex = 58;
            lTablaVacia.Text = "No se encontraron resultados...";
            lTablaVacia.Visible = false;
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
            btnBuscar.Location = new Point(736, 95);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(42, 40);
            btnBuscar.TabIndex = 57;
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(229, 24);
            labelTituloTabla.Name = "labelTituloTabla";
            labelTituloTabla.Size = new Size(159, 42);
            labelTituloTabla.TabIndex = 56;
            labelTituloTabla.Text = "Lista de ";
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
            btnMostrarInactivos.Image = (Image)resources.GetObject("btnMostrarInactivos.Image");
            btnMostrarInactivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarInactivos.Location = new Point(560, 95);
            btnMostrarInactivos.Name = "btnMostrarInactivos";
            btnMostrarInactivos.Size = new Size(159, 40);
            btnMostrarInactivos.TabIndex = 55;
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
            btnMostrarActivos.Image = (Image)resources.GetObject("btnMostrarActivos.Image");
            btnMostrarActivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.Location = new Point(395, 95);
            btnMostrarActivos.Name = "btnMostrarActivos";
            btnMostrarActivos.Size = new Size(159, 40);
            btnMostrarActivos.TabIndex = 54;
            btnMostrarActivos.Text = "Activos";
            btnMostrarActivos.TextAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarActivos.UseVisualStyleBackColor = false;
            btnMostrarActivos.Click += btnMostrarActivos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DnI, NombrePersona, ape, Email, TipoPerfilPersona, EstadoPersona, Modificar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(12, 157);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(766, 348);
            dataGridView1.TabIndex = 59;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DnI
            // 
            DnI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DnI.HeaderText = "DNI";
            DnI.Name = "DnI";
            DnI.ReadOnly = true;
            // 
            // NombrePersona
            // 
            NombrePersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NombrePersona.HeaderText = "Nombre";
            NombrePersona.Name = "NombrePersona";
            NombrePersona.ReadOnly = true;
            // 
            // ape
            // 
            ape.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ape.HeaderText = "Apellido";
            ape.Name = "ape";
            ape.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 73;
            // 
            // TipoPerfilPersona
            // 
            TipoPerfilPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TipoPerfilPersona.HeaderText = "Perfil";
            TipoPerfilPersona.Name = "TipoPerfilPersona";
            TipoPerfilPersona.ReadOnly = true;
            TipoPerfilPersona.Width = 69;
            // 
            // EstadoPersona
            // 
            EstadoPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EstadoPersona.HeaderText = "Activo";
            EstadoPersona.Name = "EstadoPersona";
            EstadoPersona.ReadOnly = true;
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
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 516);
            Controls.Add(panel1);
            Name = "ListaUsuarios";
            Text = "ListaUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTipo;
        private Button btnEmpleado;
        private Button btnCliente;
        private Label lTablaVacia;
        private Button btnBuscar;
        private Label labelTituloTabla;
        private Button btnMostrarInactivos;
        private Button btnMostrarActivos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DnI;
        private DataGridViewTextBoxColumn NombrePersona;
        private DataGridViewTextBoxColumn ape;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TipoPerfilPersona;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}