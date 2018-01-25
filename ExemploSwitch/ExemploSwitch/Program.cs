using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int condicaoSwitch = 0;

            switch (condicaoSwitch)
            {
                case 1:
                    Console.WriteLine("Condição 1");
                    break;
                case 2:
                    Console.WriteLine("Condicão 2");
                    break;
                default:
                    Console.WriteLine("Condição Inexistente");
                    break;

                   
            }
            Console.ReadLine();

        }

    }
}
