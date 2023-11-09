namespace Atlagfogyasztas;

public partial class Fogyasztas : ContentPage
{
	public Fogyasztas()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

		try
		{
            var tankoltLiter = Convert.ToDouble(entryTankoltLiter.Text);
            var megtettKM = Convert.ToDouble(entryMegtettKm.Text);
			var atlagFogyasztas = tankoltLiter / (megtettKM / 100);

            labelAtlagfogyasztas.Text = $"{atlagFogyasztas:0.00} liter/100km";
        }
		catch (Exception ex)
		{
			DisplayAlert("Hiba","A mezõkbe csak szám írható!","OK");
		}
		
    }
}