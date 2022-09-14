﻿using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Methods.App_Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister
{
    public partial class Main : Form
    {
        private readonly User _loggedUser;
        private List<UserBook>? UsersBookList;
        public Main(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            //GetUsersBook(_loggedUser.Id);
            GetUsersBook(1);
            CreateDataGridViewColums();
            SetDataGridViewStyleByUsersBookList();
            FillDataGridView();
            LabelHeaderSet();
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

                DataGridViewTextBoxColumn dgvIsbnColumn = new DataGridViewTextBoxColumn();
                dgvIsbnColumn.HeaderText = "Isbn No";
                dgvIsbnColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvIsbnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;

                DataGridViewTextBoxColumn dgvPublisherColumn = new DataGridViewTextBoxColumn();
                dgvPublisherColumn.HeaderText = "Yayınevi";
                dgvPublisherColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                dgvUpdateColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                DataGridViewImageColumn dgvDeleteColumn = new DataGridViewImageColumn();
                dgvDeleteColumn.HeaderText = "Sil";
                dgvDeleteColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDeleteColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                // 2) Sonra o kolonları dgv  e ekle
                dgvUserBookList.Columns.Add(dgvPlaceColumn);
                dgvUserBookList.Columns.Add(dgvBookNameColumn);
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
                        UsersBookList[i].Isbn,
                        UsersBookList[i].Publisher,
                        UsersBookList[i].Readed ? "Okundu" : "Okunmadı",
                        UsersBookList[i].Native ? "Yerli" : "Yabancı",
                        UsersBookList[i].ReadMonth == null ? "-" : UsersBookList[i].ReadMonth,
                        UsersBookList[i].ReadYear == null ? "-" : UsersBookList[i].ReadYear,
                        UsersBookList[i].Note == "" ? "-" : UsersBookList[i].Note,
                        Image.FromFile(UsersBookList[i].Image),
                        Image.FromFile(@"assets\updatebook.png"),
                        Image.FromFile(@"assets\deletebook.png")
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
            if (UsersBookList != null)
            {
                #region UserBookList Boş Değilse Dgv Style

                // stilleri ister kolon kısmında yaz ister satır farketmiyor. Ancak dgv datası dolmadan önce stilleri çağırmalısın.
                dgvUserBookList.RowTemplate.Height = 130;
                dgvUserBookList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvUserBookList.RowsDefaultCellStyle.BackColor = Color.Wheat;
                dgvUserBookList.BackgroundColor = Color.Wheat;
                //dgvUserBookList.AlternatingRowsDefaultCellStyle.BackColor = Color.SandyBrown; stripe efekti için.
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.Wheat; // sütun isimlerinin rengi                
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.Wheat;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;

                //dgvUserBookList.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Wheat;
                // RowHeadersDefaultCellStyle denen kısım DataGridView da her satırın başında çıkan seçici okun olduğu kısım.
                dgvUserBookList.EnableHeadersVisualStyles = false;

                #endregion
            }
            else
            {
                #region UserBookList Boşsa Dgv Style 

                // stilleri ister kolon kısmında yaz ister satır farketmiyor.
                dgvUserBookList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvUserBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUserBookList.BackgroundColor = Color.LightGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionBackColor = Color.DarkGray;
                dgvUserBookList.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
                dgvUserBookList.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray; // sütun isimlerinin rengi
                dgvUserBookList.EnableHeadersVisualStyles = false;
                dgvUserBookList.Enabled = false;

                #endregion
            }
        }

        private void LabelHeaderSet()
        {
            lblHeader.Text = _loggedUser.NickName + " kitaplığı";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBookAdd_MouseHover(object sender, EventArgs e)
        {
            btnBookAdd.BackgroundImage = Image.FromFile(@".\assets\newbook_hover.png");
        }

        private void btnBookAdd_MouseLeave(object sender, EventArgs e)
        {
            btnBookAdd.BackgroundImage = Image.FromFile(@".\assets\newbook.png");
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close_hover.png");
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Image.FromFile(@".\assets\close.png");
        }

        private void dgvUserBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserBookList.RowCount>0)
            {
                UserBook selectedUserBook = UsersBookList[Convert.ToInt32(dgvUserBookList.CurrentRow.Cells[0].Value)-1];

                if (e.ColumnIndex == 10)
                {
                    MessageBox.Show(selectedUserBook.BookName + " güncelle");
                }
                else if (e.ColumnIndex == 11)
                {
                    MessageBox.Show(selectedUserBook.BookName + " sil");
                }
            }
        }
    }
}
