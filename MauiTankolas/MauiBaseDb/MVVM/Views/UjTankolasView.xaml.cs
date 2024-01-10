using MauiBaseDb.MVVM.Models;

namespace MauiBaseDb.MVVM.Views;

public partial class UjTankolasView : ContentPage
{
    public Tankolas UjTankolas { get; set; }=new Tankolas();
    public UjTankolasView()
	{
		InitializeComponent();
        BindingContext=this;
	}

    private async void buttonUj_Clicked(object sender, EventArgs e)
    {
        var result = await DisplayAlert("Új tankolás", "Biztosan rögzíti?", "Ok", "Mégse");
        if (result)
        {
            App.TankolasRepo.NewItem(UjTankolas);
            await DisplayAlert("Új tankolás", App.TankolasRepo.StatusMsg, "Ok");
        }
    }
}