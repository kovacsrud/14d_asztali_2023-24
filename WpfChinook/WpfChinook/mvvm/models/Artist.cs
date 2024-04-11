﻿using System;
using System.Collections.Generic;

namespace WpfChinook.mvvm.models;

public partial class Artist
{
    public long ArtistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Album> Albums { get; set; } = new List<Album>();
}
