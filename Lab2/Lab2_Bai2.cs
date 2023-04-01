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
            FileStream fs = new FileStream(ofd.FileName, FileMode.Create);
            ofd.ShowDialog();
            textBox1.Text = ofd.SafeFileName.ToString();
            textBox2.Text = fs.Name.ToString();
        }
    }
}
