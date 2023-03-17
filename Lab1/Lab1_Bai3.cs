using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            int num;
            bool Success = int.TryParse(textBox2.Text, out num);
            if (Success && num >= 0 && num <= 9)
            {
                switch (num)
                {
                    case 0:
                        textBox1.Text = "Không";
                        break;
                    case 1:
                        textBox1.Text = "Một";
                        break;
                    case 2:
                        textBox1.Text = "Hai";
                        break;
                    case 3:
                        textBox1.Text = "Ba";
                        break;
                    case 4:
                        textBox1.Text = "Bốn";
                        break;
                    case 5:
                        textBox1.Text = "Năm";
                        break;
                    case 6:
                        textBox1.Text = "Sáu";
                        break;
                    case 7:
                        textBox1.Text = "Bảy";
                        break;
                    case 8:
                        textBox1.Text = "Tám";
                        break;
                    case 9:
                        textBox1.Text = "Chín";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap so tu 0 den 9", "ERROR!");
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Lab1_main lab1_main = new Lab1_main();
            lab1_main.Show();
        }
    }
}
