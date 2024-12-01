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
    public partial class UpdateDeleteStudent : Form
    {
        function fn = new function();
        String query;
        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtFather.Clear();
            txtMother.Clear();
            txtPermenent.Clear();
            txtCollege.Clear();
            txtIdProof.Clear();
            txtRoomNo.Clear();
            comboboxLiving.SelectedIndex = -1;
        }
        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 150);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            query = "select * from newStudent where mobile= "+txtMobile.Text+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count!=0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtPermenent.Text = ds.Tables[0].Rows[0][6].ToString();
                txtCollege.Text = ds.Tables[0].Rows[0][7].ToString();
                txtIdProof.Text = ds.Tables[0].Rows[0][8].ToString();
                txtRoomNo.Text= ds.Tables[0].Rows[0][9].ToString();
                comboboxLiving.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("NO RECORD FOUND","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String fname = txtFather.Text;
                String mname = txtMother.Text;
                String email = txtEmail.Text;
                String paddress = txtPermenent.Text;
                String college = txtCollege.Text;
                String idProof = txtIdProof.Text;
                Int64 newRoomNo = Int64.Parse(txtRoomNo.Text);
                String LivingStatus = comboboxLiving.Text;

                // Get the old room number for comparison
                query = "SELECT roomNo FROM newStudent WHERE mobile = " + mobile;
                DataSet ds = fn.getData(query);
                Int64 oldRoomNo = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                // Check if the new room is full
                query = $"SELECT currentOccupancy, roomCapacity FROM rooms WHERE roomNo = {newRoomNo}";
                DataSet roomDs = fn.getData(query);

                if (roomDs.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("The entered room number does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Int64 currentOccupancy = Int64.Parse(roomDs.Tables[0].Rows[0]["currentOccupancy"].ToString());
                Int64 roomCapacity = Int64.Parse(roomDs.Tables[0].Rows[0]["roomCapacity"].ToString());

                if (currentOccupancy >= roomCapacity)
                {
                    MessageBox.Show("The selected room is already full. Please choose another room.", "Room Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                query = $@"
        BEGIN TRANSACTION;

        -- Update student details
        UPDATE newStudent
        SET name = '{name}',
            fname = '{fname}',
            mname = '{mname}',
            email = '{email}',
            paddress = '{paddress}',
            college = '{college}',
            idProof = '{idProof}',
            roomNo = {newRoomNo},
            Living = '{LivingStatus}'
        WHERE mobile = {mobile};

        -- If room has changed, adjust occupancy
        IF {newRoomNo} <> {oldRoomNo}
        BEGIN
            UPDATE rooms 
            SET currentOccupancy = CASE 
                WHEN currentOccupancy > 0 THEN currentOccupancy - 1 
                ELSE currentOccupancy 
            END
            WHERE roomNo = {oldRoomNo};

            UPDATE rooms 
            SET Booked = CASE 
                WHEN currentOccupancy < roomCapacity THEN 'No' 
                ELSE 'Yes' 
            END 
            WHERE roomNo = {oldRoomNo};

            UPDATE rooms 
            SET currentOccupancy = currentOccupancy + 1 
            WHERE roomNo = {newRoomNo};

            UPDATE rooms 
            SET Booked = CASE 
                WHEN currentOccupancy >= roomCapacity THEN 'Yes' 
                ELSE 'No' 
            END 
            WHERE roomNo = {newRoomNo};
        END;

        COMMIT TRANSACTION;
        ";

                fn.setData(query, "Student record updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void  btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);

                    // Get the room number for this student
                    query = "SELECT roomNo FROM newStudent WHERE mobile = " + mobile;
                    DataSet ds = fn.getData(query);
                    Int64 roomNo = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                    query = $@"
                BEGIN TRANSACTION;

                -- Delete the student record
                DELETE FROM newStudent WHERE mobile = {mobile};

                -- Decrease the currentOccupancy for the room if it's greater than 0
                UPDATE rooms 
                SET currentOccupancy = CASE 
                    WHEN currentOccupancy > 0 THEN currentOccupancy - 1 
                    ELSE currentOccupancy 
                END
                WHERE roomNo = {roomNo};

                -- Adjust 'Booked' status for the room
                UPDATE rooms 
                SET Booked = CASE 
                    WHEN currentOccupancy < roomCapacity THEN 'No' 
                    ELSE 'Yes' 
                END 
                WHERE roomNo = {roomNo};

                COMMIT TRANSACTION;
            ";

                    fn.setData(query, "Student record deleted successfully.");
                    clearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

      
    }
}
