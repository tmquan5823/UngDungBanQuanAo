namespace GUI
{
    partial class UCQuanLySanPham
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
            this.txt_Timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_sapxep = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ListViewSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TongCong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_Size = new System.Windows.Forms.ComboBox();
            this.txt_SoLuongSize = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_MoTa = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_XuatXu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MauSac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IDSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grb_info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Timkiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_sapxep);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.ListViewSanPham);
            this.panel1.Location = new System.Drawing.Point(17, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 381);
            this.panel1.TabIndex = 0;
            // 
            // txt_Timkiem
            // 
            this.txt_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Timkiem.Location = new System.Drawing.Point(1011, 17);
            this.txt_Timkiem.Name = "txt_Timkiem";
            this.txt_Timkiem.Size = new System.Drawing.Size(229, 30);
            this.txt_Timkiem.TabIndex = 4;
            this.txt_Timkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Timkiem_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(914, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // lbl_sapxep
            // 
            this.lbl_sapxep.AutoSize = true;
            this.lbl_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sapxep.Location = new System.Drawing.Point(15, 22);
            this.lbl_sapxep.Name = "lbl_sapxep";
            this.lbl_sapxep.Size = new System.Drawing.Size(85, 25);
            this.lbl_sapxep.TabIndex = 2;
            this.lbl_sapxep.Text = "Sắp xếp";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID sản phẩm",
            "Giá"});
            this.comboBox1.Location = new System.Drawing.Point(106, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ListViewSanPham
            // 
            this.ListViewSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader3});
            this.ListViewSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewSanPham.FullRowSelect = true;
            this.ListViewSanPham.GridLines = true;
            this.ListViewSanPham.HideSelection = false;
            this.ListViewSanPham.Location = new System.Drawing.Point(17, 57);
            this.ListViewSanPham.Name = "ListViewSanPham";
            this.ListViewSanPham.Size = new System.Drawing.Size(1224, 318);
            this.ListViewSanPham.TabIndex = 0;
            this.ListViewSanPham.UseCompatibleStateImageBehavior = false;
            this.ListViewSanPham.View = System.Windows.Forms.View.Details;
            this.ListViewSanPham.SelectedIndexChanged += new System.EventHandler(this.ListViewSanPham_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID sản phẩm";
            this.columnHeader1.Width = 218;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 335;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Màu sắc";
            this.columnHeader5.Width = 219;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Giá";
            this.columnHeader6.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng số lượng";
            this.columnHeader3.Width = 236;
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.groupBox1);
            this.grb_info.Controls.Add(this.btn_xoa);
            this.grb_info.Controls.Add(this.btn_sua);
            this.grb_info.Controls.Add(this.btn_them);
            this.grb_info.Controls.Add(this.txt_MoTa);
            this.grb_info.Controls.Add(this.label8);
            this.grb_info.Controls.Add(this.txt_Gia);
            this.grb_info.Controls.Add(this.label7);
            this.grb_info.Controls.Add(this.txt_XuatXu);
            this.grb_info.Controls.Add(this.label6);
            this.grb_info.Controls.Add(this.txt_MauSac);
            this.grb_info.Controls.Add(this.label5);
            this.grb_info.Controls.Add(this.txt_IDSanPham);
            this.grb_info.Controls.Add(this.label4);
            this.grb_info.Controls.Add(this.txt_TenSanPham);
            this.grb_info.Controls.Add(this.label3);
            this.grb_info.Location = new System.Drawing.Point(17, 15);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(1244, 352);
            this.grb_info.TabIndex = 1;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "Thông tin sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_TongCong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbx_Size);
            this.groupBox1.Controls.Add(this.txt_SoLuongSize);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(582, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 147);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số lượng";
            // 
            // txt_TongCong
            // 
            this.txt_TongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongCong.Location = new System.Drawing.Point(218, 97);
            this.txt_TongCong.Name = "txt_TongCong";
            this.txt_TongCong.Size = new System.Drawing.Size(216, 34);
            this.txt_TongCong.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(91, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tổng cộng:";
            // 
            // cbx_Size
            // 
            this.cbx_Size.BackColor = System.Drawing.Color.Gainsboro;
            this.cbx_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Size.FormattingEnabled = true;
            this.cbx_Size.Items.AddRange(new object[] {
            "Size S",
            "Size M",
            "Size L"});
            this.cbx_Size.Location = new System.Drawing.Point(24, 39);
            this.cbx_Size.Name = "cbx_Size";
            this.cbx_Size.Size = new System.Drawing.Size(185, 33);
            this.cbx_Size.TabIndex = 20;
            this.cbx_Size.SelectedIndexChanged += new System.EventHandler(this.cbx_Size_SelectedIndexChanged);
            // 
            // txt_SoLuongSize
            // 
            this.txt_SoLuongSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongSize.Location = new System.Drawing.Point(218, 38);
            this.txt_SoLuongSize.Name = "txt_SoLuongSize";
            this.txt_SoLuongSize.Size = new System.Drawing.Size(216, 34);
            this.txt_SoLuongSize.TabIndex = 19;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(1058, 266);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(160, 57);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(1058, 154);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(160, 57);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(1058, 42);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(160, 57);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoTa.Location = new System.Drawing.Point(107, 206);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(455, 119);
            this.txt_MoTa.TabIndex = 14;
            this.txt_MoTa.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mô tả";
            // 
            // txt_Gia
            // 
            this.txt_Gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gia.Location = new System.Drawing.Point(162, 154);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(342, 34);
            this.txt_Gia.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giá";
            // 
            // txt_XuatXu
            // 
            this.txt_XuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_XuatXu.Location = new System.Drawing.Point(678, 91);
            this.txt_XuatXu.Name = "txt_XuatXu";
            this.txt_XuatXu.Size = new System.Drawing.Size(342, 34);
            this.txt_XuatXu.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Xuất xứ";
            // 
            // txt_MauSac
            // 
            this.txt_MauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MauSac.Location = new System.Drawing.Point(162, 93);
            this.txt_MauSac.Name = "txt_MauSac";
            this.txt_MauSac.Size = new System.Drawing.Size(342, 34);
            this.txt_MauSac.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Màu sắc";
            // 
            // txt_IDSanPham
            // 
            this.txt_IDSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDSanPham.Location = new System.Drawing.Point(162, 36);
            this.txt_IDSanPham.Name = "txt_IDSanPham";
            this.txt_IDSanPham.Size = new System.Drawing.Size(342, 34);
            this.txt_IDSanPham.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID sản phẩm";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(678, 36);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(342, 34);
            this.txt_TenSanPham.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // UCQuanLySanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.grb_info);
            this.Controls.Add(this.panel1);
            this.Name = "UCQuanLySanPham";
            this.Size = new System.Drawing.Size(1282, 803);
            this.Load += new System.EventHandler(this.UCQuanLySanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_sapxep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView ListViewSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.TextBox txt_IDSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_XuatXu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MauSac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.RichTextBox txt_MoTa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SoLuongSize;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_Size;
        private System.Windows.Forms.TextBox txt_TongCong;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
