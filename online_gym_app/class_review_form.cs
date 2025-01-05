using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace online_gym_app
{
    public partial class class_review_form : Form
    {
        public class_review_form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            review r = new review{
                rating = Int32.Parse( rating_textBox.Text ),
                comment = comments_textBox.Text
            };

            db.reviews.Add(r);
            db.SaveChanges();
            

            class_review cr = new class_review
            {
                class_id = Int32.Parse(class_id_textBox.Text),
                customer_id = Int32.Parse(cust_id_textbox.Text)
            };

            db.class_review.Add(cr);
            db.SaveChanges();
   

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
