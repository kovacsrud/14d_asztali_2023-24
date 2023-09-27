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
using WpfKolcsonzes.mvvm.viewmodels;

namespace WpfKolcsonzes.mvvm.views
{
    /// <summary>
    /// Interaction logic for WinData.xaml
    /// </summary>
    public partial class WinData : Window
    {
        public WinData()
        {
            InitializeComponent();
            DataContext = new KolcsonzesViewModel();
        }
    }
}
