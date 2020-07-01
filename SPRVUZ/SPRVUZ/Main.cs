using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPRVUZ
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        

        private void VUZ_Click(object sender, EventArgs e)
        {
            this.Hide();
            VUZ vuz = new VUZ();
            vuz.Show();
        }

        private void CITY_Click(object sender, EventArgs e)
        {
            this.Hide();
            CITY city = new CITY();
            city.Show();
        }

        private void EXITLABLE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
