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
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "soma";
                lblOperacao.Text = "SOMA";
            }
            else
            {
                MessageBox.Show("Informe um número.");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text);

            switch (operacao)
            {
                case "soma":
                    txtResultado.Text = (valor1 + valor2).ToString();
                    break;

                case "subtracao":
                    txtResultado.Text = (valor1 - valor2).ToString();
                    break;

                case "multiplicacao":
                    txtResultado.Text = (valor1 * valor2).ToString();
                    break;

                case "divisao":
                    txtResultado.Text = (valor1 / valor2).ToString();
                    break;

                case "exponenciacao":
                    txtResultado.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)));
                    break;

                case "mod":
                    txtResultado.Text = Convert.ToString(Convert.ToDouble(valor1) % Convert.ToDouble(valor2));
                    break;

            }
        }


        private void button23_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "subtracao";
                lblOperacao.Text = "SUBTRAÇÃO";
            }
            else
            {
                MessageBox.Show("Informe um número.");
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "multiplicacao";
                lblOperacao.Text = "MULTIPLICAÇÃO";
            }
            else
            {
                MessageBox.Show("Informe um número.");
            }
           
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "divisao";
                lblOperacao.Text = "DIVISÃO";
            }
            else
            {
                MessageBox.Show("Informe um número.");
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblOperacao.Text = "FATORIAL";
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                Single resultado = 1;
                Single valor = Convert.ToSingle(txtResultado.Text);
                for (int i = 1; i <= valor; i++)
                {
                    resultado = resultado * i;
                }
                txtResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o seu fatorial.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "exponenciacao";
                lblOperacao.Text = "EXPONENCIAÇÃO";
            }
            else
            {
                MessageBox.Show("Informe o número base da exponenciação.");
            }
        }
           

        private void button5_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "RAIZ";

            if (!String.IsNullOrEmpty(txtResultado.Text))
            {
                txtResultado.Text = Convert.ToString(System.Math.Sqrt(Convert.ToDouble(txtResultado.Text)));
            }
            else
            {
                MessageBox.Show("Informe um número para calcular a sua raiz.");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "PI";
            txtResultado.Text = "3.14159265359";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "TANGENTE";

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                if (checkBoxRadianos.Checked == true)
                {
                    txtResultado.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(txtResultado.Text)));
                }
                else
                {
                    txtResultado.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(txtResultado.Text))));
                }
            }
            else
            {
                MessageBox.Show("Informe um número para calcular a tangente.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "SENO";

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                if (checkBoxRadianos.Checked == true)
                {
                    txtResultado.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(txtResultado.Text)));
                }
                else
                {
                    txtResultado.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(txtResultado.Text))));
                }
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o seno.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "COSSENO";

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                if (checkBoxRadianos.Checked == true)
                {
                    txtResultado.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(txtResultado.Text)));
                }
                else
                {
                    txtResultado.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(txtResultado.Text))));
                }
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o cosseno.");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                valor1 = decimal.Parse(txtResultado.Text);
                txtResultado.Text = "";
                operacao = "mod";
                lblOperacao.Text = "MOD";
            }
            else
            {
                MessageBox.Show("Informe o primeiro valor para calcular o MOD");
            }
               
        }

        private void button28_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "LOG NA BASE 10";

            if (!String.IsNullOrEmpty(txtResultado.Text))
            {
                txtResultado.Text = Convert.ToString(System.Math.Log10(Convert.ToDouble(txtResultado.Text)));
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o seu log.");
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "LOG NATURAL";

            if (!String.IsNullOrEmpty(txtResultado.Text))
            {
                txtResultado.Text = Convert.ToString(System.Math.Log(Convert.ToDouble(txtResultado.Text)));
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o seu log.");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "PORCENTAGEM";
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                txtResultado.Text = Convert.ToString(decimal.Parse(txtResultado.Text) / 100);
            }
            else
            {
                MessageBox.Show("Informe um número para calcular a porcentagem dele.");
            }
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "INVERSO DE SENO";

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                if (checkBoxRadianos.Checked == true)
                {
                    txtResultado.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(txtResultado.Text)));
                }
                else
                {
                    txtResultado.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(txtResultado.Text))));
                }
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o inverso de seno.");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {

            lblOperacao.Text = "INVERSO DE COSSENO";

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                if (checkBoxRadianos.Checked == true)
                {
                    txtResultado.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(txtResultado.Text)));
                }
                else
                {
                    txtResultado.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(txtResultado.Text))));
                }
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o inverso do cosseno.");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            lblOperacao.Text = "INVERSO DA TANGENTE";

            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                if (checkBoxRadianos.Checked == true)
                {
                    txtResultado.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(txtResultado.Text)));
                }
                else
                {
                    txtResultado.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(txtResultado.Text))));
                }
            }
            else
            {
                MessageBox.Show("Informe um número para calcular o inverso da tangente.");
            }
        }
    }
}