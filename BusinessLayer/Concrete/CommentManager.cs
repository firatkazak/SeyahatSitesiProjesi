using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }
        public List<Comment> TGetDestinationById(int id)//DestinationID'ye göre yorum getireceğiz. Liste şeklinde metot yazdık.
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
            //DestinationID dışarıdan gelen id ile aynı ise öyle Listeleyecek.
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
        //Yukarıdaki Add,Update,Delete... metotları IGenericDal'dan geliyor. ICommentDal'da aşağıdaki 2 metot var.
        //ICommentDal, IGenericDal'dan miras aldığı için hem üstteki hem alttaki metotlara sahibiz.

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
        }
    }
}
