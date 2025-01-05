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
    public partial class book_with_coach : Form
    {
        public book_with_coach()
        {
            InitializeComponent();
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            gymEntities db = new gymEntities();
            int coach_id = Int32.Parse(coach_textBox.Text);
            int cust_id = Int32.Parse(cust_textBox.Text);
            int timetable_id = Int32.Parse(timetable_textBox.Text);
            Boolean not_found = false;

            List<member> members_list = db.members.ToList();

            //to validate that the specific timetable is assigned to the specific coach
            //var timetable = db.coach_timetable.First(tt  =>  tt.private_coach_id = coach_id && tt.timetable_id = timetable_id )

            foreach (member m in members_list)
            {
                if (cust_id == m.member_id)
                {
                    m.private_coach_id = coach_id;
                    not_found = true;
                    break;
                }

                if (not_found)
                {
                    MessageBox.Show("ID not found. Ensure you entered your id correctly.");
                }

            }

            db.SaveChanges();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
