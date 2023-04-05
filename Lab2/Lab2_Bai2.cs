using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2_Bai2 : Form
    {
        public Lab2_Bai2()
        {
            InitializeComponent();
        }

        private void ReadFile_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            textBox1.Text = ofd.SafeFileName.ToString();
            content = content.Replace("\r\n", "\r");
            textBox3.Text = richTextBox1.Lines.Count().ToString();
            textBox4.Text = (richTextBox1.Text.Count(c => c == ' ')+1).ToString();
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ',', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            textBox5.Text = source.Count().ToString();
 
            
            fs.Close();

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }
    }
}
