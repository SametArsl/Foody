using Foody.BusinessLayer.Abstract;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        private readonly IReviewDAL _reviewDAL;

        public ReviewManager(IReviewDAL reviewDAL)
        {
            _reviewDAL = reviewDAL;
        }

        public void TDelete(int id)
        {
            _reviewDAL.Delete(id);
        }

        public List<Review> TGetAll()
        {
            return _reviewDAL.GetAll();
        }

        public Review TGetById(int id)
        {
            return _reviewDAL.GetById(id);
        }

        public void TInsert(Review entity)
        {
            _reviewDAL.Insert(entity);
        }

        public void TUpdate(Review entity)
        {
            _reviewDAL.Update(entity);
        }
    }
}
