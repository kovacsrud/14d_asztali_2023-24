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

namespace WpfDinamikus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gombok(200);
        }

        private void Gombok(int darab)
        {
            for (int i = 0; i < darab; i++)
            {
                Button gomb = new Button();
                gomb.Width = 100;
                gomb.Margin = new Thickness(2);
                gomb.Content = $"{i+1}";
                wrapPanelGombok.Children.Add(gomb);
            }
        }
    }
}
