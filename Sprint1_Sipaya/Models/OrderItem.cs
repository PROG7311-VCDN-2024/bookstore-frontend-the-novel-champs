using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sprint1_Sipaya.models;

public partial class OrderItem
{
    public int OrderItemId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public int? ProductId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public int? OrderId { get; set; }

    public int? Quantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual Order1? Order { get; set; }

    public virtual Product? Product { get; set; }
}
