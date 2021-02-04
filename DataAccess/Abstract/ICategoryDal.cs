using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
        /*  List<Category> GetAll();  //Tekrar izle
            void Add(Category category);
            void Update(Category category);
            void Delete(Category category);
            List<Category> GetALLByCategory(int categoryId);*/

        //:IEntityRepository<Category> şeklinde  ekleme yapıldığında yukarıdaki kodlara gerek kalmaz.

    }
}
