using System;
using System.Windows.Media;

namespace Forgets
{
    public class Appointment : IScheduleRecord
    {
        public Appointment()
        {
            RecordType = Schedule.TEvent.TE_APPOINTMENT;
            RecordTypeColor = Color.FromRgb(0,0,255);
        }
        public Schedule.TEvent RecordType { get; set; }
        public string RecordName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; } = null;
        public DateTime? EndTime { get; set; } = null;
        public DateTime? RemindTime { get; set; } = null;
        public Color RecordTypeColor { get; set; }
        public bool isImportant { get; set; }
    }
}
