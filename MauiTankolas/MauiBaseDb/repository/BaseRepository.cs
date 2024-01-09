﻿using MauiBaseDb.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBaseDb.repository
{
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
