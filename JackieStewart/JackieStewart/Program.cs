// See https://aka.ms/new-console-template for more information
using JackieStewart;
using System.Text;

Console.WriteLine("Hello, World!");

ListBuild list=null;
try
{
    list = new ListBuild("jackie.txt", '\t');

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine($"A lista elemeinek száma:{list.JackieYears.Count}");

//4. feladat melyik évben indult a legtöbb versenyen

var maxVerseny = list.JackieYears.Max(x => x.Races);

var maxVersenyEv = list.JackieYears.Find(x => x.Races == maxVerseny);

Console.WriteLine($"Ebben az évben indult a legtöbb versenyen:{maxVersenyEv.Year}");

var maxVersenyEv_2 = list.JackieYears.FindAll(x => x.Races == maxVerseny);

Console.WriteLine($"Ebben az évben indult a legtöbb versenyen:{maxVersenyEv_2.FirstOrDefault().Year}");

var stat = list.JackieYears.ToLookup(x => x.Year.ToString().Substring(0, 3));

foreach (var i in stat)
{
    if (i.Key == "196")
    {
        Console.WriteLine($"60-as évek:{i.Sum(x => x.Wins)} nyert verseny");
    }
    else
    {
        Console.WriteLine($"70-es évek:{i.Sum(x => x.Wins)} nyert verseny");
    }
}


try
{
    FileStream fajl = new FileStream("jackie.html", FileMode.Create);

    using (StreamWriter writer = new StreamWriter(fajl, Encoding.UTF8))
    {
        writer.WriteLine("<!doctype html>");
        writer.WriteLine("<html>");
        writer.WriteLine("<head></head>");
        writer.WriteLine("<style>td {border:1px solid black}</style");
        writer.WriteLine("<body>");
        writer.WriteLine("<h1>Jackie Stewart</h1>");
        writer.WriteLine("<table>");

        foreach (var i in list.JackieYears)
        {
            writer.WriteLine("<tr>");

            writer.WriteLine($"<td>{i.Year}</td><td>{i.Races}</td><td>{i.Wins}</td>");

            writer.WriteLine("</tr>");
        }


        writer.WriteLine("</table>");
        writer.WriteLine("</body>");
        writer.WriteLine("</html>");
    }
    Console.WriteLine("Írás kész!");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.ReadKey();
