namespace AplicatieCabinetVeterinar
{
    partial class Form5
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            dataGridView3 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            button3 = new Button();
            label5 = new Label();
            txtMedie = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(346, 275);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 39);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista Clienți";
            // 
            // button1
            // 
            button1.Location = new Point(36, 39);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 2;
            button1.Text = "Afișează animale";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 90);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 3;
            button2.Text = "Total sumă";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(43, 169);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(300, 150);
            dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 146);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 5;
            label2.Text = "Animalele deținute de clienți";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(43, 355);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(300, 59);
            dataGridView3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 335);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 7;
            label3.Text = "Total sumă";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(818, 39);
            label4.Name = "label4";
            label4.Size = new Size(211, 21);
            label4.TabIndex = 8;
            label4.Text = "Clienți cu recenzii similare";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(818, 63);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(390, 278);
            dataGridView4.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(820, 354);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Afișare";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(823, 386);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 11;
            label5.Text = "Recenzie Medie Client";
            // 
            // txtMedie
            // 
            txtMedie.Location = new Point(825, 412);
            txtMedie.Name = "txtMedie";
            txtMedie.Size = new Size(100, 23);
            txtMedie.TabIndex = 12;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 450);
            Controls.Add(txtMedie);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(dataGridView4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView2;
        private Label label2;
        private DataGridView dataGridView3;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView4;
        private Button button3;
        private Label label5;
        private TextBox txtMedie;
    }
}