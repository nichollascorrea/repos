using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entities
{
    public class Telefones
    {
        public virtual int ID { get; set; }
        public virtual int ID_Contatos { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string Email { get; set; }
        public virtual string Site { get; set; }

    }
}
