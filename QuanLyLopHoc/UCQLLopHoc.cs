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