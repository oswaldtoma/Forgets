using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgets
{
    interface IScheduleRecord
    {
        string getName();
        string getLocation();
        DateTime getStartTime();
        DateTime getEndTime();
    }
}
