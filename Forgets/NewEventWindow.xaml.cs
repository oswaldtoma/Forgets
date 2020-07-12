using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Forgets
{
    /// <summary>
    /// Logika interakcji dla klasy NewEventWindow.xaml
    /// </summary>
    public partial class NewEventWindow : Window
    {
        private Schedule schedule = new Schedule();
        public NewEventWindow(ref Schedule schedule)
        {
            InitializeComponent();
            this.schedule = schedule;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var recordName = NameTextBox.Text;
            var description = DescriptionTextBox.Text;
            var startDate = StartTimeDatePicker.SelectedDate.Value == null ? Convert.ToDateTime(0) : StartTimeDatePicker.SelectedDate.Value;
            var startTime = Convert.ToDateTime($"{startDate.ToShortDateString()} {StartTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture);
            var endTime = (DateTime?)Convert.ToDateTime($"{EndTimeDatePicker.SelectedDate.Value.ToShortDateString()} {EndTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture);
            var location = LocationTextBox.Text;
            var isImportant = ImportantCheckBox.IsChecked.Value;
            var shouldRemind = RemindCheckbox.IsChecked.Value;
            var remindDate = RemindDatePicker.SelectedDate.Value;
            var remindTime = Convert.ToDateTime($"{remindDate.ToShortDateString()} {RemindTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture);


            bool areAllFieldsNotEmpty = false;

            areAllFieldsNotEmpty = !String.IsNullOrEmpty(recordName);
            areAllFieldsNotEmpty &= !String.IsNullOrEmpty(description);
            areAllFieldsNotEmpty &= !String.IsNullOrEmpty(location);
            areAllFieldsNotEmpty &= shouldRemind;

            if (areAllFieldsNotEmpty)
            {
                switch(EventType.Text)
                {
                    case "Spotkanie":
                    {
                        schedule.events.Add(new Meeting()
                        {
                            RecordName = recordName,
                            Description = description,
                            StartTime = startTime,
                            EndTime = endTime,
                            Location = location,
                            isImportant = isImportant,
                            RemindTime = remindTime
                        });
                    }
                    break;

                    case "Przypomnienie":
                    {
                        schedule.events.Add(new Reminder()
                        {
                            RecordName = recordName,
                            Description = description,
                            StartTime = startTime,
                            EndTime = endTime,
                            Location = location,
                            isImportant = isImportant,
                            RemindTime = remindTime
                        });
                    }
                    break;

                    case "Wizyta":
                    {
                        schedule.events.Add(new Appointment()
                        {
                            RecordName = recordName,
                            Description = description,
                            StartTime = startTime,
                            EndTime = endTime,
                            Location = location,
                            isImportant = isImportant,
                            RemindTime = remindTime
                        });
                    }
                    break;

                    case "Zajęcia":
                    {
                        schedule.events.Add(new Class()
                        {
                            RecordName = recordName,
                            Description = description,
                            StartTime = startTime,
                            EndTime = endTime,
                            Location = location,
                            isImportant = isImportant,
                            RemindTime = remindTime
                        });
                    }
                    break;

                    case "Zdarzenie":
                    {
                        schedule.events.Add(new Event()
                        {
                            RecordName = recordName,
                            Description = description,
                            StartTime = startTime,
                            EndTime = endTime,
                            Location = location,
                            isImportant = isImportant,
                            RemindTime = remindTime
                        });
                    }
                    break;
                }
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
