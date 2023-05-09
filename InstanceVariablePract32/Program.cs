using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVariablePract32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //java style
            Product product1 = new Product();
            product1.Equals(product1);
            product1.name = "감자";
            product1.price = 2000;

            Product product2 = new Product() { name = "고구마", price = 2100 };
            Product product3 = new Product() { name = "옥수수" };
            Product product4 = new Product() { price = 999999 };
            Product product5 = new Product() { price = 7777, name = "비트" };

        }
    }
}
