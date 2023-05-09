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
        }
    }
}
