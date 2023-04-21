﻿using System;
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

namespace WpfIdozito
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer(TimeSpan.FromSeconds(1),DispatcherPriority.Normal,valtas,Dispatcher.CurrentDispatcher);
            //timer.Start();
            timer.Stop();
            
        }

        private void valtas(object sender, EventArgs e)
        {
            if (textblockA.Visibility==Visibility.Visible)
            {
                textblockA.Visibility = Visibility.Hidden;
                textblockB.Visibility = Visibility.Visible;
            } else
            {
                textblockA.Visibility = Visibility.Visible;
                textblockB.Visibility = Visibility.Hidden;
            }
        }

        private void buttonTimer_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = !timer.IsEnabled;
            if (timer.IsEnabled)
            {
                buttonTimer.Content = "Stop";
            } else
            {
                buttonTimer.Content = "Start";
            }
        }
    }
}
