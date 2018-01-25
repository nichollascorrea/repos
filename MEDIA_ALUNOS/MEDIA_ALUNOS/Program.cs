using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MEDIA_ALUNOS
{
    class Program
    {
        static void Main(string[] args)
        {

            CALCULA_MEDIA calc;
            calc = new CALCULA_MEDIA();

            Console.Write("Nome do aluno:");
            calc.aluno = Console.ReadLine();

            Console.Write("Nota 1o Trimestre");
            calc.trimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2o Trimestre");
            calc.trimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3o Trimestre");
            calc.trimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            calc.calcula_media();

            Console.WriteLine(calc);
            Console.ReadLine();


        }
    }
}
