using MauiBaseDb.MVVM.Models;
using MauiBaseDb.repository;

namespace MauiBaseDb
{
    public partial class App : Application
    {
        public static BaseRepository<Modell> ModellRepo {  get; set; }
        public App(BaseRepository<Modell> modellrepo)
        {
            InitializeComponent();
            ModellRepo = modellrepo;

            MainPage = new AppShell();
        }
    }
}