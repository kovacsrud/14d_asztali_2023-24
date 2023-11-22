using Maui_Navigacio.Pages;

namespace Maui_Navigacio
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage());
        }
    }
}