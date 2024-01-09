using System;
using System.Collections.Generic;
using System.Linq;
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
            UpdateCommand = new Command(async () => {
                var result = await Application.Current.MainPage.DisplayAlert("Módosítás","Biztosan módosítja?","Igen","Mégse");
                if (result)
                {
                    App.TankolasRepo.UpdateItem(AktualisTankolas);
                    await Application.Current.MainPage.DisplayAlert("Módosítás",App.TankolasRepo.StatusMsg,"Ok");
                }
            
            });

            DeleteCommand = new Command(async () => {
                var result = await Application.Current.MainPage.DisplayAlert("Törlés", "Biztosan törli?", "Igen", "Mégse");
                if (result)
                {
                    App.TankolasRepo.DeleteItem(AktualisTankolas);
                    await Application.Current.MainPage.DisplayAlert("Törlés", App.TankolasRepo.StatusMsg, "Ok");
                }

            });
        }

        public void GetTankolasok()
        {
            Tankolasok = App.TankolasRepo.GetItems();
        }
    }
}
