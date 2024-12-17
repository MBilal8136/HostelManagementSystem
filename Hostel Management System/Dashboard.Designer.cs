namespace Hostel_Management_System
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddR = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFee = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentDetail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.hmlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse9 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse10 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Checkout1 = new Hostel_Management_System.AllUserControls.UC_Checkout();
            this.uC_AllStudentDetail1 = new Hostel_Management_System.AllUserControls.UC_AllStudentDetail();
            this.uC_StudentFees1 = new Hostel_Management_System.AllUserControls.UC_StudentFees();
            this.uC_UpdateandDeleteStudent1 = new Hostel_Management_System.AllUserControls.UC_UpdateandDeleteStudent();
            this.uC_AddStudent1 = new Hostel_Management_System.AllUserControls.UC_AddStudent();
            this.uC_AddRoom1 = new Hostel_Management_System.AllUserControls.UC_AddRoom();
            this.uC_AddEmployee1 = new Hostel_Management_System.AllUserControls.UC_AddEmployee();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.uC_AddEmployee1);
            this.panel1.Controls.Add(this.uC_Checkout1);
            this.panel1.Controls.Add(this.uC_AllStudentDetail1);
            this.panel1.Controls.Add(this.uC_StudentFees1);
            this.panel1.Controls.Add(this.uC_UpdateandDeleteStudent1);
            this.panel1.Controls.Add(this.uC_AddStudent1);
            this.panel1.Controls.Add(this.uC_AddRoom1);
            this.panel1.Location = new System.Drawing.Point(246, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 631);
            this.panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navigation Bar";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BorderRadius = 10;
            this.btnAddStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddStudent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddStudent.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddStudent.Location = new System.Drawing.Point(6, 149);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(239, 45);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add New Student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddR
            // 
            this.btnAddR.BorderRadius = 10;
            this.btnAddR.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddR.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddR.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddR.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddR.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnAddR.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddR.ForeColor = System.Drawing.Color.White;
            this.btnAddR.Image = ((System.Drawing.Image)(resources.GetObject("btnAddR.Image")));
            this.btnAddR.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddR.Location = new System.Drawing.Point(6, 85);
            this.btnAddR.Name = "btnAddR";
            this.btnAddR.Size = new System.Drawing.Size(239, 45);
            this.btnAddR.TabIndex = 2;
            this.btnAddR.Text = "Add Room";
            this.btnAddR.Click += new System.EventHandler(this.btnAddR_Click);
            // 
            // btnStudentFee
            // 
            this.btnStudentFee.BorderRadius = 10;
            this.btnStudentFee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentFee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStudentFee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnStudentFee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentFee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnStudentFee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentFee.ForeColor = System.Drawing.Color.White;
            this.btnStudentFee.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentFee.Image")));
            this.btnStudentFee.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStudentFee.Location = new System.Drawing.Point(6, 280);
            this.btnStudentFee.Name = "btnStudentFee";
            this.btnStudentFee.Size = new System.Drawing.Size(239, 45);
            this.btnStudentFee.TabIndex = 2;
            this.btnStudentFee.Text = "Student Fee";
            this.btnStudentFee.Click += new System.EventHandler(this.btnStudentFee_Click);
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.BorderRadius = 10;
            this.btnUpdateDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDelete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateDelete.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnUpdateDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDelete.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDelete.Image")));
            this.btnUpdateDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdateDelete.Location = new System.Drawing.Point(6, 209);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.Size = new System.Drawing.Size(239, 45);
            this.btnUpdateDelete.TabIndex = 2;
            this.btnUpdateDelete.Text = "Update & Delete Student";
            this.btnUpdateDelete.Click += new System.EventHandler(this.btnUpdateDelete_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BorderRadius = 10;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCheckout.Location = new System.Drawing.Point(6, 412);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(239, 45);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout Student";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnStudentDetail
            // 
            this.btnStudentDetail.BorderRadius = 10;
            this.btnStudentDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentDetail.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStudentDetail.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnStudentDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnStudentDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentDetail.ForeColor = System.Drawing.Color.White;
            this.btnStudentDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentDetail.Image")));
            this.btnStudentDetail.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStudentDetail.Location = new System.Drawing.Point(6, 347);
            this.btnStudentDetail.Name = "btnStudentDetail";
            this.btnStudentDetail.Size = new System.Drawing.Size(239, 45);
            this.btnStudentDetail.TabIndex = 2;
            this.btnStudentDetail.Text = "All Student Detail";
            this.btnStudentDetail.Click += new System.EventHandler(this.btnStudentDetail_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 10;
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button6.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button6.Location = new System.Drawing.Point(6, 551);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(239, 45);
            this.guna2Button6.TabIndex = 2;
            this.guna2Button6.Text = "All Data of Employee";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BorderRadius = 10;
            this.btnAddEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddEmployee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddEmployee.Location = new System.Drawing.Point(6, 481);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(239, 45);
            this.btnAddEmployee.TabIndex = 2;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.White;
            this.btnLogout.BorderRadius = 20;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogout.Location = new System.Drawing.Point(1036, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.BorderThickness = 2;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1214, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(45, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // hmlabel
            // 
            this.hmlabel.AutoSize = true;
            this.hmlabel.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hmlabel.ForeColor = System.Drawing.Color.White;
            this.hmlabel.Location = new System.Drawing.Point(528, 9);
            this.hmlabel.Name = "hmlabel";
            this.hmlabel.Size = new System.Drawing.Size(336, 44);
            this.hmlabel.TabIndex = 5;
            this.hmlabel.Text = "Hostel Management System";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel1;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel1;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel1;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel1;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 30;
            this.guna2Elipse8.TargetControl = this.panel1;
            // 
            // guna2Elipse9
            // 
            this.guna2Elipse9.BorderRadius = 30;
            this.guna2Elipse9.TargetControl = this.panel1;
            // 
            // guna2Elipse10
            // 
            this.guna2Elipse10.BorderRadius = 30;
            this.guna2Elipse10.TargetControl = this.panel1;
            // 
            // uC_Checkout1
            // 
            this.uC_Checkout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.uC_Checkout1.Location = new System.Drawing.Point(0, 0);
            this.uC_Checkout1.Name = "uC_Checkout1";
            this.uC_Checkout1.Size = new System.Drawing.Size(1020, 634);
            this.uC_Checkout1.TabIndex = 5;
            // 
            // uC_AllStudentDetail1
            // 
            this.uC_AllStudentDetail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.uC_AllStudentDetail1.Location = new System.Drawing.Point(-2, 0);
            this.uC_AllStudentDetail1.Name = "uC_AllStudentDetail1";
            this.uC_AllStudentDetail1.Size = new System.Drawing.Size(1020, 634);
            this.uC_AllStudentDetail1.TabIndex = 4;
            // 
            // uC_StudentFees1
            // 
            this.uC_StudentFees1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.uC_StudentFees1.Location = new System.Drawing.Point(-3, -1);
            this.uC_StudentFees1.Name = "uC_StudentFees1";
            this.uC_StudentFees1.Size = new System.Drawing.Size(1020, 634);
            this.uC_StudentFees1.TabIndex = 3;
            // 
            // uC_UpdateandDeleteStudent1
            // 
            this.uC_UpdateandDeleteStudent1.BackColor = System.Drawing.Color.Salmon;
            this.uC_UpdateandDeleteStudent1.Location = new System.Drawing.Point(-1, -2);
            this.uC_UpdateandDeleteStudent1.Name = "uC_UpdateandDeleteStudent1";
            this.uC_UpdateandDeleteStudent1.Size = new System.Drawing.Size(1020, 634);
            this.uC_UpdateandDeleteStudent1.TabIndex = 2;
            // 
            // uC_AddStudent1
            // 
            this.uC_AddStudent1.BackColor = System.Drawing.Color.Salmon;
            this.uC_AddStudent1.Location = new System.Drawing.Point(-2, -2);
            this.uC_AddStudent1.Name = "uC_AddStudent1";
            this.uC_AddStudent1.Size = new System.Drawing.Size(1022, 635);
            this.uC_AddStudent1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.LemonChiffon;
            this.uC_AddRoom1.Location = new System.Drawing.Point(-2, -1);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1020, 634);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // uC_AddEmployee1
            // 
            this.uC_AddEmployee1.BackColor = System.Drawing.Color.White;
            this.uC_AddEmployee1.Location = new System.Drawing.Point(-1, -1);
            this.uC_AddEmployee1.Name = "uC_AddEmployee1";
            this.uC_AddEmployee1.Size = new System.Drawing.Size(1020, 634);
            this.uC_AddEmployee1.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1275, 701);
            this.Controls.Add(this.hmlabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnStudentDetail);
            this.Controls.Add(this.btnUpdateDelete);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnStudentFee);
            this.Controls.Add(this.btnAddR);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2Button btnAddR;
        private Guna.UI2.WinForms.Guna2Button btnStudentFee;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDelete;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnStudentDetail;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button btnAddEmployee;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Label hmlabel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControls.UC_AddRoom uC_AddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControls.UC_AddStudent uC_AddStudent1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControls.UC_UpdateandDeleteStudent uC_UpdateandDeleteStudent1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private AllUserControls.UC_StudentFees uC_StudentFees1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse9;
        private AllUserControls.UC_AllStudentDetail uC_AllStudentDetail1;
        private AllUserControls.UC_Checkout uC_Checkout1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse10;
        private AllUserControls.UC_AddEmployee uC_AddEmployee1;
    }
}