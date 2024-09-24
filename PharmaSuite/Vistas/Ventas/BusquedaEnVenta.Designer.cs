namespace PharmaSuite.Vistas.Ventas
{
    partial class BusquedaEnVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaEnVenta));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pFondo = new Panel();
            lTablaVacia = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            labelTituloBusqueda = new Label();
            pFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pFondo
            // 
            pFondo.Controls.Add(lTablaVacia);
            pFondo.Controls.Add(btnCancelar);
            pFondo.Controls.Add(btnGuardar);
            pFondo.Controls.Add(dataGridView1);
            pFondo.Controls.Add(labelTituloBusqueda);
            pFondo.Dock = DockStyle.Fill;
            pFondo.Location = new Point(0, 0);
            pFondo.Name = "pFondo";
            pFondo.Size = new Size(645, 531);
            pFondo.TabIndex = 42;
            // 
            // lTablaVacia
            // 
            lTablaVacia.AutoSize = true;
            lTablaVacia.Font = new Font("Century Gothic", 20F);
            lTablaVacia.Location = new Point(113, 249);
            lTablaVacia.Name = "lTablaVacia";
            lTablaVacia.Size = new Size(419, 33);
            lTablaVacia.TabIndex = 47;
            lTablaVacia.Text = "No se encontraron resultados...";
            lTablaVacia.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.BackgroundImageLayout = ImageLayout.None;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 18F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(334, 484);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 40);
            btnCancelar.TabIndex = 46;
            btnCancelar.Text = "Salir";
            btnCancelar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(187, 222, 251);
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(467, 484);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(166, 40);
            btnGuardar.TabIndex = 45;
            btnGuardar.Text = "Agregar";
            btnGuardar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(621, 413);
            dataGridView1.TabIndex = 44;
            // 
            // labelTituloBusqueda
            // 
            labelTituloBusqueda.AutoSize = true;
            labelTituloBusqueda.Font = new Font("Century Gothic", 24F);
            labelTituloBusqueda.Location = new Point(100, 9);
            labelTituloBusqueda.Name = "labelTituloBusqueda";
            labelTituloBusqueda.Size = new Size(233, 39);
            labelTituloBusqueda.TabIndex = 43;
            labelTituloBusqueda.Text = "Busqueda de ";
            // 
            // BusquedaEnVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(645, 531);
            Controls.Add(pFondo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BusquedaEnVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultados de busqueda";
            pFondo.ResumeLayout(false);
            pFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pFondo;
        private Label labelTituloBusqueda;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lTablaVacia;
    }
}