using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace Repositorio
{
    public class RepositoryCrudDao<T> : ICrudDao<T> where T : class
    {
        public void Alterar(T entidade)
        {
            using (NHibernate.ISession session = FluentySessionFactory.AbrirSession())
            {
                //recebe a session iniciando a transação
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        //retorna BOOL, se a transação não for comitada, faz um rollback
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        //joga a exception
                        throw new Exception("Erro ao atualizar entidade: " + ex.Message);
                    }
                }

            }
        }

        public IList<T> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Excluir(T entidade)
        {
            using (NHibernate.ISession session = FluentySessionFactory.AbrirSession())
            {
                //recebe a session iniciando a transação
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        //retorna BOOL, se a transação não for comitada, faz um rollback
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        //joga a exception
                        throw new Exception("Erro ao exlcuir entidade: " + ex.Message);
                    }
                }

            }
        }
        //public void Inserir(int ID)
        public void Inserir(T entidade)
        {
            //motivo do using é usar e desalocar
            //já traz o banco aberto
            using (NHibernate.ISession session = FluentySessionFactory.AbrirSession())
            {
                //recebe a session iniciando a transação
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        //retorna BOOL, se a transação não for comitada, faz um rollback
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        //joga a exception
                        throw new Exception("Erro ao inserir entidade: " + ex.Message);
                    }
                }

            }
        }

        public T RetornarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
