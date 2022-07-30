namespace alanhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kýsakenar;
            kýsakenar=Convert.ToInt32(textBox1.Text);
            int uzunkenar;
            uzunkenar=Convert.ToInt32(textBox2.Text);
            int sonuc = 0;

            if(radioButton1.Checked)
            {
                sonuc = kýsakenar * uzunkenar;
            }
            else if (radioButton2.Checked)
            {
                sonuc = 2 * (kýsakenar + uzunkenar);
            }
            else
            {
                MessageBox.Show("Seçim Yapýnýz.");
            }
            label3.Text = "Sonuç: " + sonuc;
        }

    }
}
