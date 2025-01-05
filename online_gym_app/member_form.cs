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
    public partial class member_form : Form
    {
        public member_form()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void view_coaches_btn_Click(object sender, EventArgs e)
        {
            retrieve_all_coaches f = new retrieve_all_coaches();
            f.Show();
            this.Hide();


        }

        private void book_coach_btn_Click(object sender, EventArgs e)
        {
            book_with_coach f = new book_with_coach();
            f.Show();
            this.Hide();
        }
    }
}
