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
using System.Windows.Shapes;
using WpfMagyarorszagDbFirst.mvvm.models;
using WpfMagyarorszagDbFirst.mvvm.viewmodel;

namespace WpfMagyarorszagDbFirst.mvvm.views
{
    /// <summary>
    /// Interaction logic for TelepulesekView.xaml
    /// </summary>
    public partial class TelepulesekView : Window
    {
        public TelepulesekView(TelepulesViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void datagridTelepulesek_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var vm=(TelepulesViewModel)DataContext;
            vm.SelectedTelepules = datagridTelepulesek.SelectedItem as Telepulesek;
            TerkepView terkepView=new TerkepView(vm);
            terkepView.ShowDialog();
        }
    }
}
