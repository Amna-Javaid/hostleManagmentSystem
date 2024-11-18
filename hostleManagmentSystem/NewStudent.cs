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

        private void SaveBtn_Click(object sender, EventArgs e)

        {
            if(txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtCollege.Text != "" && txtPermenent.Text != "" && txtIdProof.Text != "" && comboRoomNo.SelectedIndex != -1)
            {

           

            Int64 mobile = Int64.Parse(txtMobile.Text);
            String name = txtName.Text;
            String fname = txtFather.Text;
            String mname = txtMother.Text;
            String email = txtEmail.Text;
            String paddress = txtPermenent.Text;
            String college = txtCollege.Text;
            String idproof = txtIdProof.Text;
            Int64 roomNo = Int64.Parse(comboRoomNo.Text);

            query = "insert into newStudent ( mobile, name,fname,mname,email,paddress,college,idproof,roomNo)" +
                "values ("+mobile+", '"+ name + "', '"+ fname + "', '"+ mname + "', '"+ email+ "', '"+ paddress + "', '"+ college + "', '"+idproof+"'," +roomNo+" ) update rooms set Booked = 'Yes' where roomNo = "+roomNo+"";

            fn.setData(query, "Student Registered Successfully");

            clearAll();
            }

            else
            {
                MessageBox.Show("Fill all the fields ", "Information!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }
    }
}
