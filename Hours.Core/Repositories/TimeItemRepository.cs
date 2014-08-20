using Hours.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours.Core.Repositories
{
    
    public class TimeItemRepository : Hours.Core.Repositories.ITimeItemRepository
    {
        HoursContext _hourContext;

        public TimeItemRepository(HoursContext context)
        {
            _hourContext = context;
        }

        public TimeItem GetById(object id)
        {
            return _hourContext.TimeItems.SingleOrDefault(s => s.Id == (int)id);
        }



        public IEnumerable<TimeItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeItem> Query(System.Linq.Expressions.Expression<Func<TimeItem, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(TimeItem entity)
        {
            _hourContext.TimeItems.Add(entity);
        }

        public void Remove(TimeItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
