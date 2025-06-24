namespace ejercicio2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lbltiemporestante = new Label();
            nudminutos = new NumericUpDown();
            nudsegundos = new NumericUpDown();
            btniniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudminutos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudsegundos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(95, 101);
            label1.Name = "label1";
            label1.Size = new Size(56, 16);
            label1.TabIndex = 0;
            label1.Text = "Minutos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(326, 101);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 1;
            label2.Text = "Segundos";
            // 
            // lbltiemporestante
            // 
            lbltiemporestante.AutoSize = true;
            lbltiemporestante.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lbltiemporestante.Location = new Point(261, 218);
            lbltiemporestante.Name = "lbltiemporestante";
            lbltiemporestante.Size = new Size(0, 16);
            lbltiemporestante.TabIndex = 2;
            // 
            // nudminutos
            // 
            nudminutos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            nudminutos.Location = new Point(177, 99);
            nudminutos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudminutos.Name = "nudminutos";
            nudminutos.Size = new Size(120, 23);
            nudminutos.TabIndex = 3;
            // 
            // nudsegundos
            // 
            nudsegundos.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            nudsegundos.Location = new Point(408, 101);
            nudsegundos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudsegundos.Name = "nudsegundos";
            nudsegundos.Size = new Size(120, 23);
            nudsegundos.TabIndex = 4;
            // 
            // btniniciar
            // 
            btniniciar.BackColor = Color.PaleVioletRed;
            btniniciar.FlatStyle = FlatStyle.Popup;
            btniniciar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btniniciar.ForeColor = SystemColors.ButtonFace;
            btniniciar.Location = new Point(244, 159);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(179, 27);
            btniniciar.TabIndex = 5;
            btniniciar.Text = "Iniciar temporizador";
            btniniciar.UseVisualStyleBackColor = false;
            btniniciar.Click += btniniciar_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 36);
            label3.Name = "label3";
            label3.Size = new Size(578, 18);
            label3.TabIndex = 6;
            label3.Text = "Configure los minutos y segundos, luego haga clic en “Iniciar temporizador”.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(676, 269);
            Controls.Add(label3);
            Controls.Add(btniniciar);
            Controls.Add(nudsegundos);
            Controls.Add(nudminutos);
            Controls.Add(lbltiemporestante);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "TicTac";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudminutos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudsegundos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbltiemporestante;
        private NumericUpDown nudminutos;
        private NumericUpDown nudsegundos;
        private Button btniniciar;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}
