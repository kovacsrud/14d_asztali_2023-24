using System;
using System.Collections.Generic;

namespace WpfMagyarorszagDbFirst.mvvm.models;

public partial class Megyek
{
    public string Kod { get; set; } = "";

    public string Nev { get; set; } = "";

    public virtual ICollection<Telepulesek> Telepuleseks { get; set; } = new List<Telepulesek>();
}
