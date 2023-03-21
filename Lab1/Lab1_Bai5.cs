using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            ResultBox.Text = string.Empty;

        }
        public class scoreException : Exception
        {
            public scoreException(string msg) : base(msg) { }
        }
        public void ScoreCheck(double[] score)
        {
            foreach (double i in score)
            {
                if (i < 0 | i > 10)
                {
                    throw new scoreException("Invalid value for score");
                }
            }
        }
        public double[] ScoreCalculate(double[] score)
        {
            double[] result = new double[3];
            Array.Sort(score);
            double avg = 0;
            for (int i = 0; i < score.Length; i++)
            {
                avg += score[i];
            }
            result[0] = avg / (score.Length-1); //avg
            result[1] = score[0];   //min
            result[2] = score[score.Length - 1]; //max 
            return result;
        }
        private void button_calc_Click(object sender, EventArgs e)
        {
            try
            {
                string[] info = textBox1.Text.Split('\u002C');
                double[] score = new double[info.Length - 1];
                for (int i = 0; i < score.Length; i++)
                {
                    score[i] = double.Parse(info[i + 1]);
                }
                ScoreCheck(score);
                double[] result = ScoreCalculate(score);
                textBox2.Text = string.Format("{0:0.00}", result[0]);
                textBox4.Text = result[1].ToString();
                textBox5.Text = result[2].ToString();
                ResultBox.Text = infoToString(info);
                int[] DauRotCount = passCheck(score);
                textBox6.Text = DauRotCount[0].ToString();
                textBox7.Text = DauRotCount[1].ToString();


            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value for score!");
            }
            catch (scoreException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string infoToString(string[] info)
        {
            string result ="";
            for (int i = 0; i < info.Length; i++)
            {
                result += $"Môn {i+1} : {info[i]}\r\n";
            }
            return result;
        }

        public int[] passCheck(double[] score)
        {
            int[] DauRot = new int[2];
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] >= 5)
                {
                    DauRot[0]++;
                }
                else
                {
                    DauRot[1]++;
                }
            }
            return DauRot;
        }     
    }
}
