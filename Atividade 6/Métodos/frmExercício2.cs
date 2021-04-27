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
    public partial class frmExercício2 : Form
    {
        public frmExercício2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Metade = tbPalavra1.Text.Length / 2;

            tbPalavra1.Text = tbPalavra1.Text.Insert(Metade, "**");
        }

        private void btVerifica_Click(object sender, EventArgs e)
        {
            if (string.Compare(tbPalavra1.Text, tbPalavra2.Text, true) == 0)
                MessageBox.Show("As palavras são iguais");
            else
                MessageBox.Show("As palavras são diferentes");
        }

        private void btMeio_Click(object sender, EventArgs e)
        {
            int metade = tbPalavra2.Text.Length / 2;

            tbPalavra2.Text = tbPalavra2.Text.Substring(0, metade) + tbPalavra1.Text +
            tbPalavra2.Text.Substring(metade, tbPalavra2.Text.Length - metade);

        }
    }
}
