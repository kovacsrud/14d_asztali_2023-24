using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaLista mediaLista { get; set; }
        DispatcherTimer mediaTimer;
        double Totaltime;
        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer.LoadedBehavior = MediaState.Manual;
            mediaLista=new MediaLista();
            listboxMedia.DataContext = mediaLista;
            mediaTimer = new DispatcherTimer();
            //mediaPlayer.Source = new Uri(@"D:\rud\kodtarak\13d_asztali_2023\WpfPlayer\WpfPlayer\bin\Debug\net7.0-windows\liget_video.mp4");
           // mediaPlayer.Play();
            
            
        }

        private void Play_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Play();
            if (!mediaTimer.IsEnabled)
            {
                mediaTimer.Start();
            }
        }

        private void Pause_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Pause();
            if (mediaTimer.IsEnabled)
            {
                mediaTimer.Stop();
            }
        }

        private void Stop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            mediaPlayer.Stop();
            if (mediaTimer.IsEnabled)
            {
                mediaTimer.Stop();
            }
        }

        private void Open_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "mp4|*.mp4|mp3|*.mp3|mpg|*.mpg|avi|*.avi|minden fájl|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    //mediaPlayer.Source = new Uri(dialog.FileName);
                    //mediaPlayer.Play();
                    //this.Title= dialog.FileName.Split('\\').Last();
                    if (dialog.FileNames.Length > 0)
                    {
                        mediaLista.SetMediaList(dialog.FileNames, '\\');
                        listboxMedia.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message,"Hiba!",MessageBoxButton.OK, MessageBoxImage.Error);                    
                }
                
            }
        }

        private void listboxMedia_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MediaElem aktualisElem= listboxMedia.SelectedItem as MediaElem;
            mediaPlayer.Source = new Uri(aktualisElem.TeljesUtvonal);

            //MediaElem aktualisElem =(MediaElem)listboxMedia.SelectedItem;

        }

        private void SliderUpdate(object sender,EventArgs e)
        {
            if (Totaltime>0)
            {
                var setval = mediaPlayer.Position.TotalMilliseconds;
                mediaSlider.Value = setval;
            }
        }

        private void mediaPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.NaturalDuration.HasTimeSpan)
            {
                mediaSlider.Maximum=mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
                Totaltime= mediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds;
            }

            mediaTimer.Interval = TimeSpan.FromSeconds(1);
            mediaTimer.Tick += SliderUpdate;
            mediaTimer.Start();
            
        }

        private void mediaSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            TimeSpan ts=new TimeSpan(0,0,0,0, (int)mediaSlider.Value);
            mediaPlayer.Position = ts;
        }
    }
}