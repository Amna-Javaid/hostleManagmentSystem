using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace hostleManagmentSystem
{
    public partial class AllEmpployeeWorking : Form
    {
        function fn = new function();
        String query;
        public AllEmpployeeWorking()
        {
            InitializeComponent();
        }

        private void AllEmpployeeWorking_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            query = "select * from newEmployee where working='Yes'";
            DataSet ds = fn.getData(query);
            
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        }
    }

