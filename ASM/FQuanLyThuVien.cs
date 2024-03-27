using ASM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FQuanLyThuVien : Form
    {
        private AsmcsharpContext dbContext = new AsmcsharpContext();
        private DataTable dt = new DataTable();

        public string tkck { get; set; }
        public string mkck { get; set; }
        public FQuanLyThuVien()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            FDangNhap FDN = new FDangNhap();
            FDN.Show();
            this.Hide();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkck == "Admin" && mkck == "12333")
            {
                FQLTaiKhoan qltk = new FQLTaiKhoan();
                qltk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền cho chức năng này", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void FQuanLyThuVien_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("maSach", typeof(int));
            dt.Columns.Add("tenSach", typeof(string));
            dt.Columns.Add("tacGia", typeof(string));
            dt.Columns.Add("maTheloai", typeof(int));
            dt.Columns.Add("NXB", typeof(string));
            dt.Columns.Add("namXuatBan", typeof(int));

            loatDuLieutodatatable();


            dgv_DanhSachSach.DataSource = dt;
            // đổ dũ liệu vào combobox
            foreach (var theLoai in dbContext.Theloais.ToList())
            {
                cbb_TheLoai.Items.Add(theLoai.TenTheloai);
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            var tenSach = txt_TenSach.Text;
            var tacGia = txt_TacGia.Text;
            var maTheloai = cbb_TheLoai.SelectedItem.ToString();
            var NXB = txt_NXB.Text;
            int namXuatBan = int.Parse(txt_NamSanXuat.Text);
            var theloai = GetTheLoaifromten(maTheloai);

            var SachDangThem = new Sach();
            SachDangThem.TenSach = tenSach;
            SachDangThem.TacGia = tacGia;
            SachDangThem.MaTheloai = theloai.MaTheloai;
            SachDangThem.Nxb = NXB;
            SachDangThem.NamXuatBan = namXuatBan;

            dbContext.Saches.Add(SachDangThem);
            dbContext.SaveChanges();
            dt.Clear();
            loatDuLieutodatatable();

        }
        private void loatDuLieutodatatable()
        {
            foreach (var Sach in dbContext.Saches.ToList())
            {
                DataRow dr = dt.NewRow();
                dr["maSach"] = Sach.MaSach;
                dr["tenSach"] = Sach.TenSach;
                dr["tacGia"] = Sach.TacGia;
                dr["maTheloai"] = Sach.MaTheloai;
                dr["NXB"] = Sach.Nxb;
                dr["namXuatBan"] = Sach.NamXuatBan;
                dt.Rows.Add(dr);
            }
        }
        private Theloai GetTheLoaifromten(string matheloai)
        {
            foreach (var i in dbContext.Theloais.ToList())
            {
                if (i.TenTheloai.Equals(matheloai))
                {
                    return i;
                }
            }
            return null;
        }
        private Theloai GetTheLoaifromMa(int ma)
        {
            foreach (var i in dbContext.Theloais.ToList())
            {
                if (i.MaTheloai.Equals(ma))
                {
                    return i;
                }
            }
            return null;
        }
        private Sach GetSachfromMaSach(int masach)
        {
            foreach (var i in dbContext.Saches.ToList())
            {
                if (i.MaSach.Equals(masach))
                {
                    return i;
                }
            }
            return null;
        }

        private void dgv_DanhSachSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowhientai = dgv_DanhSachSach.Rows[e.RowIndex];
            txt_MaSach.Text = rowhientai.Cells[0].Value.ToString();
            txt_TenSach.Text = rowhientai.Cells[1].Value.ToString();
            txt_TacGia.Text = rowhientai.Cells[2].Value.ToString();
            cbb_TheLoai.SelectedItem = GetTheLoaifromMa((int)rowhientai.Cells[3].Value).TenTheloai;
            txt_NXB.Text = rowhientai.Cells[4].Value.ToString();
            txt_NamSanXuat.Text = rowhientai.Cells[5].Value.ToString();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var maSch = txt_MaSach.Text;
            var tenSach = txt_TenSach.Text;
            var tacGia = txt_TacGia.Text;
            var maTheloai = cbb_TheLoai.SelectedItem.ToString();
            var NXB = txt_NXB.Text;
            int namXuatBan = int.Parse(txt_NamSanXuat.Text);
            var theloai = GetTheLoaifromten(maTheloai);


            var SachDangSua = GetSachfromMaSach(Convert.ToInt32(maSch));
            SachDangSua.TenSach = tenSach;
            SachDangSua.TacGia = tacGia;
            SachDangSua.MaTheloai = theloai.MaTheloai;
            SachDangSua.Nxb = NXB;
            SachDangSua.NamXuatBan = namXuatBan;

            dbContext.SaveChanges();

            dt.Rows.Clear();
            loatDuLieutodatatable();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var maSch = txt_MaSach.Text;
            var SachDangXoa = GetSachfromMaSach(Convert.ToInt32(maSch));
            dbContext.Remove(SachDangXoa);
            dbContext.SaveChanges();

            dt.Rows.Clear();
            loatDuLieutodatatable();
        }
    }
}
