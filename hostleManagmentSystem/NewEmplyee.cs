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
    public partial class NewEmplyee : Form
    {

        function fn = new function();
        String query;
        public NewEmplyee()
        {
            InitializeComponent();
        }

        private void NewEmplyee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
        }

 

    

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermenent.Text != "" && txtUniqueID.Text != "" && comboDesignation.SelectedIndex != -1 )
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String address = txtPermenent.Text;
                String id = txtUniqueID.Text;
                String designation = comboDesignation.Text;

                query = "insert into newEmployee(emobile, ename, efname, emname, eemail, epaddress, eidproof, edesignation) values(" + mobile + ", ' "+ name +" ', '" + fname +" ', ' "+ mname +" ', ' "+ email +" ', '" + address +" ', '" + id +" ', ' "+ designation + "')";
                fn.setData(query, "Employee Registered Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill all the Required Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll(); ;
        }

        private void clearAll()
        {
            txtName.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtPermenent.Clear();
            comboDesignation.SelectedIndex = -1;
            txtPermenent.Clear();
            txtUniqueID.Clear();
        }

       
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();   
        }

        
    }
}
