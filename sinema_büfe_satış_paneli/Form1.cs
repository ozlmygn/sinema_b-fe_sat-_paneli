namespace sinema_büfe_satış_paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, çay, bilet, toplam;
            misir = Convert.ToInt32(textBox1.Text);
            su = Convert.ToInt32(textBox2.Text);
            çay = Convert.ToInt32(textBox3.Text);
            bilet = Convert.ToInt32(textBox4.Text);

            toplam = misir * 10 + su * 3 + çay * 5 + bilet * 20;
            label12.Text = toplam.ToString() + "TL ";

            kasatutar = kasatutar + toplam;
            label13.Text = kasatutar.ToString() + " TL ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox1.Focus();
        }
    }
}