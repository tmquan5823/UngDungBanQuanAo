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
using BLL;

namespace GUI
{
    public partial class UCQuanLyDonHang : UserControl
    {
        public UCQuanLyDonHang()
        {
            InitializeComponent();
            HienThiHoaDon();
        }

        public void HienThiHoaDon()
        {
            List<Bill> bills = BillBLL.getInstance.getListBill();
            listBill.Items.Clear();
            foreach (Bill bill in bills)
            {
                ListViewItem item = new ListViewItem(bill.BillID + "");
                item.SubItems.Add(bill.UserID + "");
                int UserID = bill.UserID;
                UserInfo person = UserInfoBLL.instance.getUserByID(UserID);
                item.SubItems.Add(person.UserName);
                item.SubItems.Add(bill.BuyDate.ToString());
                item.SubItems.Add(bill.TotalPrice + "");
                item.SubItems.Add(bill.status);
                listBill.Items.Add(item);
            }
        }

        private void listBill_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(listBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listBill.SelectedItems[0];
                txt_IDHoaDon.Text = lvi.SubItems[0].Text;
                int IDHoaDon = Int32.Parse(lvi.SubItems[0].Text);
                Bill bill1 = BillBLL.getInstance.getBillByID(IDHoaDon);
                txt_IDKhachHang.Text = lvi.SubItems[1].Text;
                txt_TenKhachHang.Text = lvi.SubItems[2].Text;
                dtp_NgayLapHD.Value = DateTime.Parse(lvi.SubItems[3].Text);
                lbl_TongTien.Text = lvi.SubItems[4].Text;
                txt_TinhTrang.Text = lvi.SubItems[5].Text;
                txt_PTThanhToan.Text = bill1.paymentMethod.ToString();

                // Hiển thị BillDetail
                List<BillDetail> listBD = BillBLL.getInstance.getBillDetailByBillID(IDHoaDon);
                listViewSanPham.Items.Clear();
                
                foreach(BillDetail bd in listBD)
                {
                    DTO.SizeClothes temp2 = SizeBLL.instance.getByID(bd.SizeID);
                    Clothes temp = ClothesBLL.instance.getClothesByID(temp2.clothesID);
                    ListViewItem lvi2 = new ListViewItem(temp.clothesID + "");

                    
                    lvi2.SubItems.Add(temp.clothesName);
                    lvi2.SubItems.Add(temp2.NameSize);
                    lvi2.SubItems.Add(bd.Price + "");
                    lvi2.SubItems.Add(bd.BuyQuantity + "");
                    
                    listViewSanPham.Items.Add(lvi2);
                }
            }
        }

        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            if (txt_IDHoaDon.Text == "")
            {
                MessageBox.Show("Mời bạn chọn một bill trong danh sách !!");
                return;
            }
            int BillID = Int32.Parse(txt_IDHoaDon.Text);
            BillBLL.getInstance.updateBillStatus(BillID, "Đã hủy đơn");
            MessageBox.Show("Đã lưu trạng thái thành công");
            HienThiHoaDon();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (txt_IDHoaDon.Text == "")
            {
                MessageBox.Show("Mời bạn chọn một bill trong danh sách !!");
                return;
            }
            int BillID = Int32.Parse(txt_IDHoaDon.Text);
            BillBLL.getInstance.updateBillStatus(BillID, "Đã xác nhận");
            MessageBox.Show("Đã lưu trạng thái thành công");
            HienThiHoaDon();
        }

        public void HienThiBillByStatus(string status)
        {
            List<Bill> bills = BillBLL.getInstance.getListBillByStatus(status);
            listBill.Items.Clear();
            foreach (Bill bill in bills)
            {
                ListViewItem item = new ListViewItem(bill.BillID + "");
                item.SubItems.Add(bill.UserID + "");
                int UserID = bill.UserID;
                UserInfo person = UserInfoBLL.instance.getUserByID(UserID);
                item.SubItems.Add(person.UserName);
                item.SubItems.Add(bill.BuyDate.ToString());
                item.SubItems.Add(bill.TotalPrice + "");
                item.SubItems.Add(bill.status);
                listBill.Items.Add(item);
            }
        }

        private void cbx_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_TinhTrang.SelectedItem.ToString() == "Chưa xác nhận")
            {
                HienThiBillByStatus("Chưa xác nhận");
                lbl_TongTien.Text = BillBLL.getInstance.getTotalBillsByStatus("Chưa xác nhận") + "";
            }
            else if (cbx_TinhTrang.SelectedItem.ToString() == "Đã xác nhận")
            {
                HienThiBillByStatus("Đã xác nhận");
                lbl_TongTien.Text = BillBLL.getInstance.getTotalBillsByStatus("Đã xác nhận") + "";
            }
            else if (cbx_TinhTrang.SelectedItem.ToString() == "Đã hủy đơn")
            {
                HienThiBillByStatus("Đã hủy đơn");
                lbl_TongTien.Text = BillBLL.getInstance.getTotalBillsByStatus("Đã hủy đơn") + "";
            }
            else if (cbx_TinhTrang.SelectedItem.ToString() == "Tất cả")
            {
                HienThiHoaDon();
                lbl_TongTien.Text = BillBLL.getInstance.getTotalPriceAllBills() + "";
            }
        }
    }
}
