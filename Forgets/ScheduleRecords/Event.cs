using System;
using System.Windows.Media;

namespace Forgets
{
    public class Event : IScheduleRecord
    {
        public Event()
        {
            RecordType = Schedule.TEvent.TE_EVENT;
            RecordTypeColor = Color.FromRgb(0,0,120);
        }
        public Schedule.TEvent RecordType { get; set; }
        public string RecordName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? RemindTime { get; set; }
        public Color RecordTypeColor { get; set; }
        public bool IsImportant { get; set; }
        public bool ShouldRemind { get; set; }
    }
}
