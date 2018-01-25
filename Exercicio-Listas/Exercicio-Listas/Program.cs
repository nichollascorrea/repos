using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            int funcionarios;

            Console.Write("Quantos funcionários serão cadastrados: ");
            funcionarios = int.Parse(Console.ReadLine());

            List<Funcionarios> func = new List<Funcionarios>();

            func.Add(new Funcionarios(333, 4000.00, "Maria Silva"));
            func.Add(new Funcionarios(536, 3000.00, "Carlos Bastos"));
            //func.Add(new Funcionarios(333, 4000.00, "Maria Silva"));

            for (int i = 0; 0 < func.Count; i++)
            {
                Console.WriteLine(func[i].cpf + func[i].nome + func[i].salario);
            }


            Console.ReadLine();

        }
    }
}
