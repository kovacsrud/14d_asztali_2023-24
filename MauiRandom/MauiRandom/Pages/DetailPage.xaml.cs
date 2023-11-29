using MauiRandom.Model;

namespace MauiRandom.Pages;

public partial class DetailPage : ContentPage
{
    public Result Result { get; set; }
    public DetailPage(Result result)
	{
		InitializeComponent();
		Result = result;
		BindingContext = Result;
	}
}