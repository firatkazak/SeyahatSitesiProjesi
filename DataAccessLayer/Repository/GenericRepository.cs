using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    //Dışarıdan T Entity'si alacak. IGenericDal'dan Miras alacak. IGenericDal da bir T değeri alacak. Bu T bir Class olacak.
    //IGenericDal'a Implement Interface dediğimiz anda metotlarımız aşağıda tanımlanacak. Sonra metotlarımızı doldurduk.
    {
        public void Delete(T t)//T tipinde t değişkenini sileceğiz.
        {
            using var c = new Context();//CRUD işlemleri Context ile yapılıyor. O işlemi yapacak c adında nesne oluşturduk.
            c.Remove(t);//c nesnesi t nesnesini silecek.
            c.SaveChanges();//Değişiklikleri kaydet.
        }

        public T GetByID(int id)
        {
            using var c = new Context();//c nesnesi yarattık.
            return c.Set<T>().Find(id);//c'de id'ye göre bul, onu döndür dedik.
        }

        public List<T> GetList()
        {
            using var c = new Context();//c nesnesi yarattık.
            return c.Set<T>().ToList();//Nesneyi ayarlayıp listeleyecek.
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();//Context sınıfından nesne ürettik.
            return c.Set<T>().Where(filter).ToList();//Nesneyi filtreye göre ayarlayıp listeleyecek.
        }

        public void Insert(T t)
        {
            using var c = new Context();//c nesnesi yarattık.
            c.Add(t);//Context nesnemizin içine t'yi ekleyecek.
            c.SaveChanges();//Değişiklikleri kaydet.
        }

        public void Update(T t)
        {
            using var c = new Context();//c nesnesi yarattık.
            c.Update(t);//Context nesnemizi içinde t'yi güncelleyecek.
            c.SaveChanges();//Değişiklikleri kaydet.
        }
    }
}
