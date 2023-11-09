namespace MauiStart;

public partial class ProbaPage : ContentPage
{
	public ProbaPage()
	{
		InitializeComponent();
	}

    private void buttonGomb_Clicked(object sender, EventArgs e)
    {
		labelSecond.Text = entrySzoveg.Text;
    }
}