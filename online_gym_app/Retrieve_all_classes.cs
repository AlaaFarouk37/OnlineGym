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
    public partial class Retrieve_all_classes : Form
    {
        DatabaseHelper dh;
        public Retrieve_all_classes()
        {
            InitializeComponent();
            dh = new DatabaseHelper();
            this.classes_dataGridView.DataSource= dh.get_classes();
        }

    }
}
