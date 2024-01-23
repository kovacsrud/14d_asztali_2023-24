using MauiBaseDb.MVVM.ViewModels;
using PropertyChanged;

namespace MauiBaseDb.MVVM.Views;
[AddINotifyPropertyChangedInterface]

public partial class ModositTankolasView : ContentPage
{
	public ModositTankolasView(BaseViewModel vm)
	{
		InitializeComponent();
		BindingContext=vm;
	}
}