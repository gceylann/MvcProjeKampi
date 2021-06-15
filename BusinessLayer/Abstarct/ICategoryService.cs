using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface ICategoryService
    {
        List<Category> GetList();
        Category GetById(int id);
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);


    }
}
