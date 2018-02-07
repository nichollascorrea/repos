using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_polimorfismo_classeabstrata
{
    abstract class Figura
    {
        public string cor { get; set; }

        public abstract double area();

        public abstract double perimetro();

        public Figura(string cor)
        {
            this.cor = cor;
        }
    }
}
