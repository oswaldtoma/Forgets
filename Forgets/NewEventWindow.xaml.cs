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
            StartTimeDatePicker.SelectedDate = DateTime.Now;
            EndTimeDatePicker.SelectedDate = DateTime.Now;
            RemindDatePicker.SelectedDate = DateTime.Now.AddDays(-1);
            this.DataContext = schedule;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            var recordName = schedule.RecordName;
            var description = schedule.Description;
            var startTime = Convert.ToDateTime($"{schedule.StartDate.Value.ToShortDateString()} {StartTimePicker.Time.ToShortTimeString()}", CultureInfo.CurrentCulture);
            var endTime = Convert.ToDateTime($"{schedule.EndDate.Value.ToShortDateString()} {EndTimePicker.Time.ToShortTimeString()}", CultureInfo.CurrentCulture);
            var location = schedule.Location;
            var isImportant = schedule.IsImportant;
            var shouldRemind = schedule.ShouldRemind;
            var remindTime = Convert.ToDateTime($"{schedule.RemindDate.Value.ToShortDateString()} {RemindTimePicker.Time.ToShortTimeString()}", CultureInfo.CurrentCulture);


            bool areAllFieldsNotEmpty = false;

            areAllFieldsNotEmpty = !String.IsNullOrEmpty(recordName);
            areAllFieldsNotEmpty &= !String.IsNullOrEmpty(description);
            areAllFieldsNotEmpty &= !String.IsNullOrEmpty(location);
            areAllFieldsNotEmpty &= EventType.SelectedIndex != -1;

            if (areAllFieldsNotEmpty)
            {
                switch(EventType.SelectedIndex)
                {
                    case (int)Schedule.TEvent.TE_MEETING:
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

                    case (int)Schedule.TEvent.TE_REMINDER:
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

                    case (int)Schedule.TEvent.TE_APPOINTMENT:
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

                    case (int)Schedule.TEvent.TE_CLASS:
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

                    case (int)Schedule.TEvent.TE_EVENT:
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
            else
            {
                MessageBox.Show("Make sure all required fields are filled!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
