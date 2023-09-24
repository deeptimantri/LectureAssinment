using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureAssinment.ArrayInDetails
{
     class ArrayDemo4
    {
        static void Main(string[] args)
        {
            Product[] Prod = new Product[3];
            Prod[0] = new Product() {Id= 101,ProductName= "Product1" };
            Prod[1] = new Product() { Id = 102, ProductName = "Product2" };
            Prod[2] = new Product() { Id = 103, ProductName = "Product3" };

            foreach (Product item in Prod)
            {
                Console.WriteLine(item);
            }

        }
    }
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return $"Product Id = {Id} \t Product Name = {ProductName}  ";
        }

    }
}
