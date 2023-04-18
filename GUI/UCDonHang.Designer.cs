namespace GUI
{
    partial class UCDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grb_TTHoaDon = new System.Windows.Forms.GroupBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TenNguoiNhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SoLuongSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_KichThuoc = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cbx_SanPham = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_PTThanhToan = new System.Windows.Forms.ComboBox();
            this.btn_HuyDon = new System.Windows.Forms.Button();
            this.btn_XacNhanDonHang = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_SanPham = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grb_TTHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBill);
            this.panel1.Location = new System.Drawing.Point(8, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 366);
            this.panel1.TabIndex = 0;
            // 
            // listBill
            // 
            this.listBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader3});
            this.listBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBill.FullRowSelect = true;
            this.listBill.GridLines = true;
            this.listBill.HideSelection = false;
            this.listBill.Location = new System.Drawing.Point(13, 46);
            this.listBill.Name = "listBill";
            this.listBill.Size = new System.Drawing.Size(1245, 314);
            this.listBill.TabIndex = 1;
            this.listBill.UseCompatibleStateImageBehavior = false;
            this.listBill.View = System.Windows.Forms.View.Details;
            this.listBill.SelectedIndexChanged += new System.EventHandler(this.listBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID hóa đơn";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID khách hàng";
            this.columnHeader2.Width = 174;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày tạo hóa đơn";
            this.columnHeader6.Width = 261;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Phương thức thanh toán";
            this.columnHeader7.Width = 237;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tổng tiền";
            this.columnHeader8.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tình trạng";
            this.columnHeader3.Width = 239;
            // 
            // grb_TTHoaDon
            // 
            this.grb_TTHoaDon.Controls.Add(this.btn_Reset);
            this.grb_TTHoaDon.Controls.Add(this.txt_SDT);
            this.grb_TTHoaDon.Controls.Add(this.label9);
            this.grb_TTHoaDon.Controls.Add(this.txt_DiaChi);
            this.grb_TTHoaDon.Controls.Add(this.label8);
            this.grb_TTHoaDon.Controls.Add(this.txt_TenNguoiNhan);
            this.grb_TTHoaDon.Controls.Add(this.label6);
            this.grb_TTHoaDon.Controls.Add(this.txt_SoLuongSize);
            this.grb_TTHoaDon.Controls.Add(this.label5);
            this.grb_TTHoaDon.Controls.Add(this.btn_xoa);
            this.grb_TTHoaDon.Controls.Add(this.label4);
            this.grb_TTHoaDon.Controls.Add(this.cbx_KichThuoc);
            this.grb_TTHoaDon.Controls.Add(this.btn_Them);
            this.grb_TTHoaDon.Controls.Add(this.cbx_SanPham);
            this.grb_TTHoaDon.Controls.Add(this.label3);
            this.grb_TTHoaDon.Controls.Add(this.cbx_PTThanhToan);
            this.grb_TTHoaDon.Controls.Add(this.btn_HuyDon);
            this.grb_TTHoaDon.Controls.Add(this.btn_XacNhanDonHang);
            this.grb_TTHoaDon.Controls.Add(this.label7);
            this.grb_TTHoaDon.Controls.Add(this.lbl_TongTien);
            this.grb_TTHoaDon.Controls.Add(this.label1);
            this.grb_TTHoaDon.Controls.Add(this.lv_SanPham);
            this.grb_TTHoaDon.Location = new System.Drawing.Point(14, 14);
            this.grb_TTHoaDon.Name = "grb_TTHoaDon";
            this.grb_TTHoaDon.Size = new System.Drawing.Size(1252, 388);
            this.grb_TTHoaDon.TabIndex = 1;
            this.grb_TTHoaDon.TabStop = false;
            this.grb_TTHoaDon.Text = "Thông tin hóa đơn";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(155, 131);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(466, 34);
            this.txt_SDT.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Số điện thoại";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(155, 78);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(469, 34);
            this.txt_DiaChi.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Địa chỉ";
            // 
            // txt_TenNguoiNhan
            // 
            this.txt_TenNguoiNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNguoiNhan.Location = new System.Drawing.Point(155, 24);
            this.txt_TenNguoiNhan.Name = "txt_TenNguoiNhan";
            this.txt_TenNguoiNhan.Size = new System.Drawing.Size(469, 34);
            this.txt_TenNguoiNhan.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên người nhận";
            // 
            // txt_SoLuongSize
            // 
            this.txt_SoLuongSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongSize.Location = new System.Drawing.Point(442, 227);
            this.txt_SoLuongSize.Name = "txt_SoLuongSize";
            this.txt_SoLuongSize.Size = new System.Drawing.Size(182, 34);
            this.txt_SoLuongSize.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số lượng";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(648, 335);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(96, 41);
            this.btn_xoa.TabIndex = 24;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kích thước";
            // 
            // cbx_KichThuoc
            // 
            this.cbx_KichThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_KichThuoc.FormattingEnabled = true;
            this.cbx_KichThuoc.Items.AddRange(new object[] {
            "Size S",
            "Size M",
            "Size L"});
            this.cbx_KichThuoc.Location = new System.Drawing.Point(155, 229);
            this.cbx_KichThuoc.Name = "cbx_KichThuoc";
            this.cbx_KichThuoc.Size = new System.Drawing.Size(178, 33);
            this.cbx_KichThuoc.TabIndex = 22;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(486, 171);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(135, 41);
            this.btn_Them.TabIndex = 21;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cbx_SanPham
            // 
            this.cbx_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_SanPham.FormattingEnabled = true;
            this.cbx_SanPham.Location = new System.Drawing.Point(155, 179);
            this.cbx_SanPham.Name = "cbx_SanPham";
            this.cbx_SanPham.Size = new System.Drawing.Size(325, 33);
            this.cbx_SanPham.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sản phẩm";
            // 
            // cbx_PTThanhToan
            // 
            this.cbx_PTThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PTThanhToan.FormattingEnabled = true;
            this.cbx_PTThanhToan.Items.AddRange(new object[] {
            "",
            "Ví VNPay",
            "Ví Momo",
            "Thanh toán khi nhận hàng"});
            this.cbx_PTThanhToan.Location = new System.Drawing.Point(155, 278);
            this.cbx_PTThanhToan.Name = "cbx_PTThanhToan";
            this.cbx_PTThanhToan.Size = new System.Drawing.Size(469, 33);
            this.cbx_PTThanhToan.TabIndex = 18;
            // 
            // btn_HuyDon
            // 
            this.btn_HuyDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_HuyDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyDon.Location = new System.Drawing.Point(158, 324);
            this.btn_HuyDon.Name = "btn_HuyDon";
            this.btn_HuyDon.Size = new System.Drawing.Size(160, 52);
            this.btn_HuyDon.TabIndex = 17;
            this.btn_HuyDon.Text = "Hủy đơn";
            this.btn_HuyDon.UseVisualStyleBackColor = false;
            this.btn_HuyDon.Click += new System.EventHandler(this.btn_HuyDon_Click);
            // 
            // btn_XacNhanDonHang
            // 
            this.btn_XacNhanDonHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_XacNhanDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhanDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhanDonHang.Location = new System.Drawing.Point(387, 325);
            this.btn_XacNhanDonHang.Name = "btn_XacNhanDonHang";
            this.btn_XacNhanDonHang.Size = new System.Drawing.Size(212, 51);
            this.btn_XacNhanDonHang.TabIndex = 16;
            this.btn_XacNhanDonHang.Text = "Xác nhận đơn hàng";
            this.btn_XacNhanDonHang.UseVisualStyleBackColor = false;
            this.btn_XacNhanDonHang.Click += new System.EventHandler(this.btn_XacNhanDonHang_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "PT thanh toán";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(1069, 323);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(150, 39);
            this.lbl_TongTien.TabIndex = 3;
            this.lbl_TongTien.Text = "1000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(880, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền: ";
            // 
            // lv_SanPham
            // 
            this.lv_SanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader5,
            this.columnHeader9});
            this.lv_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_SanPham.FullRowSelect = true;
            this.lv_SanPham.GridLines = true;
            this.lv_SanPham.HideSelection = false;
            this.lv_SanPham.Location = new System.Drawing.Point(648, 21);
            this.lv_SanPham.Name = "lv_SanPham";
            this.lv_SanPham.Size = new System.Drawing.Size(588, 290);
            this.lv_SanPham.TabIndex = 1;
            this.lv_SanPham.UseCompatibleStateImageBehavior = false;
            this.lv_SanPham.View = System.Windows.Forms.View.Details;
            this.lv_SanPham.SelectedIndexChanged += new System.EventHandler(this.lv_SanPham_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID sản phẩm";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên sản phẩm";
            this.columnHeader12.Width = 149;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Kích thước";
            this.columnHeader14.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá";
            this.columnHeader5.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số lượng";
            this.columnHeader9.Width = 101;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.White;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(750, 335);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(96, 41);
            this.btn_Reset.TabIndex = 33;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // UCDonHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grb_TTHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "UCDonHang";
            this.Size = new System.Drawing.Size(1282, 803);
            this.panel1.ResumeLayout(false);
            this.grb_TTHoaDon.ResumeLayout(false);
            this.grb_TTHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox grb_TTHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_KichThuoc;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox cbx_SanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_PTThanhToan;
        private System.Windows.Forms.Button btn_HuyDon;
        private System.Windows.Forms.Button btn_XacNhanDonHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_SanPham;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenNguoiNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SoLuongSize;
        private System.Windows.Forms.Button btn_Reset;
    }
}
