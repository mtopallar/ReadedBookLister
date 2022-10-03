namespace Readed_Book_Lister
{
    partial class ProfileOperations
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileOperations));
            this.tbxCurrentPassword = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblProfileOperaitons = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxNewPasswordAgain = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTipProfileOperations = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxCurrentPassword
            // 
            this.tbxCurrentPassword.BackColor = System.Drawing.Color.Wheat;
            this.tbxCurrentPassword.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxCurrentPassword.Location = new System.Drawing.Point(55, 213);
            this.tbxCurrentPassword.Name = "tbxCurrentPassword";
            this.tbxCurrentPassword.PlaceholderText = "Mevcut Şifre";
            this.tbxCurrentPassword.Size = new System.Drawing.Size(235, 25);
            this.tbxCurrentPassword.TabIndex = 5;
            this.tbxCurrentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCurrentPassword.UseSystemPasswordChar = true;
            this.tbxCurrentPassword.TextChanged += new System.EventHandler(this.tbxCurrentPassword_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxName.BackColor = System.Drawing.Color.Wheat;
            this.tbxName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(55, 170);
            this.tbxName.Name = "tbxName";
            this.tbxName.PlaceholderText = "Kullanıcı Adı";
            this.tbxName.Size = new System.Drawing.Size(235, 25);
            this.tbxName.TabIndex = 4;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // lblProfileOperaitons
            // 
            this.lblProfileOperaitons.AutoSize = true;
            this.lblProfileOperaitons.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileOperaitons.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileOperaitons.ForeColor = System.Drawing.Color.Black;
            this.lblProfileOperaitons.Location = new System.Drawing.Point(-5, 83);
            this.lblProfileOperaitons.Name = "lblProfileOperaitons";
            this.lblProfileOperaitons.Size = new System.Drawing.Size(357, 61);
            this.lblProfileOperaitons.TabIndex = 3;
            this.lblProfileOperaitons.Text = "Profil İşlemleri";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.BackColor = System.Drawing.Color.Wheat;
            this.tbxNewPassword.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxNewPassword.Location = new System.Drawing.Point(55, 257);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.PlaceholderText = "Yeni Şifre";
            this.tbxNewPassword.Size = new System.Drawing.Size(235, 25);
            this.tbxNewPassword.TabIndex = 6;
            this.tbxNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            this.tbxNewPassword.TextChanged += new System.EventHandler(this.tbxNewPassword_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(308, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // tbxNewPasswordAgain
            // 
            this.tbxNewPasswordAgain.BackColor = System.Drawing.Color.Wheat;
            this.tbxNewPasswordAgain.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNewPasswordAgain.ForeColor = System.Drawing.Color.Black;
            this.tbxNewPasswordAgain.Location = new System.Drawing.Point(55, 300);
            this.tbxNewPasswordAgain.Name = "tbxNewPasswordAgain";
            this.tbxNewPasswordAgain.PlaceholderText = "Yeni Şifre Tekrar";
            this.tbxNewPasswordAgain.Size = new System.Drawing.Size(235, 25);
            this.tbxNewPasswordAgain.TabIndex = 8;
            this.tbxNewPasswordAgain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNewPasswordAgain.UseSystemPasswordChar = true;
            this.tbxNewPasswordAgain.TextChanged += new System.EventHandler(this.tbxNewPasswordAgain_TextChanged);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AccessibleDescription = "";
            this.btnDeleteUser.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.BackgroundImage")));
            this.btnDeleteUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Location = new System.Drawing.Point(284, 441);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(54, 55);
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Tag = "";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            this.btnDeleteUser.MouseLeave += new System.EventHandler(this.btnDeleteUser_MouseLeave);
            this.btnDeleteUser.MouseHover += new System.EventHandler(this.btnDeleteUser_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(151, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 73);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "";
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(189, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 55);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Tag = "";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // toolTipProfileOperations
            // 
            this.toolTipProfileOperations.IsBalloon = true;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "";
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(239, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 55);
            this.btnClear.TabIndex = 12;
            this.btnClear.Tag = "";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // ProfileOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxNewPasswordAgain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.tbxCurrentPassword);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblProfileOperaitons);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileOperations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileOperations";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProfileOperations_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProfileOperations_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProfileOperations_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCurrentPassword;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblProfileOperaitons;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbxNewPasswordAgain;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTipProfileOperations;
        private System.Windows.Forms.ToolTip toolTipClose;
        private System.Windows.Forms.Button btnClear;
    }
}