using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    interface IWriterService
    {
        List<Writer> getList();
        void writerAdd(Writer writer);
        void writerUpdate(Writer writer);
        void writerDelete(Writer writer);
        Writer getByID(int id);
    }
}
