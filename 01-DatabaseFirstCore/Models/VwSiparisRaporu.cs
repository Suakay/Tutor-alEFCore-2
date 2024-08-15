using System;
using System.Collections.Generic;

namespace _01_DatabaseFirstCore.Models;

public partial class VwSiparisRaporu
{
    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? TitleOfCourtesy { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string? Phone { get; set; }

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }
}
