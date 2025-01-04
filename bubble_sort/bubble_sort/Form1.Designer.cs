namespace bubble_sort
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(327, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(333, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(77, 291);
            button1.Name = "button1";
            button1.Size = new Size(159, 40);
            button1.TabIndex = 2;
            button1.Text = "BubbleSort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 181);
            label1.Name = "label1";
            label1.Size = new Size(235, 26);
            label1.TabIndex = 3;
            label1.Text = "Otrzymane liczby:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 37);
            label2.Name = "label2";
            label2.Size = new Size(181, 26);
            label2.TabIndex = 4;
            label2.Text = "Wpisac liczby:";
            // 
            // button2
            // 
            button2.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(214, 353);
            button2.Name = "button2";
            button2.Size = new Size(148, 40);
            button2.TabIndex = 5;
            button2.Text = "MergeSort";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(277, 291);
            button3.Name = "button3";
            button3.Size = new Size(145, 40);
            button3.TabIndex = 6;
            button3.Text = "QuickSort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(394, 353);
            button4.Name = "button4";
            button4.Size = new Size(189, 40);
            button4.TabIndex = 7;
            button4.Text = "SelectionSort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button5.Location = new Point(450, 291);
            button5.Name = "button5";
            button5.Size = new Size(193, 41);
            button5.TabIndex = 8;
            button5.Text = "InsertionSort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown1.Location = new Point(256, 87);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 33);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(24, 87);
            label3.Name = "label3";
            label3.Size = new Size(226, 26);
            label3.TabIndex = 10;
            label3.Text = "Generowac liczby";
            // 
            // button6
            // 
            button6.Font = new Font("RomanT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button6.Location = new Point(631, 353);
            button6.Name = "button6";
            button6.Size = new Size(145, 40);
            button6.TabIndex = 11;
            button6.Text = "QuickSort";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button button6;
    }
}
