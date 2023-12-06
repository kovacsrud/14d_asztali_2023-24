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
        public ICommand UpdateCommand { get; set; }

        public NoteViewModel()
        {
            GetNotes();
            UpdateCommand = new Command(async () => {
                var result = await Application.Current.MainPage.DisplayAlert("Jegyzet módosítása","Biztosan módosítja?","Igen","Nem");
                if (result)
                {
                    App.NotesRepo.UpdateNote(CurrentNote);
                    await Application.Current.MainPage.DisplayAlert("Státusz",App.NotesRepo.StatusMsg,"Ok");
                    GetNotes();
                }
            });
                
        }


        public void GetNotes()
        {
            Notes=App.NotesRepo.GetAllNotes();
        }

    }
}
