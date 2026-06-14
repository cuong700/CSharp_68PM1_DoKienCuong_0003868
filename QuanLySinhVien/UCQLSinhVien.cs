using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qlSinhVien.QuanLySinhVien
{
    public partial class UCQLSinhVien : UserControl
    {
        DataBaseDataContext db = new DataBaseDataContext();

        private const int soDongMotTrang = 10;
        private int trangHienTai = 1;
        private int? maSVDangChon = null;

        private List<tbl_sinhvien> danhSachHienThi = new List<tbl_sinhvien>();

        public UCQLSinhVien()
        {
            InitializeComponent();
        }

        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Nam");
                comboBox1.Items.Add("Nữ");

                LoadDSLH();
                LoadData();

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        public void LoadData()
        {
            try
            {
                List<tbl_sinhvien> dsSV = db.tbl_sinhviens.ToList();

                HienThiDanhSach(dsSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách sinh viên: " + ex.Message);
            }
        }

        public void LoadDSLH()
        {
            try
            {
                List<tbl_lophoc> dsLH = db.tbl_lophocs.ToList();

                comboBox2.DataSource = dsLH;
                comboBox2.DisplayMember = "tenlop";
                comboBox2.ValueMember = "malop";

                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải danh sách lớp học: " + ex.Message);
            }
        }

        private void HienThiDanhSach(List<tbl_sinhvien> ds)
        {
            danhSachHienThi = ds;

            int tongBanGhi = ds.Count;

            int tongTrang = (int)Math.Ceiling((double)tongBanGhi / soDongMotTrang);

            if (tongTrang == 0)
                tongTrang = 1;

            if (trangHienTai > tongTrang)
                trangHienTai = tongTrang;

            int batDau = (trangHienTai - 1) * soDongMotTrang;

            int ketThuc = Math.Min(batDau + soDongMotTrang, tongBanGhi);

            dataGridView1.Rows.Clear();

            for (int i = batDau; i < ketThuc; i++)
            {
                var sv = ds[i];

                dataGridView1.Rows.Add(
                    sv.id,
                    sv.hoten,
                    sv.gioitinh,
                    sv.ngaysinh?.ToString("dd/MM/yyyy"),
                    sv.malop
                );
            }

            label7.Text = $"Trang {trangHienTai}/{tongTrang} | {tongBanGhi} bản ghi";
        }

        //Nút thêm
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống!");
                    return;
                }

                int maSV;

                if (!int.TryParse(textBox1.Text.Trim(), out maSV))
                {
                    MessageBox.Show("Mã sinh viên phải là số!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!");
                    return;
                }

                var check = db.tbl_sinhviens.FirstOrDefault(x => x.id == maSV);

                if (check != null)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                tbl_sinhvien sv = new tbl_sinhvien();

                sv.id = maSV;
                sv.hoten = textBox2.Text.Trim();
                sv.gioitinh = comboBox1.Text;
                sv.ngaysinh = dateTimePicker1.Value;
                sv.malop = comboBox2.SelectedValue.ToString();

                db.tbl_sinhviens.InsertOnSubmit(sv);

                db.SubmitChanges();

                MessageBox.Show("Thêm sinh viên thành công!");

                ClearForm();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên: " + ex.Message);
            }
        }

        //Nút sửa
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (maSVDangChon == null)
                {
                    MessageBox.Show("Vui lòng chọn một sinh viên để sửa!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!");
                    return;
                }

                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!");
                    return;
                }

                if (comboBox2.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp!");
                    return;
                }

                var sv = db.tbl_sinhviens.FirstOrDefault(x => x.id == maSVDangChon.Value);

                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên!");
                    return;
                }

                sv.hoten = textBox2.Text.Trim();
                sv.gioitinh = comboBox1.Text;
                sv.ngaysinh = dateTimePicker1.Value;
                sv.malop = comboBox2.SelectedValue.ToString();

                db.SubmitChanges();

                MessageBox.Show("Cập nhật sinh viên thành công!");

                ClearForm();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sinh viên: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string maSVStr = row.Cells[0].Value?.ToString();

            if (int.TryParse(maSVStr, out int maSV))
            {
                maSVDangChon = maSV;
                textBox1.Text = maSVStr;
            }

            textBox2.Text = row.Cells[1].Value?.ToString();

            string gioiTinh = row.Cells[2].Value?.ToString();
            if (!string.IsNullOrEmpty(gioiTinh) && comboBox1.Items.Contains(gioiTinh))
                comboBox1.SelectedItem = gioiTinh;
            else
                comboBox1.SelectedIndex = -1;

            DateTime ngaySinh;
            if (DateTime.TryParseExact(
                    row.Cells[3].Value?.ToString(),
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out ngaySinh))
            {
                dateTimePicker1.Value = ngaySinh;
            }

            string malop = row.Cells[4].Value?.ToString();
            if (!string.IsNullOrEmpty(malop))
                comboBox2.SelectedValue = malop;

            textBox1.ReadOnly = true;
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();

            comboBox1.SelectedIndex = -1;

            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;

            dateTimePicker1.Value = DateTime.Now;

            textBox1.ReadOnly = false;
            maSVDangChon = null;
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }
    }
}