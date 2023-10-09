using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhansu
    {
        public string Manhanvien { get; set; }
        public string Machucvu { get; set; }
        public string Hoten { get; set; }
        public string AGE { get; set; }
        public string Ngaysinh { get; set; }
        public string Sodienthoai{ get; set; }
        public string Quequan { get; set; }
        public string Gioitinh { get; set; }
        public string Maphong { get; set; }


        public Nhansu() { }
        public Nhansu(string Manhanvien, string Machucvu, string Hoten, 
            string AGE,
            string Ngaysinh, string Sodienthoai, string Quequan,
            string Gioitinh, string Maphong)
        {
            this.Manhanvien = Manhanvien;
            this.Machucvu = Machucvu;
            this.Hoten = Hoten;
            this.AGE = AGE;
            this.Ngaysinh = Ngaysinh;
            this.Quequan = Quequan;
            this.Sodienthoai = Sodienthoai;
            this.Gioitinh = Gioitinh;
            this.Maphong = Maphong;

        }

       
    }
    
}
