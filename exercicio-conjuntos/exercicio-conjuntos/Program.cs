using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            int CursoA, CursoB, CursoC;


            Console.Write("Quantos alunos existem no curso A? ");
            CursoA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");

            for (int i = 0; i < CursoA; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));

            }

            Console.Write("Quantos alunos existem no curso B? ");
            CursoB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");

            for (int i = 0; i < CursoB; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));

            }

            Console.Write("Quantos alunos existem no curso C? ");
            CursoC = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");

            for (int i = 0; i < CursoC; i++)
            {
               C.Add(int.Parse(Console.ReadLine()));

            }

            Console.ReadLine();

            Console.WriteLine("Itens conjunto A");
            foreach (int a in A)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();

            Console.WriteLine("Itens conjunto B");
            foreach (int b in B)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine();

            Console.WriteLine("Itens conjunto C");
            foreach (int c in C)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            HashSet<int> TotalAlunos = new HashSet<int>();
            TotalAlunos.UnionWith(A);
            TotalAlunos.UnionWith(B);
            TotalAlunos.UnionWith(C);

            Console.WriteLine("Total de Alunos: " + TotalAlunos.Count);
        


            Console.ReadLine();


        }
    }
}
