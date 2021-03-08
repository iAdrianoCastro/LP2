using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            {
                double Altura, Peso, PesoIdeal;


                if (txtbPesoAtual.Text == "" && txtbAltura.Text == "" && (Feminino.Checked == false || Masculino.Checked == false))
                    MessageBox.Show("Inserir todos os requisitos");

                else
                {
                    Altura = Convert.ToDouble(txtbAltura.Text);
                    Peso = Convert.ToDouble(txtbPesoAtual.Text);


                    if (Masculino.Checked == true)
                    {
                        PesoIdeal = Math.Round(72.7 * Altura) - 58;
                        txtbPesoIdeal.Text = Convert.ToString(PesoIdeal);
                    }
                    else
                    {
                        PesoIdeal = Math.Round(62.1 * Altura) - 44.7;
                        txtbPesoIdeal.Text = Convert.ToString(PesoIdeal);
                    }

                    if (Peso == PesoIdeal)
                        MessageBox.Show("Seu peso é o ideal");
                    if (Peso > PesoIdeal)
                        MessageBox.Show("Você está acima do peso ideal, coma menos");
                    if (Peso < PesoIdeal)
                        MessageBox.Show("Você está abaixo do peso ideal, coma mais");

                }

            }
        }
    }
}
