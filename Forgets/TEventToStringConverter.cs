using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Forgets
{
    class TEventToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch((Schedule.TEvent)value)
            {
                case Schedule.TEvent.TE_MEETING: return "Meeting";
                case Schedule.TEvent.TE_REMINDER: return "Reminder";
                case Schedule.TEvent.TE_APPOINTMENT: return "Appointment";
                case Schedule.TEvent.TE_CLASS: return "Class";
                case Schedule.TEvent.TE_EVENT: return "Event";
                default: return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
