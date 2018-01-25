using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nichollas_console
{
    class Triangulo
    {
        // A Classe cria variáveis compostas
        // DECLARANDO ATRIBUTOS a, b, c
        public double a, b, c;

        //CRIANDO METODO CÁLCULO DE ÁREA
        public double area() {
            double p = (a + b + c) / 2.0;

            //MATSQR = RAIZ QUADRADA
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
