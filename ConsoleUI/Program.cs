using Business;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entitiy.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productManager = new ProductManager(new EfProductDal());
            //Product product1 = new Product() { ProductId = 6, CategoryId = 2, ProductName = "Elma", UnitPrice = 3, UnitsInStock = 10 };
           // productManager.Add(product1);
            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductId + " " + item.CategoryId+" "+item.ProductName + " " + item.UnitPrice + " " + item.UnitsInStock);
            }

        }
    }
}
