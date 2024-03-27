using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FQLTaiKhoan : Form
    {
        public FQLTaiKhoan()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
            FQuanLyThuVien fqltv = new FQuanLyThuVien();
            fqltv.Show();
            this.Hide();

        }
    }
}
