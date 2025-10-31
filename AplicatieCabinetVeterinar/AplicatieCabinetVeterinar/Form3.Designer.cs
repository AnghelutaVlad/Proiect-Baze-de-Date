namespace AplicatieCabinetVeterinar
{
    partial class Form3
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_nume = new TextBox();
            txt_prenume = new TextBox();
            txt_cnp = new TextBox();
            txt_telefon = new TextBox();
            txt_email = new TextBox();
            txt_adresa = new TextBox();
            txt_oras = new TextBox();
            txt_data = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(611, 383);
            button1.Name = "button1";
            button1.Size = new Size(103, 23);
            button1.TabIndex = 0;
            button1.Text = "Reîncarcă";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(332, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(382, 273);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_data);
            groupBox1.Controls.Add(txt_oras);
            groupBox1.Controls.Add(txt_adresa);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(txt_telefon);
            groupBox1.Controls.Add(txt_cnp);
            groupBox1.Controls.Add(txt_prenume);
            groupBox1.Controls.Add(txt_nume);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 311);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clienți";
            groupBox1.Enter += this.groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 39);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Prenume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 97);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "CNP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 127);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 156);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 185);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Adresă";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 214);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "Oraș";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 243);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 7;
            label8.Text = "Data Naștere";
            // 
            // txt_nume
            // 
            txt_nume.Location = new Point(136, 31);
            txt_nume.Name = "txt_nume";
            txt_nume.Size = new Size(100, 23);
            txt_nume.TabIndex = 8;
            txt_nume.TextChanged += this.textBox1_TextChanged;
            // 
            // txt_prenume
            // 
            this.txt_prenume.Location = new Point(136, 60);
            this.txt_prenume.Name = "txt_prenume";
            this.txt_prenume.Size = new Size(100, 23);
            this.txt_prenume.TabIndex = 9;
            //this.txt_prenume.TextChanged += this.textBox2_TextChanged;
            // 
            // txt_cnp
            // 
            this.txt_cnp.Location = new Point(136, 89);
            this.txt_cnp.Name = "txt_cnp";
            this.txt_cnp.Size = new Size(100, 23);
            this.txt_cnp.TabIndex = 10;
            this.txt_cnp.TextChanged += this.textBox3_TextChanged;
            // 
            // txt_telefon
            // 
            txt_telefon.Location = new Point(136, 119);
            txt_telefon.Name = "txt_telefon";
            txt_telefon.Size = new Size(100, 23);
            txt_telefon.TabIndex = 11;
            txt_telefon.TextChanged += this.textBox4_TextChanged;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(136, 148);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 12;
            txt_email.TextChanged += this.textBox5_TextChanged;
            // 
            // txt_adresa
            // 
            txt_adresa.Location = new Point(136, 177);
            txt_adresa.Name = "txt_adresa";
            txt_adresa.Size = new Size(100, 23);
            txt_adresa.TabIndex = 13;
            txt_adresa.TextChanged += this.textBox6_TextChanged;
            // 
            // txt_oras
            // 
            txt_oras.Location = new Point(136, 206);
            txt_oras.Name = "txt_oras";
            txt_oras.Size = new Size(100, 23);
            txt_oras.TabIndex = 14;
            txt_oras.TextChanged += this.textBox7_TextChanged;
            // 
            // txt_data
            // 
            txt_data.Location = new Point(136, 235);
            txt_data.Name = "txt_data";
            txt_data.Size = new Size(100, 23);
            txt_data.TabIndex = 15;
            txt_data.TextChanged += textBox8_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(72, 383);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 3;
            button2.Text = "Adaugă";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(240, 383);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 4;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(396, 383);
            button4.Name = "button4";
            button4.Size = new Size(92, 23);
            button4.TabIndex = 5;
            button4.Text = "Șterge";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_cnp;
        private TextBox txt_prenume;
        private TextBox txt_nume;
        private TextBox txt_data;
        private TextBox txt_oras;
        private TextBox txt_adresa;
        private TextBox txt_email;
        private TextBox txt_telefon;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}