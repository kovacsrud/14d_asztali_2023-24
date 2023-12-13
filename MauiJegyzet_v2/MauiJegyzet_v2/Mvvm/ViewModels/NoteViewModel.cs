using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiJegyzet_v2.Mvvm.Models;
using PropertyChanged;

namespace MauiJegyzet_v2.Mvvm.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class NoteViewModel
    {
        public List<Note> Notes { get; set; }= new List<Note>();
        public Note CurrentNote { get; set; }

        public List<Category> Categories { get; set; }
        public Category CurrentCategory { get; set; }

        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public NoteViewModel()
        {
            //App.CategoryRepo.NewItem(new Category { CategoryName = "vásárlás" });
            //App.CategoryRepo.NewItem(new Category { CategoryName = "emlékeztető" });
            //App.CategoryRepo.NewItem(new Category { CategoryName = "edzés" });

            //var categories = App.CategoryRepo.GetItems();

            GetNotes();
            if (Categories.Count<1)
            {
                App.CategoryRepo.NewItem(new Category { CategoryName = "alapértelmezett" });
                GetNotes();
            }
            UpdateCommand = new Command(async () => {
                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet módosítása","Biztosan módosítja?","Igen","Nem");
                if (result)
                {
                    App.NotesRepo.UpdateItem(CurrentNote);
                    await Application.Current.MainPage.DisplayAlert("Státusz",App.NotesRepo.StatusMsg,"Ok");
                    GetNotes();
                }
            });
            DeleteCommand = new Command(async () =>
            {
                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet törlése","Biztosan törli?","Igen","Nem");
                if (result)
                {
                    App.NotesRepo.DeleteItem(CurrentNote);
                    await Application.Current.MainPage.DisplayAlert("Státusz", App.NotesRepo.StatusMsg, "Ok");
                    GetNotes();
                }
            });

                
        }


        public void GetNotes()
        {
            Notes=App.NotesRepo.GetItemsWithChildren();
            Categories=App.CategoryRepo.GetItems();
        }

    }
}
