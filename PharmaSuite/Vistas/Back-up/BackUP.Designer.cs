namespace PharmaSuite.Vistas.Back_up
{
    partial class BackUP
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
            label2 = new Label();
            txbRuta = new TextBox();
            btnRuta = new Button();
            panel1 = new Panel();
            label3 = new Label();
            lCodigoProd = new Label();
            panel2 = new Panel();
            btnBackUp = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // txbRuta
            // 
            txbRuta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txbRuta.Font = new Font("Century Gothic", 13F);
            txbRuta.Location = new Point(212, 75);
            txbRuta.Name = "txbRuta";
            txbRuta.Size = new Size(330, 29);
            txbRuta.TabIndex = 3;
            // 
            // btnRuta
            // 
            btnRuta.Anchor = AnchorStyles.Top;
            btnRuta.BackColor = Color.FromArgb(187, 222, 251);
            btnRuta.FlatStyle = FlatStyle.Flat;
            btnRuta.Image = Properties.Resources.busqueda2;
            btnRuta.Location = new Point(548, 76);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(30, 28);
            btnRuta.TabIndex = 6;
            btnRuta.UseVisualStyleBackColor = false;
            btnRuta.Click += btnRuta_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 87);
            panel1.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 30F);
            label3.Location = new Point(249, 26);
            label3.Name = "label3";
            label3.Size = new Size(313, 49);
            label3.TabIndex = 43;
            label3.Text = "Nuevo backup";
            // 
            // lCodigoProd
            // 
            lCodigoProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lCodigoProd.AutoSize = true;
            lCodigoProd.Font = new Font("Century Gothic", 20F);
            lCodigoProd.Location = new Point(249, 39);
            lCodigoProd.Name = "lCodigoProd";
            lCodigoProd.Size = new Size(267, 33);
            lCodigoProd.TabIndex = 44;
            lCodigoProd.Text = "Ruta de guardado:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBackUp);
            panel2.Controls.Add(btnRuta);
            panel2.Controls.Add(lCodigoProd);
            panel2.Controls.Add(txbRuta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 363);
            panel2.TabIndex = 49;
            // 
            // btnBackUp
            // 
            btnBackUp.Anchor = AnchorStyles.Top;
            btnBackUp.BackColor = Color.FromArgb(187, 222, 251);
            btnBackUp.BackgroundImageLayout = ImageLayout.None;
            btnBackUp.Cursor = Cursors.Hand;
            btnBackUp.FlatAppearance.BorderSize = 0;
            btnBackUp.FlatStyle = FlatStyle.Flat;
            btnBackUp.Font = new Font("Century Gothic", 18F);
            btnBackUp.ForeColor = Color.Black;
            btnBackUp.Image = Properties.Resources.disco;
            btnBackUp.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackUp.Location = new Point(317, 118);
            btnBackUp.Name = "btnBackUp";
            btnBackUp.Size = new Size(166, 40);
            btnBackUp.TabIndex = 48;
            btnBackUp.Text = "Guardar";
            btnBackUp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBackUp.UseVisualStyleBackColor = false;
            btnBackUp.Click += btnBackUp_Click;
            // 
            // BackUP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "BackUP";
            Text = "BackUP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txbRuta;
        private Button btnRuta;
        private Panel panel1;
        private Label label3;
        private Label lCodigoProd;
        private Panel panel2;
        private Button btnBackUp;
    }
}