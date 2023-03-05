using Project.BLL.GenericRepository.ConcRep;
using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            _dbcustomer = new CustomerRepository();
        }
        CustomerRepository _dbcustomer;


        private void Form2_Load(object sender, EventArgs e)
        {
            lst_Problem.Items.Add("Ürüne bağlı olan problemler");
            lst_Problem.Items.Add("Dış Etkilere Bağlı Problemler");
            cmbStand.Items.Add("Modüler Stant");
            cmbStand.Items.Add("Özel Stant");
            cmbStand.Enabled = false;
        }

        private void lst_Problems_Click(object sender, EventArgs e)
        {
            if (lst_Problem.SelectedIndex is 0)
            {
                MessageBox.Show("Isci cikarimi,Yeni işci alimi,Montajda gecikme,Nakliyede gecikme");
            }
            else if (lst_Problem.SelectedIndex is 1)
            {
                MessageBox.Show("Sel,Deprem,Heyelan,AYİSALDİRİSİ gibi doğal Afetlerin yaşanmasi gibi durumlarda afetin şiddetine göre bir öteleme olucaktir");
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void trb_Field_Scroll(object sender, EventArgs e)
        {
            lblm2.Text = trb_Field.Value.ToString();
        }

        private void rdo_Stand_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox item in grp_EkstraProduct.Controls)
            {
                ckb_FairHostel.Enabled = false;
                ckb_StorageArea.Enabled = false;
                ckb_Catering.Enabled = false;
                ckb_Waiter.Enabled = false;


            }
            cmbStand.Enabled = true;
            trb_Field.Enabled = false;
        }

        private void rdo_Field_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox item in grp_EkstraProduct.Controls)
            {
                ckb_FairHostel.Enabled = true;
                ckb_StorageArea.Enabled = true;
                ckb_Catering.Enabled = true;
                ckb_Waiter.Enabled = true;
            }
            cmbStand.Enabled = false;
            trb_Field.Enabled = true;

        }

        private void cmbStand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {

        }
    }
}
