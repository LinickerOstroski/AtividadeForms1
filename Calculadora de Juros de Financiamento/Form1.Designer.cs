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
            label1 = new Label();
            btnCalcular = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrincipal = new TextBox();
            txtTaxa = new TextBox();
            txtParcelas = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lblResultado = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe MDL2 Assets", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(252, 32);
            label1.Name = "label1";
            label1.Size = new Size(516, 35);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Juros de Financiamento";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = SystemColors.GradientActiveCaption;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Location = new Point(329, 325);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 27);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Cálcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 118);
            label2.Name = "label2";
            label2.Size = new Size(230, 19);
            label2.TabIndex = 3;
            label2.Text = "Valor Principal do Empréstimo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(289, 191);
            label3.Name = "label3";
            label3.Size = new Size(161, 19);
            label3.TabIndex = 4;
            label3.Text = "Taxa de Juros Anual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(299, 256);
            label4.Name = "label4";
            label4.Size = new Size(158, 19);
            label4.TabIndex = 5;
            label4.Text = "Número de Parcelas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrincipal
            // 
            txtPrincipal.Location = new Point(274, 154);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(198, 23);
            txtPrincipal.TabIndex = 6;
            // 
            // txtTaxa
            // 
            txtTaxa.Location = new Point(274, 223);
            txtTaxa.Name = "txtTaxa";
            txtTaxa.Size = new Size(198, 23);
            txtTaxa.TabIndex = 7;
            // 
            // txtParcelas
            // 
            txtParcelas.Location = new Point(274, 287);
            txtParcelas.Name = "txtParcelas";
            txtParcelas.Size = new Size(198, 23);
            txtParcelas.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(252, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 263);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(lblResultado);
            panel3.Location = new Point(537, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 143);
            panel3.TabIndex = 10;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.InactiveCaption;
            lblResultado.Font = new Font("Segoe MDL2 Assets", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = SystemColors.Control;
            lblResultado.Location = new Point(119, 52);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(21, 32);
            lblResultado.TabIndex = 4;
            lblResultado.Text = ".";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtParcelas);
            Controls.Add(txtTaxa);
            Controls.Add(txtPrincipal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalcular;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrincipal;
        private TextBox txtTaxa;
        private TextBox txtParcelas;
        private Panel panel2;
        private Panel panel3;
        private Label lblResultado;
    }
}