﻿using System;
using System.Collections.Generic;

namespace WpfChinook.mvvm.models;

public partial class Invoice
{
    public long InvoiceId { get; set; }

    public long CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; } 

    public string? BillingAddress { get; set; }

    public string? BillingCity { get; set; }

    public string? BillingState { get; set; }

    public string? BillingCountry { get; set; }

    public string? BillingPostalCode { get; set; }

    public int Total { get; set; } 

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();
}
