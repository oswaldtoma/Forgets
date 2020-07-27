using System;
using System.Windows.Media;

namespace Forgets
{
    public class Event : ScheduleRecord
    {
        public Event()
        {
            RecordType = Schedule.TEvent.TE_EVENT;
            RecordTypeColor = Color.FromRgb(50,0,120);
        }
    }
}
