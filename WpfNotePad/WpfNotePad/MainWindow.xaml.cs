using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfNotePad
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

        private void Menu_Kilepes(object sender,RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Menu_Nevjegy(object sender,RoutedEventArgs e)
        {
            Nevjegy nevjegy = new Nevjegy();
            nevjegy.ShowDialog();
        }

        private void Menu_Megnyit(object sender,RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "szöveg (*.txt)|*.txt|adatfájl (*.csv)|*.csv|minden fájl (*.*)|*.*";
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    textboxSzoveg.Text = File.ReadAllText(dialog.FileName,Encoding.Default);
                    this.Title = dialog.FileName;
                    //this.Title = dialog.FileName.Split('\\').Last();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
        }

        private void Menu_Mentes(object sender, RoutedEventArgs e)
        {

        }

        private void Menu_MentesMaskent(object sender, RoutedEventArgs e)
        {

        }
    }
}
