namespace Latihan_DesktopApp
{
    partial class Membershipcs
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
            label1 = new Label();
            viewMembership = new DataGridView();
            btnTambah = new Button();
            ((System.ComponentModel.ISupportInitialize)viewMembership).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 0;
            label1.Text = "Membership";
            label1.Click += label1_Click;
            // 
            // viewMembership
            // 
            viewMembership.AllowUserToAddRows = false;
            viewMembership.AllowUserToDeleteRows = false;
            viewMembership.AllowUserToResizeColumns = false;
            viewMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewMembership.Location = new Point(12, 119);
            viewMembership.Name = "viewMembership";
            viewMembership.ReadOnly = true;
            viewMembership.RowTemplate.Height = 25;
            viewMembership.Size = new Size(1132, 484);
            viewMembership.TabIndex = 1;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(938, 80);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(206, 33);
            btnTambah.TabIndex = 2;
            btnTambah.Text = "Tambahkan";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // Membershipcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 615);
            Controls.Add(btnTambah);
            Controls.Add(viewMembership);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Membershipcs";
            Text = "Membershipcs";
            Load += Membershipcs_Load;
            ((System.ComponentModel.ISupportInitialize)viewMembership).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView viewMembership;
        private Button btnTambah;
    }
}