using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            _dbcustomer = new CustomerRepository();
        }
        CustomerRepository _dbcustomer;
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CompanyName = txt_Name.Text,
                CompanyAdress = txt_Adress.Text,
                CompanySector = txt_Sector.Text,
                ContactNumber = txt_Number.Text,
                Email = txt_Mail1.Text
            };
            
            
            Customer c2= new Customer()
            {
                CompanyName = txt_Isim.Text,
                CompanyAdress = txt_Adres.Text,
                CompanySector = txt_Sektor.Text,
                ContactNumber = txt_Numara.Text,
                Email = txt_Mail.Text
            };
            
            if (rdo_Yurtici.Checked == true)
            {
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else if (rdo_Global.Checked == true)
            {
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
        }
    }
}
