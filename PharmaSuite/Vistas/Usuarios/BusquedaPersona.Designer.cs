namespace PharmaSuite.Vistas.Usuarios
{
    partial class BusquedaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaPersona));
            panel1 = new Panel();
            lTablaVacia = new Label();
            btnBuscar = new Button();
            txbBusqueda = new TextBox();
            labelTitulo = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(lTablaVacia);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txbBusqueda);
            panel1.Controls.Add(labelTitulo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 183);
            panel1.TabIndex = 1;
            // 
            // lTablaVacia
            // 
            lTablaVacia.AutoSize = true;
            lTablaVacia.Font = new Font("Microsoft Sans Serif", 20F);
            lTablaVacia.Location = new Point(76, 104);
            lTablaVacia.Name = "lTablaVacia";
            lTablaVacia.Size = new Size(237, 62);
            lTablaVacia.TabIndex = 51;
            lTablaVacia.Text = "No se encontraron\nresultados...";
            lTablaVacia.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(187, 222, 251);
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 18F);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(319, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(43, 34);
            btnBuscar.TabIndex = 30;
            btnBuscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txbBusqueda
            // 
            txbBusqueda.Font = new Font("Microsoft Sans Serif", 16F);
            txbBusqueda.Location = new Point(76, 58);
            txbBusqueda.Name = "txbBusqueda";
            txbBusqueda.PlaceholderText = "Ingrese DNI sin puntos";
            txbBusqueda.Size = new Size(237, 32);
            txbBusqueda.TabIndex = 28;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 20F);
            labelTitulo.Location = new Point(76, 17);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(219, 31);
            labelTitulo.TabIndex = 27;
            labelTitulo.Text = "Ingrese Nro. DNI";
            // 
            // BusquedaPersona
            // 
            AcceptButton = btnBuscar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(438, 183);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BusquedaPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busqueda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lTablaVacia;
        private Button btnBuscar;
        private TextBox txbBusqueda;
        private Label labelTitulo;
    }
}