using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Forgets
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Schedule schedule = new Schedule();
        public MainWindow()
        {
            InitializeComponent();
            dailySchedule.ItemsSource = schedule.appointments;
            this.DataContext = schedule;
        }

        private void ListView_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            Console.WriteLine("TAK!");
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            schedule.appointments.Add(new Appointment()
            {
                RecordType = "Spotkanie",
                RecordName = "Meeting z Januszem",
                Description = "Wypad do Janusza na piwo",
                StartTime = Convert.ToDateTime("01-06-2020 20:00"),
                EndTime = Convert.ToDateTime("01-06-2020 23:00"),
                Location = "Andrychów"
                
            });
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;

            if(calendar.SelectedDate.HasValue)
                dailySchedule.ItemsSource = schedule.appointments.Where(x => x.StartTime.Date == calendar.SelectedDate);
        }
    }
}
