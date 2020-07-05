using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            Calendar.SelectedDate = DateTime.Today;
            CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(dailySchedule.ItemsSource);
            collectionView.Filter = AppointmentFilter;
            this.DataContext = schedule;
        }

        private bool AppointmentFilter(object item)
        {
            var appointment = item as Appointment;

            if (Calendar.SelectedDate.HasValue)
            {
                return appointment.StartTime.Date == Calendar.SelectedDate;
            }
            else
                return false;
        }

        private void ListView_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            Console.WriteLine("TAK");
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            schedule.appointments.Add(new Appointment()
            {
                RecordName = "Meeting z Januszem",
                Description = "Wypad do Janusza na piwo",
                StartTime = Convert.ToDateTime("01-07-2020 20:00"),
                EndTime = Convert.ToDateTime("01-07-2020 23:00"),
                Location = "Andrychów"
                
            });
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dailySchedule.ItemsSource).Refresh();
        }

        private void test2_Click(object sender, RoutedEventArgs e)
        {
            schedule.appointments.Add(new Appointment()
            { 
                RecordName = "Narada wewnętrzna",
                Description = "Opis",
                StartTime = Convert.ToDateTime("02-07-2020 20:00"),
                EndTime = Convert.ToDateTime("02-07-2020 23:00"),
                Location = "Kraków"
            });
        }

        private void NewEventButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new NewEventWindow();
            window.ShowDialog();
        }
    }
}
