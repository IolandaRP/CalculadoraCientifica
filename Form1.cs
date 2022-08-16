using System.Globalization;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "soma";
            lblOperacao.Text = "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            switch (operacao)
            {
                case "soma":
                    decimal soma = valor1 + valor2;
                    txtResultado.Text = soma.ToString();
                    break;

                case "subtracao":
                    decimal subtracao = valor1 - valor2;
                    txtResultado.Text = subtracao.ToString();
                    break;

                case "multiplicacao":
                    decimal multiplicacao = valor1 * valor2;
                    txtResultado.Text = multiplicacao.ToString();
                    break;

                case "divisao":
                    decimal divisao = valor1 / valor2;
                    txtResultado.Text = divisao.ToString();
                    break;  

            }
      
        }

        private void button23_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "subtracao";
            lblOperacao.Text = "-";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "multiplicacao";
            lblOperacao.Text = "x";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "divisao";
            lblOperacao.Text = "/";
        }
    }
}