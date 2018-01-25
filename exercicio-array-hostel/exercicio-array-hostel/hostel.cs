using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_array_hostel
{
    class hostel
    {
        
        public string nome { get; private set; }
        public string email { get; private set; }

        public hostel(string nome, string email)
        {
            
            this.nome = nome;
            this.email = email;

        }

        public override string ToString()
        {
            return nome + ", " + email;
        }


    }
}
