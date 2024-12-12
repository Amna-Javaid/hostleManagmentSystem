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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text== "amna" && textBoxPassword.Text == "123")
            {
                this.Hide();
                dashboard ds = new dashboard();
                ds.Show();
            }
            else
            {
                textBoxPassword.Clear();
                MessageBox.Show("Invalid Username or Password." +
                    " Please try again.", 
                    "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
