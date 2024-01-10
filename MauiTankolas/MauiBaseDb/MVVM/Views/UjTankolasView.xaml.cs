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
        var result = await DisplayAlert("�j tankol�s", "Biztosan r�gz�ti?", "Ok", "M�gse");
        if (result)
        {
            App.TankolasRepo.NewItem(UjTankolas);
            await DisplayAlert("�j tankol�s", App.TankolasRepo.StatusMsg, "Ok");
        }
    }
}