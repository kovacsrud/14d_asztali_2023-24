using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfKutyakDbFirst.Models;
using WpfKutyakDbFirst.Views;

namespace WpfKutyakDbFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new KutyaViewModel();
        }

        private void buttonMentes_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            //var vm=(KutyaViewModel)DataContext;

            vm.DbMentes();
            
          
        }

        private void menuitemKutyafajta_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            KutyafajtaWin kutyafajtaWin = new KutyafajtaWin(vm);
            try
            {
                kutyafajtaWin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }

        private void menuitemKutyanev_Click(object sender, RoutedEventArgs e)
        {
            var vm=DataContext as KutyaViewModel;
            KutyanevWin kutyanevWin = new KutyanevWin(vm);
            try
            {
                kutyanevWin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }

        private void menuitemUjRendelesiadat_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as KutyaViewModel;
            KutyaWin kutyaWin = new KutyaWin(vm,datagridKutyak);
            kutyaWin.ShowDialog();
        }

        private void datagridKutyak_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            var vm = DataContext as KutyaViewModel;
            vm.SelectedKutya=datagridKutyak.SelectedItem as Kutya;
            KutyaWin kutyaWin=new KutyaWin(vm,datagridKutyak,true);
            kutyaWin.ShowDialog();
        }
    }
}