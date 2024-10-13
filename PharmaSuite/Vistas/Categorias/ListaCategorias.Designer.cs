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
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            labelTituloTabla = new Label();
            btnMostrarInactivos = new Button();
            btnMostrarActivos = new Button();
            btnCliente = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCliente);
            panel2.Controls.Add(labelTituloTabla);
            panel2.Controls.Add(btnMostrarInactivos);
            panel2.Controls.Add(btnMostrarActivos);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 140);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 210);
            panel3.TabIndex = 4;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(234, 9);
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
            btnMostrarInactivos.Image = (Image)resources.GetObject("btnMostrarInactivos.Image");
            btnMostrarInactivos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrarInactivos.Location = new Point(505, 73);
            btnMostrarInactivos.Name = "btnMostrarInactivos";
            btnMostrarInactivos.Size = new Size(159, 40);
            btnMostrarInactivos.TabIndex = 64;
            btnMostrarInactivos.Text = "Inactivos";
            btnMostrarInactivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarInactivos.UseVisualStyleBackColor = false;
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
            btnMostrarActivos.Location = new Point(330, 73);
            btnMostrarActivos.Name = "btnMostrarActivos";
            btnMostrarActivos.Size = new Size(159, 40);
            btnMostrarActivos.TabIndex = 63;
            btnMostrarActivos.Text = "Activos";
            btnMostrarActivos.TextAlign = ContentAlignment.MiddleLeft;
            btnMostrarActivos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMostrarActivos.UseVisualStyleBackColor = false;
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
            btnCliente.Location = new Point(183, 73);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(130, 40);
            btnCliente.TabIndex = 67;
            btnCliente.Text = "Todas";
            btnCliente.TextAlign = ContentAlignment.MiddleLeft;
            btnCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCliente.UseVisualStyleBackColor = false;
            // 
            // ListaCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ListaCategorias";
            Text = "ListaCategorias";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button btnCliente;
        private Label labelTituloTabla;
        private Button btnMostrarInactivos;
        private Button btnMostrarActivos;
    }
}