namespace PharmaSuite.Vistas.Reportes
{
    partial class DatosVenta
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosVenta));
            panel1 = new Panel();
            labelTituloTabla = new Label();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnImp = new Button();
            panel3 = new Panel();
            totalVenta = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            formaPago = new Label();
            label5 = new Label();
            clienteVta = new Label();
            label4 = new Label();
            emplVta = new Label();
            label3 = new Label();
            fechaVta = new Label();
            label2 = new Label();
            nroVenta = new Label();
            lnroVenta = new Label();
            nombreProd = new DataGridViewTextBoxColumn();
            codBarra = new DataGridViewTextBoxColumn();
            cant = new DataGridViewTextBoxColumn();
            sub = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTituloTabla);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 65);
            panel1.TabIndex = 0;
            // 
            // labelTituloTabla
            // 
            labelTituloTabla.Anchor = AnchorStyles.Top;
            labelTituloTabla.AutoSize = true;
            labelTituloTabla.Font = new Font("Century Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloTabla.Location = new Point(260, 9);
            labelTituloTabla.Name = "labelTituloTabla";
            labelTituloTabla.Size = new Size(294, 44);
            labelTituloTabla.TabIndex = 58;
            labelTituloTabla.Text = "Datos de venta";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnImp);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 393);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 57);
            panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 18F);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Image = Properties.Resources.borrar;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(410, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(168, 40);
            btnEliminar.TabIndex = 50;
            btnEliminar.Text = "Cancelar";
            btnEliminar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnImp
            // 
            btnImp.Anchor = AnchorStyles.None;
            btnImp.BackColor = Color.FromArgb(187, 222, 251);
            btnImp.BackgroundImageLayout = ImageLayout.None;
            btnImp.Cursor = Cursors.Hand;
            btnImp.FlatAppearance.BorderSize = 0;
            btnImp.FlatStyle = FlatStyle.Flat;
            btnImp.Font = new Font("Century Gothic", 18F);
            btnImp.ForeColor = Color.Black;
            btnImp.Image = Properties.Resources.disco;
            btnImp.ImageAlign = ContentAlignment.MiddleLeft;
            btnImp.Location = new Point(136, 8);
            btnImp.Name = "btnImp";
            btnImp.Size = new Size(266, 40);
            btnImp.TabIndex = 49;
            btnImp.Text = "Guardar factura";
            btnImp.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnImp.UseVisualStyleBackColor = false;
            btnImp.Click += btnImp_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(totalVenta);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(formaPago);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(clienteVta);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(emplVta);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(fechaVta);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(nroVenta);
            panel3.Controls.Add(lnroVenta);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(804, 328);
            panel3.TabIndex = 2;
            // 
            // totalVenta
            // 
            totalVenta.Anchor = AnchorStyles.Top;
            totalVenta.AutoSize = true;
            totalVenta.Font = new Font("Century Gothic", 20F);
            totalVenta.Location = new Point(641, 93);
            totalVenta.Name = "totalVenta";
            totalVenta.Size = new Size(30, 33);
            totalVenta.TabIndex = 73;
            totalVenta.Text = "$";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.Azure;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreProd, codBarra, cant, sub });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(15, 144);
            dataGridView1.Margin = new Padding(20, 3, 3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(772, 181);
            dataGridView1.TabIndex = 72;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20F);
            label6.Location = new Point(545, 90);
            label6.Name = "label6";
            label6.Size = new Size(85, 33);
            label6.TabIndex = 69;
            label6.Text = "Total:";
            // 
            // formaPago
            // 
            formaPago.Anchor = AnchorStyles.Top;
            formaPago.AutoSize = true;
            formaPago.Font = new Font("Century Gothic", 20F);
            formaPago.Location = new Point(237, 90);
            formaPago.Name = "formaPago";
            formaPago.Size = new Size(156, 33);
            formaPago.TabIndex = 68;
            formaPago.Text = "Nro Venta:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20F);
            label5.Location = new Point(3, 90);
            label5.Name = "label5";
            label5.Size = new Size(228, 33);
            label5.TabIndex = 67;
            label5.Text = "Forma de pago:";
            // 
            // clienteVta
            // 
            clienteVta.Anchor = AnchorStyles.Top;
            clienteVta.AutoSize = true;
            clienteVta.Font = new Font("Century Gothic", 20F);
            clienteVta.Location = new Point(641, 47);
            clienteVta.Name = "clienteVta";
            clienteVta.Size = new Size(156, 33);
            clienteVta.TabIndex = 66;
            clienteVta.Text = "Nro Venta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20F);
            label4.Location = new Point(512, 47);
            label4.Name = "label4";
            label4.Size = new Size(118, 33);
            label4.TabIndex = 65;
            label4.Text = "Cliente:";
            // 
            // emplVta
            // 
            emplVta.Anchor = AnchorStyles.Top;
            emplVta.AutoSize = true;
            emplVta.Font = new Font("Century Gothic", 20F);
            emplVta.Location = new Point(165, 47);
            emplVta.Name = "emplVta";
            emplVta.Size = new Size(156, 33);
            emplVta.TabIndex = 64;
            emplVta.Text = "Nro Venta:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20F);
            label3.Location = new Point(3, 47);
            label3.Name = "label3";
            label3.Size = new Size(159, 33);
            label3.TabIndex = 63;
            label3.Text = "Empleado:";
            // 
            // fechaVta
            // 
            fechaVta.Anchor = AnchorStyles.Top;
            fechaVta.AutoSize = true;
            fechaVta.Font = new Font("Century Gothic", 20F);
            fechaVta.Location = new Point(464, 3);
            fechaVta.Name = "fechaVta";
            fechaVta.Size = new Size(156, 33);
            fechaVta.TabIndex = 62;
            fechaVta.Text = "Nro Venta:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20F);
            label2.Location = new Point(364, 3);
            label2.Name = "label2";
            label2.Size = new Size(104, 33);
            label2.TabIndex = 61;
            label2.Text = "Fecha:";
            // 
            // nroVenta
            // 
            nroVenta.Anchor = AnchorStyles.Top;
            nroVenta.AutoSize = true;
            nroVenta.Font = new Font("Century Gothic", 20F);
            nroVenta.Location = new Point(165, 3);
            nroVenta.Name = "nroVenta";
            nroVenta.Size = new Size(156, 33);
            nroVenta.TabIndex = 60;
            nroVenta.Text = "Nro Venta:";
            // 
            // lnroVenta
            // 
            lnroVenta.Anchor = AnchorStyles.Top;
            lnroVenta.AutoSize = true;
            lnroVenta.Font = new Font("Century Gothic", 20F);
            lnroVenta.Location = new Point(3, 3);
            lnroVenta.Name = "lnroVenta";
            lnroVenta.Size = new Size(156, 33);
            lnroVenta.TabIndex = 59;
            lnroVenta.Text = "Nro Venta:";
            // 
            // nombreProd
            // 
            nombreProd.HeaderText = "Nombre Producto";
            nombreProd.Name = "nombreProd";
            nombreProd.ReadOnly = true;
            // 
            // codBarra
            // 
            codBarra.HeaderText = " Código Producto";
            codBarra.Name = "codBarra";
            codBarra.ReadOnly = true;
            // 
            // cant
            // 
            cant.HeaderText = "Cantidad";
            cant.Name = "cant";
            cant.ReadOnly = true;
            // 
            // sub
            // 
            sub.HeaderText = "Subtotal";
            sub.Name = "sub";
            sub.ReadOnly = true;
            // 
            // DatosVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(804, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DatosVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label labelTituloTabla;
        private Button btnEliminar;
        private Button btnImp;
        private Label lnroVenta;
        private Label emplVta;
        private Label label3;
        private Label fechaVta;
        private Label label2;
        private Label nroVenta;
        private Label label6;
        private Label formaPago;
        private Label label5;
        private Label clienteVta;
        private Label label4;
        private DataGridView dataGridView1;
        private Label totalVenta;
        private DataGridViewTextBoxColumn nombreProd;
        private DataGridViewTextBoxColumn codBarra;
        private DataGridViewTextBoxColumn cant;
        private DataGridViewTextBoxColumn sub;
    }
}