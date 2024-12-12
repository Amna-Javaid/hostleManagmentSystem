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
    public partial class EmployeePayment : Form
    {
        function fn = new function();
        String query;
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            //monthDateTime.Format = DateTimePickerFormat.Custom;
            // monthDateTime.CustomFormat = "MMMM YYYY";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = "select ename,eemail,edesignation from newEmployee where emobile=" + txtMobile.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDesignation.Text = ds.Tables[0].Rows[0][2].ToString();

                    setDateGrid(Int64.Parse(txtMobile.Text));
                }

                else
                {
                    MessageBox.Show("No Record EXIST.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            else
            {
                MessageBox.Show("Enter some data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void setDateGrid(Int64 mobile)
        {
            query = "select * from employeeSalary where mobileNo =" + mobile + "";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];




        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtPaymentAmount.Text != "")
            {
                query = "select * from employeeSalary where mobileNo="+ txtMobile.Text+"  and fmonth='"+monthDateTime.Text+"'";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {

                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = monthDateTime.Text;
                    Int64 amount = Int64.Parse(txtPaymentAmount.Text);

                    query = "insert into employeeSalary values (" + mobile + ",'" + month + "','" + amount + " '  ) ";
                    fn.setData(query, "Salary for month " + monthDateTime.Text + " Paid");
                    setDateGrid(mobile);
                }

                else
                {
                    MessageBox.Show("No Record EXIST.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

                

                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtPaymentAmount.Clear();
            txtEmail.Clear();
            txtDesignation.Clear();
            monthDateTime.ResetText();

        }
    }
}