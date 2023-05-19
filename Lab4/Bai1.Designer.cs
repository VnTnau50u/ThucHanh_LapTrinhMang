namespace Lab4
{
    partial class Bai1
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
            txt_Url = new TextBox();
            box_Response = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(673, 58);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "GET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_Url
            // 
            txt_Url.Location = new Point(40, 58);
            txt_Url.Name = "txt_Url";
            txt_Url.Size = new Size(587, 23);
            txt_Url.TabIndex = 1;
            txt_Url.Text = "http://";
            // 
            // box_Response
            // 
            box_Response.Location = new Point(40, 100);
            box_Response.Name = "box_Response";
            box_Response.Size = new Size(708, 319);
            box_Response.TabIndex = 2;
            box_Response.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(box_Response);
            Controls.Add(txt_Url);
            Controls.Add(button1);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txt_Url;
        private RichTextBox box_Response;
    }
}