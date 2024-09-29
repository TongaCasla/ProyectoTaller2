namespace PharmaSuite.Vistas.Usuarios
{
    partial class MostrarTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarTabla));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnMostrarActivos = new Button();
            btnMostrarInactivos = new Button();
            labelTituloTabla = new Label();
            btnBuscar = new Button();
            lTablaVacia = new Label();
            dataGridView1 = new DataGridView();
            DnI = new DataGridViewTextBoxColumn();
            NombrePersona = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TipoPerfilPersona = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            btnCliente = new Button();
            btnEmpleado = new Button();
            labelTipo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarActivos
            // 
            btnMostrarActivos.Anchor = AnchorStyles.None;
            btnMostrarActivos.BackColor = Color.PaleGreen;
            btnMostrarActivos.BackgroundImageLayout = ImageLayout.None;
            btnMostrarActivos.Cursor = Cursors.Hand;
            btnMostrarActivos.FlatAppearance.BorderSize = 0;
            btnMostrarActivos.FlatStyle = FlatStyle.Flat;
            btnMostrarActivos.Font = new Font("Microsoft Sans Serif", 18F);
            btnMostrarActivos.ForeColor = Color.Black;
            btnMostrarActivos.Image = (Image)resources.GetObject("btnMostrarActivos.Image");
            btnMostrarActivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.Location = new Point(190, 124);
            btnMostrarActivos.Name = "btnMostrarActivos";
            btnMostrarActivos.Size = new Size(139, 40);
            btnMostrarActivos.TabIndex = 24;
            btnMostrarActivos.Text = "Activos";
            btnMostrarActivos.TextAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarActivos.UseVisualStyleBackColor = false;
            btnMostrarActivos.Click += btnMostrarActivos_Click;
            // 
            // btnMostrarInactivos
            // 
            btnMostrarInactivos.Anchor = AnchorStyles.None;
            btnMostrarInactivos.BackColor = Color.LightCoral;
            btnMostrarInactivos.BackgroundImageLayout = ImageLayout.None;
            btnMostrarInactivos.Cursor = Cursors.Hand;
            btnMostrarInactivos.FlatAppearance.BorderSize = 0;
            btnMostrarInactivos.FlatStyle = FlatStyle.Flat;
            btnMostrarInactivos.Font = new Font("Microsoft Sans Serif", 18F);
            btnMostrarInactivos.ForeColor = Color.Black;
            btnMostrarInactivos.Image = (Image)resources.GetObject("btnMostrarInactivos.Image");
            btnMostrarInactivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarInactivos.Location = new Point(341, 124);
            btnMostrarInactivos.Name = "btnMostrarInactivos";
            btnMostrarInactivos.Size = new Size(159, 40);
            btnMostrarInactivos.TabIndex = 25;
            btnMostrarInactivos.Text = "Inactivos";
            btnMostrarInactivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarInactivos.UseVisualStyleBackColor = false;
            btnMostrarInactivos.Click += btnMostrarInactivos_Click;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(207, 9);
            labelTituloTabla.Name = "labelTituloTabla";
            labelTituloTabla.Size = new Size(159, 42);
            labelTituloTabla.TabIndex = 26;
            labelTituloTabla.Text = "Lista de ";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 18F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(506, 124);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(136, 40);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lTablaVacia
            // 
            lTablaVacia.AutoSize = true;
            lTablaVacia.Font = new Font("Microsoft Sans Serif", 20F);
            lTablaVacia.Location = new Point(85, 341);
            lTablaVacia.Name = "lTablaVacia";
            lTablaVacia.Size = new Size(394, 31);
            lTablaVacia.TabIndex = 49;
            lTablaVacia.Text = "No se encontraron resultados...";
            lTablaVacia.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DnI, NombrePersona, Apellido, Email, TipoPerfilPersona, EstadoPersona, Modificar, Eliminar });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(11, 212);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(796, 483);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // DnI
            // 
            DnI.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DnI.HeaderText = "DNI";
            DnI.Name = "DnI";
            DnI.ReadOnly = true;
            DnI.Width = 62;
            // 
            // NombrePersona
            // 
            NombrePersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            NombrePersona.HeaderText = "Nombre";
            NombrePersona.Name = "NombrePersona";
            NombrePersona.ReadOnly = true;
            NombrePersona.Width = 90;
            // 
            // Apellido
            // 
            Apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 90;
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
            TipoPerfilPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TipoPerfilPersona.HeaderText = "Perfil";
            TipoPerfilPersona.Name = "TipoPerfilPersona";
            TipoPerfilPersona.ReadOnly = true;
            TipoPerfilPersona.Width = 69;
            // 
            // EstadoPersona
            // 
            EstadoPersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            EstadoPersona.HeaderText = "Activo";
            EstadoPersona.Name = "EstadoPersona";
            EstadoPersona.ReadOnly = true;
            EstadoPersona.Width = 77;
            // 
            // Modificar
            // 
            Modificar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            Modificar.Text = "Eliminar";
            Modificar.Width = 98;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            Eliminar.Width = 90;
            // 
            // btnCliente
            // 
            btnCliente.Anchor = AnchorStyles.None;
            btnCliente.BackColor = Color.FromArgb(187, 222, 251);
            btnCliente.BackgroundImageLayout = ImageLayout.None;
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Microsoft Sans Serif", 18F);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCliente.Location = new Point(190, 78);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(154, 40);
            btnCliente.TabIndex = 51;
            btnCliente.Text = "Clientes";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Anchor = AnchorStyles.None;
            btnEmpleado.BackColor = Color.FromArgb(187, 222, 251);
            btnEmpleado.BackgroundImageLayout = ImageLayout.None;
            btnEmpleado.Cursor = Cursors.Hand;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Microsoft Sans Serif", 18F);
            btnEmpleado.ForeColor = Color.Black;
            btnEmpleado.Image = (Image)resources.GetObject("btnEmpleado.Image");
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(363, 78);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(179, 40);
            btnEmpleado.TabIndex = 52;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // labelTipo
            // 
            labelTipo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTipo.Location = new Point(348, 9);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(152, 42);
            labelTipo.TabIndex = 53;
            labelTipo.Text = "Ejemplo";
            // 
            // MostrarTabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(820, 636);
            Controls.Add(labelTipo);
            Controls.Add(btnEmpleado);
            Controls.Add(btnCliente);
            Controls.Add(lTablaVacia);
            Controls.Add(btnBuscar);
            Controls.Add(labelTituloTabla);
            Controls.Add(btnMostrarInactivos);
            Controls.Add(btnMostrarActivos);
            Controls.Add(dataGridView1);
            Name = "MostrarTabla";
            Text = "MostrarTabla";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMostrarActivos;
        private Button btnMostrarInactivos;
        private Label labelTituloTabla;
        private Button btnBuscar;
        private Label lTablaVacia;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DnI;
        private DataGridViewTextBoxColumn NombrePersona;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TipoPerfilPersona;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
        private Button btnCliente;
        private Button btnEmpleado;
        private Label labelTipo;
    }
}