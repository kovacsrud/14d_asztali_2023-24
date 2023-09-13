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
        
        

        public MainWindow()
        {
            InitializeComponent();
        
            
        }

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == true)
                {
                    list = new ListBuild(dialog.FileName, '\t');

                    //datagridAdatok.ItemsSource = list.JackieYears;
                    //datagridAdatok.DataContext = list;
                    DataContext = list;
                    comboYears.SelectedIndex = 0;

                    
                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }

        private void buttonKeres_Click(object sender, RoutedEventArgs e)
        {
            EvKeres();

        }

        private void EvKeres()
        {
            datagridAdatok.ItemsSource = null;
            try
            {
                //var ev = Convert.ToInt32(textboxKeres.Text);
                var ev = (int)comboYears.SelectedValue;

                var result = list.JackieYears.FindAll(x => x.Year == ev);
                if (result.Count > 0)
                {
                    datagridAdatok.ItemsSource = result;
                }
                else
                {
                    MessageBox.Show("Nincs találat!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVissza_Click(object sender, RoutedEventArgs e)
        {
            datagridAdatok.ItemsSource = list.JackieYears;
        }

        private void comboYears_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EvKeres();
        }
    }
}
