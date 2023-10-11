using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSqlite
{
    public static class Constants
    {
        public static SQLiteConnection conn = new SQLiteConnection("Data Source=kutyak.db;Version=3");
    }
}
