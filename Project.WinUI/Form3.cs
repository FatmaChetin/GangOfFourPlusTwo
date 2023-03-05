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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lst_Problems.Items.Add("Problems related to the product");
            lst_Problems.Items.Add("Problems Due to External Effects");
        }

        private void lst_Problemler_Click(object sender, EventArgs e)
        {
            if (lst_Problems.SelectedIndex is 0)
            {
                MessageBox.Show("There may be a daily or hourly delay in factors such as workers, recruitment of new workers, delay in assembly, delay in transportation.");
            }
            else if(lst_Problems.SelectedIndex is 1)
            {
                MessageBox.Show("In cases such as natural disasters such as flood, earthquake, landslide, and MONSTER ATTACK, there will be a delay according to the severity of the disaster.");
            }
        }
    }
}
