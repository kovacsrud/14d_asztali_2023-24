using MauiBaseDb.MVVM.Models;
using MauiBaseDb.MVVM.Views;
using MauiBaseDb.repository;

namespace MauiBaseDb
{
    public partial class App : Application
    {
        public static BaseRepository<Tankolas> TankolasRepo {  get; set; }
        public App(BaseRepository<Tankolas> tankolasrepo)
        {
            InitializeComponent();
            TankolasRepo = tankolasrepo;

            MainPage = new NavigationPage(new BaseView());
        }
    }
}