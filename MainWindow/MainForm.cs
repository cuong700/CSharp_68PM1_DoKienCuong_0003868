using System;
using System.Windows.Forms;
using qlSinhVien.QuanLySinhVien;
using qlSinhVien.QuanLyLopHoc; 

namespace qlSinhVien.MainWindow
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Khi mở Form2, mặc định hiển thị UserControl quản lý sinh viên
            HienThiUserControl(new UCQLSinhVien());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void HienThiUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        // Menu: Quản lý Sinh Viên
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThiUserControl(new UCQLSinhVien());
        }

        // Menu: Quản lý Lớp Học
        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienThiUserControl(new UCQLLopHoc()); 
        }

        // Menu: Đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?",
                                                  "Xác nhận",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new qlSinhVien.DangNhap.Form1().Show();
            }
        }
    }
}