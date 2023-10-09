using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    public class Nhansu_DAL:Connect
    {
        public Nhansu_DAL() { }
        public DataTable Load_Lop()
        {
            return Load_DL("select * from Nhan_Vien");
        }
        public void Insert_Nhansu(Nhansu ob)
        {


        string sql = "insert into Nhan_Vien values('" +
                ob.Manhanvien + "', ' " + ob.Machucvu+ "' , ' "+ob.Hoten +
                "',' " +ob.AGE + "','"+ob.Ngaysinh + "','" +ob.Sodienthoai
            + "','" + ob.Quequan+ "','"+ ob.Gioitinh + "','"+ ob.Maphong+ "')";
            Excecute(sql);
        }
        public void Update_Nhansu(Nhansu ob)
        {
            string sql = "update Nhan_Vien set Ho_ten='" + ob.Hoten+" ' "
                +", Ma_nhan_vien='"+ob.Manhanvien +"' , Ma_chuc_vu=' "+ob.Machucvu+
                "' , Tuoi='"+ ob.AGE+" ' , So_dien_thoai='"+ob.Sodienthoai+ " ' , Que_quan='"+
                ob.Quequan+" ', Gioi_tinh='"+ob.Gioitinh+
                " ' , Ma_phong=' "+ ob.Maphong +"' " +
                    "where Ma_nhan_vien='" + ob.Manhanvien + "'";
            Excecute(sql);
        }
        public void Delete_Nhansu(string Ma_nhan_vien)
        {
            string sql = "delete from Nhan_Vien where Ma_nhan_vien ='" + Ma_nhan_vien + "'";
            Excecute(sql);
        }

    }
}
