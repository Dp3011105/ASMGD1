namespace ASM
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "" && txt_MatKhau.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ Tài Khoản và Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_TaiKhoan.Text == "Admin" && txt_MatKhau.Text == "12333")
            {
                MessageBox.Show("Đăng Nhập Thành công Xin chào Admin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FQuanLyThuVien fqltv = new FQuanLyThuVien();
                fqltv.tkck = txt_TaiKhoan.Text;
                fqltv.mkck = txt_MatKhau.Text;
                fqltv.Show();
                this.Hide();
            }
            else if (txt_TaiKhoan.Text == "User" && txt_MatKhau.Text == "12333")
            {
                MessageBox.Show("Đăng Nhập Thành công Xin Chào Thủ Thư ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FQuanLyThuVien fqltv = new FQuanLyThuVien();
                fqltv.Show();
                this.Hide();
            }
            else if (txt_TaiKhoan.Text != "Admin" || txt_TaiKhoan.Text != "Admin" || txt_MatKhau.Text != "12333")
            {
                MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
