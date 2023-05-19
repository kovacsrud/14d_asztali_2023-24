using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace WpfVizallas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MeresAdatok meresAdatok;
        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            meresAdatok = new MeresAdatok();
            JObject vizallasJson = JObject.Parse(
                new WebClient().DownloadString("http://localhost:8000/meresek")
            );

            meresAdatok = vizallasJson.ToObject<MeresAdatok>();
            datagridVizallasAdatok.ItemsSource = meresAdatok.meresek;
        }

        private async void buttonKuld_Click(object sender, RoutedEventArgs e)
        {
            // await AdatKuldes();
            DataWin dataWin = new DataWin(this);
            dataWin.ShowDialog();
        }

        public async void AdatKuldes(Meresek data,string method)
        {
            var client = new HttpClient();

            HttpResponseMessage res = null;

            if (method=="post")
            {
                 res = await client.PostAsJsonAsync("http://localhost:8000/meres", data);
            }
            if (method=="put")
            {
                 res = await client.PutAsJsonAsync("http://localhost:8000/meres", data);
            }
           
            

            if (res.IsSuccessStatusCode)
            {
                MessageBox.Show("Adat beszúrva");
                GetData();
            }
            else
            {
                MessageBox.Show("Hiba");
            }
        }

        private void datagridVizallasAdatok_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedData = datagridVizallasAdatok.SelectedItem as Meresek;
            //Debug.WriteLine(selectedData.ido);
            DataWin dataWin = new DataWin(this,selectedData);
            dataWin.ShowDialog();

        }
    }
}
