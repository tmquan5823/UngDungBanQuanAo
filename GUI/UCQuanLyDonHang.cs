﻿using System;
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
    public partial class UCQuanLyDonHang : UserControl
    {
        public UCQuanLyDonHang()
        {
            InitializeComponent();
        }

        private void listBill_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(listBill.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listBill.SelectedItems[0];

            }
        }
    }
}
