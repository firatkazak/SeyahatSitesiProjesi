using BusinessLayer.Abstract.AbstractUnitOfWork;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete.ConcreteUnitOfWork
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public Account TGetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}
