using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Api.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
