using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_gym_app
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }


        private void member_btn_Click(object sender, EventArgs e)
        {
            member_form f = new member_form();
            f.Show();
            this.Hide();
        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            Guest_form f = new Guest_form();
            f.Show();
            this.Hide();
        }
    }
}
