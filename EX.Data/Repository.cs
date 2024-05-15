using EX.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly EXContext context;
        public Repository(EXContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Add(entity);
            //context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Remove(entity);
            //context.SaveChanges();
        }

        public T? Get(int id)
        {
            return (T?)context.Find(typeof(T), id);
        }

        public T? Get(string id)
        {
            return (T?)context.Find(typeof(T), id);
        }

        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            context.Update(entity);
            //context.SaveChanges();
        }
    }
}
