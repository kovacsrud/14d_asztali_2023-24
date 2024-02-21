using System;
using System.Collections.Generic;

namespace WpfKutyakDbFirst.Models;

public partial class Kutyafajtak
{
    public long Id { get; set; }

    public string Nev { get; set; } = null!;

    public string Eredetinev { get; set; } = null!;

    public virtual ICollection<Kutya> Kutyas { get; set; } = new List<Kutya>();
}
