using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exercicio_Orientacao.dominio;

namespace Exercicio_Orientacao
{
    class Program
    {
        public static List<Produto> listaProdutos = new List<Produto>();
        public static List<Pedido> listaPedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int opcao = 0;

            #region CadastroInicialProdutos
            listaProdutos.Add(new Produto(1001, "Cadeira simples", 500.00));
            listaProdutos.Add(new Produto(1002, "Cadeira acolchoada", 900.00));
            listaProdutos.Add(new Produto(1003, "Sofá três lugares", 2000.00));
            listaProdutos.Add(new Produto(1004, "Mesa retangular", 1500.00));
            listaProdutos.Add(new Produto(1005, "Mesa retangular", 2000.00));
            listaProdutos.Sort();
            #endregion


            

            while (opcao != 5)
            {
                //Console.Clear();
                Tela.Splash();
                Tela.mostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro inesperado " + e);
                    opcao = 0;
                }

                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Tela.mostrarProdutos();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        try
                        {
                            Tela.cadastraProdutos();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Tela.cadastraPedido();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Ocorreu de negócio " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Tela.mostraPedido();
                            Console.ReadLine();
                            Console.Clear();
                        }
                        catch (ModelException e)
                        {
                            Console.WriteLine("Ocorreu de negócio " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ocorreu um erro: " + e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saindo");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida");
                        opcao = 0;
                        break;
                }


            }







           // Console.ReadLine();


        }
    }
}
