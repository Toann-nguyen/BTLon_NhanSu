using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class ChucVu_BUS
    {
        ChucVuDAL dal = new ChucVuDAL();
        public DataTable Load_Bus()
        {
            return dal.Load_ChucVu();
        }
        public void Insert_Bus(ChucVu ob)
        {
            dal.Insert_CHucVu(ob);
        }
        public void Update_Bus(ChucVu ob)
        {
            dal.Update_Chucvu(ob);
        }
        public void Delete_Bus(string malop)
        {
            dal.Delete_ChucVu(malop);
        }

    }
}
