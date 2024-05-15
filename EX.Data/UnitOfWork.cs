using EX.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly EXContext context;

        public UnitOfWork(EXContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(context);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
