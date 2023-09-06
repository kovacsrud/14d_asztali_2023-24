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

using Microsoft.Win32;

namespace WpfJackie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListBuild list;
        string fajlNev;

        public MainWindow()
        {
            InitializeComponent();
            fajlNev = "";
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            if (dialog.ShowDialog()==true)
            {
                list = new ListBuild(dialog.FileName, '\t');
                datagridAdatok.ItemsSource = list.JackieYears;
            }
        }
    }
}
