using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostleManagmentSystem
{
    public partial class LeavedEmployee : Form
    {
        function fn = new function();
        String query;
        public LeavedEmployee()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void LeavedEmployee_Load(object sender, EventArgs e)
        {
        
            this.Location = new Point(350, 170);
            query = "select * from newEmployee where working='No'";
            DataSet ds=fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
