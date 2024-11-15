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
            dataGridView1.DataSource=ds.Tables[0];
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

       
    }
}
