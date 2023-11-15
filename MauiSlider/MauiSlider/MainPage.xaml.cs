using System.Diagnostics;

namespace MauiSlider
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            labelSlider.Text = "0";
        }

        private void sliderErtek_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var red=sliderRed.Value;
            var green=sliderGreen.Value;
            var blue=sliderBlue.Value;
            
            
            Color color=Color.FromRgb(red, green, blue);
            rectangleColor.BackgroundColor = color;
            labelSlider.Text=color.ToHex();
            layout.BackgroundColor = color;
        }

        private void buttonRandom_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            var red = random.Next(0, 256);
            var green=random.Next(0, 256);
            var blue=random.Next(0, 256);
            Color color= Color.FromRgb(red, green,blue);
            rectangleColor.BackgroundColor = color;
            labelSlider.Text=color.ToHex();
            sliderRed.Value=color.Red;
            sliderGreen.Value=color.Green;
            sliderBlue.Value=color.Blue;
            layout.BackgroundColor = color;
        }
    }
}