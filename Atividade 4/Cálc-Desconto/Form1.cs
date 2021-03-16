using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálc_Desconto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char Nome;
            double SalBruto, SalFam, DescINSS, DescIRPF;
            int NumFilhos;

            DescINSS = 0;
            SalFam = 0;


            if (tbNome.Text == "" || tbSalBruto.Text == "" || tbFilhos.Text == "" || (btMasc.Checked == false && btFem.Checked == false))
                MessageBox.Show("Inserir todos os requisitos");
            else
            {
                {
                    if (Double.TryParse(tbSalBruto.Text, out SalBruto))
                    {
                        if (SalBruto <= 800.47)
                        {
                            tbAliquoINSS.Text = ("7.65%");
                            DescINSS = SalBruto * 0.0765;
                            tbDescINSS.Text = Convert.ToString(DescINSS);
                        }
                        else
                            if (SalBruto > 800.47 && SalBruto <= 1050)
                        {
                            tbAliquoINSS.Text = ("8.65%");
                            DescINSS = SalBruto * 0.0865;
                            tbDescINSS.Text = Convert.ToString(DescINSS);
                        }
                        else
                                if (SalBruto > 1050.01 && SalBruto <= 1400.77)
                        {
                            tbAliquoINSS.Text = ("9%");
                            DescINSS = SalBruto * 0.09;
                            tbDescINSS.Text = Convert.ToString(DescINSS);
                        }
                        else

                                    if (SalBruto > 1400.78 && SalBruto <= 2801.56)
                        {
                            tbAliquoINSS.Text = ("11%");
                            DescINSS = SalBruto * 0.11;
                            tbDescINSS.Text = Convert.ToString(DescINSS);
                        }
                        else
                        {
                            DescINSS = 308.17;
                            tbDescINSS.Text = Convert.ToString(DescINSS);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Insira apenas números");
                    }



                    if (SalBruto <= 1257.12)
                    {
                        tbAliquoIRPF.Text = ("Isento");
                        DescIRPF = 0;
                        tbDescIRPF.Text = Convert.ToString(DescIRPF);
                    }
                    else

                        if (SalBruto > 1257.12 && SalBruto <= 2512.08)
                    {
                        tbAliquoIRPF.Text = ("15%");
                        DescIRPF = SalBruto * 0.15;
                        tbDescIRPF.Text = Convert.ToString(DescIRPF);
                    }
                    else
                    {
                        tbAliquoIRPF.Text = ("27.5%");
                        DescIRPF = SalBruto * 0.275;
                        tbDescIRPF.Text = Convert.ToString(DescIRPF);
                    }





                    if (int.TryParse(tbFilhos.Text, out NumFilhos))
                    {

                        if (NumFilhos > 0)
                        {
                            if (SalBruto <= 435.52)
                            {
                                SalFam = 22.33 * NumFilhos;
                                tbSalarioFam.Text = Convert.ToString(SalFam);
                            }
                            if (SalBruto > 435.52 && SalBruto <= 654.61)
                            {
                                SalFam = 15.74 * NumFilhos;
                                tbSalarioFam.Text = Convert.ToString(SalFam);
                            }
                        }
                        else
                        {
                            SalFam = 0;
                            tbSalarioFam.Text = Convert.ToString(SalFam);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Insira apenas números");
                    }
                  
                 tbSalLiq.Text = Convert.ToString(SalBruto + SalFam - DescINSS - DescIRPF);

                    if (btMasc.Checked == true)
                        Salute1.Text = "Prezado Senhor";
                    else
                        Salute1.Text = "Prezada Senhora";
                 Salute2.Text = Convert.ToString(tbNome.Text);

                    if (btCasado.Checked == true)
                        Salute3.Text = "Casado e com: ";
                    else
                        Salute3.Text = "Solteiro e com: ";
                 Salute4.Text = Convert.ToString(NumFilhos);

                 SaluteFilhos.Text = "Filho(s)";

                 Salute5.Text = "Aqui estão seus descontos";

                }
            }           
        }

    }
}