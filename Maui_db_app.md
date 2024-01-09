# Adatbázist használó Maui App készítése

## A szükséges csomagok
- sqlite-net-pcl
- SqliteNetExtensions
- PropertyChanged.Fody

### Adatbázis config létrehozása (DbConfig.cs)

```c#
 public static class DbConfing
 {
     //Át kell írni az aktuális adatbázis fájlnévre
     private const string dbname = "dbalap.db";

     public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create|SQLiteOpenFlags.SharedCache;

     public static string DatabasePath {
         get
         {
             return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbname);
         }
     }
 }
```
### A szükséges mappák létrehozása
 - MVVM (benne pedig a Models,Views,ViewModels mappák)
 - Interfaces (a repository inteface, valamint az alap modell osztály)
 - Repository (az adatbázis repónak)

### Interfész valamint az alap modell osztály létrehozása

A modellek alaposztálya a TableData.cs

```C#
public class TableData
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }
}
```
Az repository interfész létrehozása

```C#
public interface IBaseRepository<T>:IDisposable where T : TableData, new()
{
    void NewItem(T item);
    void UpdateItem(T item);
    void DeleteItem(T item);
    List<T> GetItems();
}
```
