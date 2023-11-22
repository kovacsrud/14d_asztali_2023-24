using Maui_Navigacio.utils;

namespace Maui_Navigacio.Pages;

public partial class EndPage : ContentPage
{
	public EndPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtils.Vizsgal(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}