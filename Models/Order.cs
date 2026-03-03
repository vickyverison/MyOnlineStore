using System;
using System.Collections.Generic;

namespace MyOnlineStore.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime Orderdate { get; set; }

    public decimal Totalamount { get; set; }

    public int? Userid { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();

    public virtual User? User { get; set; }
}
