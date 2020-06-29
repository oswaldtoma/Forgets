using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgets
{
    interface IScheduleRecord
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string RecordType { get; set; }
        string RecordName { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
    }
}
