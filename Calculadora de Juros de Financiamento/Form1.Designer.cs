namespace Calculadora_de_Juros_de_Financiamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label3 = new Label();
            txtPrincipal = new TextBox();
            txtTaxa = new TextBox();
            lblResultado = new Label();
            txtParcelas = new TextBox();
            lblResultado1 = new Label();
            label4 = new Label();
            lblResultado2 = new Label();
            btnCalcular = new Button();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(557, 56);
            label2.TabIndex = 3;
            label2.Text = "Valor Principal do Empréstimo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 112);
            label3.Name = "label3";
            label3.Size = new Size(557, 56);
            label3.TabIndex = 4;
            label3.Text = "Taxa de Juros Anual %";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // txtPrincipal
            // 
            txtPrincipal.BackColor = SystemColors.MenuBar;
            txtPrincipal.Dock = DockStyle.Fill;
            txtPrincipal.Location = new Point(3, 59);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(557, 57);
            txtPrincipal.TabIndex = 6;
            // 
            // txtTaxa
            // 
            txtTaxa.BackColor = SystemColors.MenuBar;
            txtTaxa.Dock = DockStyle.Fill;
            txtTaxa.Location = new Point(3, 171);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(557, 57);
            txtTaxa.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.DarkSeaGreen;
            lblResultado.Dock = DockStyle.Fill;
            lblResultado.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = SystemColors.Info;
            lblResultado.Location = new Point(3, 84);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(219, 84);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "--------";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtParcelas
            // 
            txtParcelas.BackColor = SystemColors.MenuBar;
            txtParcelas.Dock = DockStyle.Fill;
            txtParcelas.Location = new Point(3, 283);
            txtParcelas.Name = "txtParcelas";
            txtParcelas.Size = new Size(557, 57);
            txtParcelas.TabIndex = 8;
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.BackColor = Color.DarkSeaGreen;
            lblResultado1.Dock = DockStyle.Fill;
            lblResultado1.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado1.ForeColor = SystemColors.Info;
            lblResultado1.Location = new Point(3, 168);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(219, 84);
            lblResultado1.TabIndex = 5;
            lblResultado1.Text = "--------";
            lblResultado1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSeaGreen;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Size = new Size(557, 56);
            label4.TabIndex = 5;
            label4.Text = "Número de Parcelas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.BackColor = Color.DarkSeaGreen;
            lblResultado2.Dock = DockStyle.Fill;
            lblResultado2.Font = new Font("Segoe MDL2 Assets", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado2.ForeColor = SystemColors.Info;
            lblResultado2.Location = new Point(3, 252);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(219, 84);
            lblResultado2.TabIndex = 11;
            lblResultado2.Text = "--------";
            lblResultado2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.OliveDrab;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Dock = DockStyle.Fill;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Image = (Image)resources.GetObject("btnCalcular.Image");
            btnCalcular.ImageAlign = ContentAlignment.MiddleRight;
            btnCalcular.Location = new Point(572, 3);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(225, 102);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkSeaGreen;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe MDL2 Assets", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(219, 84);
            label5.TabIndex = 11;
            label5.Text = "RESULTADO:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(txtPrincipal, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtTaxa, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(txtParcelas, 0, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 111);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(563, 336);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ControlLight;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 231F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(btnCalcular, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 76F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(lblResultado, 0, 1);
            tableLayoutPanel3.Controls.Add(lblResultado2, 0, 3);
            tableLayoutPanel3.Controls.Add(lblResultado1, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(572, 111);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(225, 336);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(563, 108);
            label1.TabIndex = 14;
            label1.Text = "Calculadora de Juros";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox txtPrincipal;
        private TextBox txtTaxa;
        private Label lblResultado;
        private TextBox txtParcelas;
        private Label lblResultado1;
        private Label label4;
        private Label lblResultado2;
        private Button btnCalcular;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
    }
}