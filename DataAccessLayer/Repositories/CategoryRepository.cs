using DataAccessLayer.Abstarct;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository :GenericRepository<Category>, ICategoryDal
    {
           
    }
}
