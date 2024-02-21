using System;
using System.Collections.Generic;

namespace WpfKutyakDbFirst.Models;

public partial class Kutyanevek
{
    public long Id { get; set; }

    public string Kutyanev { get; set; } = null!;

    public virtual ICollection<Kutya> Kutyas { get; set; } = new List<Kutya>();
}
