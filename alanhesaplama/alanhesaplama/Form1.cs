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
            int k�sakenar;
            k�sakenar=Convert.ToInt32(textBox1.Text);
            int uzunkenar;
            uzunkenar=Convert.ToInt32(textBox2.Text);
            int sonuc = 0;

            if(radioButton1.Checked)
            {
                sonuc = k�sakenar * uzunkenar;
            }
            else if (radioButton2.Checked)
            {
                sonuc = 2 * (k�sakenar + uzunkenar);
            }
            else
            {
                MessageBox.Show("Se�im Yap�n�z.");
            }
            label3.Text = "Sonu�: " + sonuc;
        }

    }
}
