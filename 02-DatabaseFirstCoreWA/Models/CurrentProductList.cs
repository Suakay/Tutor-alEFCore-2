﻿using System;
using System.Collections.Generic;

namespace _02_DatabaseFirstCoreWA.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
