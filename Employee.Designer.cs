namespace Latihan_DesktopApp
{
    partial class Employee
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
            viewEmployee = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnCancel = new Button();
            btnDeleteEmployee = new Button();
            btnUpdateEmployee = new Button();
            btnAddEmployee = new Button();
            rFemale = new RadioButton();
            rMale = new RadioButton();
            pickDateBirth = new DateTimePicker();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)viewEmployee).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // viewEmployee
            // 
            viewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewEmployee.Location = new Point(12, 97);
            viewEmployee.Name = "viewEmployee";
            viewEmployee.RowTemplate.Height = 25;
            viewEmployee.Size = new Size(1132, 242);
            viewEmployee.TabIndex = 0;
            viewEmployee.CellContentClick += viewEmployee_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 1;
            label1.Text = "Manage Employee";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(rFemale);
            groupBox1.Controls.Add(rMale);
            groupBox1.Controls.Add(pickDateBirth);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtConfirm);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 376);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1132, 186);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Employee";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCancel);
            groupBox2.Controls.Add(btnDeleteEmployee);
            groupBox2.Controls.Add(btnUpdateEmployee);
            groupBox2.Controls.Add(btnAddEmployee);
            groupBox2.Location = new Point(903, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(223, 158);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(6, 117);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(211, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(6, 88);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(211, 23);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(6, 59);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(211, 23);
            btnUpdateEmployee.TabIndex = 1;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(6, 30);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(211, 23);
            btnAddEmployee.TabIndex = 0;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // rFemale
            // 
            rFemale.AutoSize = true;
            rFemale.Location = new Point(749, 124);
            rFemale.Name = "rFemale";
            rFemale.Size = new Size(63, 19);
            rFemale.TabIndex = 16;
            rFemale.TabStop = true;
            rFemale.Text = "Female";
            rFemale.UseVisualStyleBackColor = true;
            // 
            // rMale
            // 
            rMale.AutoSize = true;
            rMale.Location = new Point(540, 127);
            rMale.Name = "rMale";
            rMale.Size = new Size(51, 19);
            rMale.TabIndex = 15;
            rMale.TabStop = true;
            rMale.Text = "Male";
            rMale.UseVisualStyleBackColor = true;
            // 
            // pickDateBirth
            // 
            pickDateBirth.Location = new Point(540, 92);
            pickDateBirth.Name = "pickDateBirth";
            pickDateBirth.Size = new Size(272, 23);
            pickDateBirth.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(540, 62);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(272, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(540, 25);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(272, 23);
            txtPhone.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(448, 131);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 11;
            label9.Text = "Gender*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(448, 98);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 10;
            label8.Text = "Date Birth*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 65);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 9;
            label7.Text = "Address*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 33);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 8;
            label6.Text = "Phone*";
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(141, 120);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(237, 23);
            txtConfirm.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(237, 23);
            txtName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 128);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 3;
            label5.Text = "Confirm Password*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 95);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 2;
            label4.Text = "Create Password*";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 62);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 1;
            label3.Text = "Email*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Name*";
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(viewEmployee);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Employee_Load;
            ((System.ComponentModel.ISupportInitialize)viewEmployee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewEmployee;
        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnCancel;
        private Button btnDeleteEmployee;
        private Button btnUpdateEmployee;
        private Button btnAddEmployee;
        private RadioButton rFemale;
        private RadioButton rMale;
        private DateTimePicker pickDateBirth;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtName;
    }
}