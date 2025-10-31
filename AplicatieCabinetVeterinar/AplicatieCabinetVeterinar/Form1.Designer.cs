namespace AplicatieCabinetVeterinar
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(218, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(525, 361);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(41, 234);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 1;
            button1.Text = "Load DataBase";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 196);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 2;
            button2.Text = "Afișează tabel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Medici", "Clienți", "Animale", "CategoriiServicii", "Servicii", "Afecțiuni", "AnimaleCuAfecțiuni", "Consultații", "Reviews" });
            comboBox1.Location = new Point(53, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(41, 301);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 4;
            button3.Text = "Edit Veterinari";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_click;
            // 
            // button4
            // 
            button4.Location = new Point(41, 348);
            button4.Name = "button4";
            button4.Size = new Size(122, 23);
            button4.TabIndex = 5;
            button4.Text = "Edit Clienți";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_click;
            // 
            // button5
            // 
            button5.Location = new Point(42, 397);
            button5.Name = "button5";
            button5.Size = new Size(121, 23);
            button5.TabIndex = 6;
            button5.Text = "Statistici Veterinari";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(218, 397);
            button6.Name = "button6";
            button6.Size = new Size(106, 23);
            button6.TabIndex = 7;
            button6.Text = "Statistici Clienți";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(394, 397);
            button7.Name = "button7";
            button7.Size = new Size(93, 23);
            button7.TabIndex = 8;
            button7.Text = "Statistici boli";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(544, 397);
            button8.Name = "button8";
            button8.Size = new Size(118, 23);
            button8.TabIndex = 9;
            button8.Text = "Statistici Animale";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
