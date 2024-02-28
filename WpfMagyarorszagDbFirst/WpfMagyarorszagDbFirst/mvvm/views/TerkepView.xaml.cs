using Microsoft.Maps.MapControl.WPF;
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
using System.Windows.Shapes;
using WpfMagyarorszagDbFirst.mvvm.viewmodel;

namespace WpfMagyarorszagDbFirst.mvvm.views
{
    /// <summary>
    /// Interaction logic for TerkepView.xaml
    /// </summary>
    public partial class TerkepView : Window
    {
        public TerkepView(TelepulesViewModel vm)
        {
            InitializeComponent();
            map.Center = new Location(vm.SelectedTelepules.Lat, vm.SelectedTelepules.Long);
            map.ZoomLevel = 12;

        }
    }
}
