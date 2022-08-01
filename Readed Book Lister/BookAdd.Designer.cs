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
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(583, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 48);
            this.btnClear.TabIndex = 20;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(672, 105);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(65, 53);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.UseVisualStyleBackColor = false;
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
            this.cmbYear.TabIndex = 16;
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
            this.cmbMouth.TabIndex = 17;
            this.cmbMouth.Text = "Bitirme Tarihi (Ay)";
            // 
            // cbxReaded
            // 
            this.cbxReaded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxReaded.AutoSize = true;
            this.cbxReaded.BackColor = System.Drawing.Color.Transparent;
            this.cbxReaded.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxReaded.ForeColor = System.Drawing.Color.White;
            this.cbxReaded.Image = ((System.Drawing.Image)(resources.GetObject("cbxReaded.Image")));
            this.cbxReaded.Location = new System.Drawing.Point(169, 207);
            this.cbxReaded.Name = "cbxReaded";
            this.cbxReaded.Size = new System.Drawing.Size(75, 60);
            this.cbxReaded.TabIndex = 13;
            this.cbxReaded.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxReaded.UseVisualStyleBackColor = false;
            // 
            // cbxNative
            // 
            this.cbxNative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxNative.AutoSize = true;
            this.cbxNative.BackColor = System.Drawing.Color.Transparent;
            this.cbxNative.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxNative.ForeColor = System.Drawing.Color.White;
            this.cbxNative.Image = ((System.Drawing.Image)(resources.GetObject("cbxNative.Image")));
            this.cbxNative.Location = new System.Drawing.Point(281, 211);
            this.cbxNative.Name = "cbxNative";
            this.cbxNative.Size = new System.Drawing.Size(67, 52);
            this.cbxNative.TabIndex = 14;
            this.cbxNative.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxNative.UseVisualStyleBackColor = false;
            // 
            // cbxYear
            // 
            this.cbxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxYear.AutoSize = true;
            this.cbxYear.BackColor = System.Drawing.Color.Transparent;
            this.cbxYear.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxYear.ForeColor = System.Drawing.Color.White;
            this.cbxYear.Image = ((System.Drawing.Image)(resources.GetObject("cbxYear.Image")));
            this.cbxYear.Location = new System.Drawing.Point(64, 210);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(69, 54);
            this.cbxYear.TabIndex = 15;
            this.cbxYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbxYear.UseVisualStyleBackColor = false;
            // 
            // tbxNote
            // 
            this.tbxNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxNote.BackColor = System.Drawing.Color.Wheat;
            this.tbxNote.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNote.ForeColor = System.Drawing.Color.Black;
            this.tbxNote.Location = new System.Drawing.Point(389, 169);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.PlaceholderText = "Notlar (tercihen)";
            this.tbxNote.Size = new System.Drawing.Size(348, 131);
            this.tbxNote.TabIndex = 9;
            // 
            // tbxImage
            // 
            this.tbxImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxImage.BackColor = System.Drawing.Color.Wheat;
            this.tbxImage.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxImage.ForeColor = System.Drawing.Color.Black;
            this.tbxImage.Location = new System.Drawing.Point(389, 116);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.PlaceholderText = "Resim...";
            this.tbxImage.Size = new System.Drawing.Size(277, 25);
            this.tbxImage.TabIndex = 10;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxAuthor.BackColor = System.Drawing.Color.Wheat;
            this.tbxAuthor.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxAuthor.ForeColor = System.Drawing.Color.Black;
            this.tbxAuthor.Location = new System.Drawing.Point(64, 169);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.PlaceholderText = "Yazarı";
            this.tbxAuthor.Size = new System.Drawing.Size(284, 25);
            this.tbxAuthor.TabIndex = 11;
            this.tbxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.Wheat;
            this.tbxName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(64, 116);
            this.tbxName.Name = "tbxName";
            this.tbxName.PlaceholderText = "Adı";
            this.tbxName.Size = new System.Drawing.Size(284, 25);
            this.tbxName.TabIndex = 12;
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
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(639, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 48);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(688, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 48);
            this.btnSave.TabIndex = 20;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.ControlBox = false;
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
    }
}