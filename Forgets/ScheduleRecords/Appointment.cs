using System;
using System.Windows.Media;

namespace Forgets
{
    public class Appointment : ScheduleRecord
    {
        public Appointment()
        {
            RecordType = Schedule.TEvent.TE_APPOINTMENT;
            RecordTypeColor = Color.FromRgb(0,0,255);
        }
    }
}
