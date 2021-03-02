using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pCalculadora
{
    public partial class Form1 : Form
    {
        double Num1, Num2, Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out Num1) || !double.TryParse(txtNum2.Text, out Num2))
                MessageBox.Show("Valores Inválidos");
            else
            {
                Resultado = Num1 + Num2;
                txtResultado.Text = Resultado.ToString("N2");
            }
        }

        private void Subt_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out Num1) || !double.TryParse(txtNum2.Text, out Num2))
                MessageBox.Show("Valores Inválidos");
            else
            {
                Resultado = Num1 - Num2;
                txtResultado.Text = Resultado.ToString("N2");
            }

        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out Num1) || !double.TryParse(txtNum2.Text, out Num2))
                MessageBox.Show("Valores Inválidos");
            else
            {
                Resultado = Num1 * Num2;
                txtResultado.Text = Resultado.ToString("N2");
            }

        }

        private void Div_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out Num1) && double.TryParse(txtNum2.Text, out Num2))
                if (Num2 == 0)
                {
                    MessageBox.Show("Não é possível fazer divisão por zero!");
                }
                else
                {
                    Resultado = Num1 / Num2;
                    txtResultado.Text = Resultado.ToString("N2");
                }
            else
                MessageBox.Show("Valores Inválidos");
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
