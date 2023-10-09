using BUS;
using DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using System.Data.SqlClient;

namespace BTLon_QLNhanSu
{
    public partial class Form_Chuvu : Form
    {
        public Form_Chuvu()
        {
            InitializeComponent();
        }
        ChucVu_BUS bus_chucvu = new ChucVu_BUS();
        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            Machucvu.Text = dataGridViewChucVu.Rows[i].Cells[0].Value.ToString();
            Tenchucvu.Text = dataGridViewChucVu.Rows[i].Cells[1].Value.ToString();

        }

        private void Machucvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Chuvu_Load(object sender, EventArgs e)
        {
            dataGridViewChucVu.DataSource = bus_chucvu.Load_Bus();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            ChucVu ob = new ChucVu(Machucvu.Text, Tenchucvu.Text);
            bus_chucvu.Insert_Bus(ob); 
            Form_Chuvu_Load(sender, e);
            Machucvu.Clear(); Tenchucvu.Clear();
        }

        private void dataGridViewChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bus_chucvu.Delete_Bus(Machucvu.Text);
            Form_Chuvu_Load(sender, e);
            Machucvu.Clear(); Tenchucvu.Clear();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            ChucVu ob = new ChucVu(Machucvu.Text, Tenchucvu.Text);
            bus_chucvu.Update_Bus(ob); 
            Form_Chuvu_Load(sender, e);
            Machucvu.Clear();
            Tenchucvu.Clear();

        }

        private void Xuat_excel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Nguyễn Minh Toàn";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Danh sách nhân sự:" + Tenchucvu.Text;

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Danh_sach_Lop");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "Danh_sach_Nhan_Su_" + Tenchucvu.Text;
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {  
                                                "Mã chức vụ",
                                                "Tên chức vụ"
                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Danh sách sinh viên lớp " + Tenchucvu.Text;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //gán giá trị
                        cell.Value = item;
                        colIndex++;
                    }

                    // Khai báo danh sách sinh viên
                    List<ChucVu> userList = new List<ChucVu>();
                    // lấy ra danh sách chuyển sang List từ gridview
                    for (int i = 0; i < dataGridViewChucVu.Rows.Count - 1; i++)
                    {
                        ChucVu ob = new ChucVu();
                        ob.Machucvu = dataGridViewChucVu.Rows[i].Cells[0].Value.ToString();
                        ob.Tenchucvu = dataGridViewChucVu.Rows[i].Cells[1].Value.ToString();
                        
                        userList.Add(ob);
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in userList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 1;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.Machucvu;
                        ws.Cells[rowIndex, colIndex++].Value = item.Tenchucvu;
      
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }

        }

        private void In_ds_Click(object sender, EventArgs e)
        {

        }
    }
}

