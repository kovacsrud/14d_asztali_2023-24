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
        bool modositva = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_Kilepes(object sender,RoutedEventArgs e)
        {
            if (modositva)
            {
                var valasz = MessageBox.Show("Akarja menteni a változásokat?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (valasz==MessageBoxResult.OK)
                {
                    MentesMaskent();
                } else
                {
                    Environment.Exit(0);
                }
            }
            
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
                    modositva = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
        }

        private void Menu_Mentes(object sender, RoutedEventArgs e)
        {
            if (this.Title=="Notepad")
            {
                MentesMaskent();
            } else
            {
                try
                {
                    File.WriteAllText(this.Title, textboxSzoveg.Text, Encoding.Default);
                    modositva = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Menu_MentesMaskent(object sender, RoutedEventArgs e)
        {
            MentesMaskent();
        }

        private void MentesMaskent()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "szöveg (*.txt)|*.txt|adatfájl (*.csv)|*.csv|minden fájl (*.*)|*.*";

            if (dialog.ShowDialog()==true)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, textboxSzoveg.Text, Encoding.Default);
                    this.Title = dialog.FileName;
                    modositva = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
            }

        }

        private void Menu_Kivagas(object sender,RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length>0)
            {
                Clipboard.SetText(textboxSzoveg.SelectedText);

                textboxSzoveg.Text = textboxSzoveg.Text.Remove(textboxSzoveg.CaretIndex,textboxSzoveg.SelectedText.Length);
                menuitemBeillesztes.IsEnabled = true;
            }
        }

        private void Menu_Masolas(object sender, RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length>0)
            {
                Clipboard.SetText(textboxSzoveg.SelectedText);
                menuitemBeillesztes.IsEnabled = true;
            }
        }
        private void Menu_Beillesztes(object sender, RoutedEventArgs e)
        {
            var vagolapSzoveg = Clipboard.GetText();
            textboxSzoveg.Text = textboxSzoveg.Text.Insert(textboxSzoveg.CaretIndex,vagolapSzoveg);
        }

        private void textboxSzoveg_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (textboxSzoveg.SelectedText.Length>0)
            {
                menuitemKivagas.IsEnabled = true;
                menuitemMasolas.IsEnabled = true;
            }
            if (textboxSzoveg.SelectedText.Length < 1)
            {
                menuitemKivagas.IsEnabled = false;
                menuitemMasolas.IsEnabled = false;
            }
        }

        private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            modositva = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (modositva)
            {
                var valasz = MessageBox.Show("Akarja menteni a változásokat?", "Figyelem!", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (valasz == MessageBoxResult.OK)
                {
                    MentesMaskent();
                }
                
            }
        }
    }
}
