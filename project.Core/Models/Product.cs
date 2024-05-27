using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public int OrderId { get; set; }
        public List<Order> Orders { get; set; }
    }
}
