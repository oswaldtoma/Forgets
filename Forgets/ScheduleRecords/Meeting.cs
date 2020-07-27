using System;
using System.Windows.Media;

namespace Forgets
{
    public class Meeting : ScheduleRecord
    {
        public Meeting()
        {
            RecordType = Schedule.TEvent.TE_MEETING;
            RecordTypeColor = Color.FromRgb(128,128,75);
        }
    }
}
