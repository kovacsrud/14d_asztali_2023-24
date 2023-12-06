using MauiJegyzet_v2.Mvvm.ViewModels;

namespace MauiJegyzet_v2.Mvvm.Views;

public partial class NotesView : ContentPage
{
	public NotesView()
	{
		InitializeComponent();
		BindingContext = new NoteViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var vm=(NoteViewModel)BindingContext;
		Navigation.PushAsync(new NewNoteView(vm));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        var vm = (NoteViewModel)BindingContext;
        Navigation.PushAsync(new UpdateNoteView(vm));
    }
}