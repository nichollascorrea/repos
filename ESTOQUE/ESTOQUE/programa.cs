using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ESTOQUE
{
    class Programa
    {
        static void Main(string[] args)
        {
            Fornecedor f;
            f = new Fornecedor("Lojas LTDA", "lojasltda@gmail.com", "2345678");

            Produto p;
            p = new Produto("Geladeira", 1000.00, f);

            Console.Write(p);

            Console.ReadLine();
        }
    }
}