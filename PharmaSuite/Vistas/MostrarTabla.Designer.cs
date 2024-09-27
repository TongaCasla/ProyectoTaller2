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
            DniPersona = new DataGridViewTextBoxColumn();
            NombrePersona = new DataGridViewTextBoxColumn();
            TipoPerfilPersona = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            action = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarActivos
            // 
            btnMostrarActivos.Anchor = AnchorStyles.Top;
            btnMostrarActivos.BackColor = Color.PaleGreen;
            btnMostrarActivos.BackgroundImageLayout = ImageLayout.None;
            btnMostrarActivos.Cursor = Cursors.Hand;
            btnMostrarActivos.FlatAppearance.BorderSize = 0;
            btnMostrarActivos.FlatStyle = FlatStyle.Flat;
            btnMostrarActivos.Font = new Font("Century Gothic", 18F);
            btnMostrarActivos.ForeColor = Color.Black;
            btnMostrarActivos.Image = (Image)resources.GetObject("btnMostrarActivos.Image");
            btnMostrarActivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.Location = new Point(48, 81);
            btnMostrarActivos.Name = "btnMostrarActivos";
            btnMostrarActivos.Size = new Size(166, 40);
            btnMostrarActivos.TabIndex = 24;
            btnMostrarActivos.Text = "Activos";
            btnMostrarActivos.TextAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarActivos.UseVisualStyleBackColor = false;
            // 
            // btnMostrarInactivos
            // 
            btnMostrarInactivos.Anchor = AnchorStyles.Top;
            btnMostrarInactivos.BackColor = Color.LightCoral;
            btnMostrarInactivos.BackgroundImageLayout = ImageLayout.None;
            btnMostrarInactivos.Cursor = Cursors.Hand;
            btnMostrarInactivos.FlatAppearance.BorderSize = 0;
            btnMostrarInactivos.FlatStyle = FlatStyle.Flat;
            btnMostrarInactivos.Font = new Font("Century Gothic", 18F);
            btnMostrarInactivos.ForeColor = Color.Black;
            btnMostrarInactivos.Image = (Image)resources.GetObject("btnMostrarInactivos.Image");
            btnMostrarInactivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarInactivos.Location = new Point(232, 81);
            btnMostrarInactivos.Name = "btnMostrarInactivos";
            btnMostrarInactivos.Size = new Size(166, 40);
            btnMostrarInactivos.TabIndex = 25;
            btnMostrarInactivos.Text = "Inactivos";
            btnMostrarInactivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarInactivos.UseVisualStyleBackColor = false;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(198, 9);
            labelTituloTabla.Name = "labelTituloTabla";
            labelTituloTabla.Size = new Size(163, 44);
            labelTituloTabla.TabIndex = 26;
            labelTituloTabla.Text = "Lista de ";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top;
            btnBuscar.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 18F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(418, 81);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(166, 40);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lTablaVacia
            // 
            lTablaVacia.AutoSize = true;
            lTablaVacia.Font = new Font("Century Gothic", 20F);
            lTablaVacia.Location = new Point(86, 270);
            lTablaVacia.Name = "lTablaVacia";
            lTablaVacia.Size = new Size(419, 33);
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DniPersona, NombrePersona, TipoPerfilPersona, EstadoPersona, action });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(540, 350);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // 
            // DniPersona
            // 
            DniPersona.HeaderText = "DNI";
            DniPersona.Name = "DniPersona";
            DniPersona.ReadOnly = true;
            // 
            // NombrePersona
            // 
            NombrePersona.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NombrePersona.HeaderText = "Nombre";
            NombrePersona.Name = "NombrePersona";
            NombrePersona.ReadOnly = true;
            // 
            // TipoPerfilPersona
            // 
            TipoPerfilPersona.HeaderText = "Perfil";
            TipoPerfilPersona.Name = "TipoPerfilPersona";
            TipoPerfilPersona.ReadOnly = true;
            // 
            // EstadoPersona
            // 
            EstadoPersona.HeaderText = "Estado";
            EstadoPersona.Name = "EstadoPersona";
            EstadoPersona.ReadOnly = true;
            // 
            // action
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Azure;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            action.DefaultCellStyle = dataGridViewCellStyle2;
            action.HeaderText = "Acción";
            action.Name = "action";
            action.ReadOnly = true;
            action.Resizable = DataGridViewTriState.True;
            action.SortMode = DataGridViewColumnSortMode.Automatic;
            action.Text = "Eliminar";
            // 
            // MostrarTabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(820, 503);
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
        private DataGridViewTextBoxColumn DniPersona;
        private DataGridViewTextBoxColumn NombrePersona;
        private DataGridViewTextBoxColumn TipoPerfilPersona;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewButtonColumn action;
    }
}