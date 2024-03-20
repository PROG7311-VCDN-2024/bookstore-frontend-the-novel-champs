using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sprint1_Sipaya.models;

public partial class Cart
{
    public int CartId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public int CustomerId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public int ProductId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
