using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hours.Core.Entities
{
    public class HoursContext : DbContext
    {
        public virtual DbSet<TimeItem> TimeItems { get; set; } 
               
    }

    public class TimeItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Time { get; set; }        
    }
}
