using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Projeto___P0030482021011
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btVerif_Click(object sender, EventArgs e)
        {
            double[,] Vendas = new double[4, 1];
            int i, j;
            double TotalMes = 0, TotalGeral = 0;

            listBox.Items.Add(" >> Valores das vendas << ");

            for(i=0; i<1; i++)
            {
                for(j=0; j<4; j++)
                {
                    Vendas[j,i] = Convert.ToDouble(Interaction.InputBox("Insira os valores das vendas semanais", "Entrada de dados", "", -1, -1));

                    TotalMes = Vendas[j,i] + TotalMes;

                    listBox.Items.Add("Mês " + (i+1) + " Semana " + (j+1)  + " = R$" + Vendas[j,i].ToString("N2"));

                    if(j == 3)
                    {
                        listBox.Items.Add("Total do mês " + (i+1) + " = R$" +  TotalMes.ToString("N2"));
                        TotalGeral = TotalGeral + TotalMes;
                        TotalMes = 0;
                    }
                    
                }
            }
            listBox.Items.Add(" >> Total Geral << ");
            listBox.Items.Add(" = R$" + TotalGeral.ToString("N2"));



        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
