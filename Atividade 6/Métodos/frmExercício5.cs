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
    public partial class frmExercício5 : Form
    {
        public frmExercício5()
        {
            InitializeComponent();
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            int Num1, Num2;

            Num1 = Convert.ToInt32(tbNum1.Text);
            Num2 = Convert.ToInt32(tbNum2.Text);


            Random NumAleatorio = new Random();

            int Sorteio = NumAleatorio.Next(Num1, Num2);

            MessageBox.Show("O numero sorteador foi : " + Sorteio);
        }
    }
}
