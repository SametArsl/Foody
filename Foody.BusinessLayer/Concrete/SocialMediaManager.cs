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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void TDelete(int id)
        {
            _socialMediaDAL.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return _socialMediaDAL.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDAL.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDAL.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDAL.Update(entity);
        }
    }
}
