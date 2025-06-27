namespace ejercicio8
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
            txtoracion = new TextBox();
            lblresultado = new Label();
            btncontar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            label1.Location = new Point(84, 155);
            label1.Name = "label1";
            label1.Size = new Size(154, 16);
            label1.TabIndex = 0;
            label1.Text = "Escribe una oracion.";
            // 
            // txtoracion
            // 
            txtoracion.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            txtoracion.Location = new Point(84, 184);
            txtoracion.Name = "txtoracion";
            txtoracion.Size = new Size(184, 23);
            txtoracion.TabIndex = 1;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            lblresultado.Location = new Point(497, 187);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 16);
            lblresultado.TabIndex = 3;
            // 
            // btncontar
            // 
            btncontar.BackColor = Color.DarkSeaGreen;
            btncontar.FlatStyle = FlatStyle.Flat;
            btncontar.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btncontar.ForeColor = SystemColors.ButtonHighlight;
            btncontar.Location = new Point(306, 176);
            btncontar.Name = "btncontar";
            btncontar.Size = new Size(136, 39);
            btncontar.TabIndex = 4;
            btncontar.Text = "contar palabras";
            btncontar.UseVisualStyleBackColor = false;
            btncontar.Click += btncontar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 78);
            label2.Name = "label2";
            label2.Size = new Size(602, 23);
            label2.TabIndex = 5;
            label2.Text = "Escribe una oración y presiona el botón para ver cuántas palabras contiene.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(746, 288);
            Controls.Add(label2);
            Controls.Add(btncontar);
            Controls.Add(lblresultado);
            Controls.Add(txtoracion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Contador de palabras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtoracion;
        private Label lblresultado;
        private Button btncontar;
        private Label label2;
    }
}
