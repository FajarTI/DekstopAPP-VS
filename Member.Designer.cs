namespace Latihan_DesktopApp
{
    partial class Member
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
            btnTambah = new Button();
            viewMember = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnCancel = new Button();
            btnAdd = new Button();
            dtBirth = new DateTimePicker();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            tbName = new TextBox();
            comboBox1 = new ComboBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)viewMember).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(938, 68);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(206, 33);
            btnTambah.TabIndex = 5;
            btnTambah.Text = "Tambahkan";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // viewMember
            // 
            viewMember.AllowUserToAddRows = false;
            viewMember.AllowUserToDeleteRows = false;
            viewMember.AllowUserToResizeColumns = false;
            viewMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewMember.Location = new Point(12, 107);
            viewMember.Name = "viewMember";
            viewMember.ReadOnly = true;
            viewMember.RowTemplate.Height = 25;
            viewMember.SelectionMode = DataGridViewSelectionMode.CellSelect;
            viewMember.Size = new Size(1132, 307);
            viewMember.TabIndex = 4;
            viewMember.CellContentClick += viewMembership_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 3;
            label1.Text = "Member";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.TitleBar;
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dtBirth);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 420);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 183);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tambah Data Member";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(392, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(293, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(293, 78);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(162, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Batal";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(293, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Tambahkan";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtBirth
            // 
            dtBirth.Location = new Point(6, 138);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(215, 23);
            dtBirth.TabIndex = 4;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(6, 109);
            tbPhone.Name = "tbPhone";
            tbPhone.PlaceholderText = "Masukan Nomer Telpon";
            tbPhone.Size = new Size(215, 23);
            tbPhone.TabIndex = 3;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(6, 80);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Masukan Email";
            tbEmail.Size = new Size(215, 23);
            tbEmail.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.Location = new Point(6, 51);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Masukan Nama";
            tbName.Size = new Size(215, 23);
            tbName.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 23);
            comboBox1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(293, 107);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(162, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(groupBox1);
            Controls.Add(btnTambah);
            Controls.Add(viewMember);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Member";
            Text = "Member";
            Load += Member_Load;
            ((System.ComponentModel.ISupportInitialize)viewMember).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah;
        private DataGridView viewMember;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnCancel;
        private Button btnAdd;
        private DateTimePicker dtBirth;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private TextBox tbName;
        private ComboBox comboBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnSave;
    }
}