using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_array_hostel
{
    class Program
    {
        static void Main(string[] args)
        {


            hostel[] ocupacao = new hostel[10];
            

            int qteOcupa;
            
            Console.WriteLine("Quantos alugéis serão registrados?");

            qteOcupa = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= qteOcupa; i++)
            {
                Console.WriteLine("Dados do " + i + " aluguel");
                Console.Write("Nome ");
                string nome = Console.ReadLine();

                Console.Write("Email ");
                string email = Console.ReadLine();

                Console.Write("Quarto ");
                int quarto = int.Parse(Console.ReadLine());

                ocupacao[quarto] = new hostel(nome, email);

            }


            Console.WriteLine("Quartos ocupados");

            for (int i = 1; i < 10; i++)
            {
                if(ocupacao[i] != null) { 
                Console.WriteLine(i + " " + ocupacao[i]);
                }
            }

            Console.ReadLine();

        }
    }
}
