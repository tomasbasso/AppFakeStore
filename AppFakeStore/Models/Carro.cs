using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore.Models
{
    public class Carro
    {
        public class Product
        {
            public int productId { get; set; }
            public int quantity { get; set; }
        }

        public class Root
        {
            public int id { get; set; }
            public int userId { get; set; }
            public DateTime date { get; set; }
            public List<Product> products { get; set; }
            public int __v { get; set; }
        }


    }
}
