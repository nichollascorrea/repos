using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exercicio_Orientacao.dominio;

namespace Exercicio_Orientacao
{
    //classe responsável por operações de tela, interagir com usuário.
    class Tela
    {
        public static void Splash()
        {
            Console.WriteLine(@"   _____                      ____        _     _       ");
            Console.WriteLine(@"  / ____|                    |  _ \      | |   (_)      ");
            Console.WriteLine(@" | |     __ _ ___  __ _ ___  | |_) | __ _| |__  _  __ _ ");
            Console.WriteLine(@" | |    / _` / __|/ _` / __| |  _ < / _` | '_ \| |/ _` |");
            Console.WriteLine(@" | |___| (_| \__ \ (_| \__ \ | |_) | (_| | | | | | (_| |");
            Console.WriteLine(@"  \_____\__,_|___/\__,_|___/ |____/ \__,_|_| |_|_|\__,_|");
            Console.WriteLine();
            Console.WriteLine();

        }


        public static void mostrarMenu() {
            Console.WriteLine("1 – Listar produtos ordenadamente");
            Console.WriteLine("2 – Cadastrar produto");
            Console.WriteLine("3 – Cadastrar pedido");
            Console.WriteLine("4 – Mostrar dados de um pedido");
            Console.WriteLine("5 – Sair");
            Console.Write("Digite uma opção: ");
            

        }

        public static void mostrarProdutos()
        {
            Console.WriteLine("LISTAGEM DE PRODUTOS:");

            for (int i = 0; i < Program.listaProdutos.Count; i++)
            {
                //Console.WriteLine(listaProdutos[i].codigo + ", " + listaProdutos[i].descricao + ", " + listaProdutos[i].preco.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(Program.listaProdutos[i]);

            }
            

        }

        public static void cadastraProdutos()
        {
            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produto p = new Produto(codigo, descricao, preco);
            Program.listaProdutos.Add(p);
            Program.listaProdutos.Sort();
            Console.Write("Produto Adicionado");


        }

        public static void cadastraPedido()
        {
            Console.WriteLine("Digite os dados do pedido:");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Pedido p = new Pedido(codigo, dia, mes, ano);

            Console.Write("Quanto itens no pedido? ");
            int itensPedido = int.Parse(Console.ReadLine());

            for (int i = 0; i<itensPedido; i++)
            {
                Console.WriteLine("Digite os dados do " + (i + 1) + "item:");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());

                int pos = Program.listaProdutos.FindIndex(x => x.codigo == codProduto);

                if (pos == -1)
                {
                    throw new ModelException("Código de Produto Inexistente " + codProduto);

                }

                Console.Write("Quantidade: ");
                int qte = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto");
                double porcentagemDesconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

                ItemPedido ip = new ItemPedido(qte, porcentagemDesconto, p, Program.listaProdutos[pos]);
                p.itens.Add(ip);





            }
            Program.listaPedidos.Add(p);

        }

        public static void mostraPedido()
        {
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());

            int pos = Program.listaPedidos.FindIndex(x => x.codigo == codPedido);
            if (pos == -1)
            {
                throw new ModelException("Código de Pedido Inválido: " + codPedido);
            }

            Console.Write(Program.listaPedidos[pos]);
            

        }
    }
}

