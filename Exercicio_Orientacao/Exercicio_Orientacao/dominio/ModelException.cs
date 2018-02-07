using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Orientacao.dominio
{
    class ModelException : Exception
    {
        public ModelException(string msg) : base(msg) { }
    }
}
