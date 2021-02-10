using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constrait - Generic kısıtlama. Metodlara bizim istediğimiz parametleri yazmasını sağlamak amacıyla
    // class demek referans tip demek 
    // IEntity :Entities klasöründeki IEntity olabilir veya IEntity implemente eden(category-customer-product) bir nesne olabilir.
    //new(): new'lenebilir olmalı. Yani soyut bir nesne olmamalı- IEntity new olarak kullanılamaz
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //metodun içinde filtre yazmamıza gerek kalmaz.
        T Get(Expression<Func<T, bool>> filter); //Detaylandırmak için kullanıyoruz. 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        //List<T> GetALLByCategory(int categoryId); T Get() yazıldıktan sonra bu satıra ihtiyac kalmaz.
    }
}
