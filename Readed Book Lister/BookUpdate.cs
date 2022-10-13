using Readed_Book_Lister.App_Logics;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Helpers;
using Readed_Book_Lister.Methods.App_Methods;
using Readed_Book_Lister.Methods.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Readed_Book_Lister
{
    public partial class BookUpdate : Form
    {
        private UserBook _userBookToUpdate;
        private User _loggedUser;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);

        public BookUpdate(UserBook userBookToUpdate, User loggedUser)
        {
            InitializeComponent();
            DisableAcceptOrCancelButtonFrames.DisableUnvantedFrames(btnSave, btnCancel);
            _userBookToUpdate = userBookToUpdate;
            _loggedUser = loggedUser;
            FillBooksInfo();
            ComboBoxMouthAndYearHelper.CmbYearFiller(cmbYear);
            DisableDateAreaIfBookToUpdateReadedNotChecked();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void FillBooksInfo()
        {
            tbxName.Text = _userBookToUpdate.BookName;
            tbxAuthor.Text = _userBookToUpdate.AuthorName;
            tbxIsbn.Text = _userBookToUpdate.Isbn;
            tbxPublisher.Text = _userBookToUpdate.Publisher;
            tbxImage.Text = _userBookToUpdate.Image == @".\images\default.png" ? string.Empty : _userBookToUpdate.Image;
            cbxMonth.Checked = _userBookToUpdate.ReadMonth == null ? cbxMonth.Checked = true : cbxMonth.Checked = false;
            cbxYear.Checked = _userBookToUpdate.ReadYear == null ? cbxYear.Checked = true : cbxYear.Checked = false;
            cbxReaded.Checked = _userBookToUpdate.Readed;
            cbxNative.Checked = _userBookToUpdate.Native;
            tbxNote.Text = _userBookToUpdate.Note;
            cmbMonth.Text = _userBookToUpdate.ReadMonth == null ? "Bitirme Tarihi (Ay)" : ComboBoxMouthAndYearHelper.MonthNameFromInt(_userBookToUpdate.ReadMonth.Value);
            cmbYear.Text = _userBookToUpdate.ReadYear == null ? "Bitirme Tarihi (Yıl)" : _userBookToUpdate.ReadYear.Value.ToString();
            pbxImage.Image = new Bitmap(Image.FromFile(_userBookToUpdate.Image));
        }

        private void DisableDateAreaIfBookToUpdateReadedNotChecked()
        {
            if (!_userBookToUpdate.Readed)
            {
                DisableDateArea();
            }
            else
            {
                EnableDateArea();
            }
        }

        private void DisableDateArea()
        {
            cbxMonth.Enabled = false;
            cbxYear.Enabled = false;
        }

        private void EnableDateArea()
        {
            if (!cbxYear.Checked)
            {
                cbxMonth.Enabled = true;
            }
            else
            {
                cbxMonth.Enabled = false;
            }

            cbxYear.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMonth.Checked)
            {
                cmbMonth.Text = "Bitirme Tarihi (Ay)";
                cmbMonth.Enabled = false;
            }
            else
            {
                cmbMonth.Text = _userBookToUpdate.ReadMonth == null ? "Bitirme Tarihi (Ay)" : ComboBoxMouthAndYearHelper.MonthNameFromInt(_userBookToUpdate.ReadMonth.Value);
                cmbMonth.Enabled = true;
            }
        }

        private void cbxYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxYear.Checked)
            {
                cbxMonth.Checked = true;
                cmbYear.Enabled = false;
                cmbYear.Text = "Bitirme Tarihi (Yıl)";
                cbxMonth.Enabled = false;
            }
            else
            {
                cmbYear.Enabled = true;
                cbxMonth.Enabled = true;
                if (_userBookToUpdate.ReadMonth == null)
                {
                    cbxMonth.Checked = true;
                }
                else
                {
                    cbxMonth.Checked = false;
                }
                cmbYear.Text = _userBookToUpdate.ReadYear == null ? "Bitirme Tarihi (Yıl)" : _userBookToUpdate.ReadYear.Value.ToString();
            }
        }

        private bool CheckMouthValueIsValid()
        {
            if (cbxReaded.Checked && !cbxMonth.Checked && (ComboBoxMouthAndYearHelper.MonthNameToInt(cmbMonth.Text) == 0))
            {
                cmbMonth.BackColor = Color.FromArgb(250, 184, 187);
                return false;
            }
            cmbMonth.BackColor = Color.Wheat;
            return true;
        }

        private bool CheckYearValueIsValid()
        {
            if (cbxReaded.Checked && !cbxYear.Checked && !int.TryParse(cmbYear.Text, out _))
            {
                cmbYear.BackColor = Color.FromArgb(250, 184, 187);
                return false;
            }
            cmbYear.BackColor = Color.Wheat;
            return true;
        }

        private bool IsbnLengthChecker()
        {
            if (StringUtilityHelper.TrimStartAndFinish(tbxIsbn.Text).Length == 13)
            {
                tbxIsbn.BackColor = Color.Wheat;
                return true;
            }
            tbxIsbn.BackColor = Color.FromArgb(250, 184, 187);
            return false;
        }


        private bool CheckPublisherNameIsValid()
        {
            if (StringUtilityHelper.TrimStartAndFinish(tbxPublisher.Text).Length == 0)
            {
                tbxPublisher.BackColor = Color.FromArgb(250, 184, 187);
                return false;
            }
            tbxPublisher.BackColor = Color.Wheat;
            return true;
        }

        private bool CheckAuthorNameIsValid()
        {
            if (StringUtilityHelper.TrimStartAndFinish(tbxAuthor.Text).Length == 0)
            {
                tbxAuthor.BackColor = Color.FromArgb(250, 184, 187);
                return false;
            }
            tbxAuthor.BackColor = Color.Wheat;
            return true;
        }

        private bool CheckBookNameIsValid()
        {
            if (StringUtilityHelper.TrimStartAndFinish(tbxName.Text).Length == 0)
            {
                tbxName.BackColor = Color.FromArgb(250, 184, 187);
                return false;
            }
            tbxName.BackColor = Color.Wheat;
            return true;
        }

        private bool CheckFormIfHasError(params bool[] checks)
        {
            foreach (var item in checks)
            {
                if (!item)
                {
                    DisableSaveButtonIfFormNotValid();
                    return false;
                }
            }
            return true;
        }

        private void ClearErrorColors()
        {
            cmbMonth.BackColor = Color.Wheat;
            cmbYear.BackColor = Color.Wheat;
            tbxIsbn.BackColor = Color.Wheat;
            tbxName.BackColor = Color.Wheat;
            tbxAuthor.BackColor = Color.Wheat;
            tbxPublisher.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFormIfHasError(CheckMouthValueIsValid(), CheckYearValueIsValid(), IsbnLengthChecker(), CheckBookNameIsValid(), CheckAuthorNameIsValid(), CheckPublisherNameIsValid()))
            {
                UserBook newBook = new UserBook
                {
                    Id = _userBookToUpdate.Id,
                    UserId = _userBookToUpdate.UserId,
                    BookName = tbxName.Text,
                    AuthorName = tbxAuthor.Text,
                    Isbn = tbxIsbn.Text,
                    Note = tbxNote.Text,
                    Publisher = tbxPublisher.Text,
                    Native = cbxNative.Checked,
                    Readed = cbxReaded.Checked,
                    ReadMonth = CanSetReadMonthAndYearIfReadedCheckHelper.UserCanSetReadedMonthAndYearIfReadedChecked(cbxReaded, cmbMonth),
                    ReadYear = CanSetReadMonthAndYearIfReadedCheckHelper.UserCanSetReadedMonthAndYearIfReadedChecked(cbxReaded, cmbYear),
                    Image = (tbxImage.Text == _userBookToUpdate.Image) ? _userBookToUpdate.Image : ImageOperations.GenerateGuidForImageIfImageSelected(tbxImage.Text)
                };

                if (UserBookOperations.Update(newBook))
                {
                    if (_userBookToUpdate.Image != tbxImage.Text)
                    {
                        ImageOperations.SaveImage(newBook.Image, tbxImage);
                        ImageOperations.DeleteOldImageIfNotDefault(_userBookToUpdate.Image);
                    }
                    
                    GoBackToMainFormAfterUpdate();
                }
                else
                {
                    return;
                }

            }
        }

        private void GoBackToMainFormAfterUpdate()
        {            
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(GoToMainFormWithNewThread));
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();            
            Close();
        }
        private void GoToMainFormWithNewThread()
        {
            Application.Run(new Main(_loggedUser));
        }

        private void DisableSaveButtonIfFormNotValid()
        {
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save_error.png");
            btnSave.Enabled = false;
        }

        private void EnableSaveButtonIfFormValid()
        {
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
            btnSave.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearErrorColors();
            FillBooksInfo();
        }

        private void tbxIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMonth.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private void cmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbYear.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            tbxName.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private void tbxIsbn_TextChanged(object sender, EventArgs e)
        {
            tbxIsbn.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private void tbxAuthor_TextChanged(object sender, EventArgs e)
        {
            tbxAuthor.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private void tbxPublisher_TextChanged(object sender, EventArgs e)
        {
            tbxPublisher.BackColor = Color.Wheat;
            EnableSaveButtonIfFormValid();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Resim Dosyaları (*.jpg; *.jpeg; *.gif; *.bmp; *.png;) | *.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbxImage.Text = fileDialog.FileName;
                    pbxImage.Image = new Bitmap(fileDialog.FileName);
                }
                catch (Exception)
                {
                    tbxImage.Text = string.Empty;
                    MessageBox.Show(Messages.ImageNotProper);
                    return;
                }
            }
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save_hover.png");
            toolTipUpdateBook.SetToolTip(btnSave, "Kaydet");
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
            toolTipUpdateBook.Hide(btnSave);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoBackToMainFormAfterUpdate();
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_hover.png");
            toolTipUpdateBook.SetToolTip(btnCancel, "Vazgeç");
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel.png");
            toolTipUpdateBook.Hide(btnCancel);
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear_hover.png");
            toolTipUpdateBook.SetToolTip(btnClear, "Temizle");
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear.png");
            toolTipUpdateBook.Hide(btnClear);
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

        private void BookUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void BookUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void BookUpdate_MouseMove(object sender, MouseEventArgs e)
        {

            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }

        private void cbxReaded_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxReaded.Checked)
            {
                DisableDateArea();
                cbxMonth.Checked = true;
                cbxYear.Checked = true;
            }
            else
            {
                if (_userBookToUpdate.ReadMonth == null)
                {
                    cbxMonth.Checked = true;
                }
                else
                {
                    cbxMonth.Checked = false;
                }
                if (_userBookToUpdate.ReadYear == null)
                {
                    cbxYear.Checked = true;
                }
                else
                {
                    cbxYear.Checked = false;
                }
                EnableDateArea();
            }

        }
    }
}
