using System;
using System.Collections.Generic;
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
    /// Logika interakcji dla klasy TimePicker.xaml
    /// </summary>
    public partial class TimePicker : UserControl, INotifyPropertyChanged
    {
        private object selectedTextBox;
        
        public TimePicker()
        {
            InitializeComponent();
            HrTextBox.AddHandler(FrameworkElement.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TextBox_MouseLeftButtonDown), true);
            MinTextBox.AddHandler(FrameworkElement.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TextBox_MouseLeftButtonDown), true);
            SecTextBox.AddHandler(FrameworkElement.MouseLeftButtonDownEvent, new MouseButtonEventHandler(TextBox_MouseLeftButtonDown), true);
            selectedTextBox = HrTextBox;
            PropertyChanged += ShowSeconds_Changed;
            SecTextBox.Visibility = ShowSeconds ? Visibility.Visible : Visibility.Hidden;
            SecLabel.Visibility = ShowSeconds ? Visibility.Visible : Visibility.Hidden;
        }

        public DateTime Time
        {
            get
            {
                return (DateTime)GetValue(TimeProperty);
            }
            set
            {
                SetValue(TimeProperty, value);
            }
        }

        public bool ShowSeconds
        {
            get
            {
                return (bool)GetValue(ShowSecondsProperty);
            }
            set
            {
                SetValue(ShowSecondsProperty, value);
                OnPropertyChanged("ShowSeconds");
            }
        }

        public static DependencyProperty TimeProperty =
            DependencyProperty.Register("Time", typeof(DateTime), typeof(TimePicker), new PropertyMetadata(Convert.ToDateTime("12:00:00")));

        public static DependencyProperty ShowSecondsProperty =
            DependencyProperty.Register("ShowSeconds", typeof(bool), typeof(TimePicker), new PropertyMetadata(false));

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ShowSeconds_Changed(object sender, PropertyChangedEventArgs e)
        {
            SecTextBox.Visibility = ShowSeconds ? Visibility.Visible : Visibility.Hidden;
            SecLabel.Visibility = ShowSeconds ? Visibility.Visible : Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var textbox = selectedTextBox as TextBox;
            var numValue = Convert.ToUInt16(textbox.Text);

            bool isHourTextBox = textbox.Name == "HrTextBox";
            const ushort hoursUpperBoundary = 23;
            const ushort otherUpperBoundary = 59;
            ushort upperBoundary = isHourTextBox ? hoursUpperBoundary : otherUpperBoundary;

            switch (button.Name)
            {
                case "IncButton":
                {
                    if(numValue < upperBoundary)
                    {
                        numValue++;
                    }
                    else
                    {
                        numValue = 0;
                    }

                    if(numValue >= 0 && numValue < 10)
                    {
                        textbox.Text = $"0{numValue}";
                    }
                    else
                    {
                        textbox.Text = numValue.ToString();
                    }
                }
                break;

                case "DecButton":
                {
                    if (numValue > 0)
                    {
                        numValue--;
                    }
                    else
                    {
                        numValue = upperBoundary;
                    }

                    if (numValue >= 0 && numValue < 10)
                    {
                        textbox.Text = $"0{numValue}";
                    }
                    else
                    {
                        textbox.Text = numValue.ToString();
                    }
                }
                break;
            }
        }

        private void TextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            selectedTextBox = sender;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.IsLoaded)
            {
                try
                {
                    Time = Convert.ToDateTime($"{HrTextBox.Text}:{MinTextBox.Text}:{SecTextBox.Text}");
                }
                catch (Exception)
                {
                    var textbox = sender as TextBox;
                    textbox.Clear();
                }

            }
        }
    }
}
