using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_POO_01.Dominio
{
    class Artista : IComparable
    {
        public int codigo;
        public string nome;
        public double cache;

        public Artista(int codigo, string nome, double cache)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public int CompareTo(object obj)
        {
            Artista artista = (Artista)obj;
            return nome.CompareTo(artista.nome);
           
            
        }

        public override string ToString()
        {
            return codigo + ", " + nome + ", Cachê: " + cache.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
