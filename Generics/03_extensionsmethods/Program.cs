using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_extensionsmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //estende classes seladas

            string valor = "ola mundo";
            Console.WriteLine(valor.FirstToUpper());

            Console.ReadKey();
        }
    }
}
