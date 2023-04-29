namespace Latihan_DesktopApp
{
    partial class updateMembership
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
            btnSave = new Button();
            tbUpdateMembership = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(89, 53);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 28);
            btnSave.TabIndex = 3;
            btnSave.Text = "Simpan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbUpdateMembership
            // 
            tbUpdateMembership.Location = new Point(12, 12);
            tbUpdateMembership.Name = "tbUpdateMembership";
            tbUpdateMembership.PlaceholderText = "Input Here ...";
            tbUpdateMembership.Size = new Size(253, 23);
            tbUpdateMembership.TabIndex = 2;
            tbUpdateMembership.TextChanged += tbUpdateMembership_TextChanged;
            // 
            // updateMembership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 93);
            Controls.Add(btnSave);
            Controls.Add(tbUpdateMembership);
            Name = "updateMembership";
            Text = "updateMembership";
            Load += updateMembership_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox tbUpdateMembership;
    }
}