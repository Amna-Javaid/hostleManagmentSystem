using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostleManagmentSystem
{
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFather_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM newEmployee WHERE emobile = " + txtMobile.Text;
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0]["ename"].ToString();
                txtFather.Text = ds.Tables[0].Rows[0]["efname"].ToString();
                txtMother.Text = ds.Tables[0].Rows[0]["emname"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["eemail"].ToString();
                txtPermenent.Text = ds.Tables[0].Rows[0]["epaddress"].ToString();
                txtUniqueID.Text = ds.Tables[0].Rows[0]["eidproof"].ToString();

                // Set Designation if it matches an item in the combo box
                string designation = ds.Tables[0].Rows[0]["edesignation"].ToString();
                if (txtDesignation.Items.Contains(designation))
                {
                    txtDesignation.SelectedItem = designation;
                }
                else
                {
                    txtDesignation.Text = designation; // Show text even if it isn't in the items
                }

                txtWorking.Text = ds.Tables[0].Rows[0]["working"].ToString();
            }
            else
            {
                MessageBox.Show("No Record Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse inputs safely
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String paddress = txtPermenent.Text;
                String id = txtUniqueID.Text;
                String designation = txtDesignation.Text;
                String working = txtWorking.Text;

                // Construct the query with proper syntax
                query = $@"
            UPDATE newEmployee 
            SET 
                ename = '{name}', 
                efname = '{fname}', 
                emname = '{mname}', 
                eemail = '{email}', 
                epaddress = '{paddress}', 
                eidproof = '{id}', 
                edesignation = '{designation}', 
                working = '{working}' 
            WHERE emobile = {mobile};";

                // Execute the query
                fn.setData(query, "Data Updation Successful.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please check the mobile number and other fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"A database error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile=" + txtMobile.Text + "";
                fn.setData(query, "Employee Record Deleted.");
                clearAll();
            }
        }
        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermenent.Clear();
            txtUniqueID.Clear();
 
            txtWorking.SelectedIndex = -1;
            txtDesignation.Text= "";

            txtDesignation.SelectedIndex = -1;  

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}