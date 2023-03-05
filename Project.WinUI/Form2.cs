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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lst_Problems.Items.Add("Ürüne bağlı olan problemler");
            lst_Problems.Items.Add("Dış Etkilere Bağlı Problemler");
        }

        private void lst_Problems_Click(object sender, EventArgs e)
        {
            if (lst_Problems.SelectedIndex is 0)
            {
                MessageBox.Show("Isci cikarimi,Yeni işci alimi,Montajda gecikme,Nakliyede gecikme");
            }
            else if (lst_Problems.SelectedIndex is 1)
            {
                MessageBox.Show("Sel,Deprem,Heyelan,AYİSALDİRİSİ gibi doğal Afetlerin yaşanmasi gibi durumlarda afetin şiddetine göre bir öteleme olucaktir");
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
