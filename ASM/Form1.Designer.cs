namespace ASM
{
    partial class FDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDangNhap));
            groupBox2 = new GroupBox();
            btn_Thoat = new Button();
            btn_DangNhap = new Button();
            txt_MatKhau = new TextBox();
            label3 = new Label();
            txt_TaiKhoan = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_Thoat);
            groupBox2.Controls.Add(btn_DangNhap);
            groupBox2.Controls.Add(txt_MatKhau);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_TaiKhoan);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(343, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 236);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin đăng nhập";
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(275, 176);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(102, 176);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(94, 29);
            btn_DangNhap.TabIndex = 5;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(102, 110);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(267, 27);
            txt_MatKhau.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 117);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu";
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(102, 56);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(267, 27);
            txt_TaiKhoan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 59);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fpt_polytechnic_inkythuatso_09_13_08_21;
            pictureBox1.Location = new Point(22, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(182, 76);
            label2.Name = "label2";
            label2.Size = new Size(396, 25);
            label2.TabIndex = 8;
            label2.Text = "ĐĂNG NHẬP HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            label2.Click += label2_Click;
            // 
            // FDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FDangNhap";
            Text = "Đăng Nhập";
            Load += FDangNhap_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btn_Thoat;
        private Button btn_DangNhap;
        private TextBox txt_MatKhau;
        private Label label3;
        private TextBox txt_TaiKhoan;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
