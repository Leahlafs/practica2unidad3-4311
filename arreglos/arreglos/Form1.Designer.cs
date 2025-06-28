namespace arreglos
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
            label3 = new Label();
            tbCodigo = new TextBox();
            tbPromedio = new TextBox();
            tbNombre = new TextBox();
            btnRegistar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            btnBuscar = new Button();
            label4 = new Label();
            tbBuscar = new TextBox();
            dgAlumnos = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label1.Location = new Point(58, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label2.Location = new Point(58, 148);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 14);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label3.Location = new Point(57, 188);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 14);
            label3.TabIndex = 2;
            label3.Text = "Promedio:";
            // 
            // tbCodigo
            // 
            tbCodigo.Location = new Point(136, 110);
            tbCodigo.Margin = new Padding(2);
            tbCodigo.Name = "tbCodigo";
            tbCodigo.Size = new Size(171, 23);
            tbCodigo.TabIndex = 3;
            // 
            // tbPromedio
            // 
            tbPromedio.Location = new Point(136, 185);
            tbPromedio.Margin = new Padding(2);
            tbPromedio.Name = "tbPromedio";
            tbPromedio.Size = new Size(171, 23);
            tbPromedio.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(136, 148);
            tbNombre.Margin = new Padding(2);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(171, 23);
            tbNombre.TabIndex = 5;
            // 
            // btnRegistar
            // 
            btnRegistar.BackColor = Color.SeaGreen;
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnRegistar.ForeColor = SystemColors.ButtonHighlight;
            btnRegistar.Location = new Point(55, 254);
            btnRegistar.Margin = new Padding(2);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(91, 34);
            btnRegistar.TabIndex = 6;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = false;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(197, 254);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Orange;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnOrdenar.ForeColor = SystemColors.ButtonHighlight;
            btnOrdenar.Location = new Point(354, 254);
            btnOrdenar.Margin = new Padding(2);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(90, 34);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.DodgerBlue;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            btnBuscar.ForeColor = SystemColors.ButtonHighlight;
            btnBuscar.Location = new Point(360, 311);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(84, 32);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold);
            label4.Location = new Point(48, 321);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 14);
            label4.TabIndex = 10;
            label4.Text = "Buscar por codigo";
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            tbBuscar.Location = new Point(177, 317);
            tbBuscar.Margin = new Padding(2);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(165, 22);
            tbBuscar.TabIndex = 11;
            // 
            // dgAlumnos
            // 
            dgAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAlumnos.Location = new Point(48, 366);
            dgAlumnos.Margin = new Padding(2);
            dgAlumnos.Name = "dgAlumnos";
            dgAlumnos.RowHeadersWidth = 62;
            dgAlumnos.Size = new Size(396, 115);
            dgAlumnos.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 47);
            label5.Name = "label5";
            label5.Size = new Size(295, 18);
            label5.TabIndex = 13;
            label5.Text = "Sistema de Registro de Alumnos.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(492, 504);
            Controls.Add(label5);
            Controls.Add(dgAlumnos);
            Controls.Add(tbBuscar);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegistar);
            Controls.Add(tbNombre);
            Controls.Add(tbPromedio);
            Controls.Add(tbCodigo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Sistema de Registro de Alumnos.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbCodigo;
        private TextBox tbPromedio;
        private TextBox tbNombre;
        private Button btnRegistar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Button btnBuscar;
        private Label label4;
        private TextBox tbBuscar;
        private DataGridView dgAlumnos;
        private Label label5;
    }
}
