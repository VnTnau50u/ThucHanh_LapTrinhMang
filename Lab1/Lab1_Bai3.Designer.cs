﻿namespace LAB1
{
    partial class Lab1_Bai3
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
            label1 = new Label();
            label2 = new Label();
            button_calc = new Button();
            button_del = new Button();
            button_exit = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số từ 0 đến 9:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 161);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Kết quả:";
            // 
            // button_calc
            // 
            button_calc.Location = new Point(399, 33);
            button_calc.Name = "button_calc";
            button_calc.Size = new Size(94, 29);
            button_calc.TabIndex = 2;
            button_calc.Text = "Đọc";
            button_calc.UseVisualStyleBackColor = true;
            button_calc.Click += button_calc_Click;
            // 
            // button_del
            // 
            button_del.Location = new Point(399, 157);
            button_del.Name = "button_del";
            button_del.Size = new Size(94, 29);
            button_del.TabIndex = 3;
            button_del.Text = "Xóa";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(427, 242);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 4;
            button_exit.Text = "Thoát ";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // textBox1
            // 
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(184, 158);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // Lab1_Bai3
            // 
            AcceptButton = button_calc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_exit;
            ClientSize = new Size(533, 283);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button_exit);
            Controls.Add(button_del);
            Controls.Add(button_calc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_Bai3";
            Text = "Lab1_Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_calc;
        private Button button_del;
        private Button button_exit;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}