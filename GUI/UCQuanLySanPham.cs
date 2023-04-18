using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class UCQuanLySanPham : UserControl
    {
        ClothesBLL cBLL = new ClothesBLL();
        SizeBLL sBLL = new SizeBLL();
        public UCQuanLySanPham()
        {
            InitializeComponent();
        }

        public void showListSanPham()
        {
            ListViewSanPham.Items.Clear();
            foreach(var item in cBLL.getList())
            {
                ListViewItem lvi  = new ListViewItem(item.clothesID.ToString());
                lvi.SubItems.Add(item.clothesName);
                lvi.SubItems.Add(item.color);
                lvi.SubItems.Add(item.price.ToString());
                lvi.SubItems.Add(sBLL.numberOfClothes(item.clothesID).ToString());
                ListViewSanPham.Items.Add(lvi);
            }
        }
        private void UCQuanLySanPham_Load(object sender, EventArgs e)
        {
            showListSanPham();
        }

        private void ListViewSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListViewSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = ListViewSanPham.SelectedItems[0];
                txt_IDSanPham.Text = lvi.SubItems[0].Text;

                int IDSanPham = Int32.Parse(lvi.SubItems[0].Text);
                Clothes SP = ClothesBLL.instance.getClothesByID(IDSanPham);
                txt_TenSanPham.Text = lvi.SubItems[1].Text;
                txt_MauSac.Text = lvi.SubItems[2].Text;
                txt_Gia.Text = lvi.SubItems[3].Text;
                txt_TongCong.Text = lvi.SubItems[4].Text;
                txt_XuatXu.Text = SP.origin;
                txt_MoTa.Text = SP.clothesDescription.ToString();
            }
        }

        private void cbx_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_IDSanPham.Text.Length > 0)
            {
                String Size = cbx_Size.SelectedItem.ToString().Substring(5);
                int ClothesID = Int32.Parse(txt_IDSanPham.Text);
                SizeClothes app = SizeBLL.instance.getSizeByNameAndClothesID(Size, ClothesID);
                txt_SoLuongSize.Text = app.quantity + "";
            }
            else
            {
                MessageBox.Show("Mời bạn chọn Sản phẩm trong danh sách bên dưới ");
            }
        }

        private void txt_Timkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ClothesName = txt_Timkiem.Text;
                ListViewSanPham.Items.Clear();
                Clothes clo = ClothesBLL.instance.getClothesByName(ClothesName);
                ListViewItem lvi = new ListViewItem(clo.clothesID + "");
                lvi.SubItems.Add(clo.clothesName);
                lvi.SubItems.Add(clo.color);
                lvi.SubItems.Add(clo.price + "");
                lvi.SubItems.Add(sBLL.numberOfClothes(clo.clothesID).ToString());
                ListViewSanPham.Items.Add(lvi);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Choose = comboBox1.SelectedItem.ToString();
            if(Choose == "ID sản phẩm")
            {
                ListViewSanPham.Items.Clear();
                foreach (var item in cBLL.getListByValue("ClothesID"))
                {
                    ListViewItem lvi = new ListViewItem(item.clothesID.ToString());
                    lvi.SubItems.Add(item.clothesName);
                    lvi.SubItems.Add(item.color);
                    lvi.SubItems.Add(item.price.ToString());
                    lvi.SubItems.Add(sBLL.numberOfClothes(item.clothesID).ToString());
                    ListViewSanPham.Items.Add(lvi);
                }
            }
            else if(Choose == "Giá")
            {
                ListViewSanPham.Items.Clear();
                foreach (var item in cBLL.getListByValue("Price"))
                {
                    ListViewItem lvi = new ListViewItem(item.clothesID.ToString());
                    lvi.SubItems.Add(item.clothesName);
                    lvi.SubItems.Add(item.color);
                    lvi.SubItems.Add(item.price.ToString());
                    lvi.SubItems.Add(sBLL.numberOfClothes(item.clothesID).ToString());
                    ListViewSanPham.Items.Add(lvi);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(ListViewSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = ListViewSanPham.SelectedItems[0];
                int IDSanPham = Int32.Parse(lvi.SubItems[0].Text);
                ClothesBLL.instance.deleteClothesByID(IDSanPham);
                MessageBox.Show("Xoá sản phẩm thành công !!!");
                showListSanPham();
            }
            else
            {
                MessageBox.Show("Mời bạn chọn sản phẩm ở danh sách bên dưới !!!");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(ListViewSanPham.SelectedItems == null)
            {
                MessageBox.Show("Mời bạn chọn sản phẩm trong danh sách bên dưới để chỉnh sửa");
                return;
            }
            else if(txt_IDSanPham.Text == "")
            {
                MessageBox.Show("ID sản phẩm không đúng mời bạn nhập lại ");
                return;
            }
            else if(txt_MauSac == null || txt_MoTa == null || txt_TenSanPham == null || txt_XuatXu == null || txt_Gia == null )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!!");
                return;
            }
            Clothes clo = new Clothes();
            clo.clothesID = Int32.Parse(txt_IDSanPham.Text);
            clo.clothesName = txt_TenSanPham.Text;
            clo.clothesDescription = txt_MoTa.Text;
            clo.price = Int32.Parse(txt_Gia.Text);
            clo.color = txt_MauSac.Text;
            clo.origin = txt_XuatXu.Text;

            ClothesBLL.instance.UpdateClothes(clo);

            if(cbx_Size.SelectedIndex > 0 && txt_SoLuongSize != null)
            {
                String Size = cbx_Size.SelectedItem.ToString().Substring(5);
                SizeBLL.instance.UpdateNumberOfSize(Size, clo.clothesID, Int32.Parse(txt_SoLuongSize.Text));
            }

            MessageBox.Show("Chỉnh sửa thành công !!!");

            showListSanPham();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_MauSac == null || txt_MoTa == null || txt_TenSanPham == null || txt_XuatXu == null || txt_Gia == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!!!");
                return;
            }
            else if (cbx_Size.SelectedIndex == 0 && txt_SoLuongSize == null)
            {
                MessageBox.Show("Vui lòng chọn size và nhập số lượng cho size tương ứng !!");
                return;
            }
            int ClothesID = Int32.Parse(txt_IDSanPham.Text);
            string ClothesName = txt_TenSanPham.Text;
            string Color = txt_MauSac.Text;
            string description = txt_MoTa.Text;
            string origin = txt_XuatXu.Text;
            int price = Int32.Parse(txt_Gia.Text);

            Clothes clo = new Clothes(ClothesID, ClothesName, price, origin, Color, description);

            ClothesBLL.instance.addClothes(clo);
            String Size = cbx_Size.SelectedItem.ToString().Substring(5);
            int quantity = Int32.Parse(txt_SoLuongSize.Text);

            SizeBLL.instance.AddSize(new SizeClothes(0, Size, quantity, ClothesID));
            showListSanPham();
        }
    }
}
