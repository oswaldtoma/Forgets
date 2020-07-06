using System;
using System.Windows.Media;

namespace Forgets
{
    public class Meeting : IScheduleRecord
    {
        public Meeting()
        {
            RecordType = Misc.TEvent.TE_MEETING;
            RecordTypeColor = Color.FromRgb(255,0,0);
        }
        public Misc.TEvent RecordType { get; set; }
        public string RecordName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime RemindTime { get; set; }
        public Color RecordTypeColor { get; set; }
        public bool isImportant { get; set; }
    }
}
