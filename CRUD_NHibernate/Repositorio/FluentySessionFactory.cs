using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.Data.SqlClient;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;


namespace Repositorio
{
    class FluentySessionFactory
    {

        //CLASSE DE CONFIGURAÇÃO DO BANCO DE DADOS

        //declarando o datasource
        private static string ConnectionString = @"Data Source=.\Lab; Initial Catalog = PESSOAS; User ID = csharp; Password=UQ6aiarn";

        //primeiro a criação da variável session
        private static ISessionFactory session;


        //o método cria uma sessão com o banco
        public static ISessionFactory CriarSession()
        {

            //verifica se a session tá vazia. se for diferente de NULL retorna a session
            if (session != null)
                return session;

            //Configura a conexão com o banco SQL
            //ConfigDB recebe as configurações necessárias do banco, lendo as configurações do connection string
            IPersistenceConfigurer configDB = MsSqlConfiguration.MsSql2012.ConnectionString(ConnectionString);

            //Configmap recebe as classes de mapeamento das entidades
            //mapping.contatos, recupera o namespace das classe
            var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.ContatosMap>());

            //recebe as configurações e abre o banco de dados
            session = configMap.BuildSessionFactory();


            return session;
            
        }

        //abre a sessão
        public static ISession AbrirSession()
        {
            return session.OpenSession();
        }

    }
}
