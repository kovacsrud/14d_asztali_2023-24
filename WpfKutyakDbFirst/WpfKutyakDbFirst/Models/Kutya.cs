using System;
using System.Collections.Generic;

namespace WpfKutyakDbFirst.Models;

public partial class Kutya
{
    public long Id { get; set; }

    public long Fajtaid { get; set; }

    public long Nevid { get; set; }

    public long Eletkor { get; set; }

    public string Utolsoell { get; set; } = null!;

    public virtual Kutyafajtak Fajta { get; set; } = null!;

    public virtual Kutyanevek Nev { get; set; } = null!;
}
