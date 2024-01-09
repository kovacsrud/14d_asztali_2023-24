using MauiBaseDb.MVVM.ViewModels;

namespace MauiBaseDb.MVVM.Views;

public partial class BaseView : ContentPage
{
	public BaseView()
	{
		InitializeComponent();
		BindingContext = new BaseViewModel();
	}
}