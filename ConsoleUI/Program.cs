using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        // O - Open Closed Pricipla :  mevcuttaki koduna dokunamazsın anlamında
        // 
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetByUnitPrice(40,200))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
