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

namespace WpfVizallas
{
    /// <summary>
    /// Interaction logic for DataWin.xaml
    /// </summary>
    public partial class DataWin : Window
    {
        MainWindow mainWindow;
        string method = "";

        //Dependency injection
        public DataWin(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            method = "post";
        }

        public DataWin(MainWindow mainWindow,Meresek meresadat)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            textboxId.Text = meresadat.id.ToString();
            textboxVmId.Text = meresadat.vmId.ToString();
            textboxNap.Text = meresadat.nap;
            textboxIdo.Text = meresadat.ido;
            textboxVizallas.Text = meresadat.vizAllas.ToString();
            method = "put";

        }

        private void buttonKuldes_Click(object sender, RoutedEventArgs e)
        {
            var megerosites = MessageBox.Show("Biztosan felviszi az adatot?", "Új adat",MessageBoxButton.OKCancel,MessageBoxImage.Question);
            if (megerosites==MessageBoxResult.OK)
            {
                //MessageBox.Show("Adatküldés");
                try
                {
                    Meresek ujadat = new Meresek
                    {
                        id = Convert.ToInt32(textboxId.Text),
                        vmId = Convert.ToInt32(textboxVmId.Text),
                        nap = textboxNap.Text,
                        ido = textboxIdo.Text,
                        vizAllas = Convert.ToInt32(textboxVizallas.Text)
                    };
                    mainWindow.AdatKuldes(ujadat,method);
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
                
            }
        }
    }
}
