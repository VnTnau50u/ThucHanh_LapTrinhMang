namespace LAB1
{
    partial class Lab1_Bai4
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_calc = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_exit = new Button();
            button_del = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "(none)";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox1.Location = new Point(292, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            comboBox2.Location = new Point(497, 109);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 28);
            label1.TabIndex = 2;
            label1.Text = "CONVERT TO HEX, DEC, BIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(274, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhập một số (bỏ các tiền tố \"0x\", \"0b\") :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Chọn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(387, 130);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 238);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "Kết quả: ";
            // 
            // button_calc
            // 
            button_calc.BackColor = SystemColors.ActiveCaptionText;
            button_calc.ForeColor = SystemColors.ButtonFace;
            button_calc.Location = new Point(292, 184);
            button_calc.Name = "button_calc";
            button_calc.Size = new Size(356, 36);
            button_calc.TabIndex = 7;
            button_calc.Text = "Thực hiện";
            button_calc.UseVisualStyleBackColor = false;
            button_calc.Click += button_calc_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 235);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 27);
            textBox2.TabIndex = 9;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(570, 350);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(94, 29);
            button_exit.TabIndex = 11;
            button_exit.Text = "Thoát";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // button_del
            // 
            button_del.Location = new Point(157, 188);
            button_del.Name = "button_del";
            button_del.Size = new Size(94, 29);
            button_del.TabIndex = 12;
            button_del.Text = "Xóa";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 112);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 13;
            label6.Text = "Sang";
            // 
            // Lab1_Bai4
            // 
            AcceptButton = button_calc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button_exit;
            ClientSize = new Size(666, 382);
            Controls.Add(label6);
            Controls.Add(button_del);
            Controls.Add(button_exit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button_calc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Lab1_Bai4";
            Text = "Lab1_Bai4";
            Load += Lab1_Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_calc;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button_exit;
        private Button button_del;
        private Label label6;
    }
}