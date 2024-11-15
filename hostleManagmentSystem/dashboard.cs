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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
            
        }

        private void ManageRooms_Click(object sender, EventArgs e)
        {
            AddRoom room = new AddRoom();
            room.Show();
        }
    }
}
