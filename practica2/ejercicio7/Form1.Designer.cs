namespace ejercicio7
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
            label2 = new Label();
            txtinicio = new TextBox();
            txtfin = new TextBox();
            listBoxPrimos = new ListBox();
            btnmostrarprimos = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            label1.Location = new Point(55, 93);
            label1.Name = "label1";
            label1.Size = new Size(48, 16);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            label2.Location = new Point(219, 93);
            label2.Name = "label2";
            label2.Size = new Size(29, 16);
            label2.TabIndex = 1;
            label2.Text = "Fin";
            // 
            // txtinicio
            // 
            txtinicio.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            txtinicio.Location = new Point(55, 111);
            txtinicio.Name = "txtinicio";
            txtinicio.Size = new Size(100, 23);
            txtinicio.TabIndex = 2;
            // 
            // txtfin
            // 
            txtfin.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            txtfin.Location = new Point(219, 111);
            txtfin.Name = "txtfin";
            txtfin.Size = new Size(100, 23);
            txtfin.TabIndex = 3;
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.Location = new Point(523, 111);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(105, 132);
            listBoxPrimos.TabIndex = 4;
            // 
            // btnmostrarprimos
            // 
            btnmostrarprimos.BackColor = Color.PaleVioletRed;
            btnmostrarprimos.FlatStyle = FlatStyle.Flat;
            btnmostrarprimos.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            btnmostrarprimos.ForeColor = SystemColors.ButtonHighlight;
            btnmostrarprimos.Location = new Point(355, 111);
            btnmostrarprimos.Name = "btnmostrarprimos";
            btnmostrarprimos.Size = new Size(110, 23);
            btnmostrarprimos.TabIndex = 5;
            btnmostrarprimos.Text = "Mostrar Primos";
            btnmostrarprimos.UseVisualStyleBackColor = false;
            btnmostrarprimos.Click += btnmostrarprimos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            label3.Location = new Point(505, 93);
            label3.Name = "label3";
            label3.Size = new Size(189, 16);
            label3.TabIndex = 6;
            label3.Text = "Lista de numeros primos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold);
            label4.Location = new Point(21, 42);
            label4.Name = "label4";
            label4.Size = new Size(834, 16);
            label4.TabIndex = 7;
            label4.Text = "Introduce un número de inicio y un número final para mostrar todos los números primos dentro de ese rango.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(864, 275);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnmostrarprimos);
            Controls.Add(listBoxPrimos);
            Controls.Add(txtfin);
            Controls.Add(txtinicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lista de numero primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtinicio;
        private TextBox txtfin;
        private ListBox listBoxPrimos;
        private Button btnmostrarprimos;
        private Label label3;
        private Label label4;
    }
}
