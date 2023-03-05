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
            Customer customer = new Customer();
            customer.CompanyName = txt_Name.Text;
            customer.CompanyAdress = txt_Adress.Text;
            customer.CompanySector = txt_Sector.Text;
            customer.ContactNumber = txt_Number.Text;
            customer.Email = txt_Mail1.Text;
            Customer c2= new Customer();
            c2.CompanyName = txt_Isim.Text;
            c2.CompanyAdress= txt_Adres.Text;
            c2.CompanySector = txt_Sektor.Text;
            c2.ContactNumber = txt_Numara.Text;
            c2.Email = txt_Mail.Text;
            
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
