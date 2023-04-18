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

namespace WpfPassGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char[] kisBetuk = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q','r','s','t','u','v','w','x','y','z' };
        char[] szamok = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        char[] irasJelek = { '#', '@', '&', '?', '_', '$', '!', '%' };
        Random rand;
        public MainWindow()
        {
            InitializeComponent();
            rand = new Random();
            buttonVagolap.IsEnabled = false;
        }

        private void buttonGeneralas_Click(object sender, RoutedEventArgs e)
        {
            List<char> generaltJelszo = new List<char>();
            List<char> karakterekJelszohoz = new List<char>();
            if (checkboxKisbetu.IsChecked==true)
            {
                karakterekJelszohoz.AddRange(kisBetuk);
            }
            if (checkboxNagybetu.IsChecked==true)
            {
                for (int i = 0; i < kisBetuk.Length; i++)
                {
                    karakterekJelszohoz.Add(Char.ToUpper(kisBetuk[i]));
                }
            }
            if (checkboxSzam.IsChecked==true)
            {
                karakterekJelszohoz.AddRange(szamok);
            }
            if (checkboxIrasjel.IsChecked==true)
            {
                karakterekJelszohoz.AddRange(irasJelek);
            }

            if (karakterekJelszohoz.Count>0)
            {
                var kivalasztottElem = comboboxHossz.SelectedItem as ComboBoxItem;
                int hossz = Convert.ToInt32(kivalasztottElem.Content);

                for (int i = 0; i < hossz; i++)
                {
                    generaltJelszo.Add(karakterekJelszohoz[rand.Next(0,karakterekJelszohoz.Count)]);
                }
                textboxPassword.Text = new string(generaltJelszo.ToArray());
                buttonVagolap.IsEnabled = true;

            } else
            {
                MessageBox.Show("Legalább egy négyzetet jelöljön be!");
            }
        }

        private void buttonVagolap_Click(object sender, RoutedEventArgs e)
        {
            if (textboxPassword.Text.Length>0)
            {
                Clipboard.SetText(textboxPassword.Text);
            }
        }
    }
}
