using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nichollas_console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Concatenando Strings
            string a, b;

            a = "nichollas";
            b = "correa";

            Console.WriteLine(a + b);
            Console.WriteLine("Meu nome é: " + a + " " + b);
            //Console.ReadLine();
            #endregion

            #region for
            int CondFor = 0;
            for (CondFor = 0; CondFor < 5; CondFor++)
            {
                Console.WriteLine("condição número: " + CondFor);

            }
            #endregion for

            #region While
            int CondWhile = 0;
            while (CondWhile < 5)
            {
                Console.WriteLine("while...");
                CondWhile++;

            }
            #endregion

            #region Array(Vetores)



            double[] vet;
            double soma, media;
            int N;
            Console.WriteLine("Digite a quantidade de componentes do array");
            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i=0; i<N; i++)
            {
                Console.WriteLine("Digite o valor do componente" + i.ToString());
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            soma = 0.0;
            for (int i = 0; i<N; i++)
            {
                soma = soma + vet[i];


            }
            media = soma / N;
            Console.WriteLine("ALTURA MEDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

            #endregion

            #region OrientandoAoObjeto
            Triangulo X, Y;
            double areaX, areaY;

            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Digite a área do triangulo X");
            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a área do triangulo Y");
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.area();
            areaY = Y.area();

            Console.WriteLine("Àrea do Tringulo  X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Àrea do Tringulo  Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área é: X");
            }
            else { Console.WriteLine("Maior área é: Y"); }
            #endregion
            Console.ReadLine();
        }
    }
}
