using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Repositorio.Entities;


namespace Repositorio.Mapping
{
    public class UsuariosMap : ClassMap<Usuarios>
    {
        public UsuariosMap()
        {
            Id(c => c.ID);
            Map(c => c.Status);
            Map(c => c.Nome);
            Map(c => c.Login);
            Map(c => c.Senha);
            Table("usuarios");
        }
    }
}
