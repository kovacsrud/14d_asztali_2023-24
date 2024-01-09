# Adatbázist használó Maui App készítése

## A szükséges csomagok
- sqlite-net-pcl
- SqliteNetExtensions
- PropertyChanged.Fody

## Adatbázis config létrehozása (DbConfig.cs)

```c#
 public static class DbConfing
 {
     //Át kell írni az aktuális adatbázis fájlnévre
     private const string dbname = "dbalap.db";

     public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create |         SQLiteOpenFlags.SharedCache;

     public static string DatabasePath {
         get
         {
             return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbname);
         }
     }
 }
```
