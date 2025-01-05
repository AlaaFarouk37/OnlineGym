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
    public partial class retrieve_all_coaches : Form
    {
        DatabaseHelper dh;
        public retrieve_all_coaches()
        {
            InitializeComponent();
            dh = new DatabaseHelper();
            this.dataGridView1.DataSource= dh.get_coaches();
        }
    }
}
