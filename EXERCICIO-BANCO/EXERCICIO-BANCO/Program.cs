using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EXERCICIO_BANCO
{
    class Program
    {
        static void Main(string[] args)
        {



            BANCO b;

            Console.Write("Digite o número da conta:");
            int conta = int.Parse(Console.ReadLine());


            #region bloco01
            Console.Write("Digite o nome do titular da conta:");
            string titular = Console.ReadLine();

            Console.Write("Haverá Depósito Inicial? (s/n)");

            #endregion

            #region bloco02

            if (Console.ReadLine() == "s")
            {
                Console.Write("Qual o valor do depósito?");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                b = new BANCO(conta, titular, saldo);

            }
            else
            {
                b = new BANCO(conta, titular);
            }

            #endregion

            Console.WriteLine("Conta criada");
            Console.WriteLine(b);

            Console.Write("Digite um valor para o depósito: ");

            b.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(b);

            Console.Write("Digite um valor para o saque: ");

            b.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(b);

            Console.ReadLine();


        }
    }
}
