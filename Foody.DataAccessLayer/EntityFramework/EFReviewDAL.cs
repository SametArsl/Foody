﻿using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EFReviewDAL : GenericRepository<Review>, IReviewDAL
    {
        public EFReviewDAL(FoodyContext context) : base(context)
        {
        }
    }
}
