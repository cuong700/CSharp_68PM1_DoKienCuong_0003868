using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qlSinhVien.QuanLyLopHoc
{
    public partial class UCQLLopHoc : UserControl
    {
        private List<LopHoc> danhSachLop = new List<LopHoc>();
        private int trangHienTai = 1;
        private const int soDongMotTrang = 10;
        private List<LopHoc> danhSachHienThi = new List<LopHoc>();

        public UCQLLopHoc()
        {
            InitializeComponent();
            KhoiTaoDuLieuMau();
            HienThiDanhSach(danhSachLop);
        }

        private void UC_LopHoc_Load(object sender, EventArgs e) { }

        private void KhoiTaoDuLieuMau()
        {
            danhSachLop.Add(new LopHoc { MaID = 1, MaLop = "68PM1", TenLop = "Lớp 68PM1", GhiChu = "abc" });
            danhSachLop.Add(new LopHoc { MaID = 2, MaLop = "68PM2", TenLop = "Lớp 68PM2", GhiChu = "xyz" });
        }

        private void HienThiDanhSach(List<LopHoc> ds)
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
                dataGridView1.Rows.Add(lop.MaID, lop.MaLop, lop.TenLop, lop.GhiChu);
            }

            label7.Text = $"Trang {trangHienTai}/{tongTrang}  |  {tongBanGhi} bản ghi";
        }

        private void LamMoiForm()
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
            txtMaLop.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
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