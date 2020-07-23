using System;
using System.Windows.Media;

namespace Forgets
{
    public class Reminder : ScheduleRecord
    {
        public Reminder()
        {
            RecordType = Schedule.TEvent.TE_REMINDER;
            RecordTypeColor = Color.FromRgb(120,120,120);
        }
    }
}
