using System;
using System.Collections.Generic;

namespace WpfChinook.mvvm.models;

public partial class InvoiceItem
{
    public long InvoiceLineId { get; set; }

    public long InvoiceId { get; set; }

    public long TrackId { get; set; }

    public double UnitPrice { get; set; } 

    public long Quantity { get; set; }

    public virtual Invoice Invoice { get; set; } 

    public virtual Track Track { get; set; } 
}
