using MauiJegyzet_v2.Interfeszek;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiJegyzet_v2.Mvvm.Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table("notes")]
    public class Note:TableData
    {
        //Athelyezve a TableData osztalyba
        //[PrimaryKey,AutoIncrement]
        //public int Id { get; set; }
        [NotNull]
        public string Title { get; set; }
        [NotNull]
        public string NoteText { get; set; }
        [NotNull]
        public DateTime Date { get; set; } = DateTime.Now;

        [SQLiteNetExtensions.Attributes.ForeignKey(typeof(Category))]
        public int CategoryId { get; set; }

        [OneToOne(CascadeOperations =CascadeOperation.CascadeRead)]
        public Category Category { get; set; }
    }
}
