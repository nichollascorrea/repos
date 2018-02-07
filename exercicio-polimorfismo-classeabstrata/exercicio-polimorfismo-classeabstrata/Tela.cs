using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_polimorfismo_classeabstrata
{
    class Tela
    {
        public static Retangulo lerRetangulo()
        {
            Console.Write("Largura: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Retangulo(x, y, "preta");

        }

        public static Triangulo lerTriangulo()
        {
            Console.Write("Lado A: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return new Triangulo(a, b, c, "preta");

        }
    }
}
