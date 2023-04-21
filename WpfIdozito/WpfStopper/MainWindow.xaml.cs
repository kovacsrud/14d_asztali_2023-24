using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace WpfStopper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        TimeSpan time;
        public MainWindow()
        {
            InitializeComponent();
            time = new TimeSpan(0, 0, 0, 0, 0);
            timer = new DispatcherTimer(TimeSpan.FromMilliseconds(10),DispatcherPriority.Normal,stopper,Dispatcher.CurrentDispatcher);
            timer.Stop();
            textblockIdo.Text = time.ToString("hh':'mm':'ss':'ff");
        }

        private void stopper(object sender, EventArgs e)
        {
            time = time.Add(TimeSpan.FromMilliseconds(10));
            textblockIdo.Text = time.ToString("hh':'mm':'ss':'ff");
        }

        private void buttonStopper_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
            if (timer.IsEnabled)
            {
                buttonStopper.Content = "Stop";
            } else
            {
                buttonStopper.Content = "Start";
            }
        }
    }
}
