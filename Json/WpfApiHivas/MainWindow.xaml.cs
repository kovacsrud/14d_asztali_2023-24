using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WpfApiHivas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        JObject posts;
        UserResult result;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                posts = JObject.Parse(new WebClient().DownloadString("https://reqres.in/api/users"));

                result = posts.ToObject<UserResult>();

                DataContext = result;

                //for (int i = 0; i < result.data.Count; i++)
                //{
                //    Debug.WriteLine(result.data[i].first_name);
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
