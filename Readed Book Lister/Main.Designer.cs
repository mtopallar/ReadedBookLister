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
            this.labelSearch = new System.Windows.Forms.Label();
            this.rbtnNativeStatue = new System.Windows.Forms.RadioButton();
            this.rbtnNote = new System.Windows.Forms.RadioButton();
            this.pnlNativeStatue = new System.Windows.Forms.Panel();
            this.rbtnNative = new System.Windows.Forms.RadioButton();
            this.rbtnNotNative = new System.Windows.Forms.RadioButton();
            this.pnlHasNote = new System.Windows.Forms.Panel();
            this.rbtnHasNote = new System.Windows.Forms.RadioButton();
            this.rbtnHasNoNote = new System.Windows.Forms.RadioButton();
            this.rbtnReadStatue = new System.Windows.Forms.RadioButton();
            this.pnlReadStatue = new System.Windows.Forms.Panel();
            this.rbtnReaded = new System.Windows.Forms.RadioButton();
            this.rbtNotReaded = new System.Windows.Forms.RadioButton();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.rbtnIsbn = new System.Windows.Forms.RadioButton();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.rbtnPublisher = new System.Windows.Forms.RadioButton();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.rbtnAuthor = new System.Windows.Forms.RadioButton();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.rbtnBookName = new System.Windows.Forms.RadioButton();
            this.pnlSearchButtons = new System.Windows.Forms.Panel();
            this.btnStartSearch = new System.Windows.Forms.Button();
            this.btnClearSearchArea = new System.Windows.Forms.Button();
            this.pnlSearchArea = new System.Windows.Forms.Panel();
            this.pnlIsbn = new System.Windows.Forms.Panel();
            this.pnlPublisher = new System.Windows.Forms.Panel();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.pnlBookName = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).BeginInit();
            this.pnlNativeStatue.SuspendLayout();
            this.pnlHasNote.SuspendLayout();
            this.pnlReadStatue.SuspendLayout();
            this.pnlSearchButtons.SuspendLayout();
            this.pnlSearchArea.SuspendLayout();
            this.pnlIsbn.SuspendLayout();
            this.pnlPublisher.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            this.pnlBookName.SuspendLayout();
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
            this.btnBookAdd.Location = new System.Drawing.Point(1099, 585);
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
            this.dgvUserBookList.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.dgvUserBookList.Location = new System.Drawing.Point(52, 113);
            this.dgvUserBookList.Name = "dgvUserBookList";
            this.dgvUserBookList.ReadOnly = true;
            this.dgvUserBookList.RowHeadersVisible = false;
            this.dgvUserBookList.RowTemplate.Height = 25;
            this.dgvUserBookList.Size = new System.Drawing.Size(1122, 434);
            this.dgvUserBookList.TabIndex = 1;
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
            this.btnBookSearch.Location = new System.Drawing.Point(1033, 585);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(75, 55);
            this.btnBookSearch.TabIndex = 19;
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
            this.btnProfileOperations.Location = new System.Drawing.Point(963, 585);
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
            // rbtnNativeStatue
            // 
            this.rbtnNativeStatue.AutoSize = true;
            this.rbtnNativeStatue.Location = new System.Drawing.Point(10, 337);
            this.rbtnNativeStatue.Name = "rbtnNativeStatue";
            this.rbtnNativeStatue.Size = new System.Drawing.Size(14, 13);
            this.rbtnNativeStatue.TabIndex = 30;
            this.rbtnNativeStatue.UseVisualStyleBackColor = true;
            // 
            // rbtnNote
            // 
            this.rbtnNote.AutoSize = true;
            this.rbtnNote.Location = new System.Drawing.Point(10, 291);
            this.rbtnNote.Name = "rbtnNote";
            this.rbtnNote.Size = new System.Drawing.Size(14, 13);
            this.rbtnNote.TabIndex = 28;
            this.rbtnNote.UseVisualStyleBackColor = true;
            // 
            // pnlNativeStatue
            // 
            this.pnlNativeStatue.BackColor = System.Drawing.Color.Transparent;
            this.pnlNativeStatue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNativeStatue.Controls.Add(this.rbtnNative);
            this.pnlNativeStatue.Controls.Add(this.rbtnNotNative);
            this.pnlNativeStatue.Location = new System.Drawing.Point(29, 328);
            this.pnlNativeStatue.Name = "pnlNativeStatue";
            this.pnlNativeStatue.Size = new System.Drawing.Size(281, 33);
            this.pnlNativeStatue.TabIndex = 29;
            // 
            // rbtnNative
            // 
            this.rbtnNative.AutoSize = true;
            this.rbtnNative.Location = new System.Drawing.Point(22, 6);
            this.rbtnNative.Name = "rbtnNative";
            this.rbtnNative.Size = new System.Drawing.Size(101, 22);
            this.rbtnNative.TabIndex = 27;
            this.rbtnNative.Text = "Yerli Kitaplar";
            this.rbtnNative.UseVisualStyleBackColor = true;
            // 
            // rbtnNotNative
            // 
            this.rbtnNotNative.AutoSize = true;
            this.rbtnNotNative.Location = new System.Drawing.Point(140, 6);
            this.rbtnNotNative.Name = "rbtnNotNative";
            this.rbtnNotNative.Size = new System.Drawing.Size(117, 22);
            this.rbtnNotNative.TabIndex = 28;
            this.rbtnNotNative.Text = "Yabancı Kitaplar";
            this.rbtnNotNative.UseVisualStyleBackColor = true;
            // 
            // pnlHasNote
            // 
            this.pnlHasNote.BackColor = System.Drawing.Color.Transparent;
            this.pnlHasNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHasNote.Controls.Add(this.rbtnHasNote);
            this.pnlHasNote.Controls.Add(this.rbtnHasNoNote);
            this.pnlHasNote.Location = new System.Drawing.Point(29, 282);
            this.pnlHasNote.Name = "pnlHasNote";
            this.pnlHasNote.Size = new System.Drawing.Size(280, 33);
            this.pnlHasNote.TabIndex = 27;
            // 
            // rbtnHasNote
            // 
            this.rbtnHasNote.AutoSize = true;
            this.rbtnHasNote.Location = new System.Drawing.Point(22, 6);
            this.rbtnHasNote.Name = "rbtnHasNote";
            this.rbtnHasNote.Size = new System.Drawing.Size(101, 22);
            this.rbtnHasNote.TabIndex = 27;
            this.rbtnHasNote.Text = "Not İçerenler";
            this.rbtnHasNote.UseVisualStyleBackColor = true;
            // 
            // rbtnHasNoNote
            // 
            this.rbtnHasNoNote.AutoSize = true;
            this.rbtnHasNoNote.Location = new System.Drawing.Point(140, 6);
            this.rbtnHasNoNote.Name = "rbtnHasNoNote";
            this.rbtnHasNoNote.Size = new System.Drawing.Size(125, 22);
            this.rbtnHasNoNote.TabIndex = 28;
            this.rbtnHasNoNote.Text = "Not İçermeyenler";
            this.rbtnHasNoNote.UseVisualStyleBackColor = true;
            // 
            // rbtnReadStatue
            // 
            this.rbtnReadStatue.AutoSize = true;
            this.rbtnReadStatue.Location = new System.Drawing.Point(10, 243);
            this.rbtnReadStatue.Name = "rbtnReadStatue";
            this.rbtnReadStatue.Size = new System.Drawing.Size(14, 13);
            this.rbtnReadStatue.TabIndex = 26;
            this.rbtnReadStatue.UseVisualStyleBackColor = true;
            // 
            // pnlReadStatue
            // 
            this.pnlReadStatue.BackColor = System.Drawing.Color.Transparent;
            this.pnlReadStatue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReadStatue.Controls.Add(this.rbtnReaded);
            this.pnlReadStatue.Controls.Add(this.rbtNotReaded);
            this.pnlReadStatue.Location = new System.Drawing.Point(29, 234);
            this.pnlReadStatue.Name = "pnlReadStatue";
            this.pnlReadStatue.Size = new System.Drawing.Size(281, 33);
            this.pnlReadStatue.TabIndex = 25;
            // 
            // rbtnReaded
            // 
            this.rbtnReaded.AutoSize = true;
            this.rbtnReaded.Location = new System.Drawing.Point(22, 6);
            this.rbtnReaded.Name = "rbtnReaded";
            this.rbtnReaded.Size = new System.Drawing.Size(98, 22);
            this.rbtnReaded.TabIndex = 27;
            this.rbtnReaded.Text = "Okuduklarım";
            this.rbtnReaded.UseVisualStyleBackColor = true;
            // 
            // rbtNotReaded
            // 
            this.rbtNotReaded.AutoSize = true;
            this.rbtNotReaded.Location = new System.Drawing.Point(140, 6);
            this.rbtNotReaded.Name = "rbtNotReaded";
            this.rbtNotReaded.Size = new System.Drawing.Size(111, 22);
            this.rbtNotReaded.TabIndex = 28;
            this.rbtNotReaded.Text = "Okumadıklarım";
            this.rbtNotReaded.UseVisualStyleBackColor = true;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.BackColor = System.Drawing.Color.Wheat;
            this.tbxIsbn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxIsbn.Location = new System.Drawing.Point(3, 7);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.PlaceholderText = "ISBN No";
            this.tbxIsbn.Size = new System.Drawing.Size(278, 25);
            this.tbxIsbn.TabIndex = 24;
            this.tbxIsbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnIsbn
            // 
            this.rbtnIsbn.AutoSize = true;
            this.rbtnIsbn.Location = new System.Drawing.Point(10, 199);
            this.rbtnIsbn.Name = "rbtnIsbn";
            this.rbtnIsbn.Size = new System.Drawing.Size(14, 13);
            this.rbtnIsbn.TabIndex = 23;
            this.rbtnIsbn.UseVisualStyleBackColor = true;
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.BackColor = System.Drawing.Color.Wheat;
            this.tbxPublisher.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxPublisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxPublisher.Location = new System.Drawing.Point(3, 6);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.PlaceholderText = "Yayınevi Adı";
            this.tbxPublisher.Size = new System.Drawing.Size(275, 25);
            this.tbxPublisher.TabIndex = 22;
            this.tbxPublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnPublisher
            // 
            this.rbtnPublisher.AutoSize = true;
            this.rbtnPublisher.Location = new System.Drawing.Point(10, 153);
            this.rbtnPublisher.Name = "rbtnPublisher";
            this.rbtnPublisher.Size = new System.Drawing.Size(14, 13);
            this.rbtnPublisher.TabIndex = 21;
            this.rbtnPublisher.UseVisualStyleBackColor = true;
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.BackColor = System.Drawing.Color.Wheat;
            this.tbxAuthor.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxAuthor.Location = new System.Drawing.Point(3, 6);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.PlaceholderText = "Yazar Adı";
            this.tbxAuthor.Size = new System.Drawing.Size(275, 25);
            this.tbxAuthor.TabIndex = 20;
            this.tbxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbtnAuthor
            // 
            this.rbtnAuthor.AutoSize = true;
            this.rbtnAuthor.Location = new System.Drawing.Point(10, 107);
            this.rbtnAuthor.Name = "rbtnAuthor";
            this.rbtnAuthor.Size = new System.Drawing.Size(14, 13);
            this.rbtnAuthor.TabIndex = 19;
            this.rbtnAuthor.UseVisualStyleBackColor = true;
            this.rbtnAuthor.CheckedChanged += new System.EventHandler(this.rbtnAuthor_CheckedChanged);
            // 
            // tbxBookName
            // 
            this.tbxBookName.BackColor = System.Drawing.Color.Wheat;
            this.tbxBookName.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbxBookName.Location = new System.Drawing.Point(3, 6);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.PlaceholderText = "Kitap Ad";
            this.tbxBookName.Size = new System.Drawing.Size(275, 25);
            this.tbxBookName.TabIndex = 18;
            this.tbxBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // rbtnBookName
            // 
            this.rbtnBookName.AutoSize = true;
            this.rbtnBookName.Checked = true;
            this.rbtnBookName.Location = new System.Drawing.Point(10, 59);
            this.rbtnBookName.Name = "rbtnBookName";
            this.rbtnBookName.Size = new System.Drawing.Size(14, 13);
            this.rbtnBookName.TabIndex = 0;
            this.rbtnBookName.TabStop = true;
            this.rbtnBookName.UseVisualStyleBackColor = true;
            this.rbtnBookName.CheckedChanged += new System.EventHandler(this.rbtnBookName_CheckedChanged);
            // 
            // pnlSearchButtons
            // 
            this.pnlSearchButtons.Controls.Add(this.btnStartSearch);
            this.pnlSearchButtons.Controls.Add(this.btnClearSearchArea);
            this.pnlSearchButtons.Location = new System.Drawing.Point(3, 367);
            this.pnlSearchButtons.Name = "pnlSearchButtons";
            this.pnlSearchButtons.Size = new System.Drawing.Size(309, 62);
            this.pnlSearchButtons.TabIndex = 24;
            // 
            // btnStartSearch
            // 
            this.btnStartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnStartSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartSearch.BackgroundImage")));
            this.btnStartSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartSearch.FlatAppearance.BorderSize = 0;
            this.btnStartSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStartSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartSearch.Location = new System.Drawing.Point(255, 5);
            this.btnStartSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStartSearch.Name = "btnStartSearch";
            this.btnStartSearch.Size = new System.Drawing.Size(48, 54);
            this.btnStartSearch.TabIndex = 22;
            this.btnStartSearch.UseVisualStyleBackColor = false;
            this.btnStartSearch.Click += new System.EventHandler(this.btnStartSearch_Click);
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
            this.btnClearSearchArea.Location = new System.Drawing.Point(200, 4);
            this.btnClearSearchArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSearchArea.Name = "btnClearSearchArea";
            this.btnClearSearchArea.Size = new System.Drawing.Size(50, 54);
            this.btnClearSearchArea.TabIndex = 23;
            this.btnClearSearchArea.UseVisualStyleBackColor = false;
            // 
            // pnlSearchArea
            // 
            this.pnlSearchArea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlSearchArea.BackColor = System.Drawing.Color.Wheat;
            this.pnlSearchArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchArea.Controls.Add(this.labelSearch);
            this.pnlSearchArea.Controls.Add(this.rbtnNativeStatue);
            this.pnlSearchArea.Controls.Add(this.pnlIsbn);
            this.pnlSearchArea.Controls.Add(this.rbtnNote);
            this.pnlSearchArea.Controls.Add(this.pnlSearchButtons);
            this.pnlSearchArea.Controls.Add(this.rbtnReadStatue);
            this.pnlSearchArea.Controls.Add(this.pnlPublisher);
            this.pnlSearchArea.Controls.Add(this.rbtnIsbn);
            this.pnlSearchArea.Controls.Add(this.pnlNativeStatue);
            this.pnlSearchArea.Controls.Add(this.rbtnPublisher);
            this.pnlSearchArea.Controls.Add(this.pnlAuthor);
            this.pnlSearchArea.Controls.Add(this.rbtnAuthor);
            this.pnlSearchArea.Controls.Add(this.pnlHasNote);
            this.pnlSearchArea.Controls.Add(this.rbtnBookName);
            this.pnlSearchArea.Controls.Add(this.pnlBookName);
            this.pnlSearchArea.Controls.Add(this.pnlReadStatue);
            this.pnlSearchArea.Location = new System.Drawing.Point(1179, 113);
            this.pnlSearchArea.Name = "pnlSearchArea";
            this.pnlSearchArea.Size = new System.Drawing.Size(315, 434);
            this.pnlSearchArea.TabIndex = 31;
            // 
            // pnlIsbn
            // 
            this.pnlIsbn.Controls.Add(this.tbxIsbn);
            this.pnlIsbn.Location = new System.Drawing.Point(29, 186);
            this.pnlIsbn.Name = "pnlIsbn";
            this.pnlIsbn.Size = new System.Drawing.Size(281, 39);
            this.pnlIsbn.TabIndex = 2;
            // 
            // pnlPublisher
            // 
            this.pnlPublisher.Controls.Add(this.tbxPublisher);
            this.pnlPublisher.Location = new System.Drawing.Point(29, 140);
            this.pnlPublisher.Name = "pnlPublisher";
            this.pnlPublisher.Size = new System.Drawing.Size(281, 38);
            this.pnlPublisher.TabIndex = 2;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Controls.Add(this.tbxAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(29, 94);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(281, 36);
            this.pnlAuthor.TabIndex = 2;
            // 
            // pnlBookName
            // 
            this.pnlBookName.Controls.Add(this.tbxBookName);
            this.pnlBookName.Location = new System.Drawing.Point(29, 46);
            this.pnlBookName.Name = "pnlBookName";
            this.pnlBookName.Size = new System.Drawing.Size(281, 38);
            this.pnlBookName.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1545, 680);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserBookList)).EndInit();
            this.pnlNativeStatue.ResumeLayout(false);
            this.pnlNativeStatue.PerformLayout();
            this.pnlHasNote.ResumeLayout(false);
            this.pnlHasNote.PerformLayout();
            this.pnlReadStatue.ResumeLayout(false);
            this.pnlReadStatue.PerformLayout();
            this.pnlSearchButtons.ResumeLayout(false);
            this.pnlSearchArea.ResumeLayout(false);
            this.pnlSearchArea.PerformLayout();
            this.pnlIsbn.ResumeLayout(false);
            this.pnlIsbn.PerformLayout();
            this.pnlPublisher.ResumeLayout(false);
            this.pnlPublisher.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            this.pnlAuthor.PerformLayout();
            this.pnlBookName.ResumeLayout(false);
            this.pnlBookName.PerformLayout();
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
        private System.Windows.Forms.RadioButton rbtnBookName;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.RadioButton rbtnIsbn;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.RadioButton rbtnPublisher;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.RadioButton rbtnAuthor;
        private System.Windows.Forms.RadioButton rbtnNativeStatue;
        private System.Windows.Forms.RadioButton rbtnNote;
        private System.Windows.Forms.Panel pnlNativeStatue;
        private System.Windows.Forms.RadioButton rbtnNative;
        private System.Windows.Forms.RadioButton rbtnNotNative;
        private System.Windows.Forms.Panel pnlHasNote;
        private System.Windows.Forms.RadioButton rbtnHasNote;
        private System.Windows.Forms.RadioButton rbtnHasNoNote;
        private System.Windows.Forms.RadioButton rbtnReadStatue;
        private System.Windows.Forms.Panel pnlReadStatue;
        private System.Windows.Forms.RadioButton rbtnReaded;
        private System.Windows.Forms.RadioButton rbtNotReaded;
        private System.Windows.Forms.Button btnStartSearch;
        private System.Windows.Forms.Button btnClearSearchArea;
        private System.Windows.Forms.Panel pnlSearchButtons;
        private System.Windows.Forms.Panel pnlSearchArea;
        private System.Windows.Forms.Panel pnlIsbn;
        private System.Windows.Forms.Panel pnlPublisher;
        private System.Windows.Forms.Panel pnlAuthor;
        private System.Windows.Forms.Panel pnlBookName;
    }
}