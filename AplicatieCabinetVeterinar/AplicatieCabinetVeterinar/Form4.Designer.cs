namespace AplicatieCabinetVeterinar
{
    partial class Form4
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
            dataGridView2 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            dataGridView3 = new DataGridView();
            label3 = new Label();
            dataGridView4 = new DataGridView();
            label4 = new Label();
            button3 = new Button();
            txtTotal = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(426, 150);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(346, 248);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(426, 150);
            dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(55, 73);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 2;
            button1.Text = "Istoric veterinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 10);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Lista veterinari";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 223);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Istoric consultații";
            // 
            // button2
            // 
            button2.Location = new Point(55, 143);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 5;
            button2.Text = "Calcul Recenzie Medie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(28, 248);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(268, 62);
            dataGridView3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 221);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Afișare recenzie";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(855, 30);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(336, 150);
            dataGridView4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(856, 7);
            label4.Name = "label4";
            label4.Size = new Size(165, 15);
            label4.TabIndex = 9;
            label4.Text = "Veterinari cu încasări mai mari";
            // 
            // button3
            // 
            button3.Location = new Point(855, 248);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 10;
            button3.Text = "Afișare";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(858, 216);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(856, 193);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 12;
            label5.Text = "Total veterinar selectat";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 485);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(dataGridView4);
            Controls.Add(label3);
            Controls.Add(dataGridView3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private DataGridView dataGridView3;
        private Label label3;
        private DataGridView dataGridView4;
        private Label label4;
        private Button button3;
        private TextBox txtTotal;
        private Label label5;
    }
}