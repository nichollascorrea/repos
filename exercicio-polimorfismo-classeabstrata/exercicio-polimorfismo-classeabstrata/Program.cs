using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace exercicio_polimorfismo_classeabstrata
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Figura> listFig = new List<Figura>();
           

            Console.Write("Quantas figuras você vai digitar?");
            int qteFig = int.Parse(Console.ReadLine());

            for (int i = 0; i < qteFig; i++) 
            {
                Console.Write("Figura " + (i + 1) + " triângulo ou retângulo (t/r)?");
                char fig = char.Parse(Console.ReadLine());
                
                if (fig == 'r')
                {
                    Figura f = Tela.lerRetangulo();
                    listFig.Add(f);
                 
                }

                else
                {
                    Figura f = Tela.lerTriangulo();
                    listFig.Add(f);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Áreas das Figuras:");
            for (int i = 0; i<listFig.Count; i++)
            {
                Console.WriteLine("Figura " + (i + 1) + ":" + listFig[i].area(),CultureInfo.InvariantCulture);
            }

            Console.ReadLine();
        }
    }
}
