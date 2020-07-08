using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
            schedule.events.Add(new Meeting()
            {
                RecordName = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                StartTime = Convert.ToDateTime($"{StartTimeDatePicker.SelectedDate.Value.ToShortDateString()} {StartTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture),
                EndTime = Convert.ToDateTime($"{EndTimeDatePicker.SelectedDate.Value.ToShortDateString()} {EndTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture),
                Location = LocationTextBox.Text,
                isImportant = ImportantCheckBox.IsChecked.Value,
                RemindTime = Convert.ToDateTime($"{RemindDatePicker.SelectedDate.Value.ToShortDateString()} {RemindTimePicker.getTime().ToShortTimeString()}", CultureInfo.CurrentCulture),
            });

            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
