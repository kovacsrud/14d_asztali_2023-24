using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
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
using System.Net;
using System.Diagnostics;

namespace WpfRandomUser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RandomUsers users;
        public MainWindow()
        {
            InitializeComponent();
            comboboxDb.Items.Add(5);
            comboboxDb.Items.Add(10);
            comboboxDb.Items.Add(20);
            comboboxDb.Items.Add(30);
            comboboxDb.Items.Add(40);
            comboboxDb.Items.Add(50);
            comboboxDb.SelectedIndex = 0;
        }

        public RandomUsers GetUsers(int db)
        {
            JObject usersJson = JObject.Parse(new WebClient().DownloadString($"https://randomuser.me/api/?results={db}"));
            RandomUsers result = usersJson.ToObject<RandomUsers>();
            return result;
        }

        private void buttonLetolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                users = GetUsers((int)comboboxDb.SelectedItem);
                Debug.WriteLine(users.results.Count);
                datagridUsers.DataContext = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
