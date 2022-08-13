using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Entities;
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
        User loggedUser;
        public BookAdd()
        {
            InitializeComponent();
            CmbYearFiller();
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
            int result;
            var userBook = new UserBook
            {
                //id add metodunda hallediliyor
                //userId için ctor enjeksiyonu gerekebilir. logged user a erişip id sini userbook a verebilmem için.
                BookName = tbxName.Text,
                AuthorName = tbxAuthor.Text,
                Readed = cbxReaded.Checked,
                Native = cbxNative.Checked,
                ReadMonth = MonthNameToInt(cmbMonth.Text) == 0 ? null : MonthNameToInt(cmbMonth.Text),
                ReadYear = int.TryParse(cmbYear.Text, out result) ? result : null,
                Image = GenerateGuidForImageIfImageSelected(tbxImage.Text),
                Note = tbxNote.Text,
            };
            SaveImage(userBook.Image);
            // Buraya da add metodunu çağırıp içine bu kitabı göndericem.
            MessageBox.Show("Hata yok");
            //ClearForm();
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
            // Yeni formu gösterdikten sonra eskisini kapatmak.
            Main main = new Main();
            Hide();
            main.ShowDialog();
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

        private void SaveImage(string guidedImageName)
        {
            if (!string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxImage.Text)))
            {
                File.Copy(tbxImage.Text, guidedImageName, false);
                //pbxImage.Image = new Bitmap(Image.FromFile(@".\images\default.png"));
                //pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private string GenerateGuidForImageIfImageSelected(string imageFileName)
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(imageFileName)))
            {
                return @".\images\default.png";
            }
            var extension = Path.GetExtension(imageFileName);
            var guidedNameWithExtension = @".\images\" + Guid.NewGuid() + extension;
            return guidedNameWithExtension;
        }

        private void ClearForm()
        {
            tbxName.Text = string.Empty;
            tbxAuthor.Text = string.Empty;
            tbxImage.Text = string.Empty;
            tbxNote.Text = string.Empty;
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
            cmbMonth.BackColor = Color.Wheat;
            cmbYear.BackColor = Color.Wheat;
            pbxImage.Image = new Bitmap(Image.FromFile(@".\images\default.png"));
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
            btnSave.Enabled = true;
        }

        private int MonthNameToInt(string selectedMouth)
        {
            switch (selectedMouth)
            {
                case "Ocak":
                    return 1;
                case "Şubat":
                    return 2;
                case "Mart":
                    return 3;
                case "Nisan":
                    return 4;
                case "Mayıs":
                    return 5;
                case "Haziran":
                    return 6;
                case "Temmuz":
                    return 7;
                case "Ağustos":
                    return 8;
                case "Eylül":
                    return 9;
                case "Ekim":
                    return 10;
                case "Kasım":
                    return 11;
                case "Aralık":
                    return 12;
                default: return 0;
            }
        }


        private void CmbYearFiller()
        {
            int startYear = 1700;

            for (int i = DateTime.Now.Year; i >= startYear; i--)
            {
                cmbYear.Items.Add(i.ToString());
            }
        }


        private void SetErrorStatue()
        {
            TextboxErrorSetter(tbxName, tbxAuthor);
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
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (MonthNameToInt(cmbMonth.Text) == 0))
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
            if ((cmbMonth.Enabled && cmbYear.Enabled) && (MonthNameToInt(cmbMonth.Text) != 0))
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
                if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(textbox.Text)))
                {
                    textbox.BackColor = Color.FromArgb(250, 184, 187);
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
            TextboxErrorCleaner(tbxName, tbxAuthor);
            DateComboboxErrorCleaner();
            btnSave.Enabled = true;
            btnSave.BackgroundImage = Image.FromFile(@".\assets\save.png");
        }

        private bool FormControlsErrorChecker()
        {
            if (string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxName.Text)) || string.IsNullOrEmpty(StringUtilityHelper.TrimStartAndFinish(tbxAuthor.Text)) || !DateTimeActiveButNotSelectedChecker())
            {
                return false;
            }
            return true;
        }

        private bool DateTimeActiveButNotSelectedChecker()
        {

            if (!cmbMonth.Enabled && cmbYear.Enabled && !int.TryParse(cmbYear.Text, out _))
            {
                return false;
            }

            if ((cmbMonth.Enabled && cmbYear.Enabled) && (MonthNameToInt(cmbMonth.Text) == 0 || !int.TryParse(cmbYear.Text, out _)))
            {

                return false;
            }

            return true;
        }

        #endregion

        #region TextOrSelectedValueOrCheckedChanged

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
        }


        #endregion


    }
}
