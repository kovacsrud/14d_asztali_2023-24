using MauiJegyzet_v2.Mvvm.Views;
using MauiJegyzet_v2.Repository;

namespace MauiJegyzet_v2
{
    public partial class App : Application
    {
        public static NotesRepo NotesRepo { get; private set; }
        public App(NotesRepo repo)
        {
            InitializeComponent();
            NotesRepo = repo;

            MainPage = new NavigationPage(new NotesView());
        }
    }
}