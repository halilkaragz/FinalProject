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
            //Data transformation object
            ProductTest();
            //IoC
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal(), new CategoryManager(new EFCategoryDal()));
            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data )
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }  
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
