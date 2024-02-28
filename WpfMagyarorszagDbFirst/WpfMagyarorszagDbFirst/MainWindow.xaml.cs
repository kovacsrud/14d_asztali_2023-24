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
using WpfMagyarorszagDbFirst.mvvm.viewmodel;
using WpfMagyarorszagDbFirst.mvvm.views;

namespace WpfMagyarorszagDbFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TelepulesViewModel viewModel { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new TelepulesViewModel();
        }

        private void menuitemJogallasok_Click(object sender, RoutedEventArgs e)
        {
            JogallasView jogallasView = new JogallasView(viewModel);
            jogallasView.ShowDialog();
        }

        private void menuitemMegyek_Click(object sender, RoutedEventArgs e)
        {
            MegyeView megyeView=new MegyeView(viewModel);

            
            megyeView.ShowDialog();
        }

        private void menuitemTelepulesek_Click(object sender, RoutedEventArgs e)
        {
            TelepulesekView telepulesekView=new TelepulesekView(viewModel);
            telepulesekView.ShowDialog();
        }
    }
}