using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;//şimdilik mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //böylede yazılabilir
            Product product2 = new Product {Id=2,
                CategoryId=5,
                UnitsInStock=5,
                ProductName="Kalem",UnitPrice=35 };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
            //Console.WriteLine(product1.ProductName);
            ProductManager productManager2 = new ProductManager();
            productManager2.Update(product2);
            Console.WriteLine(product2.ProductName);







        }
    }
}
