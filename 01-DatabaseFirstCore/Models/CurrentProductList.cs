﻿using System;
using System.Collections.Generic;

namespace _01_DatabaseFirstCore.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
