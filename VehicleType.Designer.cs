namespace Latihan_DesktopApp
{
    partial class VehicleType
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
            components = new System.ComponentModel.Container();
            btnTambah = new Button();
            viewVehicleType = new DataGridView();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)viewVehicleType).BeginInit();
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
            // viewVehicleType
            // 
            viewVehicleType.AllowUserToAddRows = false;
            viewVehicleType.AllowUserToDeleteRows = false;
            viewVehicleType.AllowUserToResizeColumns = false;
            viewVehicleType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewVehicleType.Location = new Point(12, 107);
            viewVehicleType.Name = "viewVehicleType";
            viewVehicleType.ReadOnly = true;
            viewVehicleType.RowTemplate.Height = 25;
            viewVehicleType.SelectionMode = DataGridViewSelectionMode.CellSelect;
            viewVehicleType.Size = new Size(1132, 484);
            viewVehicleType.TabIndex = 4;
            viewVehicleType.CellContentClick += viewMembership_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 3;
            label1.Text = "Vehicle Type";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // VehicleType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(btnTambah);
            Controls.Add(viewVehicleType);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VehicleType";
            Text = "VehicleType";
            Load += VehicleType_Load;
            ((System.ComponentModel.ISupportInitialize)viewVehicleType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah;
        private DataGridView viewVehicleType;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}