using DataAccessLayer.Abstarct;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }

}
