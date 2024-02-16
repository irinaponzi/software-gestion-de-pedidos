namespace WinFormsApp1
{
    partial class acompaniamientos
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
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            button2 = new Button();
            comboBox2 = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 600);
            panel1.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(589, 345);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(207, 29);
            comboBox3.TabIndex = 11;
            comboBox3.Text = "Seleccione cantidad";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 214, 165);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(497, 463);
            button2.Name = "button2";
            button2.Size = new Size(132, 50);
            button2.TabIndex = 10;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(321, 345);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(207, 29);
            comboBox2.TabIndex = 8;
            comboBox2.Text = "Seleccione cantidad";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 214, 165);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 293);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(324, 225);
            label3.Name = "label3";
            label3.Size = new Size(201, 37);
            label3.TabIndex = 5;
            label3.Text = "Aros de cebolla";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Bisque;
            panel5.Controls.Add(pictureBox2);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(334, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(178, 153);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(627, 225);
            label2.Name = "label2";
            label2.Size = new Size(126, 37);
            label2.TabIndex = 3;
            label2.Text = "Ensalada";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(77, 225);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 1;
            label1.Text = "Papas fritas";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Bisque;
            panel4.Controls.Add(pictureBox3);
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(600, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(178, 153);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Bisque;
            panel3.Controls.Add(pictureBox1);
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(66, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(178, 153);
            panel3.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(55, 345);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 29);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Seleccione cantidad";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 214, 165);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(227, 463);
            button1.Name = "button1";
            button1.Size = new Size(132, 50);
            button1.TabIndex = 6;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.papitas;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.anillos;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ensalada;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(178, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // acompaniamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 600);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "acompaniamientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "acompaniamientos";
            Load += acompaniamientos_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private ComboBox comboBox2;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private Panel panel5;
        private ComboBox comboBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}