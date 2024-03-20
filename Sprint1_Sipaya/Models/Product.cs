using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sprint1_Sipaya.models;

public partial class Product
{
    public int ProductId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
