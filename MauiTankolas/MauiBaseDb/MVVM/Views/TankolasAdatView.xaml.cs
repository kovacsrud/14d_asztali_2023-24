using MauiBaseDb.MVVM.ViewModels;

namespace MauiBaseDb.MVVM.Views;

public partial class TankolasAdatView : ContentPage
{
	public TankolasAdatView(BaseViewModel vm)
	{
		InitializeComponent();
		BindingContext=vm;
	}

    private async void buttonModosit_Clicked(object sender, EventArgs e)
    {
		var vm = (BaseViewModel)BindingContext;
		await Navigation.PushAsync(new ModositTankolasView(vm));
    }

    private async void buttonUj_Clicked(object sender, EventArgs e)
    {
        var vm = (BaseViewModel)BindingContext;
        await Navigation.PushAsync(new UjTankolasView(vm));
    }
}