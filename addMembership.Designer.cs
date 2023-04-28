namespace Latihan_DesktopApp
{
    partial class addMembership
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
            tbMembership = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbMembership
            // 
            tbMembership.Location = new Point(12, 12);
            tbMembership.Name = "tbMembership";
            tbMembership.PlaceholderText = "Input Here ...";
            tbMembership.Size = new Size(253, 23);
            tbMembership.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(91, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 28);
            btnSave.TabIndex = 1;
            btnSave.Text = "Tambahkan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // addMembership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 89);
            Controls.Add(btnSave);
            Controls.Add(tbMembership);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "addMembership";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambahkan Membership";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMembership;
        private Button btnSave;
    }
}