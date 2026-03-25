namespace Invoice_Generator
{
    partial class FrmManageProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageProfile));
            this.UpdateProfileBtn = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.FormLogo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FormLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateProfileBtn
            // 
            this.UpdateProfileBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.UpdateProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProfileBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateProfileBtn.Location = new System.Drawing.Point(517, 371);
            this.UpdateProfileBtn.Name = "UpdateProfileBtn";
            this.UpdateProfileBtn.Size = new System.Drawing.Size(370, 73);
            this.UpdateProfileBtn.TabIndex = 13;
            this.UpdateProfileBtn.Text = "Update Profile";
            this.UpdateProfileBtn.UseVisualStyleBackColor = false;
            this.UpdateProfileBtn.Click += new System.EventHandler(this.UpdateProfileBtn_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtPassword.Location = new System.Drawing.Point(517, 277);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(370, 39);
            this.TxtPassword.TabIndex = 12;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(356, 275);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(155, 38);
            this.LblPassword.TabIndex = 11;
            this.LblPassword.Text = "Password :";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TxtUserName.Location = new System.Drawing.Point(517, 195);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(370, 39);
            this.TxtUserName.TabIndex = 10;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserName.Location = new System.Drawing.Point(345, 196);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(169, 38);
            this.LblUserName.TabIndex = 9;
            this.LblUserName.Text = "UserName :";
            // 
            // FormLogo
            // 
            this.FormLogo.Image = ((System.Drawing.Image)(resources.GetObject("FormLogo.Image")));
            this.FormLogo.Location = new System.Drawing.Point(40, 169);
            this.FormLogo.Name = "FormLogo";
            this.FormLogo.Size = new System.Drawing.Size(270, 287);
            this.FormLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormLogo.TabIndex = 8;
            this.FormLogo.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(268, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(388, 67);
            this.Title.TabIndex = 7;
            this.Title.Text = "Manage Profile";
            // 
            // FrmManageProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 514);
            this.Controls.Add(this.UpdateProfileBtn);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.FormLogo);
            this.Controls.Add(this.Title);
            this.Name = "FrmManageProfile";
            this.Text = "FrmManageProfile";
            this.Load += new System.EventHandler(this.FrmManageProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FormLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateProfileBtn;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.PictureBox FormLogo;
        private System.Windows.Forms.Label Title;
    }
}