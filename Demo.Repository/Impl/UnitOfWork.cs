using System;
using System.Collections;
using System.Data.Entity;

namespace Demo.Repository.Impl
{
    public class UnitOfWork
    {
        protected readonly DbContext Context;
        private Hashtable _repositories;

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public IRepository<TRepository> GetRepository<TRepository>() where TRepository : class
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TRepository).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(EFGenericRepository<>);

                var repositoryInstance =
                Activator.CreateInstance(repositoryType
                .MakeGenericType(typeof(TRepository)), Context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository<TRepository>)_repositories[type];
        }

        public void ExecuteProcedure(string procedureCommand, params object[] sqlParams)
        {
            Context.Database.ExecuteSqlCommand(procedureCommand, sqlParams);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}