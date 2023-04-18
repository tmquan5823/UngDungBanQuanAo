using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCDonHang : UserControl
    {
        UserInfo ui = new UserInfo();
        Bill bl = new Bill();
        List<BillDetail> listBD = new List<BillDetail>();
        public UCDonHang(UserInfo ui)
        {
            InitializeComponent();
            this.ui = ui;
            HienThiBill();
            AddCbxSanPham();
        }

        public UCDonHang(Clothes clo)
        {

        }

        public void HienThiBill()
        {
            listBill.Items.Clear();
            foreach (var item in BillBLL.getInstance.getListBillByUserID(ui.UserID))
            {
                ListViewItem lvi = new ListViewItem(item.BillID + "");
                lvi.SubItems.Add(item.receiver);
                lvi.SubItems.Add(item.BuyDate.ToString());
                lvi.SubItems.Add(item.paymentMethod);
                lvi.SubItems.Add(item.TotalPrice + "");
                lvi.SubItems.Add(item.status);
                listBill.Items.Add(lvi);
            }
        }
        public void AddCbxSanPham()
        {
            cbx_SanPham.Items.Clear();
            List<Clothes> clothes = ClothesBLL.instance.getList();
            foreach(var item in clothes)
            {
                int numberOfClothes = SizeBLL.instance.numberOfClothes(item.clothesID);
                if(numberOfClothes > 0) 
                {
                    cbx_SanPham.Items.Add(item.clothesName);
                }
            }
            
        }

        public void HienThiSanPham(int BillID)
        {
            lv_SanPham.Items.Clear();
            foreach (var item in BillBLL.getInstance.getListBillDetailsByBillID(BillID))
            {
                SizeClothes SClo = SizeBLL.instance.getByID(item.SizeID);
                Clothes Clo = ClothesBLL.instance.getClothesByID(SClo.clothesID);
                ListViewItem lvi = new ListViewItem(SClo.clothesID + "");
                lvi.SubItems.Add(Clo.clothesName);
                lvi.SubItems.Add(SClo.NameSize);
                lvi.SubItems.Add(Clo.price + "");
                lvi.SubItems.Add(item.BuyQuantity + "");
                lv_SanPham.Items.Add(lvi);
            }
        }




        private void listBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listBill.SelectedItems[0];
                int IDBill = Int32.Parse(lvi.SubItems[0].Text);
                Bill bl = BillBLL.getInstance.getBillByID(IDBill);

                //
                txt_TenNguoiNhan.Text = bl.receiver;
                txt_DiaChi.Text = bl.Address;
                txt_SDT.Text = bl.Tel;
                cbx_PTThanhToan.Text = bl.paymentMethod;
                lbl_TongTien.Text = bl.TotalPrice + "";

                cbx_SanPham.Text = "";
                cbx_KichThuoc.Text = "";
                txt_SoLuongSize.Text = "";

                HienThiSanPham(IDBill);

            }
        }

        private void btn_XacNhanDonHang_Click(object sender, EventArgs e)
        {
            if(listBD.Count == 0)
            {
                MessageBox.Show("Hiện tại trong giỏ hàng bạn không có quần áo nào cả");
                return;
            }
            else
            {
                ShowSanPhamBackUp();
                DialogResult dr =  MessageBox.Show("Bạn có đồng ý với các thông tin trên hăn","Xác nhận", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    BillBLL.getInstance.addBill(bl);
                    foreach(var item in listBD)
                    {
                        BillBLL.getInstance.addBillDetail(item);
                        SizeClothes sc = SizeBLL.instance.getByID(item.SizeID);
                        SizeBLL.instance.UpdateNumberOfSize(sc.NameSize, sc.clothesID, sc.quantity - item.BuyQuantity);
                        ShowSanPhamBackUp();
                    }
                }
                else
                {
                    btn_Reset_Click(sender, e);
                }
            }
            HienThiBill();
        }

        private void lv_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_SanPham.SelectedItems.Count >0)
            {
                ListViewItem lvi = lv_SanPham.SelectedItems[0];
                cbx_SanPham.Text = lvi.SubItems[1].Text;
                cbx_KichThuoc.Text = "Size " + lvi.SubItems[2].Text;
                txt_SoLuongSize.Text = lvi.SubItems[4].Text;
                lbl_TongTien.Text = ( Int32.Parse(lvi.SubItems[3].Text) * Int32.Parse(lvi.SubItems[4].Text) ) + "";
            }
        }

        public void ShowSanPhamBackUp()
        {
            txt_TenNguoiNhan.Text = bl.receiver.ToString();
            txt_DiaChi.Text = bl.Address.ToString();
            txt_SDT.Text = bl.Tel.ToString();
            cbx_PTThanhToan.Text = bl.paymentMethod.ToString();

            int total = 0;
            foreach(var item in listBD)
            {
                total += (item.BuyQuantity * item.Price);
            }

            lbl_TongTien.Text = total + "";

            lv_SanPham.Items.Clear();
            foreach (var item in listBD)
            {
                SizeClothes SClo = SizeBLL.instance.getByID(item.SizeID);
                Clothes Clo = ClothesBLL.instance.getClothesByID(SClo.clothesID);
                ListViewItem lvi = new ListViewItem(SClo.clothesID + "");
                lvi.SubItems.Add(Clo.clothesName);
                lvi.SubItems.Add(SClo.NameSize);
                lvi.SubItems.Add(Clo.price + "");
                lvi.SubItems.Add(item.BuyQuantity + "");
                lv_SanPham.Items.Add(lvi);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (listBD.Count == 0)
            {
                if (txt_TenNguoiNhan.Text == "" || txt_SDT.Text == "" || txt_DiaChi.Text == "" || txt_SoLuongSize.Text == "" || cbx_KichThuoc.Text == "" || cbx_PTThanhToan.Text == "" || cbx_SanPham.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập và điền đầy đủ thông tin !!!");
                }

                bl.BillID = BillBLL.getInstance.getListBill().Count + 1;
                bl.paymentMethod = cbx_PTThanhToan.Text;
                bl.Tel = txt_SDT.Text;
                bl.Address = txt_DiaChi.Text;
                bl.receiver = txt_TenNguoiNhan.Text;
                bl.status = "Chưa xác nhận";
                bl.BuyDate = DateTime.Now;
                bl.UserID = ui.UserID;

                // Lấy Clothes
                Clothes clo = ClothesBLL.instance.getClothesByName(cbx_SanPham.Text);

                SizeClothes siz = new SizeClothes();
                string SizeName = cbx_KichThuoc.Text.Substring(5);
                int CloID = clo.clothesID;
                SizeClothes sz = SizeBLL.instance.getSizeByNameAndClothesID(SizeName, CloID);

                int quantity = Int32.Parse(txt_SoLuongSize.Text);

                if (quantity > sz.quantity)
                {
                    MessageBox.Show("Số lượng bạn muốn mua nhiều hơn số lượng có trong kho là: " + sz.quantity + " nên không thể mua được !!");
                    return;
                }

                BillDetail bd = new BillDetail();
                bd.BuyQuantity = quantity;
                bd.Price = clo.price * quantity;
                bd.SizeID = sz.SizeID;

                bl.TotalPrice = bd.Price;

                bd.BillID = bl.BillID;

                listBD.Add(bd);

                //sz.quantity -= quantity; Xác nhận
                //SizeBLL.instance.UpdateNumberOfSize(SizeName, clo.clothesID, sz.quantity);
            }
            else
            {
                if (cbx_SanPham.Text == "" || cbx_KichThuoc.Text == "" || txt_SoLuongSize.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập đầy đủ thông tin sản phẩm kích cỡ à số lượng !!");
                    return;
                }
                Clothes clo = ClothesBLL.instance.getClothesByName(cbx_SanPham.Text);

                SizeClothes siz = new SizeClothes();
                string SizeName = cbx_KichThuoc.Text.Substring(5);
                int CloID = clo.clothesID;
                SizeClothes sz = SizeBLL.instance.getSizeByNameAndClothesID(SizeName, CloID);

                int quantity = Int32.Parse(txt_SoLuongSize.Text);

                if (quantity > sz.quantity)
                {
                    MessageBox.Show("Số lượng bạn muốn mua nhiều hơn số lượng có trong kho là: " + sz.quantity + " nên không thể mua được !!");
                    return;
                }

                BillDetail bd = new BillDetail();
                bd.BuyQuantity = quantity;
                bd.Price = clo.price * quantity;
                bd.SizeID = sz.SizeID;

                bl.TotalPrice += bd.Price;

                bd.BillID = bl.BillID;

                listBD.Add(bd);
            }

            ShowSanPhamBackUp();
        }



        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            if(listBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listBill.SelectedItems[0];
                int IDBill = Int32.Parse(lvi.SubItems[0].Text);
                if (lvi.SubItems[5].Text == "Đã xác nhận")
                {
                    MessageBox.Show("Đơn đã được xác nhận bạn không thể hủy !!!");
                    return;
                }

                BillBLL.getInstance.updateBillStatus(IDBill, "Đã hủy đơn");
                HienThiBill();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lv_SanPham.Items.Clear();
            txt_TenNguoiNhan.Text = "";
            txt_DiaChi.Text = string.Empty;
            txt_SDT.Text = string.Empty;
            txt_SoLuongSize.Text = string.Empty;
            cbx_PTThanhToan.Text = string.Empty;
            cbx_KichThuoc.Text = string.Empty;
            cbx_SanPham.Text = string.Empty;

            bl.Tel = "";
            bl.Address = "";
            bl.receiver = string.Empty;
            bl.paymentMethod = string.Empty;
            bl.UserID = -1;
            bl.status = string.Empty;
            bl.BuyDate = DateTime.MinValue; 
            bl.TotalPrice = 0;
            bl.BillID = -1;

            listBD.Clear();
        }
    }
}
