﻿using System;
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

        public ObservableCollection<IScheduleRecord> events = new ObservableCollection<IScheduleRecord>();

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
