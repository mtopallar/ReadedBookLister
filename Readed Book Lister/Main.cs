using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Entities;
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
        public Main(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            //GetUsersBook(_loggedUser.Id);
            GetUsersBook(1);
            CreateDataGridViewColums();
            SetDataGridViewStyleByUsersBookList();
            FillDataGridView();
            DisableBookSearchButtonIfUserHasNoBook();
            LabelHeaderSet();
            SetFormToStartSize();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
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
            if (UsersBookList != null)
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
            if (UsersBookList != null)
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

            if (UsersBookList != null)
            {
                #region UserBookList Boş Değilse Dgv Style

                dgvUserBookList.RowTemplate.Height = 130;
                dgvUserBookList.RowsDefaultCellStyle.BackColor = Color.Wheat;
                dgvUserBookList.BackgroundColor = Color.Wheat;
                //dgvUserBookList.AlternatingRowsDefaultCellStyle.BackColor = Color.SandyBrown; stripe efekti için.
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.Wheat; // sütun isimlerinin rengi                
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.Wheat;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                //dgvUserBookList.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                // RowHeadersDefaultCellStyle denen kısım DataGridView da her satırın başında çıkan seçici okun olduğu kısım.                

                #endregion
            }
            else
            {
                #region UserBookList Boşsa Dgv Style 

                dgvUserBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUserBookList.BackgroundColor = Color.LightGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray; // sütun isimlerinin rengi
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
                //return;
            }

            //btnBookSearch.Enabled = true;
            //btnBookSearch.BackgroundImage = Image.FromFile(@".\assets\searchbook.png");
        }

        private void LabelHeaderSet()
        {
            lblHeader.Text = _loggedUser.NickName + " kitaplığı";
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
                    dgvUserBookList.CurrentRow.Cells[10].Value = Image.FromFile(@".\images\default.png"); // diğer taraftan silebilmek için
                    BookUpdate bookUpdateForm = new BookUpdate(selectedUserBook, _loggedUser);
                    Hide();
                    bookUpdateForm.ShowDialog();
                    Close();

                }
                else if (e.ColumnIndex == 12 && e.RowIndex != -1)
                {
                    MessageBox.Show(selectedUserBook.BookName + " sil");
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
            if (!searcAreaExpand)
            {
                Width = MaximumSize.Width;
                searcAreaExpand = true;
                pnlSearchArea.Enabled = true;
                pnlSearchArea.Visible = true;
                //DisableOtherSelections(pnlBookName); //sadece ilk selection aktif olsun.
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

        private void rbtnBookName_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbtnBookName.Checked)
            //{
            //    ClearSearcArea();
            //    DisableOtherSelections(pnlBookName);
            //}
        }

        private void rbtnAuthor_CheckedChanged(object sender, EventArgs e)
        {
            //if (rbtnAuthor.Checked)
            //{
            //    ClearSearcArea();
            //    DisableOtherSelections(pnlAuthor);
            //}
        }

        //Diğer Radiolar için devam et.

        private void DisableOtherSelections(Panel panelShouldActive)
        {
            List<Panel> panelList = new() { pnlBookName, pnlAuthor, pnlPublisher, pnlIsbn, pnlReadStatue, pnlHasNote, pnlNativeStatue };

            foreach (var panel in panelList)
            {
                if (panel != panelShouldActive)
                {
                    if (panel == pnlReadStatue || panel == pnlHasNote || panel == pnlNativeStatue)
                    {
                        panel.BackColor = Color.BurlyWood;
                    }

                    panel.Enabled = false;

                    foreach (Control textBox in panel.Controls.Cast<Control>())
                    {
                        if (textBox is TextBox)
                        {
                            textBox.BackColor = Color.BurlyWood;
                            textBox.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void ClearSearcArea()
        {
            List<Panel> panelList = new() { pnlBookName, pnlAuthor, pnlPublisher, pnlIsbn, pnlReadStatue, pnlHasNote, pnlNativeStatue };

            foreach (var panel in panelList)
            {
                panel.BackColor = Color.Wheat;
                panel.Enabled = true;

                foreach (Control textBox in panel.Controls.Cast<Control>())
                {
                    if (textBox is TextBox)
                    {
                        textBox.BackColor = Color.Wheat;
                        textBox.Text = string.Empty;
                    }
                }
            }
        }

        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            UsersBookList = UserBookOperations.GetListByQuery(_loggedUser.Id, tbxBookName, tbxAuthor,tbxPublisher,rbtnReaded,rbtNotReaded,rbtnHasNote,rbtnHasNoNote,rbtnNative,rbtnNotNative);

            dgvUserBookList.Rows.Clear();
            FillDataGridView();
            dgvUserBookList.Refresh();

        }

        private void tbxBookName_TextChanged(object sender, EventArgs e)
        {
            UsersBookList = UserBookOperations.GetListByQuery(_loggedUser.Id, tbxBookName, tbxAuthor, tbxPublisher, rbtnReaded, rbtNotReaded, rbtnHasNote, rbtnHasNoNote, rbtnNative, rbtnNotNative);

            dgvUserBookList.Rows.Clear();
            FillDataGridView();
            dgvUserBookList.Refresh();
        }
    }
}
