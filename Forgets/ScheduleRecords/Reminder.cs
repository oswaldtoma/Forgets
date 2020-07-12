using System;
using System.Windows.Media;

namespace Forgets
{
    public class Reminder : IScheduleRecord
    {
        public Reminder()
        {
            RecordType = Schedule.TEvent.TE_REMINDER;
            RecordTypeColor = Color.FromRgb(120,120,120);
        }
        public Schedule.TEvent RecordType { get; set; }
        public string RecordName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? RemindTime { get; set; }
        public Color RecordTypeColor { get; set; }
        public bool isImportant { get; set; }
    }
}
