using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_POO_01.Dominio;
using System.Globalization;

namespace Exercicio_POO_01
{
    class Program
    {
        public static List<Artista> listaArtista = new List<Artista>();
        public static List<Filme> listaFilme = new List<Filme>();
        

        static void Main(string[] args)
        {
            #region AdicionaArtistas
            listaArtista.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            listaArtista.Add(new Artista(102, "Chris Evans", 2500000.00));
            listaArtista.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            listaArtista.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            listaArtista.Sort();
            #endregion



            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();
                Tela.mostarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro inesperado: " + e);
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Tela.mostrarArtistas();
                        Console.ReadLine();
                        break;
                    case 2:
                        Tela.cadastrarArtista();
                        Console.ReadLine();
                        break;
                    case 3:
                        
                        try { Tela.cadastraFilme(); }
                        catch (ModelException e)
                        {
                            Console.WriteLine("erro de negócio: " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("erro: " + e.Message);
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Tela.mostrarDadosFilme();
                        Console.ReadLine();
                        break;
                    case 5:
                        break;
                    default:
                        break;


                }
                

            }


            Console.WriteLine();
        }
    }
}
