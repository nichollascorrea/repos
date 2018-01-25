using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SALARIO
{
    class SALARIO
    {

        public string nome;
        public double salarioBruto, desconto;

        public void aumentarSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.00);
        }

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public override string ToString()
        {
            return nome
                                         + ", R$ "
                           + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
