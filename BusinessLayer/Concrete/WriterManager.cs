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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer getByID(int id)
        {
            return _writerDal.Get(x=>x.WriterID == id);
        }

        public List<Writer> getList()
        {
            return _writerDal.list();
        }

        public void writerAdd(Writer writer)
        {
           _writerDal.Insert(writer);
        }

        public void writerDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void writerUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
