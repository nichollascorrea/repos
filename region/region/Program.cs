using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace region
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            int a = 0;
            int b = 1;
            #endregion Fim da declaração de variáveis

            #region Codigo
            if (a == b)
            {
                Console.WriteLine("a é igual b");

            }
            #endregion Fim do código IF
        }
    }
}
