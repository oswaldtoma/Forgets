using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
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
        NotifyIcon trayIcon = new NotifyIcon();

        int prevMinutes = DateTime.Now.Minute;

        public MainWindow()
        {
            InitializeComponent();
            dailySchedule.ItemsSource = schedule.Events;
            Calendar.SelectedDate = DateTime.Today;
            CollectionView collectionView = (CollectionView)CollectionViewSource.GetDefaultView(dailySchedule.ItemsSource);
            collectionView.Filter = EventFilter;
            this.DataContext = schedule;

            trayIcon.Icon = new Icon("icon.ico");
            trayIcon.Visible = true;
            trayIcon.DoubleClick += TrayIcon_DoubleClick;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += Timer_Tick;
            timer.Start();

            this.WindowState = WindowState.Minimized;
            this.Hide();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ScheduleRecord recordToRemind = null; 

            if(prevMinutes != DateTime.Now.Minute)
            {
                recordToRemind = schedule.Events.Where(x => x.RemindTime == Convert.ToDateTime($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}")).FirstOrDefault();
            }

            prevMinutes = DateTime.Now.Minute;

            if (recordToRemind != null)
            {
                var title = TEventToStringConverter.Convert(recordToRemind.RecordType).ToString();

                if (recordToRemind.IsImportant)
                {
                    title = $"Important {title.ToLower()}";
                }

                var text = $"{recordToRemind.RecordName} \n" +
                    $"{recordToRemind.Description} \n" +
                    $"Start Time: {recordToRemind.StartTime.Value.ToString("dd.MM.yyyy hh:mm")}";

                trayIcon.ShowBalloonTip(5000, title, text, ToolTipIcon.Info);
            }
        }

        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = WindowState.Normal;
        }

        private bool EventFilter(object item)
        {
            var eventVar = item as ScheduleRecord;

            if (Calendar.SelectedDate.HasValue)
            {
                return eventVar.StartTime.Value.ToShortDateString() == Calendar.SelectedDate.Value.ToShortDateString();
            }
            else
                return false;
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(dailySchedule.ItemsSource).Refresh();
        }

        private void NewEventButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new NewEventWindow(ref schedule);
            window.ShowDialog();
        }

        private void removeEventButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecords = dailySchedule.SelectedItems.Cast<ScheduleRecord>().ToList();

            foreach (var item in selectedRecords)
            {
                schedule.Events.Remove(item);
            }
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
                this.Hide();
        }
    }
}
