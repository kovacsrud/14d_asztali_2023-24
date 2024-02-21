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
using WpfKutyakDbFirst.Models;

namespace WpfKutyakDbFirst.Views
{
    /// <summary>
    /// Interaction logic for KutyanevWin.xaml
    /// </summary>
    public partial class KutyanevWin : Window
    {
        public KutyanevWin(KutyaViewModel vm)
        {
            InitializeComponent();
            DataContext=vm;
        }

        private void buttonKutyanevek_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            //var vm=(KutyaViewModel)DataContext;
            vm.DbMentes();
          
        }
    }
}
