using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>//T parametresi Entity'e karşılık geliyor.
    {
        void Insert(T t);//T türünde t parametresi alacak.
        void Update(T t);//T türünde t parametresi alacak.
        void Delete(T t);//T türünde t parametresi alacak.
        List<T> GetList();//T türüne göre listeleyecek.T Listelenecek Class'ın Adı Olacak.
        T GetByID(int id);//ID'ye göre getirecek.
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);//Entity'e göre(T) listeleme yapacağız.
        //T tipi delege, çıktının true/false dönmesi için bool, bir de isim veriyoruz. Syntax böyle.
    }
}
