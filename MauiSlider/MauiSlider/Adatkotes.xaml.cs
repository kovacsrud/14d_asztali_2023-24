using System.Diagnostics;

namespace MauiSlider;

public partial class Adatkotes : ContentPage
{
    Allapot2 allapot=new Allapot2 { Ertek=10};
public Adatkotes()
	{
		InitializeComponent();
        BindingContext = allapot;
        
    }

    
}