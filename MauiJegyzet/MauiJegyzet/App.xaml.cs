using MauiJegyzet.View;

namespace MauiJegyzet
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new JegyzetView();
        }
    }
}