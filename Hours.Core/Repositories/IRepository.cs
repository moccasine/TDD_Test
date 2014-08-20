using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hours.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Query(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T entity);
    }

}
