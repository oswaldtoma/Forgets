using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgets
{
    public class NewEvent
    {
        public string RecordName { get; set; } 
        public string Description { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? StartTime { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = DateTime.Now;
        public DateTime? EndTime { get; set; } = DateTime.Now;
        public string Location { get; set; }
        public bool IsImportant { get; set; }
        public bool ShouldRemind { get; set; }
        public DateTime? RemindDate { get; set; } = DateTime.Now.AddHours(-1);
        public DateTime? RemindTime { get; set; } = DateTime.Now;
    }
}
