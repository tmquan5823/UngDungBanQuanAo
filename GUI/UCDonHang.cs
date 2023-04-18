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
        public UCDonHang(UserInfo ui)
        {
            InitializeComponent();
            this.ui = ui;
            HienThiBill();
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

                HienThiSanPham(IDBill);

            }
        }

        private void btn_XacNhanDonHang_Click(object sender, EventArgs e)
        {

        }

        private void lv_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
