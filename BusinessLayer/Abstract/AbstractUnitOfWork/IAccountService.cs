using EntityLayer.Concrete;

namespace BusinessLayer.Abstract.AbstractUnitOfWork
{
    public interface IAccountService : IGenericUnitOfWorkService<Account>
    {
    }
}
