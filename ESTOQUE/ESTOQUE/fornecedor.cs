using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTOQUE
{
    class Fornecedor
    {

        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Fornecedor(string nome, string email, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;

        }

        public override string ToString()
        {
            return "Fornecedor: " + nome + " , Email: " + email + " , " + telefone;
        }
    }
}
