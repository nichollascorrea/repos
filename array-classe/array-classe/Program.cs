using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace array_classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;
            double soma, media;

            int N;
            N = int.Parse(Console.ReadLine());

            vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Nome do Produto");
                string produto = Console.ReadLine();

                Console.WriteLine("Valor");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vet[i] = new Produto(produto, valor);
            }

            soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i].preco;
            }

            media = soma / N;

            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
       

    }
}
