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
                case Schedule.TEvent.TE_MEETING: return "Spotkanie";
                case Schedule.TEvent.TE_REMINDER: return "Przypomnienie";
                case Schedule.TEvent.TE_APPOINTMENT: return "Wizyta";
                case Schedule.TEvent.TE_CLASS: return "Zajęcia";
                case Schedule.TEvent.TE_EVENT: return "Wydarzenie";
                default: return "Unknown";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
