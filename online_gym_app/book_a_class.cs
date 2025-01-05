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
    public partial class book_a_class : Form
    {
        public book_a_class()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            DatabaseHelper dh = new DatabaseHelper();

            int class_id = Int32.Parse(class_id_textbox.Text); //casting string into int
            String w_d = weekday_textbox.Text;

            int cust_id = Int32.Parse(cust_id_textBox.Text);
            String payment_method="";

            if (card_rb.Checked)
                payment_method = "Card";

            if (cash_rb.Checked)
                payment_method = "Cash";

            dh.book_class(class_id, cust_id, payment_method);


        }
    }
}
