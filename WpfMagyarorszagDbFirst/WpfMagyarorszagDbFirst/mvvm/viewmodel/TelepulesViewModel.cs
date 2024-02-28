using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfMagyarorszagDbFirst.mvvm.models;
using PropertyChanged;

namespace WpfMagyarorszagDbFirst.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class TelepulesViewModel
    {
        public MagyarTelepulesekV2Context context;
        public ObservableCollection<Jogalla> Jogallasok { get; set; }
        public ObservableCollection<Megyek> Megyek { get; set; }
        public ObservableCollection<Telepulesek> Telepulesek { get; set; }

        public ObservableCollection<Telepulesek> TelepulesDist {  get; set; }

        public Telepulesek SelectedTelepules { get; set; }

        public TelepulesViewModel()
        {
            context=new MagyarTelepulesekV2Context();
            context.Telepuleseks.Load();
            context.Jogallas.Load();
            context.Megyeks.Load();

            Jogallasok=context.Jogallas.Local.ToObservableCollection();
            Megyek=context.Megyeks.Local.ToObservableCollection();
            Telepulesek=context.Telepuleseks.Local.ToObservableCollection();
            
        }

       

        public void DbMentes()
        {
            try
            {
                var valasz = MessageBox.Show("Biztosan menti?", "Mentés", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                if (valasz==MessageBoxResult.OK)
                {
                    var result=context.SaveChanges();
                    if (result>0)
                    {
                        MessageBox.Show("Adatok mentve", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
                    } else
                    {
                        MessageBox.Show("Nem változtak az adatok", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message,"Hiba!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}
