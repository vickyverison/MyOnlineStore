using System;
using System.Collections.Generic;

namespace MyOnlineStore.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Stockquantity { get; set; }

    public int? Categoryid { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
}
