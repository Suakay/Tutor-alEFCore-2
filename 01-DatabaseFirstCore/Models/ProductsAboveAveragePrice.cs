﻿using System;
using System.Collections.Generic;

namespace _01_DatabaseFirstCore.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
