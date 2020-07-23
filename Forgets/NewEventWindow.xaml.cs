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
        private Schedule schedule = null;
        private NewEvent newEvent = new NewEvent();
        public NewEventWindow(ref Schedule schedule)
        {
            InitializeComponent();
            this.schedule = schedule;
            StartTimeDatePicker.SelectedDate = DateTime.Now;
            EndTimeDatePicker.SelectedDate = DateTime.Now;
            RemindDatePicker.SelectedDate = DateTime.Now.AddDays(-1);
            this.DataContext = newEvent;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var recordName = newEvent.RecordName;
                var description = newEvent.Description;
                var startTime = Convert.ToDateTime($"{newEvent.StartDate.Value.ToShortDateString()} {StartTimePicker.Time.ToShortTimeString()}", CultureInfo.CurrentCulture);
                var endTime = Convert.ToDateTime($"{newEvent.EndDate.Value.ToShortDateString()} {EndTimePicker.Time.ToShortTimeString()}", CultureInfo.CurrentCulture);
                var location = newEvent.Location;
                var isImportant = newEvent.IsImportant;
                var shouldRemind = newEvent.ShouldRemind;
                var remindTime = new DateTime();

                if (shouldRemind)
                    remindTime = Convert.ToDateTime($"{newEvent.RemindDate.Value.ToShortDateString()} {RemindTimePicker.Time.ToShortTimeString()}", CultureInfo.CurrentCulture);

                bool areAllFieldsNotEmpty = false;

                areAllFieldsNotEmpty = !String.IsNullOrEmpty(recordName);
                areAllFieldsNotEmpty &= !String.IsNullOrEmpty(description);
                areAllFieldsNotEmpty &= !String.IsNullOrEmpty(location);
                areAllFieldsNotEmpty &= EventType.SelectedIndex != -1;

                if (areAllFieldsNotEmpty)
                {
                    switch (EventType.SelectedIndex)
                    {
                        case (int)Schedule.TEvent.TE_MEETING:
                        {
                            schedule.Events.Add(new Meeting()
                            {
                                RecordName = recordName,
                                Description = description,
                                StartTime = startTime,
                                EndTime = endTime,
                                Location = location,
                                IsImportant = isImportant,
                                RemindTime = remindTime,
                                ShouldRemind = shouldRemind
                            });
                        }
                        break;

                        case (int)Schedule.TEvent.TE_REMINDER:
                        {
                            schedule.Events.Add(new Reminder()
                            {
                                RecordName = recordName,
                                Description = description,
                                StartTime = startTime,
                                EndTime = endTime,
                                Location = location,
                                IsImportant = isImportant,
                                RemindTime = remindTime,
                                ShouldRemind = shouldRemind
                            });
                        }
                        break;

                        case (int)Schedule.TEvent.TE_APPOINTMENT:
                        {
                            schedule.Events.Add(new Appointment()
                            {
                                RecordName = recordName,
                                Description = description,
                                StartTime = startTime,
                                EndTime = endTime,
                                Location = location,
                                IsImportant = isImportant,
                                RemindTime = remindTime,
                                ShouldRemind = shouldRemind
                            });
                        }
                        break;

                        case (int)Schedule.TEvent.TE_CLASS:
                        {
                            schedule.Events.Add(new Class()
                            {
                                RecordName = recordName,
                                Description = description,
                                StartTime = startTime,
                                EndTime = endTime,
                                Location = location,
                                IsImportant = isImportant,
                                RemindTime = remindTime,
                                ShouldRemind = shouldRemind
                            });
                        }
                        break;

                        case (int)Schedule.TEvent.TE_EVENT:
                        {
                            schedule.Events.Add(new Event()
                            {
                                RecordName = recordName,
                                Description = description,
                                StartTime = startTime,
                                EndTime = endTime,
                                Location = location,
                                IsImportant = isImportant,
                                RemindTime = remindTime,
                                ShouldRemind = shouldRemind
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
            catch(Exception ex)
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
