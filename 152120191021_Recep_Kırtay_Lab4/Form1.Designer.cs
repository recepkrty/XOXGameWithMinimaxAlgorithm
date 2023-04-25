namespace _152120191021_Recep_Kırtay_Lab4
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Number : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "20191021";
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 38);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Score : ";
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.BackColor = Color.White;
            button1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(114, 89);
            button1.Name = "button1";
            button1.Size = new Size(87, 79);
            button1.TabIndex = 3;
            button1.Tag = "00";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(207, 89);
            button2.Name = "button2";
            button2.Size = new Size(87, 79);
            button2.TabIndex = 4;
            button2.Tag = "01";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(300, 89);
            button3.Name = "button3";
            button3.Size = new Size(87, 79);
            button3.TabIndex = 5;
            button3.Tag = "02";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(114, 174);
            button4.Name = "button4";
            button4.Size = new Size(87, 79);
            button4.TabIndex = 6;
            button4.Tag = "10";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(207, 174);
            button5.Name = "button5";
            button5.Size = new Size(87, 79);
            button5.TabIndex = 7;
            button5.Tag = "11";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(300, 174);
            button6.Name = "button6";
            button6.Size = new Size(87, 79);
            button6.TabIndex = 8;
            button6.Tag = "12";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(114, 259);
            button7.Name = "button7";
            button7.Size = new Size(87, 79);
            button7.TabIndex = 9;
            button7.Tag = "20";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(207, 259);
            button8.Name = "button8";
            button8.Size = new Size(87, 79);
            button8.TabIndex = 10;
            button8.Tag = "21";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(300, 259);
            button9.Name = "button9";
            button9.Size = new Size(87, 79);
            button9.TabIndex = 11;
            button9.Tag = "22";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Click;
            // 
            // button10
            // 
            button10.BackColor = Color.LightSeaGreen;
            button10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ControlLight;
            button10.Location = new Point(157, 361);
            button10.Name = "button10";
            button10.Size = new Size(188, 38);
            button10.TabIndex = 12;
            button10.Text = "Reset Game";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 425);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}