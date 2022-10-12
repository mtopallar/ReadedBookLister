using Readed_Book_Lister.App_Logics;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Dtos;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Helpers;
using Readed_Book_Lister.Methods.App_Methods;
using Readed_Book_Lister.Methods.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Readed_Book_Lister
{
    public partial class Main : Form
    {
        private readonly User _loggedUser;
        private List<UserBook>? UsersBookList;
        bool searcAreaExpand = false;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        public Main(User loggedUser)
        {
            InitializeComponent();
            DisableAcceptOrCancelButtonFrames.DisableUnvantedFrames(btnClose);
            _loggedUser = loggedUser;
            GetUsersBook(_loggedUser.Id);            
            CreateDataGridViewColums();
            SetDataGridViewStyleByUsersBookList();
            FillDataGridView();
            DisableBookSearchButtonIfUserHasNoBook();
            LabelHeaderSet();
            SetFormToStartSize();
            EnableSelectedPanel(pnlQuery);
            EnabledPanelRadioButtonStatue(rbtnQuery);
            
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd(_loggedUser);
            Hide();
            bookAdd.ShowDialog();
            Close();
        }

        private void GetUsersBook(int userId)
        {
            UsersBookList = UserBookOperations.GetAllByUserId(userId);
        }

        private void CreateDataGridViewColums()
        {
            if (UsersBookList != null && UsersBookList.Count > 0)
            {
                // 1) Önce dgv e eklenecek kolon tiplerini belirle.
                DataGridViewTextBoxColumn dgvPlaceColumn = new DataGridViewTextBoxColumn();
                dgvPlaceColumn.HeaderText = "Sıra";
                dgvPlaceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewTextBoxColumn dgvBookNameColumn = new DataGridViewTextBoxColumn();
                dgvBookNameColumn.HeaderText = "Kitap adı";
                dgvBookNameColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBookNameColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewTextBoxColumn dgvAuthorNameColumn = new DataGridViewTextBoxColumn();
                dgvAuthorNameColumn.HeaderText = "Yazar adı";
                dgvAuthorNameColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvAuthorNameColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewTextBoxColumn dgvIsbnColumn = new DataGridViewTextBoxColumn();
                dgvIsbnColumn.HeaderText = "Isbn No";
                dgvIsbnColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvIsbnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewTextBoxColumn dgvPublisherColumn = new DataGridViewTextBoxColumn();
                dgvPublisherColumn.HeaderText = "Yayınevi";
                dgvPublisherColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvPublisherColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewTextBoxColumn dgvReadedColumn = new DataGridViewTextBoxColumn();
                dgvReadedColumn.HeaderText = "Okunma";
                dgvReadedColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewTextBoxColumn dgvNativeColumn = new DataGridViewTextBoxColumn();
                dgvNativeColumn.HeaderText = "Yerli";
                dgvNativeColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewTextBoxColumn dgvReadMonthColumn = new DataGridViewTextBoxColumn();
                dgvReadMonthColumn.HeaderText = "Okunma Ayı";
                dgvReadMonthColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReadMonthColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewTextBoxColumn dgvReadYearColumn = new DataGridViewTextBoxColumn();
                dgvReadYearColumn.HeaderText = "Okunma Yılı";
                dgvReadYearColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReadYearColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewTextBoxColumn dgvNoteColumn = new DataGridViewTextBoxColumn();
                dgvNoteColumn.HeaderText = "Not";
                dgvNoteColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvNoteColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
                dgvImageColumn.HeaderText = "Resim";
                dgvImageColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                DataGridViewImageColumn dgvUpdateColumn = new DataGridViewImageColumn();
                dgvUpdateColumn.HeaderText = "Güncelle";
                dgvUpdateColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUpdateColumn.ImageLayout = DataGridViewImageCellLayout.Normal;


                DataGridViewImageColumn dgvDeleteColumn = new DataGridViewImageColumn();
                dgvDeleteColumn.HeaderText = "Sil";
                dgvDeleteColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Normal; // normal yaptım.


                // 2) Sonra o kolonları dgv  e ekle
                dgvUserBookList.Columns.Add(dgvPlaceColumn);
                dgvUserBookList.Columns.Add(dgvBookNameColumn);
                dgvUserBookList.Columns.Add(dgvAuthorNameColumn);
                dgvUserBookList.Columns.Add(dgvIsbnColumn);
                dgvUserBookList.Columns.Add(dgvPublisherColumn);
                dgvUserBookList.Columns.Add(dgvReadedColumn);
                dgvUserBookList.Columns.Add(dgvNativeColumn);
                dgvUserBookList.Columns.Add(dgvReadMonthColumn);
                dgvUserBookList.Columns.Add(dgvReadYearColumn);
                dgvUserBookList.Columns.Add(dgvNoteColumn);
                dgvUserBookList.Columns.Add(dgvImageColumn);
                dgvUserBookList.Columns.Add(dgvUpdateColumn);
                dgvUserBookList.Columns.Add(dgvDeleteColumn);

            }
            else if (UsersBookList != null && UsersBookList.Count == 0)
            {
                DataGridViewTextBoxColumn dgvNoFilteredData = new DataGridViewTextBoxColumn();
                dgvNoFilteredData.HeaderText = "Veri Yok";
                dgvNoFilteredData.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUserBookList.Columns.Add(dgvNoFilteredData);
            }
            else
            {
                DataGridViewTextBoxColumn dgvNoData = new DataGridViewTextBoxColumn();
                dgvNoData.HeaderText = "Veri Yok";
                dgvNoData.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUserBookList.Columns.Add(dgvNoData);
            }
        }
        private void FillDataGridView()
        {
            if (UsersBookList != null && UsersBookList.Count > 0)
            {
                for (int i = 0; i < UsersBookList.Count; i++)
                {
                    // 3) sonra ilgili verileri sırasıyla içeren satırları ekle. data sırası eşit olmalı colon sırası.                
                    dgvUserBookList.Rows.Add(
                        i + 1,
                        UsersBookList[i].BookName,
                        UsersBookList[i].AuthorName,
                        UsersBookList[i].Isbn,
                        UsersBookList[i].Publisher,
                        UsersBookList[i].Readed ? "Okundu" : "Okunmadı",
                        UsersBookList[i].Native ? "Yerli" : "Yabancı",
                        UsersBookList[i].ReadMonth == null ? "-" : UsersBookList[i].ReadMonth,
                        UsersBookList[i].ReadYear == null ? "-" : UsersBookList[i].ReadYear,
                        UsersBookList[i].Note == "" ? "-" : UsersBookList[i].Note,
                        Image.FromFile(UsersBookList[i].Image),
                        Image.FromFile(@".\assets\update_book_normal.png"),
                        Image.FromFile(@".\assets\delete_book_normal.png")
                        );
                }
            }
            else if (UsersBookList != null && UsersBookList.Count == 0)
            {
                dgvUserBookList.Rows.Add(Messages.NoDataByFilter);
            }
            else
            {
                dgvUserBookList.Rows.Add(Messages.DataGridViewMessagesUserHasNoBook);
            }
        }

        private void SetDataGridViewStyleByUsersBookList()
        {
            // stilleri ister kolon kısmında yaz ister satır farketmiyor. Ancak dgv datası dolmadan önce stilleri çağırmalısın.
            dgvUserBookList.ShowCellToolTips = false;
            // her hücre için tooltip ayarlamak için CellToolTipTextNeeded'e bak ancak performans uyarısı var.
            dgvUserBookList.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUserBookList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUserBookList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUserBookList.EnableHeadersVisualStyles = false;

            if (UsersBookList != null && UsersBookList.Count > 0)
            {
                #region UserBookList Boş Değilse Dgv Style

                dgvUserBookList.RowTemplate.Height = 130;
                dgvUserBookList.RowsDefaultCellStyle.BackColor = Color.Wheat;
                dgvUserBookList.BackgroundColor = Color.Wheat;
                //dgvUserBookList.AlternatingRowsDefaultCellStyle.BackColor = Color.SandyBrown; // stripe efekti için.
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.Wheat; // sütun isimlerinin rengi                
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.Wheat;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                //dgvUserBookList.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                // RowHeadersDefaultCellStyle denen kısım DataGridView da her satırın başında çıkan seçici okun olduğu kısım.
                dgvUserBookList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None; //resimlerin boyuna göre hücre çok genişlemesin diye.
                dgvUserBookList.Enabled = true;

                #endregion
            }
            else if (UsersBookList != null && UsersBookList.Count == 0)
            {
                dgvUserBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUserBookList.BackgroundColor = Color.LightGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.MistyRose;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Red;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray; // sütun isimlerinin rengi
                dgvUserBookList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // resimli datadan sonra flitre vs geldiğinde satır genişliği resimli verinin genişliğinde kalmasın diye.
                dgvUserBookList.Enabled = false;
            }
            else
            {
                #region UserBookList Boşsa Dgv Style 

                dgvUserBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUserBookList.BackgroundColor = Color.LightGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray; // sütun isimlerinin rengi
                dgvUserBookList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvUserBookList.Enabled = false;

                #endregion
            }
        }

        private void DisableBookSearchButtonIfUserHasNoBook()
        {
            if (UsersBookList == null || UsersBookList.Count == 0)
            {
                btnBookSearch.Enabled = false;
                btnBookSearch.BackgroundImage = Image.FromFile(@".\assets\searchbook_disabled.png");                
            }                       
        }

        private void LabelHeaderSet()
        {
            lblHeader.Text = _loggedUser.NickName + " Kitaplığı";
            LocateLabelToCentre();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Hovers        

        private void btnBookAdd_MouseHover(object sender, EventArgs e)
        {
            btnBookAdd.BackgroundImage = Image.FromFile(@".\assets\newbook_hover.png");
            toolTipMain.SetToolTip(btnBookAdd, "Yeni Kitap Ekle");
        }

        private void btnBookAdd_MouseLeave(object sender, EventArgs e)
        {
            btnBookAdd.BackgroundImage = Image.FromFile(@".\assets\newbook.png");
            toolTipMain.Hide(btnBookAdd);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close_hover.png");
            toolTipClose.SetToolTip(btnClose, "Kapat");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close.png");
            toolTipClose.Hide(btnClose);
        }

        private void btnBookSearch_MouseHover(object sender, EventArgs e)
        {
            btnBookSearch.BackgroundImage = Image.FromFile(@".\assets\searchbook_hover.png");
            toolTipMain.SetToolTip(btnBookSearch, "Kitap Ara");
        }

        private void btnBookSearch_MouseLeave(object sender, EventArgs e)
        {
            btnBookSearch.BackgroundImage = Image.FromFile(@".\assets\searchbook.png");
            toolTipMain.Hide(btnBookSearch);
        }

        private void btnProfileOperations_MouseHover(object sender, EventArgs e)
        {
            btnProfileOperations.BackgroundImage = Image.FromFile(@".\assets\profile_hover.png");
            toolTipMain.SetToolTip(btnProfileOperations, "Profil İşlemleri");
        }

        private void btnProfileOperations_MouseLeave(object sender, EventArgs e)
        {
            btnProfileOperations.BackgroundImage = Image.FromFile(@".\assets\profile.png");
            toolTipMain.Hide(btnProfileOperations);
        }

        #endregion

        private void dgvUserBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserBookList.RowCount > 0)
            {
                UserBook selectedUserBook = UsersBookList[Convert.ToInt32(dgvUserBookList.CurrentRow.Cells[0].Value) - 1];
                
                if (e.ColumnIndex == 11 && e.RowIndex != -1)
                {
                    dgvUserBookList.CurrentRow.Cells[10].Value = null;                    
                    BookUpdate bookUpdateForm = new BookUpdate(selectedUserBook, _loggedUser);
                    Hide();
                    bookUpdateForm.ShowDialog();
                    Close();

                }
                else if (e.ColumnIndex == 12 && e.RowIndex != -1)
                {
                    DialogResult dialogResult = MessageBox.Show(Messages.AreYouSureToDeleteUserBook, "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {                        
                        if (UserBookOperations.Delete(selectedUserBook))
                        {
                            MessageBox.Show(Messages.DeleteUserBookSuccessful);                            
                            dgvUserBookList.CurrentRow.Cells[10].Value = Image.FromFile(@".\images\default.png");
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                            ImageOperations.DeleteOldImageIfNotDefault(selectedUserBook.Image);
                            GetUsersBook(_loggedUser.Id);
                            RefreshDataGrivViewWithNewData();
                        }
                    }                    
                }
            }
        }

        private void LocateLabelToCentre()
        {
            lblHeader.Left = (Width / 2) - (lblHeader.Width / 2);
        }

        private void dgvUserBookList_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex != -1)
            {
                dgvUserBookList.Rows[e.RowIndex].Cells[11].Value = Image.FromFile(@"assets\update_book_normal.png");

            }
            else if (e.ColumnIndex == 12 && e.RowIndex != -1)
            {
                dgvUserBookList.Rows[e.RowIndex].Cells[12].Value = Image.FromFile(@"assets\delete_book_normal.png");
            }
        }

        private void dgvUserBookList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex != -1)
            {
                dgvUserBookList.Rows[e.RowIndex].Cells[11].Value = Image.FromFile(@"assets\update_book_hover.png");

            }
            else if (e.ColumnIndex == 12 && e.RowIndex != -1)
            {
                dgvUserBookList.Rows[e.RowIndex].Cells[12].Value = Image.FromFile(@"assets\delete_book_hover.png");
            }
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            ClearSearchArea();
            if (!searcAreaExpand)
            {
                Width = MaximumSize.Width;
                searcAreaExpand = true;
                pnlSearchArea.Enabled = true;
                pnlSearchArea.Visible = true;
                dgvUserBookList.Left += 7;
                CenterToScreen();
            }
            else
            {
                pnlSearchArea.Enabled = false;
                pnlSearchArea.Visible = false;
                Width = MinimumSize.Width;
                dgvUserBookList.Left = (Width / 2) - (dgvUserBookList.Width / 2);
                searcAreaExpand = false;
                CenterToScreen();
            }
        }

        private void SetFormToStartSize()
        {
            pnlSearchArea.Enabled = false;
            pnlSearchArea.Visible = false;
            Size = MinimumSize;
            dgvUserBookList.Left = (Width / 2) - (dgvUserBookList.Width / 2);
        }


        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void tbxAuthor_TextChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void tbxPublisher_TextChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void rbtnReaded_CheckedChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void rbtNotReaded_CheckedChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void rbtnHasNote_CheckedChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void rbtnHasNoNote_CheckedChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void rbtnNative_CheckedChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void rbtnNotNative_CheckedChanged(object sender, EventArgs e)
        {
            SendToSearchQuery();
        }

        private void tbxIsbn_TextChanged(object sender, EventArgs e)
        {
            UsersBookList = UserBookOperations.GetByUserIdAndIsbnNo(_loggedUser.Id, tbxIsbn);
            RefreshDataGrivViewWithNewData();
        }


        private void SendToSearchQuery()
        {
            UsersBookList = UserBookOperations.GetListByQuery(_loggedUser.Id, tbxBookName, tbxAuthor, tbxPublisher, rbtnReaded, rbtNotReaded, rbtnHasNote, rbtnHasNoNote, rbtnNative, rbtnNotNative);

            RefreshDataGrivViewWithNewData();
        }

        private void rbtnQuery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnQuery.Checked)
            {
                EnableSelectedPanel(pnlQuery);
                EnabledPanelRadioButtonStatue(rbtnQuery);
            }
        }

        private void rbtnIsbn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnIsbn.Checked)
            {
                EnableSelectedPanel(pnlIsbn);
                EnabledPanelRadioButtonStatue(rbtnIsbn);
            }
        }

        private void EnabledPanelRadioButtonStatue(RadioButton radiobuttonToEnable)
        {
            List<RadioButton> radioButtons = new() { rbtnQuery, rbtnIsbn };
            foreach (var item in radioButtons)
            {
                if (item == radiobuttonToEnable)
                {
                    item.BackColor = Color.Tan;
                    item.Checked = true;
                }
                else
                {
                    item.BackColor = Color.LightGray;
                    item.Checked = false;
                }
            }
        }

        private void EnableSelectedPanel(Panel panelToEnable)
        {
            List<Panel> formPanels = new() { pnlQuery, pnlIsbn };

            foreach (var panel in formPanels)
            {
                if (panel == panelToEnable)
                {
                    foreach (var control in panel.Controls)
                    {
                        if (control is TextBox)
                        {
                            TextBox textBox = (TextBox)control;
                            textBox.BackColor = Color.Tan;
                        }
                        if (control is Panel)
                        {
                            Panel enabledPanel = (Panel)control;
                            enabledPanel.BackColor = Color.Tan;

                            foreach (var panelRadios in enabledPanel.Controls)
                            {
                                if (panelRadios is RadioButton)
                                {
                                    RadioButton radioButton = (RadioButton)panelRadios;
                                    radioButton.BackColor = Color.Tan;
                                }
                            }
                        }
                    }
                    panel.BackColor = Color.Tan;
                    panel.Enabled = true;
                }
                else
                {
                    DisableUnselectedPanel(panel);
                }
            }
        }

        private void DisableUnselectedPanel(Panel panelToDisable)
        {
            ClearPanelControls(panelToDisable);

            foreach (var control in panelToDisable.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.BackColor = Color.LightGray;
                }
                if (control is Panel)
                {
                    Panel disabledPanel = (Panel)control;
                    disabledPanel.BackColor = Color.LightGray;

                    foreach (var panelRadios in disabledPanel.Controls)
                    {
                        if (panelRadios is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)panelRadios;
                            radioButton.BackColor = Color.LightGray;
                        }
                    }
                }
            }

            panelToDisable.BackColor = Color.LightGray;
            panelToDisable.Enabled = false;
        }

        private void ClearPanelControls(Panel panelToClearControls)
        {
            foreach (var control in panelToClearControls.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
                if (control is Panel)
                {
                    Panel disabledPanel = (Panel)control;

                    foreach (var panelRadios in disabledPanel.Controls)
                    {
                        if (panelRadios is RadioButton)
                        {
                            RadioButton radioButton = (RadioButton)panelRadios;
                            radioButton.Checked = false;
                        }
                    }
                }
            }
        }

        private void ClearSearchArea()
        {
            if (rbtnQuery.Checked)
            {
                ClearPanelControls(pnlQuery);
            }
            else
            {
                EnableSelectedPanel(pnlQuery);
                EnabledPanelRadioButtonStatue(rbtnQuery);
            }
            GetUsersBook(_loggedUser.Id);
            RefreshDataGrivViewWithNewData();
        }

        private void btnClearSearchArea_Click(object sender, EventArgs e)
        {
            ClearSearchArea();
        }

        private void RefreshDataGrivViewWithNewData()
        {
            dgvUserBookList.Rows.Clear();
            dgvUserBookList.Columns.Clear();
            CreateDataGridViewColums();
            SetDataGridViewStyleByUsersBookList();
            FillDataGridView();
            dgvUserBookList.Refresh();
        }

        private void tbxIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnStatistics_MouseHover(object sender, EventArgs e)
        {
            btnStatistics.BackgroundImage = Image.FromFile(@".\assets\statistics_hover.png");
            toolTipMain.SetToolTip(btnStatistics, "İstatistikler");
        }

        private void btnStatistics_MouseLeave(object sender, EventArgs e)
        {
            btnStatistics.BackgroundImage = Image.FromFile(@".\assets\statistics.png");
            toolTipMain.Hide(btnStatistics);
        }

        private void btnProfileOperations_Click(object sender, EventArgs e)
        {            
            dgvUserBookList.Rows.Clear();
            dgvUserBookList.Columns.Clear();            

            ProfileOperations profileOperations = new ProfileOperations(_loggedUser);
            Hide();
            profileOperations.ShowDialog();
            Close();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            dgvUserBookList.Rows.Clear();
            dgvUserBookList.Columns.Clear();

            Statistics statistics = new Statistics(_loggedUser);
            Hide();
            statistics.ShowDialog();
            Close();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
    }
}
