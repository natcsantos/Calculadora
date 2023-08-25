/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 28/05/2022
* Autores do Projeto: Giulia Elisa Pereira - 50210666
*                     Natalia Costa Santos - 50210317
* Turma: 2HID
* Projeto proposto para o 2ºBimestre
* Observação: Código comentado.
* 
* calculadora.cs
* ************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";
        private bool inicio;
        double resultado = 0;

        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //igual
            valor2 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
               textBox1.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                textBox1.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                textBox1.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "PRC")
            {
                textBox1.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "RAIZY")
            {
                resultado = System.Math.Pow(valor1, (1 / valor2));
                textBox1.Text = System.Math.Round(resultado).ToString();
                
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //subtração
            if(textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "SUB";
                label1.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //multiplicação
            if(textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "MULT";
                label1.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //divisão
            if(textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "DIV";
                label1.Text = "÷";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão.");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //CE
            textBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //C
            textBox1.Text = "";
            valor1 = 0;
            valor2 = 0;
            label1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //setinha
            if (textBox1.TextLength > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = " ";
                inicio = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //raiz quadrada
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = System.Math.Sqrt(valor1).ToString();
            label1.Text = "√";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //porcentagem
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = (valor1 / 100).ToString();
            label1.Text = "%";
            operacao = "PRC";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //ao quadrado
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = System.Math.Pow(valor1, 2).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //ao cubo
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = System.Math.Pow(valor1, 3).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //10 elevado a X
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = System.Math.Pow(10, valor1).ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            //X elevado a Y
            valor1 = double.Parse(textBox1.Text);
            valor2 = double.Parse(textBox1.Text);
            resultado = valor1;
            textBox1.Text = System.Math.Pow(valor1, valor2).ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            //seno
            //em radianos
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(textBox1.Text)));
                label1.Text = "rad/sin";
            }
            //em graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Sin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                label1.Text = "sin";
            }
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //cosseno
            //em radianos
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(textBox1.Text)));
                label1.Text = "rad/cos";
            }

            //em graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                label1.Text = "cos";
            }
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //tangente
            //em radianos
            if (radioButton1.Checked == true)
            {
                textBox1.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(textBox1.Text)));
                label1.Text = "rad/tan";
            }
            //em graus
            else
            {
                textBox1.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(textBox1.Text))));
                label1.Text = "tan";
            }
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //logaritmo
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = System.Math.Log10(valor1).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //1 dividido por X
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = (1.0 / valor1).ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            //fatorial
            Single var1 = 1;
            Single valor = Convert.ToSingle(textBox1.Text);
            for (int i = 1; i <= valor; i++)
            {
                var1 = var1 * i;
            }
            textBox1.Text = Convert.ToString(var1);
            label1.Text = "!";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //positivo e negativo
            textBox1.Text = Convert.ToString(-Convert.ToInt32(textBox1.Text));
          
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //mod
            valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            textBox1.Text = "";
            textBox1.Text = Convert.ToString(Convert.ToDouble(valor1) % Convert.ToDouble(textBox1.Text));

        }

        private void button36_Click(object sender, EventArgs e)
        {
            //pi
            textBox1.Text = "3.141592654";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //raiz cúbica
            //arredonda até os cubos não perfeitos!!!
            valor1 = double.Parse(textBox1.Text);
            resultado = System.Math.Pow(valor1, 0.33);
            textBox1.Text = System.Math.Round(resultado).ToString();
            label1.Text = "³√";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            //raiz Y de X
            //digitar primeiro o X depois o Y(potência)!!!
            valor1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            operacao = "RAIZY";
            label1.Text = "y√";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //adição
            if(textBox1.Text != "")
            {
                valor1 = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                textBox1.Text = "";
                operacao = "SOMA";
                label1.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Soma.");
            }
        }
    }
}
