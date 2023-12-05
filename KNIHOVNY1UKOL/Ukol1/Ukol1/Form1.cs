using RetezUtil;

namespace Ukol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = string.Empty;
                string veta = textBox1.Text;
                Class1.Smaz(ref veta);
                string[] polozky;
                Class1.Zobraz(ref veta, out polozky);
                foreach (string s in polozky)
                {
                    label1.Text += s + " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Minus neco1 = new Minus(textBox2.Text);
                Minus neco2 = new Minus(textBox3.Text);
                label2.Text = neco1 - neco2;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}