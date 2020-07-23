using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Entity;
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

        public Schedule()
        {
            CompareCollectionsAndMirror();
            Events.CollectionChanged += OnEventsChanged;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public DbManager DatabaseManager = new DbManager();
        public ObservableCollection<IScheduleRecord> Events = new ObservableCollection<IScheduleRecord>();

        private void CompareCollectionsAndMirror()
        {
            if (DatabaseManager.scheduleRecords.Any())
            {
                foreach (var item in DatabaseManager.scheduleRecords)
                {
                    Events.Add(item);
                }
            }
        }

        private void OnEventsChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    DatabaseManager.scheduleRecords.Add((IScheduleRecord)item);
                }
                DatabaseManager.SaveChanges();
            }

            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    DatabaseManager.scheduleRecords.Remove((IScheduleRecord)item);
                }
                DatabaseManager.SaveChanges();
            }
        }
    }
}
