﻿using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetListCommentWithDestination();
        public List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}
