using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace online_gym_app
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        public DatabaseHelper()
        {
            connectionString = @"Server=alaa-pc;Database=gym;Trusted_Connection=True;";
        }


        public DataTable get_classes()
        {
            DataTable table = new DataTable();
            string query = @"SELECT class.class_id,class_type.class_type, class.capacity,person.first_name+person.last_name AS Coach_Name, timetable.next_date,timetable.week_day, timetable.start_time,timetable.end_time,class.class_cost
            FROM class
            JOIN coach ON class.coach_id=coach.coach_id  JOIN class_type on class.class_id=class_type.class_id JOIN person ON person.person_id = coach.coach_id JOIN class_timetable ON class.class_id=class_timetable.class_id JOIN timetable on timetable.timetable_id = class_timetable.timetable_id
            WHERE class.capacity > 0 ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }

            return table;
        }

        public void book_class(int class_id, int cust_id, string payment_method)
        {
            using (gymEntities db = new gymEntities())
            {
                var temp_class = db.classes.First(c => c.class_id == class_id);
                
                payment p = new payment
                {
                    customer_id = cust_id,
                    method = payment_method,
                    //amount = temp_class.
                };

                db.payments.Add(p);
                db.SaveChanges(); 

                customer_pay_class cpc = new customer_pay_class
                {
                    class_id = class_id,
                    customer_id = cust_id,
                    payment_id = p.payment_id 
                };
                db.customer_pay_class.Add(cpc);
                db.SaveChanges();

            }
        }


        public DataTable get_coaches()
        {
            DataTable table = new DataTable();
            string query = @"SELECT coach.coach_id, coach_speciality.speciality, AVG(review.rating) AS 'AVG Rating', timetable.next_date,timetable.start_time,timetable.end_time
                            FROM coach JOIN coach_speciality ON coach.coach_id = coach_speciality.coach_id JOIN coach_review ON coach.coach_id = coach_review.coach_id JOIN review on review.review_id = coach_review.coach_review_id JOIN coach_timetable ON coach.coach_id = coach_timetable.private_coach_id JOIN timetable on coach_timetable.timetable_id = timetable.timetable_id
                            GROUP BY coach.coach_id, coach_speciality.speciality,timetable.next_date,timetable.start_time,timetable.end_time";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);

                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }

            return table;
        }

        public void review_coach()
        {   

        }
    }
}
