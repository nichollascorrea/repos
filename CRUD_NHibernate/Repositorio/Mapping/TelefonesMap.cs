using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Entities;
using FluentNHibernate.Mapping;

namespace Repositorio.Mapping
{
    class TelefonesMap : ClassMap<Telefones>
    {
        public TelefonesMap()
        {
            //ID da Primary Key
            Id(c => c.ID);
            Map(c => c.ID_Contatos);
            Map(c => c.Telefone);
            Map(c => c.Email);
            Map(c => c.Site);
            Table("telefones");
            
        }

    }
}
