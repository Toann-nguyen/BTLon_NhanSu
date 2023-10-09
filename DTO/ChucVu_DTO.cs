using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu
    {
        public string Machucvu { get; set; }
        public string Tenchucvu { get; set; }
        public ChucVu() { }
        public ChucVu(string machucvu, string tenchucvu)
        {
            Machucvu = machucvu;
            Tenchucvu = tenchucvu;
        }
    }
}
