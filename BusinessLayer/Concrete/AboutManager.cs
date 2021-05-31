using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager: IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void CategoryAdd(About about)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(About about)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(About about)
        {
            throw new NotImplementedException();
        }

        public Category getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
