using MauiBaseDb.MVVM.Models;
using MauiBaseDb.MVVM.ViewModels;
using PropertyChanged;

namespace MauiBaseDb.MVVM.Views;

[AddINotifyPropertyChangedInterface]

public partial class UjTankolasView : ContentPage
{
    public Tankolas UjTankolas { get; set; }=new Tankolas();
    public BaseViewModel ViewModel { get; set; }
    public UjTankolasView(BaseViewModel vm)
	{
		InitializeComponent();
        ViewModel = vm;
        BindingContext=this;
	}

    private async void buttonUj_Clicked(object sender, EventArgs e)
    {
        var result = await DisplayAlert("�j tankol�s", "Biztosan r�gz�ti?", "Ok", "M�gse");
        if (result && ViewModel.Validation(UjTankolas))
        {
            App.TankolasRepo.NewItem(UjTankolas);
            await DisplayAlert("�j tankol�s", App.TankolasRepo.StatusMsg, "Ok");
            ViewModel.GetTankolasok();
            ViewModel.Tankolasrendezes(x => x.Datum);

        }
    }
}