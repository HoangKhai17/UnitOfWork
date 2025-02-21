using System;
using System.Collections.Generic;

namespace UnitOfWork.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    //public object Products { get; internal set; }

    //  public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
