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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.dgvUserBookList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnProfileOperations = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookAdd.BackgroundImage")));
            this.btnBookAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookAdd.FlatAppearance.BorderSize = 0;
            this.btnBookAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookAdd.Location = new System.Drawing.Point(1179, 595);
            this.btnBookAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 55);
            this.btnBookAdd.TabIndex = 0;
            this.btnBookAdd.UseVisualStyleBackColor = false;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            this.btnBookAdd.MouseLeave += new System.EventHandler(this.btnBookAdd_MouseLeave);
            this.btnBookAdd.MouseHover += new System.EventHandler(this.btnBookAdd_MouseHover);
            // 
            // dgvUserBookList
            // 
            this.dgvUserBookList.AllowUserToAddRows = false;
            this.dgvUserBookList.AllowUserToDeleteRows = false;
            this.dgvUserBookList.AllowUserToResizeColumns = false;
            this.dgvUserBookList.AllowUserToResizeRows = false;
            this.dgvUserBookList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserBookList.Location = new System.Drawing.Point(42, 113);
            this.dgvUserBookList.Name = "dgvUserBookList";
            this.dgvUserBookList.ReadOnly = true;
            this.dgvUserBookList.RowHeadersVisible = false;
            this.dgvUserBookList.RowTemplate.Height = 25;
            this.dgvUserBookList.Size = new System.Drawing.Size(1122, 465);
            this.dgvUserBookList.TabIndex = 1;
            this.dgvUserBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserBookList_CellContentClick);
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
            this.btnClose.Location = new System.Drawing.Point(1223, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(586, 49);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(127, 46);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "label1";
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnBookSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBookSearch.BackgroundImage")));
            this.btnBookSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBookSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.Location = new System.Drawing.Point(1115, 595);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 55);
            this.btnBookSearch.TabIndex = 19;
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.MouseLeave += new System.EventHandler(this.btnBookSearch_MouseLeave);
            this.btnBookSearch.MouseHover += new System.EventHandler(this.btnBookSearch_MouseHover);
            // 
            // btnProfileOperations
            // 
            this.btnProfileOperations.BackColor = System.Drawing.Color.Transparent;
            this.btnProfileOperations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfileOperations.BackgroundImage")));
            this.btnProfileOperations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfileOperations.FlatAppearance.BorderSize = 0;
            this.btnProfileOperations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProfileOperations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProfileOperations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfileOperations.Location = new System.Drawing.Point(1044, 595);
            this.btnProfileOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfileOperations.Name = "btnProfileOperations";
            this.btnProfileOperations.Size = new System.Drawing.Size(75, 55);
            this.btnProfileOperations.TabIndex = 20;
            this.btnProfileOperations.UseVisualStyleBackColor = false;
            this.btnProfileOperations.MouseLeave += new System.EventHandler(this.btnProfileOperations_MouseLeave);
            this.btnProfileOperations.MouseHover += new System.EventHandler(this.btnProfileOperations_MouseHover);
            // 
            // toolTipMain
            // 
            this.toolTipMain.IsBalloon = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1293, 680);
            this.ControlBox = false;
            this.Controls.Add(this.btnProfileOperations);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.DataGridView dgvUserBookList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnProfileOperations;
        private System.Windows.Forms.ToolTip toolTipMain;
        private System.Windows.Forms.ToolTip toolTipClose;
    }
}