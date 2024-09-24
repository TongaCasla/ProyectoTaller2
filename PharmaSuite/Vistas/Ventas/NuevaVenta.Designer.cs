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
            panel3 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btnCliente);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TBDni);
            panel1.Controls.Add(btnBuscarDNI);
            panel1.Location = new Point(403, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 242);
            panel1.TabIndex = 0;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(187, 222, 251);
            btnCliente.BackgroundImageLayout = ImageLayout.None;
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Century Gothic", 15.75F);
            btnCliente.ForeColor = Color.Black;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.Location = new Point(81, 141);
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
            checkBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(81, 191);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(200, 28);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "Consumidor final";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F);
            label1.Location = new Point(130, 25);
            label1.Name = "label1";
            label1.Size = new Size(111, 33);
            label1.TabIndex = 42;
            label1.Text = "Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F);
            label6.Location = new Point(81, 72);
            label6.Name = "label6";
            label6.Size = new Size(99, 24);
            label6.TabIndex = 36;
            label6.Text = "Nro. DNI:";
            // 
            // TBDni
            // 
            TBDni.Font = new Font("Century Gothic", 15.75F);
            TBDni.Location = new Point(81, 96);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(196, 33);
            TBDni.TabIndex = 37;
            // 
            // btnBuscarDNI
            // 
            btnBuscarDNI.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscarDNI.BackgroundImageLayout = ImageLayout.None;
            btnBuscarDNI.Cursor = Cursors.Hand;
            btnBuscarDNI.FlatAppearance.BorderSize = 0;
            btnBuscarDNI.FlatStyle = FlatStyle.Flat;
            btnBuscarDNI.Font = new Font("Century Gothic", 15.75F);
            btnBuscarDNI.ForeColor = Color.Black;
            btnBuscarDNI.Image = (Image)resources.GetObject("btnBuscarDNI.Image");
            btnBuscarDNI.Location = new Point(277, 95);
            btnBuscarDNI.Name = "btnBuscarDNI";
            btnBuscarDNI.Size = new Size(36, 34);
            btnBuscarDNI.TabIndex = 38;
            btnBuscarDNI.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscarDNI.UseVisualStyleBackColor = false;
            btnBuscarDNI.Click += btnBuscarDNI_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnBuscarNombreProd);
            panel2.Controls.Add(TBNombreprod);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(TBCodigoprod);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 242);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F);
            label4.Location = new Point(132, 21);
            label4.Name = "label4";
            label4.Size = new Size(137, 33);
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
            btnBuscarNombreProd.Font = new Font("Century Gothic", 15.75F);
            btnBuscarNombreProd.ForeColor = Color.Black;
            btnBuscarNombreProd.Image = (Image)resources.GetObject("btnBuscarNombreProd.Image");
            btnBuscarNombreProd.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarNombreProd.Location = new Point(281, 171);
            btnBuscarNombreProd.Name = "btnBuscarNombreProd";
            btnBuscarNombreProd.Size = new Size(36, 33);
            btnBuscarNombreProd.TabIndex = 34;
            btnBuscarNombreProd.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscarNombreProd.UseVisualStyleBackColor = false;
            btnBuscarNombreProd.Click += btnBuscarNombreProd_Click;
            // 
            // TBNombreprod
            // 
            TBNombreprod.Font = new Font("Century Gothic", 15.75F);
            TBNombreprod.Location = new Point(85, 171);
            TBNombreprod.Name = "TBNombreprod";
            TBNombreprod.Size = new Size(196, 33);
            TBNombreprod.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F);
            label3.Location = new Point(85, 141);
            label3.Name = "label3";
            label3.Size = new Size(236, 24);
            label3.TabIndex = 32;
            label3.Text = "Nombre de producto:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 15.75F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(279, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(36, 34);
            btnBuscar.TabIndex = 31;
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TBCodigoprod
            // 
            TBCodigoprod.Font = new Font("Century Gothic", 15.75F);
            TBCodigoprod.Location = new Point(83, 96);
            TBCodigoprod.Name = "TBCodigoprod";
            TBCodigoprod.Size = new Size(196, 33);
            TBCodigoprod.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F);
            label2.Location = new Point(83, 72);
            label2.Name = "label2";
            label2.Size = new Size(227, 24);
            label2.TabIndex = 15;
            label2.Text = "Código de producto:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.FromArgb(187, 222, 251);
            panel3.Location = new Point(400, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(12, 275);
            panel3.TabIndex = 36;
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
            btnCancelar.Location = new Point(452, 513);
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
            btnGuardar.Font = new Font("Century Gothic", 18F);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(626, 513);
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
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(743, 218);
            dataGridView1.TabIndex = 39;
            // 
            // NuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(797, 574);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(panel3);
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
        private Panel panel3;
        private CheckBox checkBox1;
        private Button btnCliente;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dataGridView1;
    }
}