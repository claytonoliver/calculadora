using System.Diagnostics;
using System.Globalization;

namespace calcsytemos
{

    
    public partial class Form1 : Form

    {


        decimal valorum = 0, valordois = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        

        public static void btn1_Click(object sender, EventArgs e)
        {

           

            Console.WriteLine("botão1");

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {

            valordois = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operacao == "soma")
            {
                txtResultado.Text = Convert.ToString(valorum + valordois);
            }

            if (operacao == "divi")
            {
                txtResultado.Text = Convert.ToString(valorum / valordois);
            }

            if (operacao == "multi")
            {
                txtResultado.Text = Convert.ToString(valorum * valordois);
            }

            if (operacao == "sub")
            {
                txtResultado.Text = Convert.ToString(valorum - valordois);
            }


        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "soma";
            lblshow.Text = "+";
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "divi";
            lblshow.Text = "/";
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "multi";
            lblshow.Text = "x";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            valorum = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "sub";
            lblshow.Text = "-";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
    }
}