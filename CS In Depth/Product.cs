using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_In_Depth
{
    public class Product
    {
        readonly string name;
        public string Name { get { return name; }}

        readonly decimal price;
        public decimal Price { get { return price; } }
    
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = Price;
        }

        public static List<Product> GetSampleProduct()
        {
            return new List<Product>
            {
                new Product(name:"Book1",price:9.99m),
                new Product(name:"Book2",price:14.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}",name,price); 
        }
    }
}
