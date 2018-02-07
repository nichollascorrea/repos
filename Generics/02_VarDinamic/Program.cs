using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //object aceita um tipo diferente de dado da que foi originalmente declarado
            object t1 = "";
            object t2 = 12345;
            t2 = "";

            //var
            var v1 = "";
            var v2 = 13243;
            //não inicia sem um valor
            //var v3;

            //pode ocorrer erros em tempo de execução
            dynamic d1;

        }
    }
}
