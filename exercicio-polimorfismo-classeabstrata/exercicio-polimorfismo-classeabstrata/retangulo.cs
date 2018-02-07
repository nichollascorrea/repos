using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_polimorfismo_classeabstrata
{
    class Retangulo : Figura
    {
        double x, y;

        public Retangulo(double x, double y, string cor) : base(cor)
        {
            this.x = x;
            this.y = y;
        }

        public override double area()
        {
            return x * y;
        }

        public override double perimetro()
        {
            return 2 * (x + y);
        }

        public override string ToString()
        {
            return area().ToString(); 
                
        }

    }
}
