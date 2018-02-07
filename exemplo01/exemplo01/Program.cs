using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;


            Console.Write("Digite o primeiro valor");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor");
            num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double divisao = num1 / num2;
            double subtracao = num1 - num2;
            double multiplicacao = num1 * num2;
            double media = soma / 2;

            Console.WriteLine("O resultado da soma é: " + soma);
            Console.WriteLine("O resultado da divisão é: " + divisao);
            Console.WriteLine("O resultado da subtração é: " + subtracao);
            Console.WriteLine("O resultado da multiplicação é: " + multiplicacao);
            Console.WriteLine("A média de " + num1 + " e" + num2 + " é:" + media);

            Console.ReadLine();

        }
    }
}
