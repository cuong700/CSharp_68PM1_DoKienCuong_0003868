using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qlSinhVien.QuanLyLopHoc
{
    public partial class UCQLLopHoc : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();

        private int trangHienTai = 1;
        private const int soDongMotTrang = 10;

        private List<tbl_lophoc> danhSachHienThi = new List<tbl_lophoc>();

        private string maLopDangChon = null;

        public UCQLLopHoc()
        {
            InitializeComponent();

            var danhSachLop = db.tbl_lophocs.ToList();

            HienThiDanhSach(danhSachLop);
        }

        private void UC_LopHoc_Load(object sender, EventArgs e) { }


        private void HienThiDanhSach(List<tbl_lophoc> ds)
        {
            danhSachHienThi = ds;
            int tongBanGhi = ds.Count;
            int tongTrang = (int)Math.Ceiling((double)tongBanGhi / soDongMotTrang);
            if (tongTrang == 0) tongTrang = 1;
            if (trangHienTai > tongTrang) trangHienTai = tongTrang;

            int batDau = (trangHienTai - 1) * soDongMotTrang;
            int ketThuc = Math.Min(batDau + soDongMotTrang, tongBanGhi);

            dataGridView1.Rows.Clear();
            for (int i = batDau; i < ketThuc; i++)
            {
                var lop = ds[i];

                dataGridView1.Rows.Add(
                    lop.id,
                    lop.malop,
                    lop.tenlop,
                    lop.ghichu
                );
            }

            label7.Text = $"Trang {trangHienTai}/{tongTrang}  |  {tongBanGhi} bản ghi";
        }

        private bool ChuaTuKhoa(string nguon, string tuKhoa)
        {
            if (string.IsNullOrEmpty(nguon)) return false;
            return nguon.ToLowerInvariant().IndexOf(tuKhoa, StringComparison.Ordinal) >= 0;
        }

        //Nút thêm
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaLop.Text))
                {
                    MessageBox.Show("Mã lớp không được để trống!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenLop.Text))
                {
                    MessageBox.Show("Tên lớp không được để trống!");
                    return;
                }

                string maLop = txtMaLop.Text.Trim();

                var check = db.tbl_lophocs.FirstOrDefault(x => x.malop == maLop);

                if (check != null)
                {
                    MessageBox.Show("Mã lớp đã tồn tại!");
                    return;
                }

                tbl_lophoc lop = new tbl_lophoc();

                lop.malop = maLop;
                lop.tenlop = txtTenLop.Text.Trim();
                lop.ghichu = txtGhiChu.Text.Trim();

                db.tbl_lophocs.InsertOnSubmit(lop);

                db.SubmitChanges();

                MessageBox.Show("Thêm lớp học thành công!");

                ClearForm();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp học: " + ex.Message);
            }
        }

        //Nút sửa
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maLopDangChon))
                {
                    MessageBox.Show("Vui lòng chọn một lớp để sửa!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenLop.Text))
                {
                    MessageBox.Show("Tên lớp không được để trống!");
                    return;
                }

                var lop = db.tbl_lophocs.FirstOrDefault(x => x.malop == maLopDangChon);

                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp học!");
                    return;
                }

                lop.tenlop = txtTenLop.Text.Trim();
                lop.ghichu = txtGhiChu.Text.Trim();

                db.SubmitChanges();

                MessageBox.Show("Cập nhật lớp học thành công!");

                ClearForm();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa lớp học: " + ex.Message);
            }
        }

        //Nút xóa
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(maLopDangChon))
                {
                    MessageBox.Show("Vui lòng chọn một lớp để xóa!");
                    return;
                }

                var lop = db.tbl_lophocs.FirstOrDefault(x => x.malop == maLopDangChon);

                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp học!");
                    return;
                }

                bool dangDuocSuDung = db.tbl_sinhviens.Any(x => x.malop == lop.malop);

                if (dangDuocSuDung)
                {
                    MessageBox.Show("Không thể xóa! Lớp này đang có sinh viên.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa lớp \"{lop.tenlop}\" (Mã lớp: {lop.malop})?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                db.tbl_lophocs.DeleteOnSubmit(lop);

                db.SubmitChanges();

                MessageBox.Show("Xóa lớp học thành công!");

                ClearForm();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa lớp học: " + ex.Message);
            }
        }

        //Nút làm mới
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            ClearForm();

            LoadData();
        }

        //Nút tìm kiếm
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = textBox3.Text.Trim().ToLowerInvariant();

                List<tbl_lophoc> dsGoc = db.tbl_lophocs.ToList();

                List<tbl_lophoc> dsKetQua;

                if (string.IsNullOrEmpty(tuKhoa))
                {
                    dsKetQua = dsGoc;
                }
                else
                {
                    dsKetQua = dsGoc.Where(lop =>
                        lop.id.ToString().IndexOf(tuKhoa, StringComparison.Ordinal) >= 0 ||
                        ChuaTuKhoa(lop.malop, tuKhoa) ||
                        ChuaTuKhoa(lop.tenlop, tuKhoa)
                    ).ToList();
                }

                trangHienTai = 1;

                HienThiDanhSach(dsKetQua);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        //Nút << 
        private void button6_Click(object sender, EventArgs e)
        {
            trangHienTai = 1;
            HienThiDanhSach(danhSachHienThi);
        }

        //Nút < 
        private void button7_Click(object sender, EventArgs e)
        {
            if (trangHienTai > 1)
            {
                trangHienTai--;
                HienThiDanhSach(danhSachHienThi);
            }
        }

        //Nút > 
        private void button9_Click(object sender, EventArgs e)
        {
            int tongTrang = (int)Math.Ceiling((double)danhSachHienThi.Count / soDongMotTrang);

            if (tongTrang == 0)
                tongTrang = 1;

            if (trangHienTai < tongTrang)
            {
                trangHienTai++;
                HienThiDanhSach(danhSachHienThi);
            }
        }

        //Nút >> 
        private void button8_Click(object sender, EventArgs e)
        {
            int tongTrang = (int)Math.Ceiling((double)danhSachHienThi.Count / soDongMotTrang);

            if (tongTrang == 0)
                tongTrang = 1;

            trangHienTai = tongTrang;

            HienThiDanhSach(danhSachHienThi);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtMaID.Text = row.Cells[0].Value?.ToString();

            maLopDangChon = row.Cells[1].Value?.ToString();

            txtMaLop.Text = maLopDangChon;
            txtTenLop.Text = row.Cells[2].Value?.ToString();
            txtGhiChu.Text = row.Cells[3].Value?.ToString();

            txtMaLop.ReadOnly = true;
        }

        private void ClearForm()
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();

            txtMaLop.ReadOnly = false;
            maLopDangChon = null;
        }

        public void LoadData()
        {
            try
            {
                List<tbl_lophoc> dsLop = db.tbl_lophocs.ToList();

                HienThiDanhSach(dsLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách lớp học: " + ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e) { }

        public class LopHoc
        {
            public int MaID { get; set; }
            public string MaLop { get; set; }
            public string TenLop { get; set; }
            public string GhiChu { get; set; }
        }
    }
}