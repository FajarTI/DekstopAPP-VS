namespace Latihan_DesktopApp
{
    partial class search
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
            txtID = new TextBox();
            label2 = new Label();
            btnCari = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 56);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(81, 53);
            txtID.Name = "txtID";
            txtID.Size = new Size(156, 23);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 2;
            label2.Text = "Masukan ID";
            // 
            // btnCari
            // 
            btnCari.Location = new Point(12, 93);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(225, 23);
            btnCari.TabIndex = 3;
            btnCari.Text = "Cari ID";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCari;
            ClientSize = new Size(249, 133);
            Controls.Add(btnCari);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "search";
            Text = "Cari ID";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private Label label2;
        private Button btnCari;
    }
}