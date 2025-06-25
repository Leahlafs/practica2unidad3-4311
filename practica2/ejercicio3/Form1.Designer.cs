namespace ejercicio3
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
            txtvalor = new TextBox();
            cmbUnidadEntrada = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbUnidadSalida = new ComboBox();
            lblresultado = new Label();
            btnconvertir = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(77, 132);
            label1.Name = "label1";
            label1.Size = new Size(118, 16);
            label1.TabIndex = 0;
            label1.Text = "Valor a convertir:";
            // 
            // txtvalor
            // 
            txtvalor.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtvalor.Location = new Point(77, 162);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(100, 23);
            txtvalor.TabIndex = 1;
            // 
            // cmbUnidadEntrada
            // 
            cmbUnidadEntrada.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cmbUnidadEntrada.FormattingEnabled = true;
            cmbUnidadEntrada.Location = new Point(81, 238);
            cmbUnidadEntrada.Name = "cmbUnidadEntrada";
            cmbUnidadEntrada.Size = new Size(121, 24);
            cmbUnidadEntrada.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(81, 207);
            label2.Name = "label2";
            label2.Size = new Size(28, 16);
            label2.TabIndex = 3;
            label2.Text = "De:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(284, 207);
            label3.Name = "label3";
            label3.Size = new Size(21, 16);
            label3.TabIndex = 4;
            label3.Text = "A:";
            // 
            // cmbUnidadSalida
            // 
            cmbUnidadSalida.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            cmbUnidadSalida.FormattingEnabled = true;
            cmbUnidadSalida.Location = new Point(284, 235);
            cmbUnidadSalida.Name = "cmbUnidadSalida";
            cmbUnidadSalida.Size = new Size(121, 24);
            cmbUnidadSalida.TabIndex = 5;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblresultado.Location = new Point(81, 367);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(90, 23);
            lblresultado.TabIndex = 6;
            lblresultado.Text = "Resultado:";
            // 
            // btnconvertir
            // 
            btnconvertir.BackColor = Color.LavenderBlush;
            btnconvertir.FlatStyle = FlatStyle.Flat;
            btnconvertir.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnconvertir.ForeColor = SystemColors.ControlText;
            btnconvertir.Location = new Point(149, 291);
            btnconvertir.Name = "btnconvertir";
            btnconvertir.Size = new Size(180, 36);
            btnconvertir.TabIndex = 7;
            btnconvertir.Text = "Convertir";
            btnconvertir.UseVisualStyleBackColor = false;
            btnconvertir.Click += btnconvertir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(125, 55);
            label4.Name = "label4";
            label4.Size = new Size(214, 27);
            label4.TabIndex = 8;
            label4.Text = "Conversor de Longitud";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(506, 444);
            Controls.Add(label4);
            Controls.Add(btnconvertir);
            Controls.Add(lblresultado);
            Controls.Add(cmbUnidadSalida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbUnidadEntrada);
            Controls.Add(txtvalor);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor de Longitud";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtvalor;
        private ComboBox cmbUnidadEntrada;
        private Label label2;
        private Label label3;
        private ComboBox cmbUnidadSalida;
        private Label lblresultado;
        private Button btnconvertir;
        private Label label4;
    }
}
