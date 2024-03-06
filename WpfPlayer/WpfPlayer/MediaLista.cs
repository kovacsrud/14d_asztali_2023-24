using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayer
{
    public class MediaLista
    {
        public ObservableCollection<MediaElem> MediaElemek { get; set; }= new ObservableCollection<MediaElem>();

        public void SetMediaList(string[] fajlnevek,char separator)
        {
            for (int i = 0; i < fajlnevek.Length; i++)
            {
                MediaElemek.Add(new MediaElem(fajlnevek[i], separator));
            }

        }


    }
}
