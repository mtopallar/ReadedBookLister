namespace Readed_Book_Lister
{
    partial class BookAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAdd));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMouth = new System.Windows.Forms.ComboBox();
            this.cbxReaded = new System.Windows.Forms.CheckBox();
            this.cbxNative = new System.Windows.Forms.CheckBox();
            this.cbxYear = new System.Windows.Forms.CheckBox();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.tbxImage = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAddBook = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTipAddBook = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
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
            this.btnClear.Location = new System.Drawing.Point(583, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 48);
            this.btnClear.TabIndex = 11;
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
            this.btnBrowse.Location = new System.Drawing.Point(672, 105);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(65, 53);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.MouseLeave += new System.EventHandler(this.btnBrowse_MouseLeave);
            this.btnBrowse.MouseHover += new System.EventHandler(this.btnBrowse_MouseHover);
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.Color.Wheat;
            this.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(214, 274);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(134, 26);
            this.cmbYear.TabIndex = 7;
            this.cmbYear.Text = "Bitirme Tarihi (Yıl)";
            // 
            // cmbMouth
            // 
            this.cmbMouth.BackColor = System.Drawing.Color.Wheat;
            this.cmbMouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMouth.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbMouth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMouth.FormattingEnabled = true;
            this.cmbMouth.Location = new System.Drawing.Point(64, 274);
            this.cmbMouth.Name = "cmbMouth";
            this.cmbMouth.Size = new System.Drawing.Size(134, 26);
            this.cmbMouth.TabIndex = 6;
            this.cmbMouth.Text = "Bitirme Tarihi (Ay)";
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
            this.cbxReaded.Location = new System.Drawing.Point(169, 207);
            this.cbxReaded.Name = "cbxReaded";
            this.cbxReaded.Size = new System.Drawing.Size(75, 60);
            this.cbxReaded.TabIndex = 4;
            this.cbxReaded.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxReaded.UseVisualStyleBackColor = false;
            this.cbxReaded.MouseLeave += new System.EventHandler(this.cbxReaded_MouseLeave);
            this.cbxReaded.MouseHover += new System.EventHandler(this.cbxReaded_MouseHover);
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
            this.cbxNative.Location = new System.Drawing.Point(281, 211);
            this.cbxNative.Name = "cbxNative";
            this.cbxNative.Size = new System.Drawing.Size(63, 48);
            this.cbxNative.TabIndex = 5;
            this.cbxNative.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxNative.UseVisualStyleBackColor = false;
            this.cbxNative.MouseLeave += new System.EventHandler(this.cbxNative_MouseLeave);
            this.cbxNative.MouseHover += new System.EventHandler(this.cbxNative_MouseHover);
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
            this.cbxYear.Location = new System.Drawing.Point(64, 210);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(69, 54);
            this.cbxYear.TabIndex = 3;
            this.cbxYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxYear.UseVisualStyleBackColor = false;
            this.cbxYear.MouseLeave += new System.EventHandler(this.cbxYear_MouseLeave);
            this.cbxYear.MouseHover += new System.EventHandler(this.cbxYear_MouseHover);
            // 
            // tbxNote
            // 
            this.tbxNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNote.BackColor = System.Drawing.Color.Wheat;
            this.tbxNote.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxNote.Location = new System.Drawing.Point(389, 169);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.PlaceholderText = "Notlar (tercihen)";
            this.tbxNote.Size = new System.Drawing.Size(348, 131);
            this.tbxNote.TabIndex = 10;
            // 
            // tbxImage
            // 
            this.tbxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxImage.BackColor = System.Drawing.Color.Wheat;
            this.tbxImage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxImage.Location = new System.Drawing.Point(389, 116);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.PlaceholderText = "Kapak Resmi";
            this.tbxImage.Size = new System.Drawing.Size(277, 25);
            this.tbxImage.TabIndex = 8;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxAuthor.BackColor = System.Drawing.Color.Wheat;
            this.tbxAuthor.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxAuthor.Location = new System.Drawing.Point(64, 169);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.PlaceholderText = "Yazarı";
            this.tbxAuthor.Size = new System.Drawing.Size(284, 25);
            this.tbxAuthor.TabIndex = 2;
            this.tbxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Wheat;
            this.tbxName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxName.Location = new System.Drawing.Point(64, 116);
            this.tbxName.Name = "tbxName";
            this.tbxName.PlaceholderText = "Adı";
            this.tbxName.Size = new System.Drawing.Size(284, 25);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.BackColor = System.Drawing.Color.Transparent;
            this.lblAddBook.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddBook.ForeColor = System.Drawing.Color.Black;
            this.lblAddBook.Location = new System.Drawing.Point(269, 37);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(231, 54);
            this.lblAddBook.TabIndex = 8;
            this.lblAddBook.Text = "Kitap Ekle";
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
            this.btnCancel.Location = new System.Drawing.Point(639, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 48);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            this.btnCancel.MouseHover += new System.EventHandler(this.btnCancel_MouseHover);
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
            this.btnSave.Location = new System.Drawing.Point(688, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 48);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
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
            this.btnClose.Location = new System.Drawing.Point(732, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // toolTipAddBook
            // 
            this.toolTipAddBook.IsBalloon = true;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbMouth);
            this.Controls.Add(this.cbxReaded);
            this.Controls.Add(this.cbxNative);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.tbxImage);
            this.Controls.Add(this.tbxAuthor);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblAddBook);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMouth;
        private System.Windows.Forms.CheckBox cbxReaded;
        private System.Windows.Forms.CheckBox cbxNative;
        private System.Windows.Forms.CheckBox cbxYear;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.TextBox tbxImage;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTipAddBook;
        private System.Windows.Forms.ToolTip toolTipClose;
    }
}