namespace Readed_Book_Lister
{
    partial class BookUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookUpdate));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cbxReaded = new System.Windows.Forms.CheckBox();
            this.cbxNative = new System.Windows.Forms.CheckBox();
            this.cbxMonth = new System.Windows.Forms.CheckBox();
            this.cbxYear = new System.Windows.Forms.CheckBox();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.tbxImage = new System.Windows.Forms.TextBox();
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.lblUpdateBook = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.toolTipUpdateBook = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.Wheat;
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage.Image")));
            this.pbxImage.Location = new System.Drawing.Point(638, 200);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(100, 131);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 35;
            this.pbxImage.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(584, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 48);
            this.btnClear.TabIndex = 31;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnClear_MouseHover);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(673, 141);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(65, 53);
            this.btnBrowse.TabIndex = 29;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.Wheat;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(215, 305);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(134, 26);
            this.cmbYear.TabIndex = 26;
            this.cmbYear.Text = "Bitirme Tarihi (Yıl)";
            this.cmbYear.SelectedValueChanged += new System.EventHandler(this.cmbYear_SelectedValueChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.Wheat;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbMonth.Location = new System.Drawing.Point(65, 305);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(134, 26);
            this.cmbMonth.TabIndex = 25;
            this.cmbMonth.Text = "Bitirme Tarihi (Ay)";
            this.cmbMonth.SelectedValueChanged += new System.EventHandler(this.cmbMonth_SelectedValueChanged);
            // 
            // cbxReaded
            // 
            this.cbxReaded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxReaded.AutoSize = true;
            this.cbxReaded.BackColor = System.Drawing.Color.Transparent;
            this.cbxReaded.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbxReaded.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbxReaded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbxReaded.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxReaded.ForeColor = System.Drawing.Color.White;
            this.cbxReaded.Image = ((System.Drawing.Image)(resources.GetObject("cbxReaded.Image")));
            this.cbxReaded.Location = new System.Drawing.Point(215, 229);
            this.cbxReaded.Name = "cbxReaded";
            this.cbxReaded.Size = new System.Drawing.Size(75, 60);
            this.cbxReaded.TabIndex = 22;
            this.cbxReaded.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxReaded.UseVisualStyleBackColor = false;
            this.cbxReaded.CheckedChanged += new System.EventHandler(this.cbxReaded_CheckedChanged);
            // 
            // cbxNative
            // 
            this.cbxNative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNative.AutoSize = true;
            this.cbxNative.BackColor = System.Drawing.Color.Transparent;
            this.cbxNative.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbxNative.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbxNative.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbxNative.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNative.ForeColor = System.Drawing.Color.White;
            this.cbxNative.Image = ((System.Drawing.Image)(resources.GetObject("cbxNative.Image")));
            this.cbxNative.Location = new System.Drawing.Point(297, 235);
            this.cbxNative.Name = "cbxNative";
            this.cbxNative.Size = new System.Drawing.Size(63, 48);
            this.cbxNative.TabIndex = 23;
            this.cbxNative.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxNative.UseVisualStyleBackColor = false;
            // 
            // cbxMonth
            // 
            this.cbxMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxMonth.AutoSize = true;
            this.cbxMonth.BackColor = System.Drawing.Color.Transparent;
            this.cbxMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbxMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbxMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbxMonth.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxMonth.ForeColor = System.Drawing.Color.White;
            this.cbxMonth.Image = ((System.Drawing.Image)(resources.GetObject("cbxMonth.Image")));
            this.cbxMonth.Location = new System.Drawing.Point(70, 229);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(69, 54);
            this.cbxMonth.TabIndex = 20;
            this.cbxMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxMonth.UseVisualStyleBackColor = false;
            this.cbxMonth.CheckedChanged += new System.EventHandler(this.cbxMonth_CheckedChanged);
            // 
            // cbxYear
            // 
            this.cbxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxYear.AutoSize = true;
            this.cbxYear.BackColor = System.Drawing.Color.Transparent;
            this.cbxYear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.cbxYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cbxYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cbxYear.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxYear.ForeColor = System.Drawing.Color.White;
            this.cbxYear.Image = ((System.Drawing.Image)(resources.GetObject("cbxYear.Image")));
            this.cbxYear.Location = new System.Drawing.Point(140, 229);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(69, 54);
            this.cbxYear.TabIndex = 21;
            this.cbxYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxYear.UseVisualStyleBackColor = false;
            this.cbxYear.CheckedChanged += new System.EventHandler(this.cbxYear_CheckedChanged);
            // 
            // tbxNote
            // 
            this.tbxNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNote.BackColor = System.Drawing.Color.Wheat;
            this.tbxNote.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxNote.Location = new System.Drawing.Point(390, 200);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.PlaceholderText = "Notlar (tercihen)";
            this.tbxNote.Size = new System.Drawing.Size(243, 131);
            this.tbxNote.TabIndex = 30;
            // 
            // tbxImage
            // 
            this.tbxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxImage.BackColor = System.Drawing.Color.Wheat;
            this.tbxImage.Enabled = false;
            this.tbxImage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxImage.Location = new System.Drawing.Point(390, 152);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.PlaceholderText = "                  Kapak Resmi";
            this.tbxImage.ReadOnly = true;
            this.tbxImage.Size = new System.Drawing.Size(277, 25);
            this.tbxImage.TabIndex = 28;
            this.tbxImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(733, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
            this.btnClose.TabIndex = 34;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(689, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 48);
            this.btnSave.TabIndex = 33;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(640, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 48);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPublisher.BackColor = System.Drawing.Color.Wheat;
            this.tbxPublisher.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxPublisher.Location = new System.Drawing.Point(65, 189);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.PlaceholderText = "Yayınevi";
            this.tbxPublisher.Size = new System.Drawing.Size(284, 25);
            this.tbxPublisher.TabIndex = 19;
            this.tbxPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPublisher.TextChanged += new System.EventHandler(this.tbxPublisher_TextChanged);
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.BackColor = System.Drawing.Color.Wheat;
            this.tbxIsbn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxIsbn.Location = new System.Drawing.Point(390, 116);
            this.tbxIsbn.MaxLength = 13;
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.PlaceholderText = "ISBN No";
            this.tbxIsbn.Size = new System.Drawing.Size(277, 25);
            this.tbxIsbn.TabIndex = 27;
            this.tbxIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIsbn.TextChanged += new System.EventHandler(this.tbxIsbn_TextChanged);
            this.tbxIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIsbn_KeyPress);
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxAuthor.BackColor = System.Drawing.Color.Wheat;
            this.tbxAuthor.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxAuthor.Location = new System.Drawing.Point(65, 152);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.PlaceholderText = "Yazarı";
            this.tbxAuthor.Size = new System.Drawing.Size(284, 25);
            this.tbxAuthor.TabIndex = 18;
            this.tbxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAuthor.TextChanged += new System.EventHandler(this.tbxAuthor_TextChanged);
            // 
            // lblUpdateBook
            // 
            this.lblUpdateBook.AutoSize = true;
            this.lblUpdateBook.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateBook.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateBook.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateBook.Location = new System.Drawing.Point(258, 37);
            this.lblUpdateBook.Name = "lblUpdateBook";
            this.lblUpdateBook.Size = new System.Drawing.Size(326, 54);
            this.lblUpdateBook.TabIndex = 24;
            this.lblUpdateBook.Text = "Kitabı Güncelle";
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Wheat;
            this.tbxName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxName.Location = new System.Drawing.Point(65, 116);
            this.tbxName.Name = "tbxName";
            this.tbxName.PlaceholderText = "Adı";
            this.tbxName.Size = new System.Drawing.Size(284, 25);
            this.tbxName.TabIndex = 17;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // toolTipUpdateBook
            // 
            this.toolTipUpdateBook.IsBalloon = true;
            // 
            // BookUpdate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(796, 416);
            this.ControlBox = false;
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cbxReaded);
            this.Controls.Add(this.cbxNative);
            this.Controls.Add(this.cbxMonth);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.tbxImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxPublisher);
            this.Controls.Add(this.tbxIsbn);
            this.Controls.Add(this.tbxAuthor);
            this.Controls.Add(this.lblUpdateBook);
            this.Controls.Add(this.tbxName);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookUpdate";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookUpdate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.CheckBox cbxReaded;
        private System.Windows.Forms.CheckBox cbxNative;
        private System.Windows.Forms.CheckBox cbxMonth;
        private System.Windows.Forms.CheckBox cbxYear;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.TextBox tbxImage;
        private System.Windows.Forms.ToolTip toolTipClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label lblUpdateBook;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.ToolTip toolTipUpdateBook;
    }
}