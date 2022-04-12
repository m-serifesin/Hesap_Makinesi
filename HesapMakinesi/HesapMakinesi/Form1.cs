namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            toplam = sayi1 + sayi2;

            label4.Text= toplam.ToString(); //ifade dönüþümü yapýldý.



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            int carpma;

            a = Convert.ToInt32(textBox4.Text);

            b = Convert.ToInt32(textBox3.Text);

            carpma = a * b;

            label5.Text=carpma.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int cikarma;

            x = Convert.ToInt32(textBox6.Text);

            y = Convert.ToInt32(textBox5.Text);

            cikarma = x - y;

            label9.Text = cikarma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int z;
            int t;
            int bol;

            z = Convert.ToInt32(textBox8.Text);

            t = Convert.ToInt32(textBox7.Text);

            bol = z / t;

            label13.Text = bol.ToString();
        }
    }
}