using DataAccessLayer.Abstarct;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }

}
