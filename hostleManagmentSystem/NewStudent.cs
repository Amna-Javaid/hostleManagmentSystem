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
    public partial class NewStudent : Form
    {
        function fn = new function();
        String query;
        public NewStudent()
        {
            InitializeComponent();
        }




        private void NewStudent_Load_1(object sender, EventArgs e)
        {
            this.Location = new Point(340, 135);
            query = "select roomNo from rooms where roomStatus = 'yes' and Booked = 'No'";
            DataSet ds = fn.getData(query);

            for (int i=0;i< ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearAll()
        {
            txtMobile.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtEmail.Clear();
            txtIdProof.Clear();
            txtName.Clear();
            txtPermenent.Clear();
            txtCollege.Clear();
            comboRoomNo.SelectedIndex = -1;

        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtCollege.Text != "" && txtPermenent.Text != "" && txtIdProof.Text != "" && comboRoomNo.SelectedIndex != -1)
            {
                try
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);

                    // Check if the mobile number already exists
                    query = $"SELECT COUNT(*) FROM newStudent WHERE mobile = {mobile}";
                    DataSet ds = fn.getData(query);
                    int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                    if (count > 0)
                    {
                        MessageBox.Show("This mobile number is already registered. Please use a different mobile number.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Exit the method if the mobile number exists
                    }

                    String name = txtName.Text;
                    String fname = txtFather.Text;
                    String mname = txtMother.Text;
                    String email = txtEmail.Text;
                    String paddress = txtPermenent.Text;
                    String college = txtCollege.Text;
                    String idproof = txtIdProof.Text;
                    Int64 roomNo = Int64.Parse(comboRoomNo.Text);

                    // Insert new student and update room occupancy
                    query = $@"
            BEGIN TRANSACTION;

            INSERT INTO newStudent (mobile, name, fname, mname, email, paddress, college, idproof, roomNo)
            VALUES ({mobile}, '{name}', '{fname}', '{mname}', '{email}', '{paddress}', '{college}', '{idproof}', {roomNo});

            UPDATE rooms 
            SET currentOccupancy = currentOccupancy + 1 
            WHERE roomNo = {roomNo};

            -- If room is fully occupied, mark it as booked
            UPDATE rooms 
            SET Booked = 'Yes' 
            WHERE roomNo = {roomNo} AND currentOccupancy >= roomCapacity;

            COMMIT TRANSACTION;
            ";

                    fn.setData(query, "Student Registered Successfully");
                    clearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill all the fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            this.clearAll();
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
