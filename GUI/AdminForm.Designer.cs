namespace GUI
{
    partial class AdminForm
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
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.panel_info = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_TrangChu = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLyDonHang = new FontAwesome.Sharp.IconButton();
            this.btn_QuanLySanPham = new FontAwesome.Sharp.IconButton();
            this.btn_dangxuat = new FontAwesome.Sharp.IconButton();
            this.btn_admin = new FontAwesome.Sharp.IconButton();
            this.panel_sidebar.SuspendLayout();
            this.panel_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.Controls.Add(this.btn_TrangChu);
            this.panel_sidebar.Controls.Add(this.btn_QuanLyDonHang);
            this.panel_sidebar.Controls.Add(this.btn_QuanLySanPham);
            this.panel_sidebar.Controls.Add(this.panel_admin);
            this.panel_sidebar.Controls.Add(this.btn_admin);
            this.panel_sidebar.Controls.Add(this.panel_logo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(300, 753);
            this.panel_sidebar.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(300, 205);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_admin
            // 
            this.panel_admin.Controls.Add(this.btn_dangxuat);
            this.panel_admin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_admin.Location = new System.Drawing.Point(0, 285);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(300, 80);
            this.panel_admin.TabIndex = 2;
            this.panel_admin.Visible = false;
            // 
            // panel_info
            // 
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(300, 0);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(1082, 50);
            this.panel_info.TabIndex = 1;
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(300, 50);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1082, 703);
            this.panel_main.TabIndex = 2;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_TrangChu.IconColor = System.Drawing.Color.Black;
            this.btn_TrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_TrangChu.Location = new System.Drawing.Point(0, 525);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(300, 80);
            this.btn_TrangChu.TabIndex = 5;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.UseVisualStyleBackColor = true;
            // 
            // btn_QuanLyDonHang
            // 
            this.btn_QuanLyDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLyDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLyDonHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_QuanLyDonHang.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLyDonHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLyDonHang.Location = new System.Drawing.Point(0, 445);
            this.btn_QuanLyDonHang.Name = "btn_QuanLyDonHang";
            this.btn_QuanLyDonHang.Size = new System.Drawing.Size(300, 80);
            this.btn_QuanLyDonHang.TabIndex = 4;
            this.btn_QuanLyDonHang.Text = "Quản lý đơn hàng";
            this.btn_QuanLyDonHang.UseVisualStyleBackColor = true;
            // 
            // btn_QuanLySanPham
            // 
            this.btn_QuanLySanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_QuanLySanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuanLySanPham.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_QuanLySanPham.IconColor = System.Drawing.Color.Black;
            this.btn_QuanLySanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_QuanLySanPham.Location = new System.Drawing.Point(0, 365);
            this.btn_QuanLySanPham.Name = "btn_QuanLySanPham";
            this.btn_QuanLySanPham.Size = new System.Drawing.Size(300, 80);
            this.btn_QuanLySanPham.TabIndex = 3;
            this.btn_QuanLySanPham.Text = "Quản lý sản phẩm";
            this.btn_QuanLySanPham.UseVisualStyleBackColor = true;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_dangxuat.IconColor = System.Drawing.Color.Black;
            this.btn_dangxuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 0);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(300, 80);
            this.btn_dangxuat.TabIndex = 1;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
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
            this.btn_admin.Text = "Admin";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_sidebar);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel_sidebar.ResumeLayout(false);
            this.panel_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sidebar;
        private FontAwesome.Sharp.IconButton btn_admin;
        private System.Windows.Forms.Panel panel_logo;
        private FontAwesome.Sharp.IconButton btn_TrangChu;
        private FontAwesome.Sharp.IconButton btn_QuanLyDonHang;
        private FontAwesome.Sharp.IconButton btn_QuanLySanPham;
        private System.Windows.Forms.Panel panel_admin;
        private FontAwesome.Sharp.IconButton btn_dangxuat;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_main;
    }
}