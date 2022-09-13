namespace Readed_Book_Lister
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.dgvUserBookList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(1248, 609);
            this.btnBookAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 28);
            this.btnBookAdd.TabIndex = 0;
            this.btnBookAdd.Text = "Kitap Ekle";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // dgvUserBookList
            // 
            this.dgvUserBookList.AllowUserToAddRows = false;
            this.dgvUserBookList.AllowUserToDeleteRows = false;
            this.dgvUserBookList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserBookList.Location = new System.Drawing.Point(40, 100);
            this.dgvUserBookList.Name = "dgvUserBookList";
            this.dgvUserBookList.ReadOnly = true;
            this.dgvUserBookList.RowTemplate.Height = 25;
            this.dgvUserBookList.Size = new System.Drawing.Size(1283, 478);
            this.dgvUserBookList.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 673);
            this.ControlBox = false;
            this.Controls.Add(this.dgvUserBookList);
            this.Controls.Add(this.btnBookAdd);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.DataGridView dgvUserBookList;
    }
}