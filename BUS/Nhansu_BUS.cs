using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class Nhansu_BUS
    {
        Nhansu_DAL Nhansu = new Nhansu_DAL();
        public DataTable Load_Bus()
        {
            return Nhansu.Load_Lop();

        }
        public void Insert_Bus(Nhansu ob)
        {
            Nhansu.Insert_Nhansu(ob);
        }
        public void Update_Bus(Nhansu ob)
        {
            Nhansu.Update_Nhansu(ob);
        }
        public void Delete_Bus(string Ma_nhan_vien)
        {
            Nhansu.Delete_Nhansu(Ma_nhan_vien);
        }

    }
}
