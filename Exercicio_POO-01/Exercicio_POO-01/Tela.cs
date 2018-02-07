using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_POO_01
{
    class Tela
    {
        public Tela()
        {

        }

        public static void cadastraFilme()
        {
            Console.WriteLine("DIGITE OS DADOS DO FILME:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite os dados da " + N + "a participação");

                Console.Write("Artista (Código): ");
                int codArtista = int.Parse(Console.ReadLine());

                int pos = Program.listaArtista.FindIndex(a => a.codigo == codArtista);

                if (pos == -1)
                {
                    throw new ModelException("Artista Inválido");
                }

                
                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }


        }

        public static void mostrarDadosFilme()
        {
            Console.WriteLine("DADOS DO FILME:");
            Console.Write("Código do Filme: ");
            Console.Write("Título: ");
            Console.Write("Ano:");
            Console.Write("Quantas participações tem o filme? ");
            int N = int.Parse(Console.ReadLine());




        }

        public static void cadastrarArtista()
        {
            Console.WriteLine("DIGITE OS DADOS DO ARTISTA:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Dominio.Artista a;
            a = new Dominio.Artista(codigo, nome, cache);
            Program.listaArtista.Add(a);
            Program.listaArtista.Sort();



        }

        public static void mostrarArtistas()
        {
            Console.WriteLine("LISTAGEM DE ARTISTAS:");

            for (int i = 0; i < Program.listaArtista.Count; i++)
            {
                Console.WriteLine(Program.listaArtista[i]);
            }
        }

        public static void mostarMenu()
        {
            Console.WriteLine("Escolha Uma Opção");
            Console.WriteLine("1 - Listar Artistas");
            Console.WriteLine("2 - Cadastrar Artista");
            Console.WriteLine("3 - Cadastrar Filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
        }
    }
}
