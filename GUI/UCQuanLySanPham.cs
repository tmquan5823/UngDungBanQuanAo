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
            listView1.Items.Clear();
            foreach(var item in cBLL.getList())
            {
                ListViewItem lvi  = new ListViewItem(item.clothesID.ToString());
                lvi.SubItems.Add(item.clothesName);
                lvi.SubItems.Add(item.color);
                lvi.SubItems.Add(item.price.ToString());
                lvi.SubItems.Add(sBLL.numberOfClothes(item.clothesID).ToString());
                listView1.Items.Add(lvi);
            }
        }
        private void UCQuanLySanPham_Load(object sender, EventArgs e)
        {
            showListSanPham();
        }
    }
}
