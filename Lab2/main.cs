namespace Lab2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab2_Bai1 lab2_Bai1 = new Lab2_Bai1();
            lab2_Bai1.Show();
        }
    }
}