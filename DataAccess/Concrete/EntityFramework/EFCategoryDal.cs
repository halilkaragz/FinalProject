using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {       
    }
}
