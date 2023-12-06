using MauiJegyzet.Model;
using SQLite;

namespace MauiJegyzet.View;

public partial class JegyzetView : ContentPage
{
	static string dbname = "jegyzetek.db";
	public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;
	string dbpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,dbname);
	SQLiteConnection connection;
    public List<Jegyzet> Jegyzetek { get; set; }= new List<Jegyzet>();
    public Jegyzet AktualisJegyzet { get; set; }
    public JegyzetView()
	{
		InitializeComponent();
		connection = new SQLiteConnection(dbpath, Flags);
		connection.CreateTable<Jegyzet>();
		Jegyzetek=connection.Table<Jegyzet>().ToList();
		BindingContext = this;
	}

    private void buttonUj_Clicked(object sender, EventArgs e)
    {
		var jegyzet=new Jegyzet { Cim=entryCim.Text, Szoveg=entrySzoveg.Text };
		connection.Insert(jegyzet);
        Jegyzetek = connection.Table<Jegyzet>().ToList();
    }

    private void buttonModosit_Clicked(object sender, EventArgs e)
    {
        connection.Update(AktualisJegyzet);
        Jegyzetek = connection.Table<Jegyzet>().ToList();
    }

    private void buttonTorol_Clicked(object sender, EventArgs e)
    {
        connection.Delete(AktualisJegyzet);
        Jegyzetek = connection.Table<Jegyzet>().ToList();
    }
}