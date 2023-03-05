﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            Form3 frm3 = new Form3();
            if (rdo_Yurtici.Checked == true)
            {
                frm2.ShowDialog();
            }
            else if (rdo_Global.Checked == true)
            {
                frm3.ShowDialog();
            }
        }
    }
}
