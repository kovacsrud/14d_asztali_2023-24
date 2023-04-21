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

namespace WpfKepek
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

        private void buttonMegnyit_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg képek(*.jpg)|*.jpg|minden fájl|*.*";
            if (dialog.ShowDialog()==true)
            {
                var bitmap = new BitmapImage(new Uri(dialog.FileName));
                kep2.Source = bitmap;
            }
        }

        private void buttonTobbMegnyit_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg képek(*.jpg)|*.jpg|minden fájl|*.*";
            dialog.Multiselect = true;
            try
            {
                if (dialog.ShowDialog()==true)
                {
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        var image = new Image();
                        var bitmap = new BitmapImage(new Uri(dialog.FileNames[i]));
                        image.Source = bitmap;
                        wrapKepek.Children.Add(image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }

        }
    }
}
