namespace Latihan_DesktopApp
{
    partial class Vehicle
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
            dataGridVehicle = new DataGridView();
            label1 = new Label();
            cbVehicleType = new ComboBox();
            cbMember = new ComboBox();
            tbPlate = new TextBox();
            tbNote = new TextBox();
            btnTambah = new Button();
            btnBatal = new Button();
            btnSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridVehicle).BeginInit();
            SuspendLayout();
            // 
            // dataGridVehicle
            // 
            dataGridVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVehicle.Location = new Point(323, 12);
            dataGridVehicle.Name = "dataGridVehicle";
            dataGridVehicle.RowTemplate.Height = 25;
            dataGridVehicle.Size = new Size(821, 591);
            dataGridVehicle.TabIndex = 0;
            dataGridVehicle.CellContentClick += dataGridVehicle_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Gothic Std B", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 1;
            label1.Text = "Vehicle";
            // 
            // cbVehicleType
            // 
            cbVehicleType.FormattingEnabled = true;
            cbVehicleType.Location = new Point(12, 84);
            cbVehicleType.Name = "cbVehicleType";
            cbVehicleType.Size = new Size(286, 23);
            cbVehicleType.TabIndex = 2;
            // 
            // cbMember
            // 
            cbMember.FormattingEnabled = true;
            cbMember.Location = new Point(12, 125);
            cbMember.Name = "cbMember";
            cbMember.Size = new Size(286, 23);
            cbMember.TabIndex = 3;
            // 
            // tbPlate
            // 
            tbPlate.Location = new Point(12, 165);
            tbPlate.Name = "tbPlate";
            tbPlate.PlaceholderText = "Masukan Plat Nomer Kendaraan";
            tbPlate.Size = new Size(286, 23);
            tbPlate.TabIndex = 4;
            // 
            // tbNote
            // 
            tbNote.Location = new Point(12, 206);
            tbNote.Multiline = true;
            tbNote.Name = "tbNote";
            tbNote.PlaceholderText = "Tambahkan Catatan";
            tbNote.Size = new Size(286, 119);
            tbNote.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(12, 352);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 23);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(204, 352);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 23);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(12, 352);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 23);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Visible = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // Vehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(btnTambah);
            Controls.Add(tbNote);
            Controls.Add(tbPlate);
            Controls.Add(cbMember);
            Controls.Add(cbVehicleType);
            Controls.Add(label1);
            Controls.Add(dataGridVehicle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vehicle";
            Text = "Vehicle";
            Load += Vehicle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridVehicle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridVehicle;
        private Label label1;
        private ComboBox cbVehicleType;
        private ComboBox cbMember;
        private TextBox tbPlate;
        private TextBox tbNote;
        private Button btnTambah;
        private Button btnBatal;
        private Button btnSimpan;
    }
}