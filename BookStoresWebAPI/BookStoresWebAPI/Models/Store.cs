using System;
using System.Collections.Generic;

namespace BookStoresWebAPI.Models;

public partial class Store
{
    public string StoreId { get; set; } = null!;

    public string? StoreName { get; set; }

    public string? StoreAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
