namespace ASM
{
    partial class FQuanLyThuVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuanLyThuVien));
            menuStrip1 = new MenuStrip();
            quảnLýSáchToolStripMenuItem = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            quảnLýĐộcGỉaToolStripMenuItem = new ToolStripMenuItem();
            quảnLýMượnTrảToolStripMenuItem = new ToolStripMenuItem();
            báoCáoThốngKêToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            cbb_TheLoai = new ComboBox();
            txt_NXB = new TextBox();
            txt_NamSanXuat = new TextBox();
            txt_TenSach = new TextBox();
            txt_TacGia = new TextBox();
            txt_MaSach = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_DanhSachSach = new DataGridView();
            groupBox2 = new GroupBox();
            btn_LamMoi = new Button();
            btn_Xoa = new Button();
            btn_CapNhat = new Button();
            btn_Them = new Button();
            groupBox3 = new GroupBox();
            btn_TimKiem = new Button();
            txt_TimKiem = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSach).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýSáchToolStripMenuItem, quảnLýTàiKhoảnToolStripMenuItem, quảnLýĐộcGỉaToolStripMenuItem, quảnLýMượnTrảToolStripMenuItem, báoCáoThốngKêToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(788, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSáchToolStripMenuItem
            // 
            quảnLýSáchToolStripMenuItem.Name = "quảnLýSáchToolStripMenuItem";
            quảnLýSáchToolStripMenuItem.Size = new Size(106, 24);
            quảnLýSáchToolStripMenuItem.Text = "Quản lý sách";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(143, 24);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản Lý Tài Khoản";
            quảnLýTàiKhoảnToolStripMenuItem.Click += quảnLýTàiKhoảnToolStripMenuItem_Click;
            // 
            // quảnLýĐộcGỉaToolStripMenuItem
            // 
            quảnLýĐộcGỉaToolStripMenuItem.Name = "quảnLýĐộcGỉaToolStripMenuItem";
            quảnLýĐộcGỉaToolStripMenuItem.Size = new Size(130, 24);
            quảnLýĐộcGỉaToolStripMenuItem.Text = "Quản lý Độc Gỉa";
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            quảnLýMượnTrảToolStripMenuItem.Size = new Size(142, 24);
            quảnLýMượnTrảToolStripMenuItem.Text = "Quản Lý Mượn Trả";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            báoCáoThốngKêToolStripMenuItem.Size = new Size(139, 24);
            báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(93, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbb_TheLoai);
            groupBox1.Controls.Add(txt_NXB);
            groupBox1.Controls.Add(txt_NamSanXuat);
            groupBox1.Controls.Add(txt_TenSach);
            groupBox1.Controls.Add(txt_TacGia);
            groupBox1.Controls.Add(txt_MaSach);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 164);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Sách";
            // 
            // cbb_TheLoai
            // 
            cbb_TheLoai.FormattingEnabled = true;
            cbb_TheLoai.Location = new Point(563, 51);
            cbb_TheLoai.Name = "cbb_TheLoai";
            cbb_TheLoai.Size = new Size(151, 28);
            cbb_TheLoai.TabIndex = 12;
            // 
            // txt_NXB
            // 
            txt_NXB.Location = new Point(563, 107);
            txt_NXB.Name = "txt_NXB";
            txt_NXB.Size = new Size(144, 27);
            txt_NXB.TabIndex = 10;
            // 
            // txt_NamSanXuat
            // 
            txt_NamSanXuat.Location = new Point(359, 107);
            txt_NamSanXuat.Name = "txt_NamSanXuat";
            txt_NamSanXuat.Size = new Size(127, 27);
            txt_NamSanXuat.TabIndex = 9;
            // 
            // txt_TenSach
            // 
            txt_TenSach.Location = new Point(359, 47);
            txt_TenSach.Name = "txt_TenSach";
            txt_TenSach.Size = new Size(127, 27);
            txt_TenSach.TabIndex = 8;
            // 
            // txt_TacGia
            // 
            txt_TacGia.Location = new Point(114, 103);
            txt_TacGia.Name = "txt_TacGia";
            txt_TacGia.Size = new Size(120, 27);
            txt_TacGia.TabIndex = 7;
            // 
            // txt_MaSach
            // 
            txt_MaSach.Location = new Point(114, 44);
            txt_MaSach.Name = "txt_MaSach";
            txt_MaSach.Size = new Size(120, 27);
            txt_MaSach.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(492, 110);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 5;
            label6.Text = "NXB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(492, 54);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Thể Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 110);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Năm sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 51);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 106);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Tác giả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sách";
            // 
            // dgv_DanhSachSach
            // 
            dgv_DanhSachSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DanhSachSach.Location = new Point(12, 223);
            dgv_DanhSachSach.Name = "dgv_DanhSachSach";
            dgv_DanhSachSach.RowHeadersWidth = 51;
            dgv_DanhSachSach.Size = new Size(751, 191);
            dgv_DanhSachSach.TabIndex = 3;
            dgv_DanhSachSach.CellContentClick += dgv_DanhSachSach_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_LamMoi);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_CapNhat);
            groupBox2.Controls.Add(btn_Them);
            groupBox2.Location = new Point(12, 420);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 64);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Công cụ";
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Location = new Point(324, 23);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(94, 29);
            btn_LamMoi.TabIndex = 3;
            btn_LamMoi.Text = "Làm Mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(221, 23);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(114, 23);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(94, 29);
            btn_CapNhat.TabIndex = 1;
            btn_CapNhat.Text = "Cập nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(3, 23);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_TimKiem);
            groupBox3.Controls.Add(txt_TimKiem);
            groupBox3.Location = new Point(436, 422);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(327, 62);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm Kiếm";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(214, 25);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(94, 29);
            btn_TimKiem.TabIndex = 4;
            btn_TimKiem.Text = "Tìm Kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(6, 26);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(202, 27);
            txt_TimKiem.TabIndex = 0;
            // 
            // FQuanLyThuVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 493);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgv_DanhSachSach);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "FQuanLyThuVien";
            Text = "Quản Lý thư viện";
            Load += FQuanLyThuVien_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_DanhSachSach).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýSáchToolStripMenuItem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem quảnLýĐộcGỉaToolStripMenuItem;
        private ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private GroupBox groupBox1;
        private ComboBox cbb_TheLoai;
        private TextBox txt_NXB;
        private TextBox txt_NamSanXuat;
        private TextBox txt_TenSach;
        private TextBox txt_TacGia;
        private TextBox txt_MaSach;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_DanhSachSach;
        private GroupBox groupBox2;
        private Button btn_LamMoi;
        private Button btn_Xoa;
        private Button btn_CapNhat;
        private Button btn_Them;
        private GroupBox groupBox3;
        private Button btn_TimKiem;
        private TextBox txt_TimKiem;
    }
}