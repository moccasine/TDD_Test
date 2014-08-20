using Hours.Core.Entities;
using System;
using System.Collections.Generic;
namespace Hours.Core.Repositories
{
    public interface ITimeItemRepository : IRepository<TimeItem>
    {
        TimeItem GetById(object id);
        IEnumerable<TimeItem> GetAll();
        IEnumerable<TimeItem> Query(System.Linq.Expressions.Expression<Func<TimeItem, bool>> filter);
        void Add(TimeItem entity);
        void Remove(TimeItem entity);
    }
}
