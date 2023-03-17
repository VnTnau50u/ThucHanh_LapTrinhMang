namespace Lab1
{
    partial class Lab1_Bai1
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button_del = new Button();
            button_sum = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 7);
            label1.Name = "label1";
            label1.Size = new Size(205, 17);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TỔNG 2 SÔ NGUYÊN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 48);
            label2.Name = "label2";
            label2.Size = new Size(59, 13);
            label2.TabIndex = 1;
            label2.Text = "Nhập số 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 82);
            label3.Name = "label3";
            label3.Size = new Size(59, 13);
            label3.TabIndex = 2;
            label3.Text = "Nhập số 2:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 172);
            label4.Name = "label4";
            label4.Size = new Size(35, 13);
            label4.TabIndex = 3;
            label4.Text = "Tổng:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 168);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(88, 23);
            textBox3.TabIndex = 6;
            // 
            // button_del
            // 
            button_del.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button_del.Location = new Point(18, 126);
            button_del.Name = "button_del";
            button_del.Size = new Size(66, 22);
            button_del.TabIndex = 7;
            button_del.Text = "Xóa";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // button_sum
            // 
            button_sum.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button_sum.Location = new Point(157, 126);
            button_sum.Name = "button_sum";
            button_sum.Size = new Size(66, 22);
            button_sum.TabIndex = 8;
            button_sum.Text = "Tính";
            button_sum.UseVisualStyleBackColor = true;
            button_sum.Click += button_sum_Click;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            button_exit.Location = new Point(191, 216);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(66, 22);
            button_exit.TabIndex = 9;
            button_exit.Text = "Thoát";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Lab1_Bai1
            // 
            AcceptButton = button_sum;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_exit;
            ClientSize = new Size(257, 239);
            Controls.Add(button_exit);
            Controls.Add(button_sum);
            Controls.Add(button_del);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab1_Bai1";
            Text = "Lab1_Bai1";
            Load += Lab1_Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_sum;
        private System.Windows.Forms.Button button_exit;
    }
}