namespace hostleManagmentSystem
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ManageRooms = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnUpdateDeleteStudent = new System.Windows.Forms.Button();
            this.btnStudentFees = new System.Windows.Forms.Button();
            this.btnAllStudentLiving = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.button6 = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnLeavedStudents = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
=======
            this.btnUpdateDeleteEmployee = new System.Windows.Forms.Button();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnLeavedStudents = new System.Windows.Forms.Button();
            this.btnEmployeePayment = new System.Windows.Forms.Button();
            this.btnAllEmployeeWorking = new System.Windows.Forms.Button();
            this.btnLeavedEmployee = new System.Windows.Forms.Button();
>>>>>>> bushraj
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.CornflowerBlue;
            this.title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(495, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(360, 32);
            this.title.TabIndex = 1;
            this.title.Text = "Hostel Managment System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Bar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageRooms
            // 
            this.ManageRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManageRooms.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageRooms.Location = new System.Drawing.Point(30, 156);
            this.ManageRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageRooms.Name = "ManageRooms";
            this.ManageRooms.Size = new System.Drawing.Size(222, 36);
            this.ManageRooms.TabIndex = 3;
            this.ManageRooms.Text = "Manage Rooms";
            this.ManageRooms.UseVisualStyleBackColor = true;
            this.ManageRooms.Click += new System.EventHandler(this.ManageRooms_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 104);
            this.panel1.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogOut.Location = new System.Drawing.Point(1179, 32);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(128, 55);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewStudent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.Location = new System.Drawing.Point(30, 216);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(222, 36);
            this.btnNewStudent.TabIndex = 5;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(28, 276);
            this.btnUpdateDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(222, 36);
            this.btnUpdateDeleteStudent.TabIndex = 6;
            this.btnUpdateDeleteStudent.Text = "Update Student";
            this.btnUpdateDeleteStudent.UseVisualStyleBackColor = true;
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnStudentFees
            // 
            this.btnStudentFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentFees.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentFees.Location = new System.Drawing.Point(30, 336);
            this.btnStudentFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudentFees.Name = "btnStudentFees";
            this.btnStudentFees.Size = new System.Drawing.Size(222, 36);
            this.btnStudentFees.TabIndex = 7;
            this.btnStudentFees.Text = "Student Fees";
            this.btnStudentFees.UseVisualStyleBackColor = true;
            this.btnStudentFees.Click += new System.EventHandler(this.btnStudentFees_Click);
            // 
            // btnAllStudentLiving
            // 
            this.btnAllStudentLiving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllStudentLiving.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudentLiving.Location = new System.Drawing.Point(28, 396);
            this.btnAllStudentLiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllStudentLiving.Name = "btnAllStudentLiving";
            this.btnAllStudentLiving.Size = new System.Drawing.Size(222, 36);
            this.btnAllStudentLiving.TabIndex = 8;
            this.btnAllStudentLiving.Text = "All students";
            this.btnAllStudentLiving.UseVisualStyleBackColor = true;
            this.btnAllStudentLiving.Click += new System.EventHandler(this.btnAllStudentLiving_Click);
            // 
<<<<<<< HEAD
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(28, 576);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(222, 36);
            this.button6.TabIndex = 9;
            this.button6.Text = "Update Employee";
            this.button6.UseVisualStyleBackColor = true;
=======
            // btnUpdateDeleteEmployee
            // 
            this.btnUpdateDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDeleteEmployee.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDeleteEmployee.Location = new System.Drawing.Point(27, 576);
            this.btnUpdateDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateDeleteEmployee.Name = "btnUpdateDeleteEmployee";
            this.btnUpdateDeleteEmployee.Size = new System.Drawing.Size(222, 36);
            this.btnUpdateDeleteEmployee.TabIndex = 9;
            this.btnUpdateDeleteEmployee.Text = " Update Employee";
            this.btnUpdateDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateDeleteEmployee.Click += new System.EventHandler(this.btnUpdateDeleteEmployee_Click);
>>>>>>> bushraj
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewEmployee.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEmployee.Location = new System.Drawing.Point(28, 516);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(222, 36);
            this.btnNewEmployee.TabIndex = 10;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnLeavedStudents
            // 
            this.btnLeavedStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeavedStudents.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedStudents.Location = new System.Drawing.Point(28, 456);
            this.btnLeavedStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeavedStudents.Name = "btnLeavedStudents";
            this.btnLeavedStudents.Size = new System.Drawing.Size(222, 36);
            this.btnLeavedStudents.TabIndex = 11;
            this.btnLeavedStudents.Text = "Leaved Students";
            this.btnLeavedStudents.UseVisualStyleBackColor = true;
            this.btnLeavedStudents.Click += new System.EventHandler(this.btnLeavedStudents_Click);
            // 
<<<<<<< HEAD
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(28, 636);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 36);
            this.button9.TabIndex = 12;
            this.button9.Text = "Employee payment";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(28, 696);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(222, 36);
            this.button10.TabIndex = 13;
            this.button10.Text = "All Employee";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(30, 756);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(222, 36);
            this.button11.TabIndex = 14;
            this.button11.Text = "Leaved Employee";
            this.button11.UseVisualStyleBackColor = true;
