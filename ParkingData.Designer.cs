namespace Latihan_DesktopApp
{
    partial class ParkingData
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
            dgparkingData = new DataGridView();
            cbLicense = new ComboBox();
            cbVehicle = new ComboBox();
            cbEmployee = new ComboBox();
            cbHourlyRates = new ComboBox();
            dtTimeIn = new DateTimePicker();
            dtTimeOut = new DateTimePicker();
            tbAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSimpan = new Button();
            btnCancel = new Button();
            btnJumlah = new Button();
            btnSimpanUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgparkingData).BeginInit();
            SuspendLayout();
            // 
            // dgparkingData
            // 
            dgparkingData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgparkingData.Location = new Point(307, 12);
            dgparkingData.Name = "dgparkingData";
            dgparkingData.RowTemplate.Height = 25;
            dgparkingData.Size = new Size(837, 591);
            dgparkingData.TabIndex = 0;
            dgparkingData.CellContentClick += dgparkingData_CellContentClick;
            // 
            // cbLicense
            // 
            cbLicense.FormattingEnabled = true;
            cbLicense.Location = new Point(92, 78);
            cbLicense.Margin = new Padding(10);
            cbLicense.Name = "cbLicense";
            cbLicense.Size = new Size(171, 23);
            cbLicense.TabIndex = 1;
            // 
            // cbVehicle
            // 
            cbVehicle.FormattingEnabled = true;
            cbVehicle.Location = new Point(92, 121);
            cbVehicle.Margin = new Padding(10);
            cbVehicle.Name = "cbVehicle";
            cbVehicle.Size = new Size(171, 23);
            cbVehicle.TabIndex = 2;
            // 
            // cbEmployee
            // 
            cbEmployee.FormattingEnabled = true;
            cbEmployee.Location = new Point(92, 164);
            cbEmployee.Margin = new Padding(10);
            cbEmployee.Name = "cbEmployee";
            cbEmployee.Size = new Size(171, 23);
            cbEmployee.TabIndex = 3;
            // 
            // cbHourlyRates
            // 
            cbHourlyRates.FormattingEnabled = true;
            cbHourlyRates.Location = new Point(92, 207);
            cbHourlyRates.Margin = new Padding(10);
            cbHourlyRates.Name = "cbHourlyRates";
            cbHourlyRates.Size = new Size(171, 23);
            cbHourlyRates.TabIndex = 4;
            // 
            // dtTimeIn
            // 
            dtTimeIn.Format = DateTimePickerFormat.Time;
            dtTimeIn.Location = new Point(92, 250);
            dtTimeIn.Margin = new Padding(10);
            dtTimeIn.Name = "dtTimeIn";
            dtTimeIn.Size = new Size(171, 23);
            dtTimeIn.TabIndex = 5;
            // 
            // dtTimeOut
            // 
            dtTimeOut.Format = DateTimePickerFormat.Time;
            dtTimeOut.Location = new Point(92, 293);
            dtTimeOut.Margin = new Padding(10);
            dtTimeOut.Name = "dtTimeOut";
            dtTimeOut.Size = new Size(171, 23);
            dtTimeOut.TabIndex = 6;
            // 
            // tbAmount
            // 
            tbAmount.Enabled = false;
            tbAmount.Location = new Point(173, 329);
            tbAmount.Name = "tbAmount";
            tbAmount.PlaceholderText = "Rp. 0";
            tbAmount.Size = new Size(90, 23);
            tbAmount.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 299);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 9;
            label2.Text = "Date Out";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 256);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Date In";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 81);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 11;
            label4.Text = "License Plate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 124);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "Vehicle";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 167);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 13;
            label6.Text = "Employee";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 210);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 14;
            label7.Text = "HourLy Rates";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(15, 380);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 15;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(188, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnJumlah
            // 
            btnJumlah.Location = new Point(92, 329);
            btnJumlah.Name = "btnJumlah";
            btnJumlah.Size = new Size(75, 23);
            btnJumlah.TabIndex = 17;
            btnJumlah.Text = "Jumlah";
            btnJumlah.UseVisualStyleBackColor = true;
            btnJumlah.Click += btnJumlah_Click;
            // 
            // btnSimpanUpdate
            // 
            btnSimpanUpdate.Location = new Point(15, 380);
            btnSimpanUpdate.Name = "btnSimpanUpdate";
            btnSimpanUpdate.Size = new Size(75, 23);
            btnSimpanUpdate.TabIndex = 18;
            btnSimpanUpdate.Text = "Simpan";
            btnSimpanUpdate.UseVisualStyleBackColor = true;
            btnSimpanUpdate.Visible = false;
            btnSimpanUpdate.Click += btnSimpanUpdate_Click;
            // 
            // ParkingData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(btnSimpanUpdate);
            Controls.Add(btnJumlah);
            Controls.Add(btnCancel);
            Controls.Add(btnSimpan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbAmount);
            Controls.Add(dtTimeOut);
            Controls.Add(dtTimeIn);
            Controls.Add(cbHourlyRates);
            Controls.Add(cbEmployee);
            Controls.Add(cbVehicle);
            Controls.Add(cbLicense);
            Controls.Add(dgparkingData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParkingData";
            Text = "ParkingData";
            Load += ParkingData_Load;
            ((System.ComponentModel.ISupportInitialize)dgparkingData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgparkingData;
        private ComboBox cbLicense;
        private ComboBox cbVehicle;
        private ComboBox cbEmployee;
        private ComboBox cbHourlyRates;
        private DateTimePicker dtTimeIn;
        private DateTimePicker dtTimeOut;
        private TextBox tbAmount;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSimpan;
        private Button btnCancel;
        private Button btnJumlah;
        private Button btnSimpanUpdate;
    }
}