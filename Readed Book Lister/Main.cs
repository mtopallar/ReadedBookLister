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
        public Main(User loggedUser)
        {
            InitializeComponent();
            _loggedUser = loggedUser;
            FillDataGridView();
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd(_loggedUser);
            Hide();
            bookAdd.ShowDialog();
            Close();
        }
        

        private void FillDataGridView()
        {
            List<UserBook>? UsersBookList = UserBookOperations.GetAllByUserId(1);

            //Önce dgv e eklenecek kolon tiplerini belirle.
            DataGridViewTextBoxColumn dgvPlaceColumn = new DataGridViewTextBoxColumn();
            dgvPlaceColumn.HeaderText = "Sıra";
            dgvPlaceColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dgvBookNameColumn = new DataGridViewTextBoxColumn();
            dgvBookNameColumn.HeaderText = "Kitap adı";
            dgvBookNameColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dgvIsbnColumn = new DataGridViewTextBoxColumn();
            dgvIsbnColumn.HeaderText = "Isbn No";
            dgvIsbnColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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

            DataGridViewTextBoxColumn dgvReadYearColumn = new DataGridViewTextBoxColumn();
            dgvReadYearColumn.HeaderText = "Okunma Yılı";
            dgvReadYearColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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


            dgvUserBookList.RowTemplate.Height = 130;
            dgvUserBookList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgwUserBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            //Sonra o kolonları dgv  e ekle
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

            for (int i = 0; i < UsersBookList.Count; i++)
            {
                //sonra ilgili verileri sırasıyla içeren satırları ekle. data sırası eşit olmalı colon sırası.                
                dgvUserBookList.Rows.Add(
                    i+1,
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
    }
}
