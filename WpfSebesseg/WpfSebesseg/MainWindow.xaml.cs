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

namespace WpfSebesseg
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

        private void buttomSzamol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioMs.IsChecked==true)
                {
                    textblockEredmeny.Text = Converter.KmhToMs(Convert.ToDouble(textboxKmh.Text)).ToString();
                } else
                {
                    textblockEredmeny.Text = Converter.KmhToMph(Convert.ToDouble(textboxKmh.Text)).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hiba");
            }
        }
    }
}
