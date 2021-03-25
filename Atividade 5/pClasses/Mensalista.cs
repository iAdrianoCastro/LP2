using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClasses
{
    class Mensalista : Empregado
    {
        public double SalarioMensal { get; set; }


        public Mensalista()
        {


        }

        public Mensalista(int matx, string nomex, DateTime datax, double salariox)
        {
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
