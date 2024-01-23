using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiBaseDb.MVVM.Models;
using PropertyChanged;

namespace MauiBaseDb.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel
    {
        public List<Tankolas> Tankolasok { get; set; }=new List<Tankolas>();
        public Tankolas AktualisTankolas { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public BaseViewModel()
        {
            GetTankolasok();
            Tankolasrendezes(x => x.Datum);

            UpdateCommand = new Command(async () => {
                var result = await Application.Current.MainPage.DisplayAlert("Módosítás","Biztosan módosítja?","Igen","Mégse");
                if (result && Validation(AktualisTankolas))
                {
                    App.TankolasRepo.UpdateItem(AktualisTankolas);
                    await Application.Current.MainPage.DisplayAlert("Módosítás",App.TankolasRepo.StatusMsg,"Ok");
                    GetTankolasok();
                    Tankolasrendezes(x => x.Datum);
                }
            
            });

            DeleteCommand = new Command(async () => {
                var result = await Application.Current.MainPage.DisplayAlert("Törlés", "Biztosan törli?", "Igen", "Mégse");
                if (result)
                {
                    App.TankolasRepo.DeleteItem(AktualisTankolas);
                    await Application.Current.MainPage.DisplayAlert("Törlés", App.TankolasRepo.StatusMsg, "Ok");
                    GetTankolasok();
                }

            });
        }

        public void GetTankolasok()
        {
            Tankolasok = App.TankolasRepo.GetItems();
            
        }

        public bool Validation(Tankolas aktualisTankolas)
        {
            var IsValid = false;
            if (Tankolasok.Count==0)
            {
                return true;
            }

            var elozoOraAllasok = Tankolasok.Any(x=>x.OraAllas>aktualisTankolas.OraAllas && x.Datum<aktualisTankolas.Datum);
            var kovetkezoOraAllasok = Tankolasok.Any(x => x.OraAllas < aktualisTankolas.OraAllas && x.Datum > aktualisTankolas.Datum);

            if (!elozoOraAllasok)
            {
                IsValid= true;
            } else
            {
                //Kivétel dobás vagy egy alert
                Application.Current.MainPage.DisplayAlert("Hiba", "Nem lehet kisebb az óraállás, mint a korábbiak!", "Ok");
                return false;
            }

            if (!kovetkezoOraAllasok)
            {
                IsValid= true;
            }
            else 
            {
                //Kivétel dobás vagy egy alert
                Application.Current.MainPage.DisplayAlert("Hiba", "Nem lehet nagyobb az óraállás, mint a későbbiek!", "Ok");
                return false;
            }



            return IsValid;
        }

        public void Tankolasrendezes(Expression<Func<Tankolas, object>> predicate,bool csokkeno=true)
        {
            if (csokkeno)
            {
                Tankolasok = Tankolasok.AsQueryable().OrderByDescending(predicate).ToList();
            } else
            {
                Tankolasok = Tankolasok.AsQueryable().OrderBy(predicate).ToList();
            }

            
        }
    }
}
