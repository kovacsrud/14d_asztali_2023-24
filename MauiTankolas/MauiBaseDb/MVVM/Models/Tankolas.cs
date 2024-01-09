using MauiBaseDb.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBaseDb.MVVM.Models
{
    public class Tankolas:TableData
    {
        [NotNull]
        public int TankoltLiter { get; set; }
        [NotNull]
        public int OraAllas { get; set; }
        [NotNull]
        public DateTime Datum { get; set; } = DateTime.Now;
    }
}
