namespace ejercicio4
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
            txtpalabra = new TextBox();
            btnverificar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(102, 100);
            label1.Name = "label1";
            label1.Size = new Size(162, 18);
            label1.TabIndex = 0;
            label1.Text = "Ingresa una palabra:";
            // 
            // txtpalabra
            // 
            txtpalabra.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            txtpalabra.Location = new Point(101, 135);
            txtpalabra.Name = "txtpalabra";
            txtpalabra.Size = new Size(154, 26);
            txtpalabra.TabIndex = 1;
            // 
            // btnverificar
            // 
            btnverificar.BackColor = Color.DarkSeaGreen;
            btnverificar.FlatStyle = FlatStyle.Flat;
            btnverificar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnverificar.ForeColor = SystemColors.ButtonHighlight;
            btnverificar.Location = new Point(113, 180);
            btnverificar.Name = "btnverificar";
            btnverificar.Size = new Size(124, 29);
            btnverificar.TabIndex = 2;
            btnverificar.Text = "Verificar";
            btnverificar.UseVisualStyleBackColor = false;
            btnverificar.Click += btnverificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 34);
            label2.Name = "label2";
            label2.Size = new Size(229, 27);
            label2.TabIndex = 3;
            label2.Text = "Verificador Palindromos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(370, 258);
            Controls.Add(label2);
            Controls.Add(btnverificar);
            Controls.Add(txtpalabra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "VerificadorPalindromos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtpalabra;
        private Button btnverificar;
        private Label label2;
    }
}
