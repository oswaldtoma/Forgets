using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Forgets
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Schedule schedule = new Schedule();
        public MainWindow()
        {
            InitializeComponent();
            dailySchedule.ItemsSource = schedule.events;
            Calendar.SelectedDate = DateTime.Today;
            CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(dailySchedule.ItemsSource);
            collectionView.Filter = EventFilter;
            this.DataContext = schedule;

            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon("icon.ico");
            trayIcon.Visible = true;
            trayIcon.DoubleClick += TrayIcon_DoubleClick;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var recordToRemind = schedule.events.Where(x => x.StartTime == DateTime.Now);
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
        }

        private bool EventFilter(object item)
        {
            var eventVar = item as IScheduleRecord;

            if (Calendar.SelectedDate.HasValue)
            {
                return eventVar.StartTime.Value.ToShortDateString() == Calendar.SelectedDate.Value.ToShortDateString();
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
            schedule.events.Add(new Meeting()
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
            schedule.events.Add(new Meeting()
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
            Window window = new NewEventWindow(ref schedule);
            window.ShowDialog();
        }

        private void removeEventButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecords = dailySchedule.SelectedItems.Cast<IScheduleRecord>().ToList();

            foreach (var item in selectedRecords)
            {
                schedule.events.Remove(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test2_Click(sender, e);
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
                this.Hide();
        }
    }
}
