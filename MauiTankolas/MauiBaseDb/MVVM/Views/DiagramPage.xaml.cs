using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using MauiBaseDb.MVVM.Models;
using MauiBaseDb.MVVM.ViewModels;
using SkiaSharp;
using PropertyChanged;

namespace MauiBaseDb.MVVM.Views;
[AddINotifyPropertyChangedInterface]

public partial class DiagramPage : ContentPage
{
	BaseViewModel ViewModel { get; set; }
	public ISeries[] TankoltLiterSeries { get; set; }
	public Axis[] XAxes { get; set; }
    public Axis[] YAxes { get; set; }

    public List<Tankolas> ChartData { get; set; }=new List<Tankolas>();

    public DiagramPage(BaseViewModel vm)
	{
		InitializeComponent();
		ViewModel = vm;
		BindingContext = this;
		ChartData = ViewModel.Tankolasok;
		CreateBarDiagram();

	}

    private void CreateBarDiagram()
    {
        List<int> tankolasok=new List<int>();
		List<string> napok=new List<string>();

		foreach (var i in ChartData)
		{
			tankolasok.Add(i.TankoltLiter);
			napok.Add($"{i.Datum.Year}.{i.Datum.Month}.{i.Datum.Day}");
		}

		TankoltLiterSeries = new ISeries[]
		{
			new ColumnSeries<int>
			{
				Name="Tankolt liter",
				Values=tankolasok,
				Fill=new SolidColorPaint(new SKColor(0,0,0))
			}
		};

		XAxes = new Axis[] { 
			new Axis
			{
				Name="Napok",
				Labels=napok,
				NameTextSize=12,
				LabelsRotation=90
			}

		};

        YAxes = new Axis[] {
			new Axis
			{
				Name="liter",
				NameTextSize=10,
				Labeler=Labelers.Default,
				MinLimit=0,
				MaxLimit=50,
				ForceStepToMin=false,
				MinStep=10,
				TextSize=10,
			}

        };
    }
}