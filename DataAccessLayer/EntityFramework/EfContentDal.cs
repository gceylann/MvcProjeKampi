using DataAccessLayer.Abstarct;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfContentDal : GenericRepository<Content>, IContentDal
    {
    }

}
