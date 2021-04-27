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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int Posição = tbPalavra2.Text.IndexOf(tbPalavra1.Text);

            while (Posição >= 0)
            {
                tbPalavra2.Text = tbPalavra2.Text.Substring(0, Posição) +
                tbPalavra2.Text.Substring(Posição + tbPalavra1.Text.Length,
                tbPalavra2.Text.Length - Posição - tbPalavra1.Text.Length);

                Posição = tbPalavra2.Text.IndexOf(tbPalavra1.Text);
            }
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            tbPalavra2.Text = tbPalavra2.Text.Replace(tbPalavra1.Text, "");
        }

        private void btInvert_Click(object sender, EventArgs e)
        {
            char[] meuArray = tbPalavra1.Text.ToArray();

            Array.Reverse(meuArray);

            foreach (char c in meuArray)
            {
                tbPalavra2.Text += c;
            }
        }
    }
}
