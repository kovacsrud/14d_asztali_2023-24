using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfChinook.mvvm.models;

namespace WpfChinook.mvvm.viewmodel
{
    public class AppViewModel
    {
        ChinookContext chinookContext;

        public ObservableCollection<Track> Tracks { get; set; }
        public ObservableCollection<Artist> Artists { get; set; }
        public ObservableCollection<Album> Albums { get; set; }
        public ObservableCollection<Genre> Genres { get; set; }
        public ObservableCollection<MediaType> MediaTypes { get; set; }
        public ObservableCollection<Playlist> Playlists { get; set; }

        public AppViewModel()
        {
            chinookContext = new ChinookContext();
            chinookContext.Albums.Load();
            chinookContext.Artists.Load();
            chinookContext.Tracks.Load();
            chinookContext.Genres.Load();
            chinookContext.MediaTypes.Load();
            chinookContext.Playlists.Load();

            Tracks=chinookContext.Tracks.Local.ToObservableCollection();
            Artists=chinookContext.Artists.Local.ToObservableCollection();
            Albums=chinookContext.Albums.Local.ToObservableCollection();
            Genres = chinookContext.Genres.Local.ToObservableCollection();
            MediaTypes=chinookContext.MediaTypes.Local.ToObservableCollection();
            Playlists=chinookContext.Playlists.Local.ToObservableCollection();
        }
    }
}
