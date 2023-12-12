using MauiJegyzet_v2.Mvvm.Models;
using MauiJegyzet_v2.Mvvm.Views;
using MauiJegyzet_v2.Repository;

namespace MauiJegyzet_v2
{
    public partial class App : Application
    {
        //public static NotesRepo NotesRepo { get; private set; }
        public static BaseRepository<Note> NotesRepo { get; private set; }
        public static BaseRepository<Category> CategoryRepo { get; private set; }
        public App(BaseRepository<Note> repo, BaseRepository<Category> category)
        {
            InitializeComponent();
            NotesRepo = repo;
            CategoryRepo = category;

            MainPage = new NavigationPage(new NotesView());
        }
    }
}