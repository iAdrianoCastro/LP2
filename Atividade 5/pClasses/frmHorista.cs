using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFalta.Text);

            MessageBox.Show("Nome              : " + objHorista.NomeEmpregado + "\n" +
                            "Matrícula        : " + objHorista.Matricula + "\n" +
                            "Salário           : " + objHorista.SalarioBruto().ToString("N2") + "\n" +
                            "Tempo de Trabalho : " + objHorista.TempoTrabalho().ToString() + " dias");
                            
        }
    }
}
