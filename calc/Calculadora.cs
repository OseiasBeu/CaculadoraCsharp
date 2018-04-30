using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Calculadora : Form
    {
        double valor1;
        double valor2;
        string operador;

        public Calculadora()
        {
            InitializeComponent();
        }

        Classes.clsSum objeto = new Classes.clsSum();
        Classes.clsSub objeto2 = new Classes.clsSub();
        Classes.clsMult objeto3 = new Classes.clsMult();
        Classes.clsDiv objeto4 = new Classes.clsDiv();

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";  
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";  
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            operador = "+";
            valor1 = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operador = "-";
            valor1 = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            valor1 = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            valor1 = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(tbxScreen.Text);
            double Sum;
            double Sub;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = objeto.Somar((valor1), (valor2));
                    tbxScreen.Text = Sum.ToString();
                    break;

                case "-":
                    Sub = objeto2.Dividir((valor1), (valor2));
                    tbxScreen.Text = Sub.ToString();
                    break;

                case "*":
                    Mul = objeto3.Multiplicar((valor1), (valor2));
                    tbxScreen.Text = Mul.ToString();
                    break;
                    
                case "/":
                    Div = objeto4.Dividir((valor1), valor2);
                    tbxScreen.Text = Div.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
    }
}
