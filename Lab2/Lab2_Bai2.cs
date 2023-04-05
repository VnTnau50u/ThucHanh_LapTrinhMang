using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
        private int DemSoDong(StreamReader sr)
        {
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            return lineCount;
        }
        private int countLine(StreamReader sr)
        {
            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
            return lineCount;
        }
        private void ReadFile_Button_Click(object sender, EventArgs e)
        {        
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Txt Files|*.txt";
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                textBox1.Text = ofd.SafeFileName.ToString();
                textBox2.Text = fs.Name.ToString();
                var content = sr.ReadToEnd();
                sr.BaseStream.Position = 0;
                textBox3.Text = countLine(sr).ToString();
                textBox4.Text = content.Length.ToString();
                string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                textBox5.Text = source.Count().ToString();
                richTextBox1.Text = content;
                fs.Close();
                sr.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.Show();
            this.Close();
        }
    }
}
