
using System;
using System.Collections;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {


            Customlist <Product> customlist = new Customlist<Product>();
            Product product1 = new Product(4);
            Product product2 = new Product(5);
            Product product3 = new Product(4);
            Product product4 = new Product(46);
            Product product5 = new Product(47);
            Product product6 = new Product(47);
            customlist.Add(product1);
            customlist.Add(product2);
            customlist.Add(product3);
            customlist.Add(product4);
            customlist.Add(product5);
            customlist.Add(product6);
            customlist.remove(product6);
            customlist.Contains(product5);
            customlist.clear();
            customlist.remove(3);



        }


    }
}
