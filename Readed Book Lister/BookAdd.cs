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
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Readed_Book_Lister
{
    public partial class BookAdd : Form
    {
        private readonly User _loggedUser;
        private bool _dragging = false;
        private Point _startPoint = new Point(0, 0);
        
        public BookAdd(User loggedUser)
        {
            InitializeComponent();
            DisableAcceptOrCancelButtonFrames.DisableUnvantedFrames(btnSave, btnCancel);
            ComboBoxMouthAndYearHelper.CmbYearFiller(cmbYear);            
            DisableDateAreaWhenAppStartsOrReadedUnchecked();
            _loggedUser = loggedUser;            
        }
        
        #region Clicks

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!FormControlsErrorChecker())
            {
                SetErrorStatue();
                return;
            }
            
            var userBook = new UserBook
            {
                //id add metodunda hallediliyor
                UserId = _loggedUser.Id,
                BookName = tbxName.Text,
                AuthorName = tbxAuthor.Text,
                Isbn = tbxIsbn.Text,
                Publisher = tbxPublisher.Text,
                Readed = cbxReaded.Checked,
                Native = cbxNative.Checked,              
                ReadMonth = CanSetReadMonthAndYearIfReadedCheckHelper.UserCanSetReadedMonthAndYearIfReadedChecked(cbxReaded, cmbMonth),
                ReadYear = CanSetReadMonthAndYearIfReadedCheckHelper.UserCanSetReadedMonthAndYearIfReadedChecked(cbxReaded, cmbYear),
                Image = ImageOperations.GenerateGuidForImageIfImageSelected(tbxImage.Text),
                Note = tbxNote.Text,
            };

            // kitap ekleme true ise resim ekleme çalışmalı. yoksa isbn hatası verip kitabu eklemese bile resmi ekliyor.
            if (UserBookOperations.Add(userBook))
            {
                ImageOperations.SaveImage(userBook.Image, tbxImage);
                ClearForm();
            }            
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(GoToMainFormWithNewThread));            
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
            Close();
        }
        
        #endregion

        #region Hovers        

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

        private void btnBrowse_MouseHover(object sender, EventArgs e)
        {
            btnBrowse.BackgroundImage = Image.FromFile(@".\assets\browse_hover.png");
            toolTipAddBook.SetToolTip(btnBrowse, "Gözat");
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBrowse.BackgroundImage = Image.FromFile(@".\assets\browse.png");
            toolTipAddBook.Hide(btnBrowse);
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear_hover.png");
            toolTipAddBook.SetToolTip(btnClear, "Temizle");
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackgroundImage = Image.FromFile(@".\assets\clear.png");
            toolTipAddBook.Hide(btnClear);
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel_hover.png");
            toolTipAddBook.SetToolTip(btnCancel, "Vazgeç");
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackgroundImage = Image.FromFile(@".\assets\cancel.png");
            toolTipAddBook.Hide(btnCancel);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                btnSave.BackgroundImage = Image.FromFile(@".\assets\save_hover.png");
                toolTipAddBook.SetToolTip(btnSave, "Kaydet");
            }

        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            if (btnSave.Enabled)
            {
                btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
                toolTipAddBook.Hide(btnSave);
            }

        }

        private void cbxYear_MouseHover(object sender, EventArgs e)
        {
            cbxYear.Image = Image.FromFile(@".\assets\date_remember_hover.png");
            toolTipAddBook.SetToolTip(cbxYear, "Tarihi Hatırlamıyorum");
        }

        private void cbxYear_MouseLeave(object sender, EventArgs e)
        {
            cbxYear.Image = Image.FromFile(@".\assets\date_remember.png");
            toolTipAddBook.Hide(cbxYear);
        }

        private void cbxReaded_MouseHover(object sender, EventArgs e)
        {
            cbxReaded.Image = Image.FromFile(@".\assets\completed_hover.png");
            toolTipAddBook.SetToolTip(cbxReaded, "Okudum");
        }

        private void cbxReaded_MouseLeave(object sender, EventArgs e)
        {
            cbxReaded.Image = Image.FromFile(@".\assets\completed.png");
            toolTipAddBook.Hide(cbxReaded);
        }

        private void cbxNative_MouseHover(object sender, EventArgs e)
        {
            cbxNative.Image = Image.FromFile(@".\assets\native_hover.png");
            toolTipAddBook.SetToolTip(cbxNative, "Yerli Kitap");
        }

        private void cbxNative_MouseLeave(object sender, EventArgs e)
        {
            cbxNative.Image = Image.FromFile(@".\assets\native.png");
            toolTipAddBook.Hide(cbxNative);
        }

        private void cbxMonth_MouseHover(object sender, EventArgs e)
        {
            cbxMonth.Image = Image.FromFile(@".\assets\month_hover.png");
            toolTipAddBook.SetToolTip(cbxMonth, "Ayı Hatırlamıyorum");
        }

        private void cbxMonth_MouseLeave(object sender, EventArgs e)
        {
            cbxMonth.Image = Image.FromFile(@".\assets\month.png");
            toolTipAddBook.Hide(cbxMonth);
        }


        #endregion

        #region Helpers

        private void GoToMainFormWithNewThread()
        {
            Application.Run(new Main(_loggedUser));
        }

        private void DisableDateAreaWhenAppStartsOrReadedUnchecked()
        {
            cbxMonth.Checked = true;
            cbxYear.Checked = true;
            cbxMonth.Enabled = false;
            cbxYear.Enabled = false;
        }

        private void ClearForm()
        {
            tbxName.Text = string.Empty;
            tbxAuthor.Text = string.Empty;
            tbxImage.Text = string.Empty;
            tbxNote.Text = string.Empty;
            tbxPublisher.Text = string.Empty;
            tbxIsbn.Text = string.Empty;
            cbxNative.Checked = false;
            cbxReaded.Checked = false;
            cbxYear.Checked = false;
            cbxMonth.Checked = false;
            cmbMonth.SelectedIndex = -1;
            cmbMonth.Text = "Bitirme Tarihi (Ay)";
            cmbYear.SelectedIndex = -1;
            cmbYear.Text = "Bitirme Tarihi (Yıl)";
            tbxName.BackColor = Color.Wheat;
            tbxAuthor.BackColor = Color.Wheat;
            tbxPublisher.BackColor = Color.Wheat;
            tbxIsbn.BackColor = Color.Wheat;
            cmbMonth.BackColor = Color.Wheat;
            cmbYear.BackColor = Color.Wheat;
            pbxImage.Image = new Bitmap(Image.FromFile(@".\images\default.png"));
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
            btnSave.Enabled = true;
            DisableDateAreaWhenAppStartsOrReadedUnchecked();
        }
        

        private void SetErrorStatue()
        {
            TextboxErrorSetter(tbxName, tbxAuthor, tbxPublisher, tbxIsbn);
            DateComboboxErrorSetter();
            btnSave.Enabled = false;
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save_error.png");
        }

        private void DateComboboxErrorSetter()
        {
            if (!cmbMonth.Enabled && cmbYear.Enabled && !int.TryParse(cmbYear.Text, out _))
            {
                cmbYear.BackColor = Color.FromArgb(250, 184, 187);
            }
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (ComboBoxMouthAndYearHelper.MonthNameToInt(cmbMonth.Text) == 0))
            {
                cmbMonth.BackColor = Color.FromArgb(250, 184, 187);

            }
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (!int.TryParse(cmbYear.Text, out _)))
            {
                cmbYear.BackColor = Color.FromArgb(250, 184, 187);
            }
        }

        private void DateComboboxErrorCleaner()
        {
            if (!cmbMonth.Enabled && cmbYear.Enabled && int.TryParse(cmbYear.Text, out _))
            {
                cmbYear.BackColor = Color.Wheat;
            }
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (ComboBoxMouthAndYearHelper.MonthNameToInt(cmbMonth.Text) != 0))
            {
                cmbMonth.BackColor = Color.Wheat;

            }
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (int.TryParse(cmbYear.Text, out _)))
            {
                cmbYear.BackColor = Color.Wheat;
            }
        }

        private void TextboxErrorSetter(params TextBox[] textBoxes)
        {
            foreach (var textbox in textBoxes)
            {
                if (textbox != tbxIsbn)
                {
                    if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(textbox.Text)))
                    {
                        textbox.BackColor = Color.FromArgb(250, 184, 187);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(textbox.Text)) || textbox.Text.Length != 13)
                    {
                        textbox.BackColor = Color.FromArgb(250, 184, 187);
                    }
                }

            }
        }

        private void TextboxErrorCleaner(params TextBox[] textBoxes)
        {
            foreach (var textbox in textBoxes)
            {
                if (!string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(textbox.Text)))
                {
                    textbox.BackColor = Color.Wheat;
                }
            }
        }

        private void ClearErrorStatue()
        {
            TextboxErrorCleaner(tbxName, tbxAuthor, tbxPublisher, tbxIsbn);
            DateComboboxErrorCleaner();
            btnSave.Enabled = true;
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
        }

        private bool FormControlsErrorChecker()
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxName.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxAuthor.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxPublisher.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxIsbn.Text)) || !DateTimeActiveButNotSelectedChecker() || !IsbnLengthChecker())
            {
                return false;
            }
            return true;
        }

        private bool IsbnLengthChecker()
        {
            var isbnText = StringUtilityHelper.TrimStartAndFinish(tbxIsbn.Text);
            if (isbnText.Length == 13)
            {
                return true;
            }

            return false;
        }

        private bool DateTimeActiveButNotSelectedChecker()
        {

            if (!cmbMonth.Enabled && cmbYear.Enabled && !int.TryParse(cmbYear.Text, out _))
            {
                return false;
            }

            if ((cmbMonth.Enabled && cmbYear.Enabled) && (ComboBoxMouthAndYearHelper.MonthNameToInt(cmbMonth.Text) == 0 || !int.TryParse(cmbYear.Text, out _)))
            {

                return false;
            }

            return true;
        }

        #endregion

        #region TextOrSelectedValueOrCheckedChanged

        private void cbxReaded_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxReaded.Checked)
            {
                cbxMonth.Enabled = true;
                cbxYear.Enabled = true;
                cbxMonth.Checked = false;
                cbxYear.Checked = false;
            }
            else
            {                
                DisableDateAreaWhenAppStartsOrReadedUnchecked();                
            }
        }

        private void cbxYear_CheckedChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
            if (cbxYear.Checked)
            {
                cmbMonth.Text = "Bitirme Tarihi (Ay)";
                cmbYear.Text = "Bitirme Tarihi (Yıl)";
                cmbMonth.Enabled = false;
                cmbYear.Enabled = false;
                cbxMonth.Enabled = false;
            }
            else
            {
                cmbMonth.Enabled = true;
                cmbYear.Enabled = true;
                cbxMonth.Checked = false;
                cbxMonth.Enabled = true;
            }
        }

        private void cbxMonth_CheckedChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
            if (cbxMonth.Checked)
            {
                cmbMonth.Text = "Bitirme Tarihi (Ay)";
                cmbMonth.Enabled = false;
            }
            else
            {
                cmbMonth.Enabled = true;
            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }
        private void tbxPublisher_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        private void tbxIsbn_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        private void tbxAuthor_TextChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        private void cmbMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
        }

        private void cmbYear_SelectedValueChanged(object sender, EventArgs e)
        {
            ClearErrorStatue();
            //cmbMonth.Text = "Bitirme Tarihi (Ay)"; ya böyle
            ComboBoxMouthAndYearHelper.CmbMonthFillerByCheckingCurrentYear(cmbMonth, cmbYear);
            if (cmbYear.Text == DateTime.Now.Year.ToString() && ComboBoxMouthAndYearHelper.MonthNameToInt(cmbMonth.Text) >= DateTime.Now.Month)
            {
                //cmbMonth.Text = ComboBoxMouthAndYearHelper.MonthNameFromInt(cmbMonth.Items.Count); //ya böyle
                cmbMonth.Text = "Bitirme Tarihi (Ay)"; //ya da böyle. Bu ayı yeniden seçmek zorunda bırakır, güvenlik önlemi.
            }
        }



        #endregion

        #region MoveForm
        private void BookAdd_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void BookAdd_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void BookAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }

        #endregion

        private void tbxIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
                
    }
}
