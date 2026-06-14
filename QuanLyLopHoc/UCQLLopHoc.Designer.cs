namespace qlSinhVien.QuanLyLopHoc
{
    partial class UCQLLopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.txtMaID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Text = "Thông tin lớp học";
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 560);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            //
            // label1 (Mã ID)
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Text = "Mã ID:";
            this.label1.TabIndex = 0;
            //
            // txtMaID 
            //
            this.txtMaID.Location = new System.Drawing.Point(15, 52);
            this.txtMaID.Name = "txtMaID";
            this.txtMaID.Size = new System.Drawing.Size(395, 27);
            this.txtMaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaID.ReadOnly = true;
            this.txtMaID.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.txtMaID.TabIndex = 5;
            //
            // label2 (Mã lớp)
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Text = "Mã lớp:";
            this.label2.TabIndex = 1;
            //
            // txtMaLop
            //
            this.txtMaLop.Location = new System.Drawing.Point(15, 117);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(395, 27);
            this.txtMaLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaLop.TabIndex = 6;
            //
            // label3 (Tên lớp)
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Text = "Tên lớp:";
            this.label3.TabIndex = 2;
            //
            // txtTenLop
            //
            this.txtTenLop.Location = new System.Drawing.Point(15, 182);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(395, 27);
            this.txtTenLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenLop.TabIndex = 7;
            //
            // label4 (Ghi chú)
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(15, 225);
            this.label4.Name = "label4";
            this.label4.Text = "Ghi chú:";
            this.label4.TabIndex = 3;
            //
            // txtGhiChu
            //
            this.txtGhiChu.Location = new System.Drawing.Point(15, 247);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(395, 27);
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.TabIndex = 8;
            //
            // button1 (Thêm)
            //
            this.button1.Text = "Thêm";
            this.button1.Location = new System.Drawing.Point(12, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.TabIndex = 2;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // button2 (Sửa)
            //
            this.button2.Text = "Sửa";
            this.button2.Location = new System.Drawing.Point(222, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.TabIndex = 3;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button3 (Xóa)
            //
            this.button3.Text = "Xóa";
            this.button3.Location = new System.Drawing.Point(12, 635);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.TabIndex = 4;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // button4 (Làm mới)
            //
            this.button4.Text = "Làm mới";
            this.button4.Location = new System.Drawing.Point(222, 635);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.BackColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.TabIndex = 5;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button10 (Xem danh sách sinh viên)
            //
            this.button10.Text = "Xem danh sách sinh viên";
            this.button10.Location = new System.Drawing.Point(12, 695);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(410, 50);
            this.button10.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.TabIndex = 6;
            //
            // label6 (Tìm kiếm)
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(460, 8);
            this.label6.Name = "label6";
            this.label6.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            this.label6.TabIndex = 7;
            //
            // textBox3 (Ô tìm kiếm)
            //
            this.textBox3.Location = new System.Drawing.Point(460, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(480, 30);
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.TabIndex = 8;
            //
            // button5 (Tìm)
            //
            this.button5.Text = "Tìm";
            this.button5.Location = new System.Drawing.Point(950, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 34);
            this.button5.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.TabIndex = 9;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // dataGridView1
            //
            this.dataGridView1.Location = new System.Drawing.Point(460, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 560);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //
            // Cột dataGridView1
            //
            this.colMaID.HeaderText = "Mã ID";
            this.colMaID.Name = "colMaID";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.Name = "colMaLop";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.Name = "colTenLop";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaID, this.colMaLop, this.colTenLop, this.colGhiChu });
            //
            // button6 (<<)
            //
            this.button6.Text = "<<";
            this.button6.Location = new System.Drawing.Point(460, 650);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 35);
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.TabIndex = 11;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            //
            // button7 (<)
            //
            this.button7.Text = "<";
            this.button7.Location = new System.Drawing.Point(515, 650);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 35);
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.TabIndex = 12;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            //
            // label7 (Trang x/x)
            //
            this.label7.AutoSize = false;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(565, 650);
            this.label7.Size = new System.Drawing.Size(375, 35);
            this.label7.Name = "label7";
            this.label7.Text = "Trang 1/1  |  0 bản ghi";
            this.label7.TabIndex = 15;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            //
            // button9 (>)
            //
            this.button9.Text = ">";
            this.button9.Location = new System.Drawing.Point(940, 650);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 35);
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.TabIndex = 13;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            //
            // button8 (>>)
            //
            this.button8.Text = ">>";
            this.button8.Location = new System.Drawing.Point(995, 650);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 35);
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.TabIndex = 14;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            //
            // UCQLLopHoc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(249, 250, 251);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_LopHoc";
            this.Size = new System.Drawing.Size(1100, 760);
            this.Load += new System.EventHandler(this.UC_LopHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaID;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
    }
}