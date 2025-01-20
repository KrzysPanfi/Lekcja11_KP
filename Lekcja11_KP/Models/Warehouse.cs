using System;
using System.Collections.Generic;

namespace Lekcja11_KP.Models;

public partial class Warehouse
{
    public int IdWarehouse { get; set; }

    public string Name { get; set; } = null!;

    public string? Address { get; set; }

    public virtual ICollection<ProductWarehouse> ProductWarehouses { get; set; } = new List<ProductWarehouse>();
}
