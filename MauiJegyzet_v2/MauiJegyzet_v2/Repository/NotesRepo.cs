using MauiJegyzet_v2.Mvvm.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiJegyzet_v2.Repository
{
    public class NotesRepo
    {
        SQLiteConnection connection;
        public string StatusMsg { get; set; }

        public NotesRepo()
        {
            connection = new SQLiteConnection(DbConfig.DatabasePath, DbConfig.Flags);
            connection.CreateTable<Note>();
        }

        public void NewNote(Note note)
        {
            int result = 0;
            try
            {
                result = connection.Insert(note);
                StatusMsg = $"{result} jegyzet hozzáadva";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";                
            }
        }

        public void UpdateNote(Note note)
        {
            int result = 0;
            try
            {
                result = connection.Update(note);
                StatusMsg = $"{result} jegyzet módosítva";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
        }

        public void DeleteNote(Note note)
        {
            int result = 0;
            try
            {
                result = connection.Delete(note);
                StatusMsg = $"{result} jegyzet törölve";
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
        }

        public List<Note> GetAllNotes()
        {
            try
            {
                return connection.Table<Note>().ToList();
            }
            catch (Exception ex)
            {
                StatusMsg = $"Hiba:{ex.Message}";
            }
            return null;
        }
    }
}
