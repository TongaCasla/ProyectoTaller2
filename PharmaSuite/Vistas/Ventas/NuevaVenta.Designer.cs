namespace PharmaSuite.Vistas
{
    partial class NuevaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaVenta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCliente = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label6 = new Label();
            TBDni = new TextBox();
            btnBuscarDNI = new Button();
            panel2 = new Panel();
            label4 = new Label();
            btnBuscarNombreProd = new Button();
            TBNombreprod = new TextBox();
            label3 = new Label();
            btnBuscar = new Button();
            TBCodigoprod = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            DnI = new DataGridViewTextBoxColumn();
            NombrePersona = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TipoPerfilPersona = new DataGridViewTextBoxColumn();
            EstadoPersona = new DataGridViewTextBoxColumn();
            Modificar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TBDni);
            panel1.Controls.Add(btnBuscarDNI);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 242);
            panel1.TabIndex = 0;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(187, 222, 251);
            btnCliente.BackgroundImageLayout = ImageLayout.None;
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.Location = new Point(35, 140);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(232, 34);
            btnCliente.TabIndex = 44;
            btnCliente.Text = "Nuevo cliente";
            btnCliente.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(35, 190);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(192, 29);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "Consumidor final";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(84, 24);
            label1.Name = "label1";
            label1.Size = new Size(99, 31);
            label1.TabIndex = 42;
            label1.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F);
            label6.Location = new Point(35, 67);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 36;
            label6.Text = "Nro. DNI:";
            // 
            // TBDni
            // 
            TBDni.Font = new Font("Microsoft Sans Serif", 15.75F);
            TBDni.Location = new Point(35, 95);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(196, 31);
            TBDni.TabIndex = 37;
            // 
            // btnBuscarDNI
            // 
            btnBuscarDNI.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscarDNI.BackgroundImageLayout = ImageLayout.None;
            btnBuscarDNI.Cursor = Cursors.Hand;
            btnBuscarDNI.FlatAppearance.BorderSize = 0;
            btnBuscarDNI.FlatStyle = FlatStyle.Flat;
            btnBuscarDNI.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnBuscarDNI.ForeColor = Color.Black;
            btnBuscarDNI.Image = (Image)resources.GetObject("btnBuscarDNI.Image");
            btnBuscarDNI.Location = new Point(231, 94);
            btnBuscarDNI.Name = "btnBuscarDNI";
            btnBuscarDNI.Size = new Size(36, 34);
            btnBuscarDNI.TabIndex = 38;
            btnBuscarDNI.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscarDNI.UseVisualStyleBackColor = false;
            btnBuscarDNI.Click += btnBuscarDNI_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnBuscarNombreProd);
            panel2.Controls.Add(TBNombreprod);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(TBCodigoprod);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(331, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(276, 242);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20F);
            label4.Location = new Point(76, 21);
            label4.Name = "label4";
            label4.Size = new Size(123, 31);
            label4.TabIndex = 35;
            label4.Text = "Producto";
            // 
            // btnBuscarNombreProd
            // 
            btnBuscarNombreProd.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscarNombreProd.BackgroundImageLayout = ImageLayout.None;
            btnBuscarNombreProd.Cursor = Cursors.Hand;
            btnBuscarNombreProd.FlatAppearance.BorderSize = 0;
            btnBuscarNombreProd.FlatStyle = FlatStyle.Flat;
            btnBuscarNombreProd.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnBuscarNombreProd.ForeColor = Color.Black;
            btnBuscarNombreProd.Image = (Image)resources.GetObject("btnBuscarNombreProd.Image");
            btnBuscarNombreProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarNombreProd.Location = new Point(225, 171);
            btnBuscarNombreProd.Name = "btnBuscarNombreProd";
            btnBuscarNombreProd.Size = new Size(36, 33);
            btnBuscarNombreProd.TabIndex = 34;
            btnBuscarNombreProd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscarNombreProd.UseVisualStyleBackColor = false;
            btnBuscarNombreProd.Visible = false;
            // 
            // TBNombreprod
            // 
            TBNombreprod.Font = new Font("Microsoft Sans Serif", 15.75F);
            TBNombreprod.Location = new Point(29, 171);
            TBNombreprod.Name = "TBNombreprod";
            TBNombreprod.Size = new Size(196, 31);
            TBNombreprod.TabIndex = 33;
            TBNombreprod.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F);
            label3.Location = new Point(29, 141);
            label3.Name = "label3";
            label3.Size = new Size(213, 25);
            label3.TabIndex = 32;
            label3.Text = "Nombre de producto:";
            label3.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 15.75F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(223, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 34);
            btnBuscar.TabIndex = 31;
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // TBCodigoprod
            // 
            TBCodigoprod.Font = new Font("Microsoft Sans Serif", 15.75F);
            TBCodigoprod.Location = new Point(27, 96);
            TBCodigoprod.Name = "TBCodigoprod";
            TBCodigoprod.Size = new Size(196, 31);
            TBCodigoprod.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F);
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 15;
            label2.Text = "Código de producto:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 18F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(238, 522);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 40);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(412, 522);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
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
            dataGridView1.Location = new Point(12, 278);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(656, 227);
            dataGridView1.TabIndex = 51;
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
            // NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(868, 574);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NuevaVenta";
            Text = "Venta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox TBCodigoprod;
        private Label label2;
        private Button btnBuscar;
        private Button btnBuscarNombreProd;
        private TextBox TBNombreprod;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label6;
        private TextBox TBDni;
        private Button btnBuscarDNI;
        private CheckBox checkBox1;
        private Button btnCliente;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn DnI;
        private DataGridViewTextBoxColumn NombrePersona;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TipoPerfilPersona;
        private DataGridViewTextBoxColumn EstadoPersona;
        private DataGridViewButtonColumn Modificar;
        private DataGridViewButtonColumn Eliminar;
    }
}