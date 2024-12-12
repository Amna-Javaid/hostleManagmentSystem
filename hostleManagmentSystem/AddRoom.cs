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
    public partial class AddRoom : Form
    {

        function fn = new function();
        String query;
        public AddRoom()
        {
            InitializeComponent();
        }



        private void AddRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(340, 135);
            labelRoomExist.Visible = false;
            labelRoom.Visible = false;
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            query = "SELECT * FROM rooms WHERE roomNo = " + txtRoomNo2.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                labelRoom.Text = "No room exists";
                labelRoom.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                labelRoom.Text = "Room Found";
                labelRoom.Visible = true;

                if (ds.Tables[0].Rows[0]["roomStatus"].ToString() == "yes")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }

                // Display capacity and occupancy
                int capacity = Convert.ToInt32(ds.Tables[0].Rows[0]["roomCapacity"]);
                int occupancy = Convert.ToInt32(ds.Tables[0].Rows[0]["currentOccupancy"]);
                MessageBox.Show($"Room Capacity: {capacity}\nCurrent Occupancy: {occupancy}", "Room Details");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            String status;
            if (checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }

            query = "UPDATE rooms SET roomStatus = '" + status + "' WHERE roomNo = " + txtRoomNo2.Text;
            fn.setData(query, "Detail Updated!");

            // Check and update room status based on capacity
            query = "SELECT roomCapacity, currentOccupancy FROM rooms WHERE roomNo = " + txtRoomNo2.Text;
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                int capacity = Convert.ToInt32(ds.Tables[0].Rows[0]["roomCapacity"]);
                int occupancy = Convert.ToInt32(ds.Tables[0].Rows[0]["currentOccupancy"]);
                if (occupancy == capacity)
                {
                    query = "UPDATE rooms SET roomStatus = 'No' WHERE roomNo = " + txtRoomNo2.Text;
                    fn.setData(query, "Room is now fully booked.");
                }
            }

            AddRoom_Load(this, null);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (labelRoom.Text== "Room Found")
            {
                query= "delete from rooms where roomNo = "+txtRoomNo2.Text+"";
                fn.setData(query, "Room deleted Successfully");
                AddRoom_Load(this, null);

            }
            else
            {
                MessageBox.Show("Trying to delete Room that doesn't exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo = " + txtRoomNo1.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                String status;
                int capacity;

                if (checkBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }

                // Validate capacity input
                if (int.TryParse(txtCapacity.Text, out capacity) && capacity > 0)
                {
                    labelRoomExist.Visible = false;
                    query = "INSERT INTO rooms (roomNo, roomStatus, roomCapacity, currentOccupancy) VALUES (" +
                            txtRoomNo1.Text + ", '" + status + "', " + capacity + ", 0)";
                    fn.setData(query, "Room Added Successfully");
                    AddRoom_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Please enter a valid room capacity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                labelRoomExist.Text = "Room already exists";
                labelRoomExist.Visible = true;
            }
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
