using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
using OfficeOpenXml;
using System.Windows.Media;

namespace BTLon_QLNhanSu
{
    public partial class Form_Nhan_Su : Form
    {
        public Form_Nhan_Su()
        {
            InitializeComponent();
        }
        Nhansu_BUS BUS = new Nhansu_BUS();

        private void Form_Nhan_Su_Load(object sender, EventArgs e)
        {
            dataGridViewNhanvien.DataSource = BUS.Load_Bus();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Nhansu ob = new Nhansu(
                Ma_nhan_vien.Text,
                Ma_chuc_vu.Text,
                Ho_ten.Text,
                AGE.Text,
                Ngay_sinh.Text,
                So_dien_thoai.Text,
                Que_quan.Text,
                Gioi_tinh.Text,
                Ma_phong.Text
                );
            BUS.Insert_Bus(ob);
            Form_Nhan_Su_Load(sender, e);
            Ma_nhan_vien.Clear();
            Ma_chuc_vu.Clear();
            Ho_ten.Clear();
            AGE.Clear();
            Ngay_sinh.Clear();
            So_dien_thoai.Clear();
            Que_quan.Clear();
            Gioi_tinh.Clear();
            Ma_phong.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Nhansu ob = new Nhansu(
             Ma_nhan_vien.Text,
             Ma_chuc_vu.Text,
             Ho_ten.Text,
             AGE.Text,
             Ngay_sinh.Text,
             So_dien_thoai.Text,
             Que_quan.Text,
             Gioi_tinh.Text,
             Ma_phong.Text
             );
            BUS.Update_Bus(ob);
            Form_Nhan_Su_Load(sender, e);
            Ma_nhan_vien.Clear();
            Ma_chuc_vu.Clear();
            Ho_ten.Clear();
            AGE.Clear();
            Ngay_sinh.Clear();
            So_dien_thoai.Clear();
            Que_quan.Clear();
            Gioi_tinh.Clear();
            Ma_phong.Clear();
        }

        private void chondong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            Ma_nhan_vien.Text = dataGridViewNhanvien.Rows[i].Cells[0].Value.ToString();
            Ma_chuc_vu.Text = dataGridViewNhanvien.Rows[i].Cells[1].Value.ToString();
            Ho_ten.Text = dataGridViewNhanvien.Rows[i].Cells[2].Value.ToString();
            AGE.Text = dataGridViewNhanvien.Rows[i].Cells[3].Value.ToString();
            Ngay_sinh.Text = dataGridViewNhanvien.Rows[i].Cells[4].Value.ToString();
            So_dien_thoai.Text = dataGridViewNhanvien.Rows[i].Cells[5].Value.ToString();
            Que_quan.Text = dataGridViewNhanvien.Rows[i].Cells[6].Value.ToString();
            Gioi_tinh.Text = dataGridViewNhanvien.Rows[i].Cells[7].Value.ToString();
            Ma_chuc_vu.Text = dataGridViewNhanvien.Rows[i].Cells[8].Value.ToString();


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Nhansu ob = new Nhansu(
            Ma_nhan_vien.Text,
            Ma_chuc_vu.Text,
            Ho_ten.Text,
            AGE.Text,
            Ngay_sinh.Text,
            So_dien_thoai.Text,
            Que_quan.Text,
            Gioi_tinh.Text,
            Ma_phong.Text
            );
            BUS.Delete_Bus(Ma_nhan_vien.Text);
            Form_Nhan_Su_Load(sender, e);
            Ma_nhan_vien.Clear();
            Ma_chuc_vu.Clear();
            Ho_ten.Clear();
            AGE.Clear();
            Ngay_sinh.Clear();
            So_dien_thoai.Clear();
            Que_quan.Clear();
            Gioi_tinh.Clear();
            Ma_phong.Clear();
        }

        private void Xuat_Excel_Click(object sender, EventArgs e)
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
                    p.Workbook.Properties.Author = "Nguyễn Thị Mười Phương";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Danh sách sinh viên lớp:" + Ma_phong.Text;

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Danh_sach_Lop");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "Danh_sach_Nhan_su" + Ma_phong.Text;
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Mã nhân viên",
                                                "Mã nhân sự",
                                                "Họ tên",
                                                "Tuoi",
                                                "Ngày sinh",
                                                "So dien thoai",
                                                "Que quan",
                                                "Giới tính",
                                                "Mã phòng"
                };
                
                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Danh sách sinh viên lớp " + Ma_phong.Text;
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
                    List<Nhansu> userList = new List<Nhansu>();
                    // lấy ra danh sách chuyển sang List từ gridview
                    for (int i = 0; i < dataGridViewNhanvien.Rows.Count - 1; i++)
                    {
                        Nhansu ob = new Nhansu();
                        ob.Manhanvien = dataGridViewNhanvien.Rows[i].Cells[0].Value.ToString();
                        ob.Machucvu = dataGridViewNhanvien.Rows[i].Cells[1].Value.ToString();
                        ob.Hoten = dataGridViewNhanvien.Rows[i].Cells[2].Value.ToString();
                        ob.AGE = dataGridViewNhanvien.Rows[i].Cells[3].Value.ToString();
                        ob.Ngaysinh = dataGridViewNhanvien.Rows[i].Cells[4].Value.ToString();
                        ob.Sodienthoai = dataGridViewNhanvien.Rows[i].Cells[5].Value.ToString();
                        ob.Quequan = dataGridViewNhanvien.Rows[i].Cells[6].Value.ToString();
                        ob.Gioitinh = dataGridViewNhanvien.Rows[i].Cells[7].Value.ToString();
                        ob.Maphong = dataGridViewNhanvien.Rows[i].Cells[8].Value.ToString();

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
                        ws.Cells[rowIndex, colIndex++].Value = item.Manhanvien;
                        ws.Cells[rowIndex, colIndex++].Value = item.Machucvu;
                        ws.Cells[rowIndex, colIndex++].Value = item.Hoten;
                        ws.Cells[rowIndex, colIndex++].Value = item.AGE;
                        ws.Cells[rowIndex, colIndex++].Value = item.Ngaysinh;
                        ws.Cells[rowIndex, colIndex++].Value = item.Sodienthoai;
                        ws.Cells[rowIndex, colIndex++].Value = item.Quequan;
                        ws.Cells[rowIndex, colIndex++].Value = item.Gioitinh;
                        ws.Cells[rowIndex, colIndex++].Value = item.Maphong;
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
    }
}

