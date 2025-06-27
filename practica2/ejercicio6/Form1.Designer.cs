namespace ejercicio6
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
            maskedTextBox1 = new MaskedTextBox();
            btnverificar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Century Gothic", 12F);
            maskedTextBox1.Location = new Point(200, 108);
            maskedTextBox1.Margin = new Padding(2, 2, 2, 2);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(159, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // btnverificar
            // 
            btnverificar.Font = new Font("Century Gothic", 12F);
            btnverificar.Location = new Point(229, 139);
            btnverificar.Margin = new Padding(2, 2, 2, 2);
            btnverificar.Name = "btnverificar";
            btnverificar.Size = new Size(91, 29);
            btnverificar.TabIndex = 1;
            btnverificar.Text = "verificar";
            btnverificar.UseVisualStyleBackColor = true;
            btnverificar.Click += btnverificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.Location = new Point(78, 41);
            label1.Name = "label1";
            label1.Size = new Size(377, 21);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un número entero positivo en el cuadro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(37, 190);
            label2.Name = "label2";
            label2.Size = new Size(491, 21);
            label2.TabIndex = 3;
            label2.Text = "Un número perfecto es igual a la suma de sus divisores propios.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(55, 62);
            label3.Name = "label3";
            label3.Size = new Size(424, 21);
            label3.TabIndex = 4;
            label3.Text = "Presione el botón para saber si es un número perfecto";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(584, 243);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnverificar);
            Controls.Add(maskedTextBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "numeros perfectos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button btnverificar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
