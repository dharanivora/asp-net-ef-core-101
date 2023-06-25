using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ef_core_101.Models;

[Index("OrderId", Name = "IX_OrderDetails_OrderId")]
public partial class OrderDetail
{
    [Key]
    public int Id { get; set; }

    public int Quantity { get; set; }

    public int OrderId { get; set; }

    public int ProductId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderDetails")]
    public virtual Order Order { get; set; } = null!;
}
