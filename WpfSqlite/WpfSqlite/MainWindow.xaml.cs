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
using System.Data.SQLite;
using System.Data;
using WpfSqlite.views.kutyak;
using System.Diagnostics;

namespace WpfSqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //DbRepo dbRepo = new DbRepo();

            //dbRepo.InsertKutya(1, 1, 11, "2023.10.11");
            //596 módosítása
            //dbRepo.UpdateKutya(596, 2, 2, 22, "2023.10.22");

            //dbRepo.DeleteKutya(596);

            //datagridKutyak.ItemsSource = dbRepo.GetData("select * from kutya");
            string connString = (string)Application.Current.FindResource("connString");

            Debug.WriteLine("---------------"+connString+"-----------------");

        }

        private void RendelesiAdatok_Click(object sender, RoutedEventArgs e)
        {
            KutyakWin kutyakWin = new KutyakWin();
            kutyakWin.ShowDialog();
        }
    }
}
