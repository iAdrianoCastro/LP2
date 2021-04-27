using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos
{
    public partial class frmExercício4 : Form
    {
        public frmExercício4()
        {
            InitializeComponent();
        }

        private void btNum_Click(object sender, EventArgs e)
        {
            int QtdChar, QtdNum;
            QtdNum = 0;

            QtdChar = rtbTexto.Text.Length;

            for (int x = 0; x < QtdChar; x++)
            {
                if (char.IsNumber(rtbTexto.Text, x))
                {
                    QtdNum = ++QtdNum;
                }
            }

            MessageBox.Show("Quantidade de numeros: " + QtdNum);
        }

        private void btBranco_Click(object sender, EventArgs e)
        {
            int QtdChar, Posição, Contador;
            Posição = 0;
            Contador = 0;



            QtdChar = rtbTexto.Text.Length;

            while (Posição == 0 && Contador < QtdChar)
            {
                if (char.IsWhiteSpace(rtbTexto.Text, Contador))
                {
                    Posição = Contador + 1;
                }

                ++Contador;

            }


            MessageBox.Show("O primeiro espaço em branco está na posição: " + Posição);
        }

        private void btLetras_Click(object sender, EventArgs e)
        {
            int QntChar = rtbTexto.Text.Length;
            char[] Frase = rtbTexto.Text.ToArray();
            int QtdLetras;
            QtdLetras = 0;
            int Contador = 0;

            foreach (char c in Frase)
            {
                if (char.IsLetter(rtbTexto.Text, Contador))
                {
                    QtdLetras++;
                }

                Contador++;
            }


            MessageBox.Show("Quantidade de letras : " + QtdLetras);
        }
    }
}
