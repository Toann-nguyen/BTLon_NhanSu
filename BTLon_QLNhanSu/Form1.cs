using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLon_QLNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Nhansu_BUS Nhansu_BUS = new Nhansu_BUS();
        private void nhậpBảngNhânvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nhan_Su nhanvien = new Form_Nhan_Su();
            nhanvien.Show();
        }

        private void nhậpBảngChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Chuvu form_Chuvu = new Form_Chuvu();
            form_Chuvu.Show();
        }

        private void Check_tenbang_Click(object sender, EventArgs e)
        {
            string sql = "Select * from" + comboBox1.Text;
            DataTable dt = new DataTable();
            dt = 
            }
        }
    }
}
