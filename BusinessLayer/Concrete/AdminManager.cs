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
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;

        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public List<Admin> GetList()
        {
            return _admindal.GetListAll();
        }

        public void TAdd(Admin t)
        {
            _admindal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _admindal.Delete(t);
        }

        public Admin TGetById(int id)
        {
            return _admindal.GetByID(id);
        }

        public void TUpdate(Admin t)
        {
            _admindal.Update(t);
        }
    }
}