=======
            // btnEmployeePayment
            // 
            this.btnEmployeePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeePayment.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePayment.Location = new System.Drawing.Point(28, 636);
            this.btnEmployeePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmployeePayment.Name = "btnEmployeePayment";
            this.btnEmployeePayment.Size = new System.Drawing.Size(222, 36);
            this.btnEmployeePayment.TabIndex = 12;
            this.btnEmployeePayment.Text = "Employee payment";
            this.btnEmployeePayment.UseVisualStyleBackColor = true;
            this.btnEmployeePayment.Click += new System.EventHandler(this.btnEmployeePayment_Click);
            // 
            // btnAllEmployeeWorking
            // 
            this.btnAllEmployeeWorking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllEmployeeWorking.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllEmployeeWorking.Location = new System.Drawing.Point(28, 696);
            this.btnAllEmployeeWorking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAllEmployeeWorking.Name = "btnAllEmployeeWorking";
            this.btnAllEmployeeWorking.Size = new System.Drawing.Size(222, 36);
            this.btnAllEmployeeWorking.TabIndex = 13;
            this.btnAllEmployeeWorking.Text = "All Employee";
            this.btnAllEmployeeWorking.UseVisualStyleBackColor = true;
            this.btnAllEmployeeWorking.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnLeavedEmployee
            // 
            this.btnLeavedEmployee.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeavedEmployee.Location = new System.Drawing.Point(30, 756);
            this.btnLeavedEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeavedEmployee.Name = "btnLeavedEmployee";
            this.btnLeavedEmployee.Size = new System.Drawing.Size(222, 36);
            this.btnLeavedEmployee.TabIndex = 14;
            this.btnLeavedEmployee.Text = "Leaved Employee";
            this.btnLeavedEmployee.UseVisualStyleBackColor = true;
            this.btnLeavedEmployee.Click += new System.EventHandler(this.btnLeavedEmployee_Click);
>>>>>>> bushraj
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hostleManagmentSystem.Properties.Resources.hostel;
            this.pictureBox1.Location = new System.Drawing.Point(280, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1333, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 882);
<<<<<<< HEAD
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnLeavedStudents);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.button6);
=======
            this.Controls.Add(this.btnLeavedEmployee);
            this.Controls.Add(this.btnAllEmployeeWorking);
            this.Controls.Add(this.btnEmployeePayment);
            this.Controls.Add(this.btnLeavedStudents);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnUpdateDeleteEmployee);
>>>>>>> bushraj
            this.Controls.Add(this.btnAllStudentLiving);
            this.Controls.Add(this.btnStudentFees);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ManageRooms);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
<<<<<<< HEAD
=======
            this.Load += new System.EventHandler(this.dashboard_Load);
>>>>>>> bushraj
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageRooms;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnUpdateDeleteStudent;
        private System.Windows.Forms.Button btnStudentFees;
        private System.Windows.Forms.Button btnAllStudentLiving;
<<<<<<< HEAD
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnLeavedStudents;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
=======
        private System.Windows.Forms.Button btnUpdateDeleteEmployee;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnLeavedStudents;
        private System.Windows.Forms.Button btnEmployeePayment;
        private System.Windows.Forms.Button btnAllEmployeeWorking;
        private System.Windows.Forms.Button btnLeavedEmployee;
>>>>>>> bushraj
        private System.Windows.Forms.Button btnLogOut;
    }
}