using System;
using System.Collections.Generic;
using System.Collections;
namespace TestProject
{
    public class Product : IComparable
    {
        private string name;
        private int price;
        public Product(string name,int price)
        {
            this.name = name;
            this.price = price;
        }

        public int CompareTo(object obj)  
        {

             
            Product p1 = (Product)obj;   
            if (this.price > p1.price)   
            {
                return 1;
            }
            else if (this.price < p1.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "product :" + name + "  " + price;
        }
    }

    public class Laptop : IEnumerable
    {
        private Product[] products
            ;
        public Laptop()
        {
            products = new Product[2];
            products[0] = new Product("Dell",20000);
            products[1] = new Product("Lenova",35000);
            
        }

        public IEnumerator GetEnumerator()
        {
            return products.GetEnumerator();
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {

            Laptop laptop = new Laptop();
            foreach (var item in laptop)
            {
                Console.WriteLine(item);
            }

            Product Dell = new Product("Dell", 20000);
            Product Lenova = new Product("Lenova", 35000);

            int result = Dell.CompareTo(Lenova);
            if (result == 1)
            {
                Console.WriteLine("Dell have more price than Lenova");
            }
            else if (result == -1)
            {
                Console.WriteLine("Lenova have more price than Dell");
            }
            else
            {
                Console.WriteLine("Dell & Lenova have equal price");
            }
        }


    }

}

