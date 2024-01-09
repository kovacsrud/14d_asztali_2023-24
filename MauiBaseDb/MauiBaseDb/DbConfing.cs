﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBaseDb
{
    public static class DbConfing
    {
        //Át kell írni az aktuális adatbázis fájlnévre
        private const string dbname = "dbalap.db";

        public const SQLiteOpenFlags Flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create | SQLiteOpenFlags.SharedCache;

        public static string DatabasePath {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbname);
            }
        }
    }
}
