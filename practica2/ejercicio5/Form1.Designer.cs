namespace ejercicio5
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
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(122, 131);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(130, 23);
            maskedTextBox1.TabIndex = 1;
            // 
            // btnverificar
            // 
            btnverificar.BackColor = Color.DarkSalmon;
            btnverificar.FlatStyle = FlatStyle.Flat;
            btnverificar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnverificar.ForeColor = SystemColors.ButtonHighlight;
            btnverificar.Location = new Point(144, 173);
            btnverificar.Name = "btnverificar";
            btnverificar.Size = new Size(88, 34);
            btnverificar.TabIndex = 2;
            btnverificar.Text = "verificar";
            btnverificar.UseVisualStyleBackColor = false;
            btnverificar.Click += btnverificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(31, 75);
            label1.Name = "label1";
            label1.Size = new Size(328, 23);
            label1.TabIndex = 3;
            label1.Text = "Digite un número para verificar si es primo.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(414, 349);
            Controls.Add(label1);
            Controls.Add(btnverificar);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button btnverificar;
        private Label label1;
    }
}
