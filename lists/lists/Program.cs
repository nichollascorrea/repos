using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("joão");
            lista.Add("maria");
            lista.Add("josé");

            //lista.Add(new Produto("Geladeira", 2000.00);
            //int pos = lista.FindIndex(x => x.nome == "Geladeira");
            //int pos = lista.FindIndex(x => x.preco<1000);

            // lista.Remove("maria");

            lista.RemoveAt(0);

            int pos = lista.FindIndex(x => x == "maria");
            Console.WriteLine("posição da maria é = " + pos.ToString());

            for (int i=0; i<lista.Count; i++)
            {

               Console.WriteLine(lista[i]);
            }



            Console.ReadLine();
        }
    }
}
