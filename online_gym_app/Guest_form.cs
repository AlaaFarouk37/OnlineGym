using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace online_gym_app
{   

    public partial class Guest_form : Form
    {
        private string connectionString = @"Server=alaa-pc;Database=gym;Trusted_Connection=True;";
        public Guest_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void view_classes_btn_Click(object sender, EventArgs e){

            Retrieve_all_classes f = new Retrieve_all_classes();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book_a_class f = new book_a_class();
            f.Show();
            this.Hide();
        }

        private void review_btn_Click(object sender, EventArgs e)
        {
            class_review_form f = new class_review_form();
              f.Show();
            this.Hide();
        }
        

    }
}
