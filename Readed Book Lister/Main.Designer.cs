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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.dgvUserBookList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnProfileOperations = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipClose = new System.Windows.Forms.ToolTip(this.components);
            this.labelSearch = new System.Windows.Forms.Label();
            this.pnlNativeStatue = new System.Windows.Forms.Panel();
            this.rbtnNative = new System.Windows.Forms.RadioButton();
            this.rbtnNotNative = new System.Windows.Forms.RadioButton();
            this.pnlHasNote = new System.Windows.Forms.Panel();
            this.rbtnHasNote = new System.Windows.Forms.RadioButton();
            this.rbtnHasNoNote = new System.Windows.Forms.RadioButton();
            this.pnlReadStatue = new System.Windows.Forms.Panel();
            this.rbtnReaded = new System.Windows.Forms.RadioButton();
            this.rbtNotReaded = new System.Windows.Forms.RadioButton();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.rbtnIsbn = new System.Windows.Forms.RadioButton();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.rbtnQuery = new System.Windows.Forms.RadioButton();
            this.btnClearSearchArea = new System.Windows.Forms.Button();
            this.pnlSearchArea = new System.Windows.Forms.Panel();
            this.pnlIsbn = new System.Windows.Forms.Panel();
            this.pnlQuery = new System.Windows.Forms.Panel();
            this.btnStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).BeginInit();
            this.pnlNativeStatue.SuspendLayout();
            this.pnlHasNote.SuspendLayout();
            this.pnlReadStatue.SuspendLayout();
            this.pnlSearchArea.SuspendLayout();
            this.pnlIsbn.SuspendLayout();
            this.pnlQuery.SuspendLayout();
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
            this.btnBookAdd.Location = new System.Drawing.Point(962, 577);
            this.btnBookAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 55);
            this.btnBookAdd.TabIndex = 2;
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
            this.dgvUserBookList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgvUserBookList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserBookList.Location = new System.Drawing.Point(52, 113);
            this.dgvUserBookList.Name = "dgvUserBookList";
            this.dgvUserBookList.ReadOnly = true;
            this.dgvUserBookList.RowHeadersVisible = false;
            this.dgvUserBookList.RowTemplate.Height = 25;
            this.dgvUserBookList.Size = new System.Drawing.Size(1122, 434);
            this.dgvUserBookList.TabIndex = 0;
            this.dgvUserBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserBookList_CellContentClick);
            this.dgvUserBookList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserBookList_CellMouseEnter);
            this.dgvUserBookList.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserBookList_CellMouseLeave);
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
            this.btnClose.Location = new System.Drawing.Point(1469, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 26);
            this.btnClose.TabIndex = 5;
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
            this.lblHeader.Location = new System.Drawing.Point(712, 49);
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
            this.btnBookSearch.Location = new System.Drawing.Point(1099, 577);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 55);
            this.btnBookSearch.TabIndex = 4;
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
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
            this.btnProfileOperations.Location = new System.Drawing.Point(899, 577);
            this.btnProfileOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfileOperations.Name = "btnProfileOperations";
            this.btnProfileOperations.Size = new System.Drawing.Size(75, 55);
            this.btnProfileOperations.TabIndex = 1;
            this.btnProfileOperations.UseVisualStyleBackColor = false;
            this.btnProfileOperations.Click += new System.EventHandler(this.btnProfileOperations_Click);
            this.btnProfileOperations.MouseLeave += new System.EventHandler(this.btnProfileOperations_MouseLeave);
            this.btnProfileOperations.MouseHover += new System.EventHandler(this.btnProfileOperations_MouseHover);
            // 
            // toolTipMain
            // 
            this.toolTipMain.IsBalloon = true;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(94, 9);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(142, 29);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Kitap Ara...";
            // 
            // pnlNativeStatue
            // 
            this.pnlNativeStatue.BackColor = System.Drawing.Color.Tan;
            this.pnlNativeStatue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNativeStatue.Controls.Add(this.rbtnNative);
            this.pnlNativeStatue.Controls.Add(this.rbtnNotNative);
            this.pnlNativeStatue.Location = new System.Drawing.Point(3, 227);
            this.pnlNativeStatue.Name = "pnlNativeStatue";
            this.pnlNativeStatue.Size = new System.Drawing.Size(274, 33);
            this.pnlNativeStatue.TabIndex = 29;
            // 
            // rbtnNative
            // 
            this.rbtnNative.AutoSize = true;
            this.rbtnNative.Location = new System.Drawing.Point(22, 6);
            this.rbtnNative.Name = "rbtnNative";
            this.rbtnNative.Size = new System.Drawing.Size(101, 22);
            this.rbtnNative.TabIndex = 14;
            this.rbtnNative.TabStop = true;
            this.rbtnNative.Text = "Yerli Kitaplar";
            this.rbtnNative.UseVisualStyleBackColor = true;
            this.rbtnNative.CheckedChanged += new System.EventHandler(this.rbtnNative_CheckedChanged);
            // 
            // rbtnNotNative
            // 
            this.rbtnNotNative.AutoSize = true;
            this.rbtnNotNative.Location = new System.Drawing.Point(140, 6);
            this.rbtnNotNative.Name = "rbtnNotNative";
            this.rbtnNotNative.Size = new System.Drawing.Size(117, 22);
            this.rbtnNotNative.TabIndex = 15;
            this.rbtnNotNative.TabStop = true;
            this.rbtnNotNative.Text = "Yabancı Kitaplar";
            this.rbtnNotNative.UseVisualStyleBackColor = true;
            this.rbtnNotNative.CheckedChanged += new System.EventHandler(this.rbtnNotNative_CheckedChanged);
            // 
            // pnlHasNote
            // 
            this.pnlHasNote.BackColor = System.Drawing.Color.Tan;
            this.pnlHasNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHasNote.Controls.Add(this.rbtnHasNote);
            this.pnlHasNote.Controls.Add(this.rbtnHasNoNote);
            this.pnlHasNote.Location = new System.Drawing.Point(3, 179);
            this.pnlHasNote.Name = "pnlHasNote";
            this.pnlHasNote.Size = new System.Drawing.Size(274, 33);
            this.pnlHasNote.TabIndex = 27;
            // 
            // rbtnHasNote
            // 
            this.rbtnHasNote.AutoSize = true;
            this.rbtnHasNote.Location = new System.Drawing.Point(22, 6);
            this.rbtnHasNote.Name = "rbtnHasNote";
            this.rbtnHasNote.Size = new System.Drawing.Size(101, 22);
            this.rbtnHasNote.TabIndex = 12;
            this.rbtnHasNote.TabStop = true;
            this.rbtnHasNote.Text = "Not İçerenler";
            this.rbtnHasNote.UseVisualStyleBackColor = true;
            this.rbtnHasNote.CheckedChanged += new System.EventHandler(this.rbtnHasNote_CheckedChanged);
            // 
            // rbtnHasNoNote
            // 
            this.rbtnHasNoNote.AutoSize = true;
            this.rbtnHasNoNote.Location = new System.Drawing.Point(140, 6);
            this.rbtnHasNoNote.Name = "rbtnHasNoNote";
            this.rbtnHasNoNote.Size = new System.Drawing.Size(125, 22);
            this.rbtnHasNoNote.TabIndex = 13;
            this.rbtnHasNoNote.TabStop = true;
            this.rbtnHasNoNote.Text = "Not İçermeyenler";
            this.rbtnHasNoNote.UseVisualStyleBackColor = true;
            this.rbtnHasNoNote.CheckedChanged += new System.EventHandler(this.rbtnHasNoNote_CheckedChanged);
            // 
            // pnlReadStatue
            // 
            this.pnlReadStatue.BackColor = System.Drawing.Color.Tan;
            this.pnlReadStatue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReadStatue.Controls.Add(this.rbtnReaded);
            this.pnlReadStatue.Controls.Add(this.rbtNotReaded);
            this.pnlReadStatue.Location = new System.Drawing.Point(3, 131);
            this.pnlReadStatue.Name = "pnlReadStatue";
            this.pnlReadStatue.Size = new System.Drawing.Size(274, 33);
            this.pnlReadStatue.TabIndex = 25;
            // 
            // rbtnReaded
            // 
            this.rbtnReaded.AutoSize = true;
            this.rbtnReaded.Location = new System.Drawing.Point(22, 6);
            this.rbtnReaded.Name = "rbtnReaded";
            this.rbtnReaded.Size = new System.Drawing.Size(98, 22);
            this.rbtnReaded.TabIndex = 10;
            this.rbtnReaded.TabStop = true;
            this.rbtnReaded.Text = "Okuduklarım";
            this.rbtnReaded.UseVisualStyleBackColor = true;
            this.rbtnReaded.CheckedChanged += new System.EventHandler(this.rbtnReaded_CheckedChanged);
            // 
            // rbtNotReaded
            // 
            this.rbtNotReaded.AutoSize = true;
            this.rbtNotReaded.Location = new System.Drawing.Point(140, 6);
            this.rbtNotReaded.Name = "rbtNotReaded";
            this.rbtNotReaded.Size = new System.Drawing.Size(111, 22);
            this.rbtNotReaded.TabIndex = 11;
            this.rbtNotReaded.TabStop = true;
            this.rbtNotReaded.Text = "Okumadıklarım";
            this.rbtNotReaded.UseVisualStyleBackColor = true;
            this.rbtNotReaded.CheckedChanged += new System.EventHandler(this.rbtNotReaded_CheckedChanged);
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.BackColor = System.Drawing.Color.Tan;
            this.tbxIsbn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxIsbn.Location = new System.Drawing.Point(3, 7);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.PlaceholderText = "ISBN No";
            this.tbxIsbn.Size = new System.Drawing.Size(274, 26);
            this.tbxIsbn.TabIndex = 0;
            this.tbxIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxIsbn.TextChanged += new System.EventHandler(this.tbxIsbn_TextChanged);
            this.tbxIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIsbn_KeyPress);
            // 
            // rbtnIsbn
            // 
            this.rbtnIsbn.BackColor = System.Drawing.Color.Tan;
            this.rbtnIsbn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnIsbn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnIsbn.Location = new System.Drawing.Point(3, 322);
            this.rbtnIsbn.Name = "rbtnIsbn";
            this.rbtnIsbn.Size = new System.Drawing.Size(21, 39);
            this.rbtnIsbn.TabIndex = 2;
            this.rbtnIsbn.UseVisualStyleBackColor = false;
            this.rbtnIsbn.CheckedChanged += new System.EventHandler(this.rbtnIsbn_CheckedChanged);
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.BackColor = System.Drawing.Color.Tan;
            this.tbxPublisher.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxPublisher.Location = new System.Drawing.Point(2, 91);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.PlaceholderText = "Yayınevi Adı";
            this.tbxPublisher.Size = new System.Drawing.Size(275, 26);
            this.tbxPublisher.TabIndex = 9;
            this.tbxPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPublisher.TextChanged += new System.EventHandler(this.tbxPublisher_TextChanged);
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.BackColor = System.Drawing.Color.Tan;
            this.tbxAuthor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxAuthor.Location = new System.Drawing.Point(3, 47);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.PlaceholderText = "Yazar Adı";
            this.tbxAuthor.Size = new System.Drawing.Size(275, 26);
            this.tbxAuthor.TabIndex = 8;
            this.tbxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxAuthor.TextChanged += new System.EventHandler(this.tbxAuthor_TextChanged);
            // 
            // tbxBookName
            // 
            this.tbxBookName.BackColor = System.Drawing.Color.Tan;
            this.tbxBookName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxBookName.Location = new System.Drawing.Point(3, 6);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.PlaceholderText = "Kitap Ad";
            this.tbxBookName.Size = new System.Drawing.Size(275, 26);
            this.tbxBookName.TabIndex = 6;
            this.tbxBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // rbtnQuery
            // 
            this.rbtnQuery.BackColor = System.Drawing.Color.Tan;
            this.rbtnQuery.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnQuery.Checked = true;
            this.rbtnQuery.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnQuery.Location = new System.Drawing.Point(3, 46);
            this.rbtnQuery.Name = "rbtnQuery";
            this.rbtnQuery.Size = new System.Drawing.Size(21, 266);
            this.rbtnQuery.TabIndex = 0;
            this.rbtnQuery.TabStop = true;
            this.rbtnQuery.UseVisualStyleBackColor = false;
            this.rbtnQuery.CheckedChanged += new System.EventHandler(this.rbtnQuery_CheckedChanged);
            // 
            // btnClearSearchArea
            // 
            this.btnClearSearchArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearSearchArea.BackColor = System.Drawing.Color.Transparent;
            this.btnClearSearchArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearSearchArea.BackgroundImage")));
            this.btnClearSearchArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearSearchArea.FlatAppearance.BorderSize = 0;
            this.btnClearSearchArea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearSearchArea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearSearchArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearchArea.Location = new System.Drawing.Point(140, 368);
            this.btnClearSearchArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSearchArea.Name = "btnClearSearchArea";
            this.btnClearSearchArea.Size = new System.Drawing.Size(44, 54);
            this.btnClearSearchArea.TabIndex = 5;
            this.btnClearSearchArea.UseVisualStyleBackColor = false;
            this.btnClearSearchArea.Click += new System.EventHandler(this.btnClearSearchArea_Click);
            this.btnClearSearchArea.MouseLeave += new System.EventHandler(this.btnClearSearchArea_MouseLeave);
            this.btnClearSearchArea.MouseHover += new System.EventHandler(this.btnClearSearchArea_MouseHover);
            // 
            // pnlSearchArea
            // 
            this.pnlSearchArea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlSearchArea.BackColor = System.Drawing.Color.Wheat;
            this.pnlSearchArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchArea.Controls.Add(this.btnClearSearchArea);
            this.pnlSearchArea.Controls.Add(this.labelSearch);
            this.pnlSearchArea.Controls.Add(this.pnlIsbn);
            this.pnlSearchArea.Controls.Add(this.rbtnIsbn);
            this.pnlSearchArea.Controls.Add(this.rbtnQuery);
            this.pnlSearchArea.Controls.Add(this.pnlQuery);
            this.pnlSearchArea.Location = new System.Drawing.Point(1179, 113);
            this.pnlSearchArea.Name = "pnlSearchArea";
            this.pnlSearchArea.Size = new System.Drawing.Size(315, 434);
            this.pnlSearchArea.TabIndex = 5;
            // 
            // pnlIsbn
            // 
            this.pnlIsbn.BackColor = System.Drawing.Color.Tan;
            this.pnlIsbn.Controls.Add(this.tbxIsbn);
            this.pnlIsbn.Location = new System.Drawing.Point(29, 322);
            this.pnlIsbn.Name = "pnlIsbn";
            this.pnlIsbn.Size = new System.Drawing.Size(281, 39);
            this.pnlIsbn.TabIndex = 3;
            this.pnlIsbn.TabStop = true;
            // 
            // pnlQuery
            // 
            this.pnlQuery.BackColor = System.Drawing.Color.Tan;
            this.pnlQuery.Controls.Add(this.tbxPublisher);
            this.pnlQuery.Controls.Add(this.tbxBookName);
            this.pnlQuery.Controls.Add(this.tbxAuthor);
            this.pnlQuery.Controls.Add(this.pnlNativeStatue);
            this.pnlQuery.Controls.Add(this.pnlReadStatue);
            this.pnlQuery.Controls.Add(this.pnlHasNote);
            this.pnlQuery.Location = new System.Drawing.Point(29, 46);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(281, 266);
            this.pnlQuery.TabIndex = 1;
            this.pnlQuery.TabStop = true;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStatistics.BackgroundImage")));
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Location = new System.Drawing.Point(1029, 577);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(75, 55);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            this.btnStatistics.MouseLeave += new System.EventHandler(this.btnStatistics_MouseLeave);
            this.btnStatistics.MouseHover += new System.EventHandler(this.btnStatistics_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1545, 680);
            this.ControlBox = false;
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.pnlSearchArea);
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
            this.MaximumSize = new System.Drawing.Size(1545, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1206, 680);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).EndInit();
            this.pnlNativeStatue.ResumeLayout(false);
            this.pnlNativeStatue.PerformLayout();
            this.pnlHasNote.ResumeLayout(false);
            this.pnlHasNote.PerformLayout();
            this.pnlReadStatue.ResumeLayout(false);
            this.pnlReadStatue.PerformLayout();
            this.pnlSearchArea.ResumeLayout(false);
            this.pnlSearchArea.PerformLayout();
            this.pnlIsbn.ResumeLayout(false);
            this.pnlIsbn.PerformLayout();
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
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
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.RadioButton rbtnQuery;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.RadioButton rbtnIsbn;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Panel pnlNativeStatue;
        private System.Windows.Forms.RadioButton rbtnNative;
        private System.Windows.Forms.RadioButton rbtnNotNative;
        private System.Windows.Forms.Panel pnlHasNote;
        private System.Windows.Forms.RadioButton rbtnHasNote;
        private System.Windows.Forms.RadioButton rbtnHasNoNote;
        private System.Windows.Forms.Panel pnlReadStatue;
        private System.Windows.Forms.RadioButton rbtnReaded;
        private System.Windows.Forms.RadioButton rbtNotReaded;
        private System.Windows.Forms.Button btnClearSearchArea;
        private System.Windows.Forms.Panel pnlSearchArea;
        private System.Windows.Forms.Panel pnlIsbn;
        private System.Windows.Forms.Panel pnlQuery;
        private System.Windows.Forms.Button btnStatistics;
    }
}