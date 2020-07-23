using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgets
{
    public class DbManager : DbContext
    {
        public DbManager() : base()
        {

        }

        public DbSet<ScheduleRecord> scheduleRecords { get; set; }
    }
}
