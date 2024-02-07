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
using UnitsNet;
using WpfKonverter.mvvm.viewmodel;

namespace WpfKonverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new KonverterViewModel();
        }

        private void listboxMennyisegek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var vm=(KonverterViewModel)DataContext;
            if (listboxMennyisegek.SelectedItem!=null)
            {
                vm.KivalasztottMennyisegNev = listboxMennyisegek.SelectedItem.ToString();
                vm.InputMertekegysegek = vm.MertekegysegBetoltes();
                vm.OutputMertekegysegek = vm.MertekegysegBetoltes();
                listboxInMertekegyseg.SelectedIndex = 0;
                listboxOutMertekegyseg.SelectedIndex = 1;
            }
        }

        private void listboxInMertekegyseg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Konvertal();
        }

        private void listboxOutMertekegyseg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Konvertal();
        }
        private void Konvertal()
        {
            var vm = (KonverterViewModel)DataContext;
            if (listboxInMertekegyseg.SelectedItem!=null && listboxOutMertekegyseg.SelectedItem!=null && vm.InputErtek!=null)
            {
                vm.OutputErtek = UnitConverter.ConvertByName(vm.InputErtek, vm.KivalasztottMennyisegNev, vm.InputKivalasztott, vm.OutputKivalasztott);
            }
        }
    }
}
