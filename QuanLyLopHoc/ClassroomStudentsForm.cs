using System;
using System.Linq;
using System.Windows.Forms;

namespace qlSinhVien.QuanLyLopHoc
{
    public partial class ClassroomStudentsForm : Form
    {
        private string maLop;
        private DataBaseDataContext db = new DataBaseDataContext();

        public ClassroomStudentsForm(string maLop)
        {
            this.maLop = maLop;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var lop = db.tbl_lophocs.SingleOrDefault(c => c.malop == maLop);

                if (lop != null)
                {
                    lblTitle.Text = $"Danh Sách Sinh Viên - Lớp {lop.malop.ToUpper()} ({lop.tenlop})";
                }

                dgvStudents.AutoGenerateColumns = false;

                if (dgvStudents.Columns["colNgaySinh"] != null)
                {
                    dgvStudents.Columns["colNgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                var studentList = db.tbl_sinhviens
                                    .Where(s => s.malop == maLop)
                                    .OrderByDescending(s => s.id)
                                    .Select(s => new
                                    {
                                        s.id,
                                        s.hoten,
                                        s.ngaysinh,
                                        s.gioitinh
                                    })
                                    .ToList();

                dgvStudents.DataSource = studentList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}