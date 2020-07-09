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
            var startTime = Convert.ToDateTime($"{StartTimeDatePicker.SelectedDate.Value.ToShortDateString()} {StartTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture);
            var endTime = Convert.ToDateTime($"{EndTimeDatePicker.SelectedDate.Value.ToShortDateString()} {EndTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture);
            var location = LocationTextBox.Text;
            var isImportant = ImportantCheckBox.IsChecked.Value;
            var remindTime = Convert.ToDateTime($"{RemindDatePicker.SelectedDate.Value.ToShortDateString()} {RemindTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture);


            bool areAllFieldsNotEmpty = false;

            areAllFieldsNotEmpty = !String.IsNullOrEmpty(recordName);
            areAllFieldsNotEmpty &= !String.IsNullOrEmpty(description);
            areAllFieldsNotEmpty &= !String.IsNullOrEmpty(location);

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
