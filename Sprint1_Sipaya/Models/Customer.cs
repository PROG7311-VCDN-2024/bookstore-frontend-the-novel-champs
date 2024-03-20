using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sprint1_Sipaya.models;

public partial class Customer
{
    public int CustomerId { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]

    public string Username { get; set; } = null!;

    public string PasswordDash { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Order1> Order1s { get; set; } = new List<Order1>();
}
