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

namespace WpfHomerseklet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var homerseklet = Convert.ToDouble(textboxHomerseklet.Text);
                if (radioCelsius.IsChecked==true)
                {
                    var celsius = (homerseklet - 32) / 1.8;
                    textblockEredmeny.Text = $"{celsius:0.00} C";

                } else
                {
                    var fahrenheit = (homerseklet * 1.8) + 32;
                    textblockEredmeny.Text = $"{fahrenheit:0.00} F";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            
        }
    }
}
