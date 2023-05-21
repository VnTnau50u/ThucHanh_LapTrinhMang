namespace Lab4
{
    partial class Bai2
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
            txt_Url = new TextBox();
            txt_content = new TextBox();
            button1 = new Button();
            ResponseBox = new RichTextBox();
            SuspendLayout();
            // 
            // txt_Url
            // 
            txt_Url.Location = new Point(12, 23);
            txt_Url.Name = "txt_Url";
            txt_Url.Size = new Size(634, 23);
            txt_Url.TabIndex = 0;
            txt_Url.Text = "http::/";
            txt_Url.TextChanged += txt_Url_TextChanged;
            // 
            // txt_content
            // 
            txt_content.Location = new Point(12, 61);
            txt_content.Name = "txt_content";
            txt_content.Size = new Size(634, 23);
            txt_content.TabIndex = 1;
            txt_content.Text = "content";
            // 
            // button1
            // 
            button1.Location = new Point(666, 23);
            button1.Name = "button1";
            button1.Size = new Size(106, 61);
            button1.TabIndex = 2;
            button1.Text = "Post";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResponseBox
            // 
            ResponseBox.Location = new Point(12, 103);
            ResponseBox.Name = "ResponseBox";
            ResponseBox.Size = new Size(760, 335);
            ResponseBox.TabIndex = 3;
            ResponseBox.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResponseBox);
            Controls.Add(button1);
            Controls.Add(txt_content);
            Controls.Add(txt_Url);
            Name = "Bai2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Url;
        private TextBox txt_content;
        private Button button1;
        private RichTextBox ResponseBox;
    }
}