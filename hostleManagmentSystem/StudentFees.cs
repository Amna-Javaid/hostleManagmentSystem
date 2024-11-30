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
    public partial class StudentFees : Form
    {

        function fn = new function();
        String query;
        public StudentFees()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = "select name,email,roomNo from newStudent where mobile ="+txtMobile.Text+"";

                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRollNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    query = "Select * from newStudent where mobile =" + txtMobile.Text + "";
                    DataSet ds2 = fn.getData(query);
                    dataGridView1.DataSource = ds2.Tables[0];
                    setDataGrid(Int64.Parse(txtMobile.Text));

                }   

                else
                {
                    MessageBox.Show("No Record Exist","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        public void setDataGrid(Int64 mobile)
        {
            query = "select * from fees where mobileNo = " + mobile + "";
            DataSet ds = fn.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            if(txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "Select * from fees where mobileNo = " + Int64.Parse(txtMobile.Text) + " and fmonth= " + dateTimePicker1.Text + "";
                DataSet ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    String month = dateTimePicker1.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);
                    query = "insert into fees values ( " + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query,"Fees Paid");
                    clearAll();
                }
                else
                {

                    MessageBox.Show("No dues of " + dateTimePicker1.Text + "left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtAmount.Clear();
            txtRollNo.Clear();
            txtEmail.Clear();
            dataGridView1.DataSource = 0;
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
