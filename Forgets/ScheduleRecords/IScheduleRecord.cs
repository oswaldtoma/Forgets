using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Forgets
{
    public class IScheduleRecord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Key]
        public int ID { get; set; }
        public Schedule.TEvent RecordType { get; set; }
        public string RecordName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? RemindTime { get; set; }
        public Color RecordTypeColor { get; set; }
        public bool IsImportant { get; set; }
        public bool ShouldRemind { get; set; }


    }
}
