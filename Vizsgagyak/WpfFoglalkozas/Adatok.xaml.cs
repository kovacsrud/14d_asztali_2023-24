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
using System.Windows.Shapes;
using Vizsgagyak;

namespace WpfFoglalkozas
{
    /// <summary>
    /// Interaction logic for Adatok.xaml
    /// </summary>
    public partial class Adatok : Window
    {
        List<Dolgozo> dolgozok = new List<Dolgozo>();
        public Adatok(List<Dolgozo> adatok)
        {
            InitializeComponent();
            dolgozok = adatok;
            datagridDolgozok.ItemsSource = dolgozok;
        }
    }
}
