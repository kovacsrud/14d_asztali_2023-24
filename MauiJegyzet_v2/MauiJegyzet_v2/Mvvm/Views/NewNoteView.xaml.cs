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
        var result = await DisplayAlert("�j jegyzet","Biztosan r�gz�ti?","Igen","Nem");
        if (result) {
            App.NotesRepo.NewNote(NewNote);
            await DisplayAlert("St�tusz", App.NotesRepo.StatusMsg, "Ok");
            ViewModel.GetNotes();
        }
    }
}