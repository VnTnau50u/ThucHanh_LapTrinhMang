namespace Lab4
{
    partial class Bai3
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
            url = new TextBox();
            path = new TextBox();
            Download = new Button();
            exit_btn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // url
            // 
            url.Location = new Point(44, 31);
            url.Name = "url";
            url.Size = new Size(524, 23);
            url.TabIndex = 0;
            url.Text = "http::/";
            // 
            // path
            // 
            path.Location = new Point(44, 71);
            path.Name = "path";
            path.Size = new Size(524, 23);
            path.TabIndex = 1;
            // 
            // Download
            // 
            Download.Location = new Point(633, 31);
            Download.Name = "Download";
            Download.Size = new Size(75, 23);
            Download.TabIndex = 2;
            Download.Text = "Download";
            Download.UseVisualStyleBackColor = true;
            Download.Click += Download_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(633, 71);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 23);
            exit_btn.TabIndex = 3;
            exit_btn.Text = "Exit";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(44, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(664, 282);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 435);
            Controls.Add(richTextBox1);
            Controls.Add(exit_btn);
            Controls.Add(Download);
            Controls.Add(path);
            Controls.Add(url);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox url;
        private TextBox path;
        private Button Download;
        private Button exit_btn;
        private RichTextBox richTextBox1;
    }
}