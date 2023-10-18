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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe MDL2 Assets", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(265, 44);
            label1.Name = "label1";
            label1.Size = new Size(439, 29);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Juros de Financiamento";
            // 
            // btnCalcular
            // 
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Location = new Point(433, 321);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 27);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Cálcular";
            btnCalcular.UseVisualStyleBackColor = true;
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
            label2.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(373, 120);
            label2.Name = "label2";
            label2.Size = new Size(230, 19);
            label2.TabIndex = 3;
            label2.Text = "Valor Principal do Empréstimo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(400, 194);
            label3.Name = "label3";
            label3.Size = new Size(161, 19);
            label3.TabIndex = 4;
            label3.Text = "Taxa de Juros Anual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe MDL2 Assets", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(400, 268);
            label4.Name = "label4";
            label4.Size = new Size(158, 19);
            label4.TabIndex = 5;
            label4.Text = "Número de Parcelas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
    }
}