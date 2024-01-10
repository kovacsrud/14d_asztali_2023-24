using MauiBaseDb.MVVM.ViewModels;

namespace MauiBaseDb.MVVM.Views;

public partial class BaseView : ContentPage
{
	public BaseView()
	{
		InitializeComponent();
		BindingContext = new BaseViewModel();
	}

    private async void buttonUj_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new UjTankolasView());
    }
}