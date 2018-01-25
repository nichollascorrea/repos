using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SALARIO
{
    class Program
    {
        static void Main(string[] args)
        {
            SALARIO S;
            S = new SALARIO();

            Console.Write("Nome: ");
            S.nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            S.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            S.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Funcionario: " + S);

            Console.Write("Deseja aumentar o salário em qual porcentagem?");
            S.aumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do Funcionario: " + S);

            Console.ReadLine();



        }
    }
}
