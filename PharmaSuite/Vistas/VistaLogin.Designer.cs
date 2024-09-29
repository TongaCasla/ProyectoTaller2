namespace Vistas
{
    partial class VistaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaLogin));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtbContra = new TextBox();
            label2 = new Label();
            txtbUsuario = new TextBox();
            label1 = new Label();
            btnSalir = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 242, 253);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtbContra);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtbUsuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 494);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(187, 222, 251);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(71, 343);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 5, 0);
            button1.Size = new Size(169, 43);
            button1.TabIndex = 6;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(227, 242, 253);
            label3.Font = new Font("Century Gothic", 50F, FontStyle.Italic);
            label3.Location = new Point(163, 38);
            label3.Name = "label3";
            label3.Size = new Size(398, 81);
            label3.TabIndex = 4;
            label3.Text = "Bienvenido";
            // 
            // txtbContra
            // 
            txtbContra.Font = new Font("Century Gothic", 16F);
            txtbContra.Location = new Point(46, 269);
            txtbContra.Name = "txtbContra";
            txtbContra.PasswordChar = '*';
            txtbContra.PlaceholderText = "Ingrese contraseña";
            txtbContra.Size = new Size(217, 34);
            txtbContra.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F);
            label2.Location = new Point(46, 235);
            label2.Name = "label2";
            label2.Size = new Size(169, 33);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtbUsuario
            // 
            txtbUsuario.Font = new Font("Century Gothic", 16F);
            txtbUsuario.Location = new Point(46, 176);
            txtbUsuario.Name = "txtbUsuario";
            txtbUsuario.PlaceholderText = "Ingrese usuario";
            txtbUsuario.Size = new Size(217, 34);
            txtbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F);
            label1.Location = new Point(46, 136);
            label1.Name = "label1";
            label1.Size = new Size(108, 33);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(720, 8);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(70, 68);
            btnSalir.TabIndex = 7;
            btnSalir.TabStop = false;
            btnSalir.Click += pictureBox2_Click;
            // 
            // VistaLogin
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            ClientSize = new Size(800, 494);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VistaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PharmaSuite";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox txtbContra;
        private Label label2;
        private TextBox txtbUsuario;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox btnSalir;
    }
}