using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal  // IProductDal yazınca Using ekle ve implement interface yap
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product {CategoryId=1, ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product {CategoryId=1, ProductId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product {CategoryId=2, ProductId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product {CategoryId=2, ProductId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product {CategoryId=2, ProductId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {   // 
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    productToDelete = p;
            //}
            // uzun yöntem olarak 
            // => lamda        LINQ ile yazma metodu aşağıda
            //   _products.SingleOrDefault    --> foreach yap demek ve her birine takma isim ver. metotdur.
            // 
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); // tek tek dolaşmaya yarıyor. 
            _products.Remove(productToDelete);          // her p ( foreach de olduğu gibi takma ad olur) için o an dolaştığı productId 
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            // gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
        }
        public List<Product> GetALLByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            //where içindeki şarta uyan bütün elemanları secerek yeni bir liste haline getirir ve döndürür
            //yeni koşullarda ekleyebilirsin
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
