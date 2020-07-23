using System;
using System.Windows.Media;

namespace Forgets
{
    public class Class : ScheduleRecord
    {
        public Class()
        {
            RecordType = Schedule.TEvent.TE_CLASS;
            RecordTypeColor = Color.FromRgb(120,20,0);
        }
    }
}
