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
    public partial class review_form : Form
    {
        public review_form()
        {
            InitializeComponent();
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
            
            coach_review cr = new coach_review {
                coach_review_id = r.review_id,
                coach_id = Int32.Parse(coach_id_textBox.Text),
                customer_id = Int32.Parse(cust_id_textbox.Text)
            };

            db.coach_review.Add(cr);
            db.SaveChanges();
        }
    }
}
