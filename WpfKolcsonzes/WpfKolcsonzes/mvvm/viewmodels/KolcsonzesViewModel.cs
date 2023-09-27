using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfKolcsonzes.mvvm.models;

namespace WpfKolcsonzes.mvvm.viewmodels
{
    public class KolcsonzesViewModel
    {
        public List<Kolcsonzes> Kolcsonzesek { get; set; }

        public KolcsonzesViewModel()
        {
            Kolcsonzesek = new KolcsonzoLista("kolcsonzesek.txt", ';').Kolcsonzesek;
        }
    }
}
