using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Enumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            Mes x;
            x = Mes.Fevereiro;

            int valorx = (int)Mes.Fevereiro;
            Console.WriteLine(x);
            Console.WriteLine(valorx);

            Console.ReadLine();
        }
    }
}
