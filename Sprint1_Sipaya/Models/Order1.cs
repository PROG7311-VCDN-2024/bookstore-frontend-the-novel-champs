using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sprint1_Sipaya.models;

public partial class Order1
{
    public int OrderId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
