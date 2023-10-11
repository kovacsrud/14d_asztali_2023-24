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
using System.Data.SQLite;

namespace WpfSqlite.views.kutyak
{
    /// <summary>
    /// Interaction logic for KutyakWin.xaml
    /// </summary>
    public partial class KutyakWin : Window
    {
        public KutyakWin()
        {
            InitializeComponent();
            DbRepo dbRepo = new DbRepo();
            datagridKutya.ItemsSource = dbRepo.GetData("select * from kutya");
        }
    }
}
