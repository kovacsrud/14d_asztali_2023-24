using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Car
    {
        
        public string Country { get; set; }
        public int Year { get; set; }
        public int Sale { get; set; }

        public Car(string country, int year, int sale)
        {
            Country = country;
            Year = year;
            Sale = sale;
        }

    }
}
