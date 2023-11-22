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
            string veta = textBox1.Text;
            Class1.Smaz(ref veta);
            label1.Text = veta;
        }
    }
}