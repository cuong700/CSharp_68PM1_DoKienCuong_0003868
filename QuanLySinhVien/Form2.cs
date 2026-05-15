
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlSinhVien.QuanLySinhVien
{
    public partial class Form2 : Form
    {
        private List<SinhVien> danhSachSV = new List<SinhVien>();
        private List<string> danhSachLop = new List<string>();
        private int trangHienTai = 1;
        private const int soDongMotTrang = 10;
        private List<SinhVien> danhSachHienThi = new List<SinhVien>();

        public Form2()
        {
            InitializeComponent();
            KhoiTaoDuLieuMau();
            NapDanhSachLop();
            HienThiDanhSach(danhSachSV);
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private void KhoiTaoDuLieuMau()
        {
            danhSachLop.Add("68PM1");
            danhSachLop.Add("68PM2");
            danhSachLop.Add("68PM3");

            danhSachSV.Add(new SinhVien { MaSV = "1", HoTen = "cuong", GioiTinh = "Nam", NgaySinh = new DateTime(2026, 7, 2), Lop = "68PM1" });
            danhSachSV.Add(new SinhVien { MaSV = "2", HoTen = "Nguyễn Văn B", GioiTinh = "Nam", NgaySinh = new DateTime(2026, 3, 11), Lop = "68PM2" });
            danhSachSV.Add(new SinhVien { MaSV = "3", HoTen = "Trần Văn C", GioiTinh = "Nam", NgaySinh = new DateTime(2026, 3, 21), Lop = "68PM2" });
        }

        private void NapDanhSachLop()
        {
            comboBox2.Items.Clear();
            foreach (var lop in danhSachLop)
                comboBox2.Items.Add(lop);
            if (comboBox2.Items.Count > 0)
                comboBox2.SelectedIndex = 0;
        }

        private void HienThiDanhSach(List<SinhVien> ds)
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
                var sv = ds[i];
                dataGridView1.Rows.Add(sv.MaSV, sv.HoTen, sv.GioiTinh, sv.NgaySinh.ToString("dd/MM/yyyy"), sv.Lop);
            }

            label7.Text = $"Trang {trangHienTai}/{tongTrang}  |  {tongBanGhi} bản ghi";
        }

        private void LamMoiForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count > 0) comboBox2.SelectedIndex = 0;
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e) { }
    }

    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
    }
}