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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Dispose();
            frm.ShowDialog();
        }
    }
}
