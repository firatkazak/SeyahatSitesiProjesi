using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;//DI
        public AboutManager(IAboutDal aboutDal)//DI
        {//DI
            _aboutDal = aboutDal;//DI
        }//DI
        //YUKARIDA DEPENDENCY INJECTION YAPTIK!
        //DI yaparak _aboutDal'ı çağırınca IGenericDal'daki metotlara erişebiliyoruz.(Insert, Update,Delete vs)
        //Neden IGenericDal'dakiler geldi? IAboutDal'da IGenericDal'dan miras alıyor çünkü.
        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
