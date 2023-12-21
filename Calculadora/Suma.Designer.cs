namespace Calculadora
{
    partial class Suma
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
            label1 = new Label();
            SumaA = new TextBox();
            label2 = new Label();
            SumaB = new TextBox();
            label3 = new Label();
            SumaResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los montos a sumar";
            // 
            // SumaA
            // 
            SumaA.Location = new Point(23, 61);
            SumaA.Name = "SumaA";
            SumaA.Size = new Size(100, 23);
            SumaA.TabIndex = 1;
            SumaA.TextChanged += SumaA_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 64);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "+";
            // 
            // SumaB
            // 
            SumaB.Location = new Point(209, 61);
            SumaB.Name = "SumaB";
            SumaB.Size = new Size(100, 23);
            SumaB.TabIndex = 3;
            SumaB.TextChanged += SumaB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 64);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 4;
            label3.Text = "=";
            // 
            // SumaResultado
            // 
            SumaResultado.Location = new Point(370, 61);
            SumaResultado.Name = "SumaResultado";
            SumaResultado.Size = new Size(100, 23);
            SumaResultado.TabIndex = 5;
            SumaResultado.TextChanged += SumaResultado_TextChanged;
            // 
            // Suma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SumaResultado);
            Controls.Add(label3);
            Controls.Add(SumaB);
            Controls.Add(label2);
            Controls.Add(SumaA);
            Controls.Add(label1);
            Name = "Suma";
            Text = "Suma";
            Load += Suma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SumaA;
        private Label label2;
        private TextBox SumaB;
        private Label label3;
        private TextBox SumaResultado;
    }
}