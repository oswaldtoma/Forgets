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
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndTime { get; set; }
        public string Location { get; set; }
        public bool IsImportant { get; set; }
        public bool ShouldRemind { get; set; }
        public DateTime? RemindDate { get; set; }
        public DateTime? RemindTime { get; set; }
    }
}
