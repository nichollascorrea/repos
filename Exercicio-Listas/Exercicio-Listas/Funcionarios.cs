using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Listas
{
    class Funcionarios
    {
       public int cpf { get; private set; }
       public double salario { get; private set; }
       public string nome { get; private set; }

        public Funcionarios(int cpf, double salario, string nome)
        {
            this.cpf = cpf;
            this.salario = salario;
            this.nome = nome;

        }

      
    }
}
