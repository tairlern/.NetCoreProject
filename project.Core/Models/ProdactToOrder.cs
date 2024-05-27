using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class ProdactToOrder
    {
        public int Id { get; set; }
        public int count { get; set; }
        public Order orderId { get; set; }
        public Product productId { get; set; }

    }
}
