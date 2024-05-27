using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CountProdact { get; set; }
        //public Product Product { get; set; }
        public DateTime DateOrder { get; set; }

        //public ProductDto Product { get; set; }
    }
}
