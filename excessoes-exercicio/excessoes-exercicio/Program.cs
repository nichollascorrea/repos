using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace excessoes_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta;
            string nomeTitular;
            double limiteDeSaque;

            Banco b;


            Console.Write("Qual o numero da conta? ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Qual o nome do titular da conta? ");
            nomeTitular = Console.ReadLine();

            Console.Write("Qual o limite de saque? ");
            limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            b = new Banco(conta, nomeTitular, limiteDeSaque);

            Console.WriteLine(b);

            Console.Write("Qual o Valor do depósito? ");
            b.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
           Console.WriteLine("Valor da Conta Corrente: " + b.saldo.ToString("F2", CultureInfo.InvariantCulture));
           // Console.WriteLine("Valor da Conta Corrente: " + b.saldo);
            Console.Write("Qual o Valor do Saque? ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          try
            {
                b.Saque(saque);
                Console.WriteLine("Valor da Conta Corrente: " + b.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
           catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }



            Console.ReadLine();








        }
    }
}
