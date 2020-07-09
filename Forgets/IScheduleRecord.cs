using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Forgets
{
    public interface IScheduleRecord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Schedule.TEvent RecordType { get; set; }
        string RecordName { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        DateTime RemindTime { get; set; }
        Color RecordTypeColor { get; set; }
        bool isImportant { get; set; }


    }
}
