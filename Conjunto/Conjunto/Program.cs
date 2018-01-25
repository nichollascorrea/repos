using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            //conjuntos não tem posição. está ou não esta. organanizado pelo hashset
            HashSet<int> A = new HashSet<int>();

            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //diferença de conjutos
            //A.ExceptWith(B);

            //união
            //A.UnionWith(B);

            //interseção
            A.IntersectWith(B);

            foreach (int a in A)
            {
                Console.WriteLine(a);

            }

            //B.Remove(5);



            Console.WriteLine("Digite um valor inteiro");
            int n = int.Parse(Console.ReadLine());

            if (B.Contains(n))
            {
                Console.WriteLine("contém " + n);
            }





            Console.ReadLine();
        }
    }
}
