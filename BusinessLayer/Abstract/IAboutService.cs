using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();

        void CategoryAdd(About about);

        void CategoryDelete(About about);

        void CategoryUpdate(About about);
        Category getById(int id);
    }
}
