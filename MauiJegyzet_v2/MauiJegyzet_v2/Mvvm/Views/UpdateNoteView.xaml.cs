using MauiJegyzet_v2.Mvvm.ViewModels;

namespace MauiJegyzet_v2.Mvvm.Views;

public partial class UpdateNoteView : ContentPage
{
	public UpdateNoteView(NoteViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}