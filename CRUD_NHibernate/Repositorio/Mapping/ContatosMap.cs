using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Repositorio.Entities;

namespace Repositorio.Mapping
{
    public class ContatosMap : ClassMap<Contatos>
    {
        public ContatosMap()
        {
            Id(c => c.ID);
            Map(c => c.Nome);
            Map(c => c.Endereco);
            Map(c => c.Bairro);
            Map(c => c.Cidade);
            Map(c => c.Estado);
            Map(c => c.Numero);
            Map(c => c.Cep);
            Map(c => c.Status);
            Table("contatos");
        }
    }
}
