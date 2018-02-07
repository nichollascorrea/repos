using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_01.Dominio
{
    

    class Filme
    {
        public int codigo;
        public string titulo;
        public int ano;


        public Filme(int codigo, string titulo, int ano)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
        }

        public double custoTotal()
        {
            return 0.0;
        }

    }
}
