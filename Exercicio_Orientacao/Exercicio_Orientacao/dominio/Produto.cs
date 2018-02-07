using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Orientacao.dominio
{
    class Produto : IComparable
    {
        public int codigo;
        public string descricao;
        public double preco;

        public Produto(int codigo, string descricao, double preco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.preco = preco;


        }

        public int CompareTo(object obj)
        {
            Produto prod = (Produto)obj;
            int resultado = descricao.CompareTo(prod.descricao);
            if (resultado != 0)
            {
                return resultado;
            }
            else
            {
                //com sinal de menos para ordem descrescente
                //em ordem crescente não precisa de sinal
                return -preco.CompareTo(prod.preco);
            }
        }

        public override string ToString()
        {
            return codigo + ", " + descricao + ", " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
