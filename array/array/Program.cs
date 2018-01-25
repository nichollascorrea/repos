using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            double soma, media;
            int qte;

            qte = int.Parse(Console.ReadLine());

            vet = new double[qte];

            for (int i = 0; i < qte; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine(vet[i]);

            }

            soma = 0.0;
            for (int i = 0; i< qte; i++)
            {
                soma = soma + vet[i];
            }

            media = soma / qte;

            Console.WriteLine(media.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
