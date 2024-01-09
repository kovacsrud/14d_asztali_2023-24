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
Az repository interfész létrehozása (IBaseRepository.cs)

```C#
public interface IBaseRepository<T>:IDisposable where T : TableData, new()
{
    void NewItem(T item);
    void UpdateItem(T item);
    void DeleteItem(T item);
    List<T> GetItems();
}
```
A repository létrehozása az interfész alapján (BaseRepository.cs)

```C#
    public class BaseRepository<T> : IBaseRepository<T> where T : TableData, new()
    {

        SQLiteConnection connection;
        public string StatusMsg { get; set; }

        public BaseRepository()
        {
            connection = new SQLiteConnection(DbConfing.DatabasePath, DbConfing.Flags);
            connection.CreateTable<T>();
        }
        public void DeleteItem(T item)
        {
            int result = 0;
            try
            {
                result = connection.Delete(item);
                StatusMsg = $"{result} elem törölve";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";                
            }
        }

        public void Dispose()
        {
           connection.Close();
        }

        public List<T> GetItems()
        {
            try
            {
                return connection.Table<T>().ToList();
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
            return null;
        }

        public void NewItem(T item)
        {
            int result = 0;
            try
            {
                result = connection.Insert(item);
                StatusMsg = $"{result} elem hozzáadva";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
        }

        public void UpdateItem(T item)
        {
            int result = 0;
            try
            {
                result = connection.Update(item);
                StatusMsg = $"{result} elem módosítva";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
        }
    }
}
```
### Modell osztály létrehozása

```C#
public class Modell:TableData
{
    public int PropA { get; set; }
    public string PropB { get; set; }
}
```
