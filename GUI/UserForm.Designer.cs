namespace GUI
{
    partial class UserForm
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
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.btn_QuanLyDonHang = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLySanPham = new FontAwesome.Sharp.IconButton();
            this.panel_user = new System.Windows.Forms.Panel();
            this.btn_DangXuat = new FontAwesome.Sharp.IconButton();
            this.btn_TTCaNhan = new FontAwesome.Sharp.IconButton();
            this.btn_admin = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.panel_sidebar.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Controls.Add(this.btn_QuanLyDonHang);
            this.panel_sidebar.Controls.Add(this.btn_QuanLySanPham);
            this.panel_sidebar.Controls.Add(this.panel_user);
            this.panel_sidebar.Controls.Add(this.btn_admin);
            this.panel_sidebar.Controls.Add(this.panel_logo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(300, 853);
            this.panel_sidebar.TabIndex = 1;
            // 
            // btn_QuanLyDonHang
            // 
            this.btn_QuanLyDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyDonHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_QuanLyDonHang.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLyDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLyDonHang.Location = new System.Drawing.Point(0, 525);
            this.btn_QuanLyDonHang.Name = "btn_QuanLyDonHang";
            this.btn_QuanLyDonHang.Size = new System.Drawing.Size(300, 80);
            this.btn_QuanLyDonHang.TabIndex = 4;
            this.btn_QuanLyDonHang.Text = "Đơn hàng";
            this.btn_QuanLyDonHang.UseVisualStyleBackColor = true;
            this.btn_QuanLyDonHang.Click += new System.EventHandler(this.btn_QuanLyDonHang_Click);
            // 
            // btn_QuanLySanPham
            // 
            this.btn_QuanLySanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLySanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLySanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_QuanLySanPham.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLySanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLySanPham.Location = new System.Drawing.Point(0, 445);
            this.btn_QuanLySanPham.Name = "btn_QuanLySanPham";
            this.btn_QuanLySanPham.Size = new System.Drawing.Size(300, 80);
            this.btn_QuanLySanPham.TabIndex = 3;
            this.btn_QuanLySanPham.Text = "Trang Chủ";
            this.btn_QuanLySanPham.UseVisualStyleBackColor = true;
            this.btn_QuanLySanPham.Click += new System.EventHandler(this.btn_QuanLySanPham_Click);
            // 
            // panel_user
            // 
            this.panel_user.Controls.Add(this.btn_DangXuat);
            this.panel_user.Controls.Add(this.btn_TTCaNhan);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 285);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(300, 160);
            this.panel_user.TabIndex = 2;
            this.panel_user.Visible = false;
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_DangXuat.IconColor = System.Drawing.Color.Black;
            this.btn_DangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DangXuat.Location = new System.Drawing.Point(0, 80);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(300, 80);
            this.btn_DangXuat.TabIndex = 1;
            this.btn_DangXuat.Text = "Đăng Xuất";
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            // 
            // btn_TTCaNhan
            // 
            this.btn_TTCaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TTCaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TTCaNhan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_TTCaNhan.IconColor = System.Drawing.Color.Black;
            this.btn_TTCaNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TTCaNhan.Location = new System.Drawing.Point(0, 0);
            this.btn_TTCaNhan.Name = "btn_TTCaNhan";
            this.btn_TTCaNhan.Size = new System.Drawing.Size(300, 80);
            this.btn_TTCaNhan.TabIndex = 0;
            this.btn_TTCaNhan.Text = "Thông tin cá nhân";
            this.btn_TTCaNhan.UseVisualStyleBackColor = true;
            this.btn_TTCaNhan.Click += new System.EventHandler(this.btn_TTCaNhan_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_admin.IconColor = System.Drawing.Color.Black;
            this.btn_admin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_admin.Location = new System.Drawing.Point(0, 205);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(300, 80);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "User";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(300, 205);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(300, 50);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1282, 803);
            this.panel_main.TabIndex = 4;
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.lbl_info);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(300, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1282, 50);
            this.panel_info.TabIndex = 3;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_info.Location = new System.Drawing.Point(6, 9);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(90, 31);
            this.lbl_info.TabIndex = 1;
            this.lbl_info.Text = "Home";
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_sidebar);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel_sidebar.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Panel panel_user;
        private FontAwesome.Sharp.IconButton btn_admin;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton btn_QuanLyDonHang;
        private FontAwesome.Sharp.IconButton btn_QuanLySanPham;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_info;
        private FontAwesome.Sharp.IconButton btn_DangXuat;
        private FontAwesome.Sharp.IconButton btn_TTCaNhan;
        private System.Windows.Forms.Label lbl_info;
    }
}