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
            btnBackUp = new Button();
            label1 = new Label();
            label2 = new Label();
            txbRuta = new TextBox();
            btnRuta = new Button();
            btnRutaRestore = new Button();
            txbRestore = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnRestore = new Button();
            txtbPassGerente = new TextBox();
            SuspendLayout();
            // 
            // btnBackUp
            // 
            btnBackUp.Location = new Point(16, 110);
            btnBackUp.Name = "btnBackUp";
            btnBackUp.Size = new Size(75, 23);
            btnBackUp.TabIndex = 0;
            btnBackUp.Text = "Back up";
            btnBackUp.UseVisualStyleBackColor = true;
            btnBackUp.Click += btnBackUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Ruta de guardado:";
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
            txbRuta.Location = new Point(16, 59);
            txbRuta.Name = "txbRuta";
            txbRuta.Size = new Size(261, 23);
            txbRuta.TabIndex = 3;
            // 
            // btnRuta
            // 
            btnRuta.Location = new Point(285, 59);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(32, 23);
            btnRuta.TabIndex = 6;
            btnRuta.Text = "*";
            btnRuta.UseVisualStyleBackColor = true;
            btnRuta.Click += btnRuta_Click;
            // 
            // btnRutaRestore
            // 
            btnRutaRestore.Location = new Point(703, 60);
            btnRutaRestore.Name = "btnRutaRestore";
            btnRutaRestore.Size = new Size(32, 23);
            btnRutaRestore.TabIndex = 10;
            btnRutaRestore.Text = "*";
            btnRutaRestore.UseVisualStyleBackColor = true;
            btnRutaRestore.Click += btnRutaRestore_Click;
            // 
            // txbRestore
            // 
            txbRestore.Location = new Point(434, 60);
            txbRestore.Name = "txbRestore";
            txbRestore.Size = new Size(261, 23);
            txbRestore.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 42);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 42);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 7;
            label5.Text = "Ruta de restore:";
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(434, 150);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(75, 23);
            btnRestore.TabIndex = 11;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // txtbPassGerente
            // 
            txtbPassGerente.Font = new Font("Microsoft Sans Serif", 16F);
            txtbPassGerente.Location = new Point(434, 103);
            txtbPassGerente.Name = "txtbPassGerente";
            txtbPassGerente.PasswordChar = '*';
            txtbPassGerente.PlaceholderText = "Contraseña Gerente";
            txtbPassGerente.Size = new Size(217, 32);
            txtbPassGerente.TabIndex = 12;
            // 
            // BackUP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtbPassGerente);
            Controls.Add(btnRestore);
            Controls.Add(btnRutaRestore);
            Controls.Add(txbRestore);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(btnRuta);
            Controls.Add(txbRuta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBackUp);
            Name = "BackUP";
            Text = "BackUP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackUp;
        private Label label1;
        private Label label2;
        private TextBox txbRuta;
        private Button btnRuta;
        private Button btnRutaRestore;
        private TextBox txbRestore;
        private Label label4;
        private Label label5;
        private Button btnRestore;
        private TextBox txtbPassGerente;
    }
}