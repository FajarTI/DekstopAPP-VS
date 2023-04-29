namespace Latihan_DesktopApp
{
    partial class HourlyRates
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
            viewHourlyrates = new DataGridView();
            label1 = new Label();
            btnTambah = new Button();
            groupBox1 = new GroupBox();
            tbValue = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)viewHourlyrates).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // viewHourlyrates
            // 
            viewHourlyrates.AllowUserToAddRows = false;
            viewHourlyrates.AllowUserToDeleteRows = false;
            viewHourlyrates.AllowUserToResizeColumns = false;
            viewHourlyrates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewHourlyrates.Location = new Point(12, 78);
            viewHourlyrates.Name = "viewHourlyrates";
            viewHourlyrates.ReadOnly = true;
            viewHourlyrates.RowTemplate.Height = 25;
            viewHourlyrates.SelectionMode = DataGridViewSelectionMode.CellSelect;
            viewHourlyrates.Size = new Size(1132, 357);
            viewHourlyrates.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 6;
            label1.Text = "Hourly Rates";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(6, 116);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(205, 30);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbValue);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnTambah);
            groupBox1.Location = new Point(12, 441);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 151);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tambahkan Tarif Per Jam";
            // 
            // tbValue
            // 
            tbValue.BorderStyle = BorderStyle.FixedSingle;
            tbValue.Location = new Point(6, 87);
            tbValue.Name = "tbValue";
            tbValue.PlaceholderText = "Masukan Jumlah Tarif";
            tbValue.Size = new Size(205, 23);
            tbValue.TabIndex = 11;
            tbValue.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // HourlyRates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(groupBox1);
            Controls.Add(viewHourlyrates);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HourlyRates";
            Text = "Hourly Rates";
            Load += HourlyRates_Load;
            ((System.ComponentModel.ISupportInitialize)viewHourlyrates).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewHourlyrates;
        private Label label1;
        private Button btnTambah;
        private GroupBox groupBox1;
        private TextBox tbValue;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}