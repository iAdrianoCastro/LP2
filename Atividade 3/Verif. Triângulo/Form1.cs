using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verif.Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVerif_Click(object sender, EventArgs e)
        {
            {
                double A, B, C;

                if (tbA.Text == "" || tbB.Text == "" || tbC.Text == "")
                    MessageBox.Show("Inserir todos os requisitos");
                else
                {
                    if
                    (Double.TryParse(tbA.Text, out A) &&
                    Double.TryParse(tbB.Text, out B) &&
                    Double.TryParse(tbC.Text, out C))

                    {
                        if (A >= 0 && B >= 0 && C >= 0 && A < B + C && B < A + C && C < A + B)                           
                        {

                            if (A == B && B == C)
                                tbTipo.Text = ("Triângulo Equilátero");
                            else
                            {
                                if (A != B && B != C && A != C)
                                    tbTipo.Text = ("Triângulo Escaleno");
                                else
                                {
                                    if ((A == B && A != C) || (B == C && B != A) || (C == A && B != C)) ;
                                    tbTipo.Text = ("Triângulo Isósceles");
                                }
                            }
                        }

                        else
                            MessageBox.Show("Não Forma Triângulo");
                        
                    }
                    else
                        MessageBox.Show("Inserir Apenas Números");
                    
                }

            }
        }
    }

}
