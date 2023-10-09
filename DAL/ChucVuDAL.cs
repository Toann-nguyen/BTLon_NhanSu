using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChucVuDAL:Connect
    {
   

        public ChucVuDAL() { }
        public DataTable Load_ChucVu()
        {
            return Load_DL("select * from Chuc_Vu");
        }
        public void Insert_CHucVu(ChucVu ob)
        {
            string sql = "insert into Chuc_Vu values('" +
                ob.Machucvu + "','" + ob.Tenchucvu + "')";
            Excecute(sql);
        }
        public void Update_Chucvu(ChucVu ob)
        {
            string sql = "update Chuc_Vu set Ten_chuc_vu='" + ob.Tenchucvu + "' " +
                    "where Ma_chuc_vu='" + ob.Machucvu + "'";
            Excecute(sql);
        }
        public void Delete_ChucVu(string Machucvu)
        {
            string sql = "delete from Chuc_Vu where Ma_chuc_vu='" + Machucvu + "'";
            Excecute(sql);
        }

    }
}
