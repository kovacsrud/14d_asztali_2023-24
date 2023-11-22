using Maui_Navigacio.utils;

namespace Maui_Navigacio.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    public Page2(string szoveg)
    {
       InitializeComponent();
       labelTxt.Text = szoveg;
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
        Navigation.PushAsync(new EndPage());
    }
}