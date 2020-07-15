using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Forgets
{
    public class Schedule : INotifyPropertyChanged
    {
        public enum TEvent
        {
            TE_MEETING,
            TE_REMINDER,
            TE_APPOINTMENT,
            TE_CLASS,
            TE_EVENT
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<IScheduleRecord> events = new ObservableCollection<IScheduleRecord>();

        public string RecordName { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public string StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndTime { get; set; }
        public string Location { get; set; }
        public bool isImportant { get; set; }
        public bool shouldRemind { get; set; }
        public DateTime? remindDate { get; set; }
        public string remindTime { get; set; }
    }
}
