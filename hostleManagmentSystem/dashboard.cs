﻿using System;
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

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees();
            sf.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving();
            asl.Show();
        }

        private void btnLeavedStudents_Click(object sender, EventArgs e)
        {
            LeavedStudent ls = new LeavedStudent();
            ls.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmplyee newEmplyee = new NewEmplyee();   
            newEmplyee.Show();
        }
<<<<<<< HEAD
=======

        private void btnUpdateDeleteEmployee_Click(object sender, EventArgs e)
        {
          UpdateDeleteEmployee ue=new UpdateDeleteEmployee();
            ue.Show();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            EmployeePayment ep = new EmployeePayment();
            ep.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            AllEmpployeeWorking aew=new AllEmpployeeWorking();
            aew.Show();
        }

        private void btnLeavedEmployee_Click(object sender, EventArgs e)
        {
            LeavedEmployee ls = new LeavedEmployee();  
            ls.Show();
        }
>>>>>>> bushraj
    }
}
