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

namespace WpfIdojarasBongeszo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IdojarasLista idojarasLista;
        public MainWindow()
        {
            InitializeComponent();
            idojarasLista = new IdojarasLista("idojaras.csv", ';');
            listboxEvek.ItemsSource = idojarasLista.GetEvek();
        }

        private void listboxEvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            datagridIdojarasAdatok.ItemsSource = idojarasLista.GetAdatok((int)listboxEvek.SelectedItem);
            listboxHonapok.ItemsSource = idojarasLista.GetHonapok((int)listboxEvek.SelectedItem);
        }
    }
}
