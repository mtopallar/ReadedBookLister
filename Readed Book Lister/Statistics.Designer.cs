namespace Readed_Book_Lister
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJustMonthInAYear = new System.Windows.Forms.ComboBox();
            this.cmbJustAYear = new System.Windows.Forms.ComboBox();
            this.cmbBetweenTwoYears = new System.Windows.Forms.ComboBox();
            this.cmbSelection = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(449, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstatistikler";
            // 
            // cmbJustMonthInAYear
            // 
            this.cmbJustMonthInAYear.BackColor = System.Drawing.Color.Wheat;
            this.cmbJustMonthInAYear.FormattingEnabled = true;
            this.cmbJustMonthInAYear.Location = new System.Drawing.Point(332, 158);
            this.cmbJustMonthInAYear.Name = "cmbJustMonthInAYear";
            this.cmbJustMonthInAYear.Size = new System.Drawing.Size(226, 26);
            this.cmbJustMonthInAYear.TabIndex = 1;
            this.cmbJustMonthInAYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbJustMonthInAYear_KeyDown);
            // 
            // cmbJustAYear
            // 
            this.cmbJustAYear.BackColor = System.Drawing.Color.Wheat;
            this.cmbJustAYear.FormattingEnabled = true;
            this.cmbJustAYear.Location = new System.Drawing.Point(607, 158);
            this.cmbJustAYear.Name = "cmbJustAYear";
            this.cmbJustAYear.Size = new System.Drawing.Size(226, 26);
            this.cmbJustAYear.TabIndex = 2;
            this.cmbJustAYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbJustAYear_KeyDown);
            // 
            // cmbBetweenTwoYears
            // 
            this.cmbBetweenTwoYears.BackColor = System.Drawing.Color.Wheat;
            this.cmbBetweenTwoYears.FormattingEnabled = true;
            this.cmbBetweenTwoYears.Location = new System.Drawing.Point(875, 158);
            this.cmbBetweenTwoYears.Name = "cmbBetweenTwoYears";
            this.cmbBetweenTwoYears.Size = new System.Drawing.Size(226, 26);
            this.cmbBetweenTwoYears.TabIndex = 3;
            this.cmbBetweenTwoYears.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBetweenTwoYears_KeyDown);
            // 
            // cmbSelection
            // 
            this.cmbSelection.BackColor = System.Drawing.Color.Wheat;
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Items.AddRange(new object[] {
            "Seçili yıl içinde",
            "Seçili yıldaki seçili bir ay içinde",
            "Seçili yıllar arasında"});
            this.cmbSelection.Location = new System.Drawing.Point(56, 158);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(226, 26);
            this.cmbSelection.TabIndex = 4;
            this.cmbSelection.SelectedIndexChanged += new System.EventHandler(this.cmbSelection_SelectedIndexChanged);
            this.cmbSelection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSelection_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1092, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
            this.btnClose.TabIndex = 18;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 686);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmbSelection);
            this.Controls.Add(this.cmbBetweenTwoYears);
            this.Controls.Add(this.cmbJustAYear);
            this.Controls.Add(this.cmbJustMonthInAYear);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistics";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJustMonthInAYear;
        private System.Windows.Forms.ComboBox cmbJustAYear;
        private System.Windows.Forms.ComboBox cmbBetweenTwoYears;
        private System.Windows.Forms.ComboBox cmbSelection;
        private System.Windows.Forms.Button btnClose;
    }
}