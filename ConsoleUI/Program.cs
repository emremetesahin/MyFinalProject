using Business;
using Business.Abstract;
using Business.Concrete;
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
            //ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryId + " " + category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            IProductService productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetail();
            if (result.Success==true)
            {
                foreach (var item in productManager.GetProductDetail().Data)
                {
                    Console.WriteLine(item.ProductName + " " + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

        }
    }
}
