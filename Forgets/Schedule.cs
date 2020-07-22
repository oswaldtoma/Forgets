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
            Events.CollectionChanged += OnEventsChanged;
            CompareCollectionsAndEqualize();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public DbManager DatabaseManager = new DbManager();
        public ObservableCollection<IScheduleRecord> Events = new ObservableCollection<IScheduleRecord>();

        private void CompareCollectionsAndEqualize()
        {
            if (DatabaseManager.scheduleRecords.Any())
            {
                for (int i = 0; i < DatabaseManager.scheduleRecords.Count(); i++)
                {
                    if (Events[i] != DatabaseManager.scheduleRecords.ToList()[i])
                    {
                        Events[i] = DatabaseManager.scheduleRecords.ToList()[i];
                    }
                }
            }
            else if (Events.Any())
            {
                for (int i = 0; i < Events.Count(); i++)
                {
                    if (DatabaseManager.scheduleRecords.ToList()[i] != Events[i])
                    {
                        DatabaseManager.scheduleRecords.ToList()[i] = Events[i];
                    }
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
            }

            if(e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    DatabaseManager.scheduleRecords.Remove((IScheduleRecord)item);
                }
            }
        }
    }
}
