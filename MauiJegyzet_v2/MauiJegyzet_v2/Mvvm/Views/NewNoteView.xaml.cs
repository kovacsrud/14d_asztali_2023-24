using MauiJegyzet_v2.Mvvm.Models;
using MauiJegyzet_v2.Mvvm.ViewModels;

namespace MauiJegyzet_v2.Mvvm.Views;

public partial class NewNoteView : ContentPage
{
    public NoteViewModel ViewModel { get; set; }
    public Note NewNote { get; set; }=new Note();

    public NewNoteView(NoteViewModel vm)
	{
		InitializeComponent();
        ViewModel = vm;
        BindingContext = this;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var result = await DisplayAlert("Új jegyzet","Biztosan rögzíti?","Igen","Nem");
        if (result) {
            App.NotesRepo.NewNote(NewNote);
            await DisplayAlert("Státusz", App.NotesRepo.StatusMsg, "Ok");
            ViewModel.GetNotes();
        }
    }
}