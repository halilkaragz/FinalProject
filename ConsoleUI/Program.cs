using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());
            foreach (var product in productManager.GetByUnitPrice(30, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
