using Microsoft.Win32;
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

namespace WpfAutoadatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AutoLista autoLista;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.csv (csv fájlok)|*.csv";
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    autoLista = new AutoLista(dialog.FileName, ';');
                    datagridAutoAdatok.ItemsSource = autoLista.Autok;
                    tabitemAdatok.IsEnabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
                
            }
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            var kereses = textboxKeres.Text;
            if (kereses.Length>0)
            {
                var eredmeny = autoLista.Autok.FindAll(x => x.Marka.ToLower() == kereses.ToLower());
                if (eredmeny.Count>0)
                {
                    datagridAutoAdatok.ItemsSource = eredmeny;
                } else
                {
                    MessageBox.Show("Nincs találat!");
                }

            } else
            {
                MessageBox.Show("Adja meg a keresett márkát!");
            }
            
        }

        private void textboxKeres_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textboxKeres.Text.Length<1)
            {
                datagridAutoAdatok.ItemsSource = autoLista.Autok;
            }
        }
    }
}
