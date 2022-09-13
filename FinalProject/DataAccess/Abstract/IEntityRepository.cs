using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filter=null filtre vermeyebilirsinde demek. Yani tüm datayı da isteyebilirsin.
        T Get(Expression<Func<T, bool>> filter); //filtre vermek zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    //T kısmını filtreleyelim çünkü veritabanı nesnelerim üzerinde sadece işlem yapacağiım.--Generic Constraint deniliyor buna. where koşulu yazdık
    //Class olması referans tipleri alsın demek sadece yani int, string gibi değerler almasın.
    //ama biz sadece IEntity nesnelerine ait classları kullanmak istiyoruz o yüzden class:IEntity yazdık.
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //IEntity ide kullanamam çünkü somut bir nesne olacak kullanacağımız nesne o yuzden new() yazdık. Ientity new lenemez soyut olduğu için
}
