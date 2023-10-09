using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Connect
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T0VIECI\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True");
        public DataTable Load_DL(string sql)
        {
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt); conn.Close(); return dt;
        }
        public void Excecute(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery(); 
            conn.Close();
        }
    }
}
