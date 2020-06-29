using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forgets
{
    public class Schedule
    {
        public ObservableCollection<Appointment> appointments = new ObservableCollection<Appointment>();
    }
}
