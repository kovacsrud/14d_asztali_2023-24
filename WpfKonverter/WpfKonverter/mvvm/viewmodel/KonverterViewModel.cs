using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;
using UnitsNet;

namespace WpfKonverter.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class KonverterViewModel
    {
        public string KivalasztottMennyisegNev { get; set; }
        public List<string> Mennyisegek { get; set; }
        public List<string> InputMertekegysegek { get; set; }
        public List<string> OutputMertekegysegek { get; set; }

        public string InputKivalasztott { get; set; }
        public string OutputKivalasztott { get; set; }
        public double InputErtek { get; set; }
        public double OutputErtek { get; set; }

        public KonverterViewModel()
        {
              Mennyisegek=Quantity.Infos.Select(x=>x.Name).ToList();
              KivalasztottMennyisegNev = Mennyisegek.FirstOrDefault();
              InputMertekegysegek = MertekegysegBetoltes();
              OutputMertekegysegek=MertekegysegBetoltes();
              InputErtek = 1;
        }

        public List<string> MertekegysegBetoltes()
        {
            if (KivalasztottMennyisegNev!=null)
            {
                var mertekegysegek = Quantity.Infos.FirstOrDefault(x => x.Name == KivalasztottMennyisegNev).UnitInfos.Select(u => u.Name).ToList();

                return new List<string>(mertekegysegek);
            }
            return new List<string>();
        }

    }
}
