namespace practica2
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
            txtnumero = new TextBox();
            btnmostrar = new Button();
            lsttabla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 58);
            label1.Name = "label1";
            label1.Size = new Size(518, 18);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el número que desee para mostrar la tabla correspondiente:";
            // 
            // txtnumero
            // 
            txtnumero.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold | FontStyle.Italic);
            txtnumero.Location = new Point(43, 98);
            txtnumero.Multiline = true;
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(127, 28);
            txtnumero.TabIndex = 1;
            // 
            // btnmostrar
            // 
            btnmostrar.BackColor = Color.PaleVioletRed;
            btnmostrar.FlatStyle = FlatStyle.Flat;
            btnmostrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnmostrar.ForeColor = SystemColors.ControlLightLight;
            btnmostrar.Location = new Point(185, 98);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(133, 39);
            btnmostrar.TabIndex = 2;
            btnmostrar.Text = "Mostrar tabla";
            btnmostrar.UseVisualStyleBackColor = false;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // lsttabla
            // 
            lsttabla.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsttabla.FormattingEnabled = true;
            lsttabla.ItemHeight = 19;
            lsttabla.Location = new Point(344, 98);
            lsttabla.Name = "lsttabla";
            lsttabla.Size = new Size(131, 213);
            lsttabla.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(646, 412);
            Controls.Add(lsttabla);
            Controls.Add(btnmostrar);
            Controls.Add(txtnumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnumero;
        private Button btnmostrar;
        private ListBox lsttabla;
    }
}
