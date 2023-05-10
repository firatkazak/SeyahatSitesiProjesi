using System.Collections.Generic;

namespace BusinessLayer.Abstract.AbstractUnitOfWork
{
    public interface IGenericUnitOfWorkService<T>
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<T> t);
        T TGetByID(int id);
    }
}
