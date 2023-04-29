namespace Latihan_DesktopApp
{
    partial class addVehicleType
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
            tbVehicleType = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(92, 45);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 28);
            btnSave.TabIndex = 3;
            btnSave.Text = "Tambahkan";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbVehicleType
            // 
            tbVehicleType.Location = new Point(13, 16);
            tbVehicleType.Name = "tbVehicleType";
            tbVehicleType.PlaceholderText = "Input Here ...";
            tbVehicleType.Size = new Size(253, 23);
            tbVehicleType.TabIndex = 2;
            // 
            // addVehicleType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 89);
            Controls.Add(btnSave);
            Controls.Add(tbVehicleType);
            Name = "addVehicleType";
            Text = "addVehicleType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox tbVehicleType;
    }
}