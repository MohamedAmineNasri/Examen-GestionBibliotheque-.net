using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX.Core.Interfaces;

namespace EX.Core.Services
{
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IUnitOfWork uow;
        IRepository<T> repo;
        public Service(IUnitOfWork uow)
        {
            this.uow = uow;
            repo = uow.GetRepository<T>();
        }
        public void Add(T entity)
        {
            repo.Add(entity);
            uow.Save();
        }

        public void Delete(T entity)
        {
            repo.Delete(entity);
            uow.Save();
        }

        public T? Get(int id)
        {
            return repo.Get(id);
        }

        public T? Get(string id)
        {
            return repo.Get(id);
        }

        public IList<T> GetAll()
        {
            return repo.GetAll();
        }

        public void Update(T entity)
        {
            repo.Update(entity);
            uow.Save();
        }
    }
}
