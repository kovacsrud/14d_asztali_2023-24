namespace Atlagfogyasztas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Fogyasztas();
        }
    }
}