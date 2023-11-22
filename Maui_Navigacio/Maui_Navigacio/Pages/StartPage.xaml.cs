using Maui_Navigacio.mvvm;
using Maui_Navigacio.utils;

namespace Maui_Navigacio.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        BindingContext = new StartPageViewModel();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtils.Vizsgal(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var vm=(StartPageViewModel)BindingContext;

        Navigation.PushAsync(new Page2 { BindingContext=vm });

		//Navigation.PushAsync(new Page2(startText.Text));
    }
}